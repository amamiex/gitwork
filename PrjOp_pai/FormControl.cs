using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjHikariwoAnim
{
    public partial class FormControl : Form
    {
        private static readonly int HEAD_HEIGHT = 20;
        private static readonly int LINE_HEIGHT = 40;
        private static readonly int TIME_CELL_WIDTH = 15;
        public ArrayList mListLine = null;  //値はClsLine
        public Font mFont = null;

        public FormControl()
        {
            InitializeComponent();
        }

        private void FormControl_Load(object sender, EventArgs e)
        {
            this.mListLine = new ArrayList();
            this.mFont = new Font("ＭＳ ゴシック", 10.5f);

            this.panel_Control.Top = 0;
            this.panel_Control.Left = 0;
            this.panel_Control.Width = 32;
            this.panel_Control.Height = 32;

            this.panel_Time.Top = 0;
            this.panel_Time.Left = 0;
            this.panel_Time.Width = 32;
            this.panel_Time.Height = 32;
        }

        private void FormControl_DragEnter(object sender, DragEventArgs e)
        {
            IntPtr pinDesktopWindow = ClsWin32.GetDesktopWindow();
            ClsWin32.ImageList_DragEnter(pinDesktopWindow, Cursor.Position.X, Cursor.Position.Y);

            bool isSuccess = e.Data.GetDataPresent(typeof(ListViewItem[]));
            if (isSuccess)
            {
                //以下、ドラッグ＆ドロップを有効化する処理
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void FormControl_DragDrop(object sender, DragEventArgs e)
        {
            IntPtr pinDesktopWindow = ClsWin32.GetDesktopWindow();
            ClsWin32.ImageList_DragLeave(pinDesktopWindow);

            if (e.Data.GetDataPresent(typeof(ListViewItem[])))
            {
                //以下、ドラッグ＆ドロップ処理
                ListViewItem[] pclItems = (ListViewItem[])e.Data.GetData(typeof(ListViewItem[]));
                foreach (ListViewItem clItem in pclItems)
                {
                    string clKey = clItem.SubItems[2].Text;

                    bool isExist = ClsTool.mTblImage.ContainsKey(clKey);
                    if(!isExist) continue;

                    ClsLine clLine = new ClsLine();
                    clLine.mMD5 = clKey;
                    clLine.mName = clKey;
                    this.mListLine.Add(clLine);
                }

                int inWidth = (int)this.numericUpDown_Frame.Value * FormControl.TIME_CELL_WIDTH + 1;
                int inHeight = FormControl.HEAD_HEIGHT + this.mListLine.Count * FormControl.LINE_HEIGHT + 1;
                this.panel_Control.Width = 512;
                this.panel_Control.Height = inHeight;
                this.panel_Time.Width = inWidth;
                this.panel_Time.Height = inHeight;
                this.splitContainer.Panel2.HorizontalScroll.Maximum = inWidth;
                this.splitContainer.Panel1.VerticalScroll.Maximum = inHeight;
                this.splitContainer.Panel2.VerticalScroll.Maximum = inHeight;
                this.panel_Control.Refresh();
            }
        }

        private void splitContainer_Panel1_Scroll(object sender, ScrollEventArgs e)
        {
            if(e.ScrollOrientation== ScrollOrientation.VerticalScroll)
            {
                this.splitContainer.Panel2.VerticalScroll.Value = e.NewValue;
            }
        }

        private void splitContainer_Panel2_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                this.splitContainer.Panel1.VerticalScroll.Value = e.NewValue;
            }
        }

        private void panel_Control_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel_Control_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panel_Control_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel_Control_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panel_Time_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel_Time_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panel_Time_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel_Time_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void numericUpDown_Frame_ValueChanged(object sender, EventArgs e)
        {
            int inWidth = (int)this.numericUpDown_Frame.Value * FormControl.TIME_CELL_WIDTH + 1;
            this.panel_Time.Width = inWidth;

            this.panel_Time.Refresh();
        }

        private void panel_Control_Paint(object sender, PaintEventArgs e)
        {
            int inWidth = this.panel_Control.Width;
            int inHeight = this.panel_Control.Height;

            //以下、イメージリスト描画処理
            e.Graphics.Clear(Color.White);

            //以下、縦ライン描画処理
            e.Graphics.DrawLine(Pens.Black, 40, 0, 40, inHeight);

            //以下、横ライン描画処理
            int inY = FormControl.HEAD_HEIGHT;
            e.Graphics.DrawLine(Pens.Black, 0, inY, inWidth, inY);

            int inCnt, inMax = this.mListLine.Count;
            for (inCnt = 0; inCnt < inMax; inCnt++)
            {
                ClsLine clLine = this.mListLine[inCnt] as ClsLine;
                if (clLine == null) continue;

                //以下、イメージ描画処理
                bool isExist = ClsTool.mTblImage.ContainsKey(clLine.mMD5);
                if (isExist)
                {
                    ClsImage clImageData = ClsTool.mTblImage[clLine.mMD5] as ClsImage;
                    e.Graphics.DrawImage(clImageData.mImageSmall, 4, FormControl.HEAD_HEIGHT + inCnt * FormControl.LINE_HEIGHT + 4);
                }

                //以下、名前描画処理
                if (!string.IsNullOrEmpty(clLine.mName))
                {
                    e.Graphics.DrawString(clLine.mName, this.mFont, Brushes.Black, 48, FormControl.HEAD_HEIGHT + inCnt * FormControl.LINE_HEIGHT + 14);
                }

                //以下、境界ライン描画処理
                inY = FormControl.HEAD_HEIGHT + (inCnt + 1) * FormControl.LINE_HEIGHT;
                e.Graphics.DrawLine(Pens.Black, 0, inY, inWidth, inY);
            }

//          e.Graphics.FillRectangle(Brushes.Lime, new Rectangle(0, 0, 500, 500));
        }

        private void panel_Time_Paint(object sender, PaintEventArgs e)
        {
            int inWidth = this.panel_Time.Width;
            int inHeight = this.panel_Control.Height;
            int inFrame = (int)this.numericUpDown_Frame.Value;

            //以下、タイムライン描画処理
            e.Graphics.Clear(Color.White);

            //以下、縦ライン描画処理
            int inCnt, inMax;
            for (inCnt = 0; inCnt < inFrame; inCnt++)
            {
                e.Graphics.DrawLine(Pens.Black, (inCnt + 1) * FormControl.TIME_CELL_WIDTH, 0, (inCnt + 1) * FormControl.TIME_CELL_WIDTH, inHeight);
            }

            //以下、横ライン描画処理
            int inY = FormControl.HEAD_HEIGHT;
            e.Graphics.DrawLine(Pens.Black, 0, inY, inWidth, inY);

            inMax = this.mListLine.Count;
            for (inCnt = 0; inCnt < inMax; inCnt++)
            {
                ClsLine clLine = this.mListLine[inCnt] as ClsLine;
                if (clLine == null) continue;

                //以下、境界ライン描画処理
                inY = FormControl.HEAD_HEIGHT + (inCnt + 1) * FormControl.LINE_HEIGHT;
                e.Graphics.DrawLine(Pens.Black, 0, inY, inWidth, inY);
            }
        }
    }

    public class ClsLine
    {
        public string mName;    //名前
        public string mMD5;     //画像のHash値
        public Hashtable mTblCell;  //キーはintのタイムライン番号 値はClsCell

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ClsLine()
        {
            this.mMD5 = "";
            this.mName = "";
            this.mTblCell = new Hashtable();
        }
    }

    public class ClsCell
    {
    }
}
