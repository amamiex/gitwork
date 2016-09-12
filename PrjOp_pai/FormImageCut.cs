using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PrjHikariwoAnim
{
    public partial class FormImageCut : Form
    {
        private bool mRectStart;
        private bool mRectEnd;
        private Point mPosStart;    //左上のポジション
        private Point mPosEnd;  //右下のポジション
        private Image mImage;
        private double mMag;
        private bool mMouseDown;    //マウスが押されたらtrueになる
        private bool mShiftDown;    //シフトキーが押されたらtrueになる
        private Point mOld;
        private Pen mPenGrid;
        private SolidBrush mBrushRect;
        private Color mBrushRectColor;

        public FormImageCut(Image clImage)
        {
            InitializeComponent();

            //以下、初期化処理
            this.mRectStart = false;
            this.mRectEnd = false;
            this.mPosStart = new Point();
            this.mPosEnd = new Point();
            this.mImage = clImage;
            this.mMag = 1.0;
            this.mMouseDown = false;
            this.mShiftDown = false;
            this.mOld = new Point();
            this.mPenGrid = new Pen(Color.Silver);
            this.mBrushRectColor = Color.FromArgb(128, Color.Lime.R, Color.Lime.G, Color.Lime.B);
            this.mBrushRect = new SolidBrush(this.mBrushRectColor);
        }

        private void FormImageCut_Load(object sender, EventArgs e)
        {
            //以下、初期化処理
            this.DialogResult = DialogResult.None;

            this.comboBox_Mag.SelectedIndex = 0;
            this.panel_Image.GetType().InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, this.panel_Image, new object[] { true });
        }

        private void button_Cut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            this.panel_Image.Refresh();
        }

        private void panel_Image_Paint(object sender, PaintEventArgs e)
        {
            //以下、拡大してボケないようにする処理
            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            //以下、画像表示処理
            e.Graphics.DrawImage(this.mImage, 0.0f, 0.0f, this.panel_Image.Width, this.panel_Image.Height);

            //以下、選択用矩形表示処理
            if (this.mRectStart && this.mRectEnd)
            {
                int inX1 = 0;
                int inX2 = 0;
                int inY1 = 0;
                int inY2 = 0;

                if(this.mPosStart.X < this.mPosEnd.X) {
                    inX1 = (int)(this.mPosStart.X * this.mMag);
                    inX2 = (int)(this.mPosEnd.X * this.mMag);
                }
                else {
                    inX1 = (int)(this.mPosEnd.X * this.mMag);
                    inX2 = (int)(this.mPosStart.X * this.mMag);
                }

                if(this.mPosStart.Y < this.mPosEnd.Y) {
                    inY1 = (int)(this.mPosStart.Y * this.mMag);
                    inY2 = (int)(this.mPosEnd.Y * this.mMag);
                }
                else {
                    inY1 = (int)(this.mPosEnd.Y * this.mMag);
                    inY2 = (int)(this.mPosStart.Y * this.mMag);
                }

                e.Graphics.FillRectangle(this.mBrushRect, inX1, inY1, inX2 - inX1, inY2 - inY1);
            }

            //以下、グリッド表示処理
            if (this.checkBox_Grid.Checked)
            {
                int inGrid = 8;
                if (this.radioButton_16dot.Checked) inGrid = 16;
                else if (this.radioButton_32dot.Checked) inGrid = 32;

                int inCnt, inMax = this.mImage.Width / inGrid;
                for (inCnt = 1; inCnt < inMax; inCnt++)
                {
                    int inX = (int)(inCnt * inGrid * this.mMag);
                    Point stPos1 = new Point(inX, 0);
                    Point stPos2 = new Point(inX, this.panel_Image.Height - 1);
                    e.Graphics.DrawLine(this.mPenGrid, stPos1, stPos2);
                }

                inMax = this.mImage.Height / inGrid;
                for (inCnt = 1; inCnt < inMax; inCnt++)
                {
                    int inY = (int)(inCnt * inGrid * this.mMag);
                    Point stPos1 = new Point(0, inY);
                    Point stPos2 = new Point(this.panel_Image.Width - 1, inY);
                    e.Graphics.DrawLine(this.mPenGrid, stPos1, stPos2);
                }
            }
        }

        private void panel_Image_MouseDown(object sender, MouseEventArgs e)
        {
            this.mOld.X = Cursor.Position.X;
            this.mOld.Y = Cursor.Position.Y;
            this.mMouseDown = true;

            Point stPos = this.panel_Image.PointToClient(Cursor.Position);
            if (this.checkBox_Magnet.Checked)
            {
                double doValue = 32.0 * this.mMag;
                if (this.radioButton_8dot.Checked) doValue = 8.0 * this.mMag;
                else if (this.radioButton_16dot.Checked) doValue = 16.0 * this.mMag;

                stPos.X = (int)Math.Round((decimal)(stPos.X / doValue)) * (int)doValue;
                stPos.Y = (int)Math.Round((decimal)(stPos.Y / doValue)) * (int)doValue;
            }

            this.mRectStart = true;
            this.mPosStart.X = (int)(stPos.X / this.mMag);
            this.mPosStart.Y = (int)(stPos.Y / this.mMag);
            this.mRectEnd = false;
            this.mPosEnd.X = (int)(stPos.X / this.mMag);
            this.mPosEnd.Y = (int)(stPos.Y / this.mMag);
            this.mPosEnd = new Point();

            this.panel.Refresh();
        }

        private void panel_Image_MouseUp(object sender, MouseEventArgs e)
        {
            this.mMouseDown = false;
        }

        public Rectangle GetRectangle()
        {
            Rectangle stRect = new Rectangle();
            stRect.X = this.mPosStart.X;
            stRect.Y = this.mPosStart.Y;
            stRect.Width = this.mPosEnd.X- this.mPosStart.X;
            stRect.Height = this.mPosEnd.Y- this.mPosStart.Y;
            return (stRect);            
        }

        private void FormImageCut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Shift || e.KeyCode == Keys.ShiftKey)
            {
                if (!this.mShiftDown)
                {
                    this.panel.Cursor = Cursors.NoMove2D;
                    this.mShiftDown = true;
                }
            }
        }

        private void FormImageCut_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Shift || e.KeyCode == Keys.ShiftKey)
            {
                this.panel.Cursor = Cursors.Default;
                this.mShiftDown = false;
            }
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            if (this.mMouseDown)
            {
                if (this.mShiftDown)
                {
                    //以下、画像移動処理
                    if (this.mOld.X != Cursor.Position.X || this.mOld.Y != Cursor.Position.Y)
                    {
                        int inX = Cursor.Position.X;
                        int inY = Cursor.Position.Y;
                        int inDiffX = inX - this.mOld.X;
                        int inDiffY = inY - this.mOld.Y;
                        this.panel.AutoScrollPosition = new Point(-this.panel.AutoScrollPosition.X - inDiffX, -this.panel.AutoScrollPosition.Y - inDiffY);
                        this.mOld.X = inX;
                        this.mOld.Y = inY;

                        this.panel.Refresh();
                    }
                }
                else
                {
                    //以下、矩形表示処理
                    if (this.mOld.X != Cursor.Position.X || this.mOld.Y != Cursor.Position.Y)
                    {
                        if (this.mRectStart)
                        {
                            Point stPos = this.panel_Image.PointToClient(Cursor.Position);
                            if (this.checkBox_Magnet.Checked)
                            {
                                double doValue = 32.0 * this.mMag;
                                if (this.radioButton_8dot.Checked) doValue = 8.0 * this.mMag;
                                else if (this.radioButton_16dot.Checked) doValue = 16.0 * this.mMag;

                                stPos.X = (int)Math.Round((decimal)(stPos.X / doValue)) * (int)doValue;
                                stPos.Y = (int)Math.Round((decimal)(stPos.Y / doValue)) * (int)doValue;
                            }

                            this.mRectEnd = true;
                            this.mPosEnd.X = (int)(stPos.X / this.mMag);
                            this.mPosEnd.Y = (int)(stPos.Y / this.mMag);

                            this.panel.Refresh();
                        }
                    }
                }
            }

            bool isEnable = false;
            if (this.mRectStart && this.mRectEnd)
            {
                if (this.mPosStart.X != this.mPosEnd.X ||
                    this.mPosStart.Y != this.mPosEnd.Y)
                {
                    isEnable = true;
                }
            }
            this.button_Cut.Enabled = isEnable;
        }

        private void checkBox_Grid_CheckedChanged(object sender, EventArgs e)
        {
            this.panel.Refresh();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.panel.Refresh();
        }

        private void comboBox_Mag_SelectedIndexChanged(object sender, EventArgs e)
        {
            Match clMatch = Regex.Match(this.comboBox_Mag.Text, "^(\\d*?)%$");
            if (clMatch.Success)
            {
                int inMag = Convert.ToInt32(clMatch.Groups[1].Value);
                this.mMag = inMag / 100.0;
            }

            this.panel_Image.Width = (int)(this.mImage.Width * this.mMag);
            this.panel_Image.Height = (int)(this.mImage.Height * this.mMag);

            this.panel.Refresh();
        }

        private void panel_ColorGrid_Click(object sender, EventArgs e)
        {
            ColorDialog clDialog = new ColorDialog();
            clDialog.Color = this.mPenGrid.Color;
            DialogResult enResult = clDialog.ShowDialog();
            if (enResult != DialogResult.OK) return;

            this.mPenGrid = new Pen(clDialog.Color);
            this.panel_ColorGrid.BackColor = clDialog.Color;

            this.panel_Image.Refresh();
        }

        private void panel_ColorRect_Click(object sender, EventArgs e)
        {
            ColorDialog clDialog = new ColorDialog();
            clDialog.Color = this.mBrushRect.Color;
            DialogResult enResult = clDialog.ShowDialog();
            if (enResult != DialogResult.OK) return;

            this.mBrushRectColor = Color.FromArgb(128, clDialog.Color.R, clDialog.Color.G, clDialog.Color.B);
            this.mBrushRect = new SolidBrush(this.mBrushRectColor);
            this.panel_ColorRect.BackColor = clDialog.Color;

            this.panel_Image.Refresh();
        }
    }
}
