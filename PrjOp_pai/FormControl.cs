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

                int inWidth = (int)this.InFrame.Value * FormControl.TIME_CELL_WIDTH + 1;
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
            //Item選択

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
            //Flameクリック処理
            //フレーム検出
            int cx = e.X / TIME_CELL_WIDTH;
            int cy = e.Y / HEAD_HEIGHT;
            //注:範囲指定時は考慮
            //クリックフレームを現在のフレームに指定
            if (cx <= InFrame.Value) NowFlame.Value = cx;
            
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
            int inWidth = (int)this.InFrame.Value * FormControl.TIME_CELL_WIDTH + 1;
            this.panel_Time.Width = inWidth;

            this.panel_Time.Refresh();
        }

        private void panel_Control_Paint(object sender, PaintEventArgs e)
        {
            int inWidth  = this.panel_Control.Width;
            int inHeight = this.panel_Control.Height;
            int GridSize = 8 * PreviewZoomLelel.Value;


            //以下、イメージリスト描画処理
            e.Graphics.Clear(Color.White);

            //DrawGrid
            if (CheckGrid.Checked)
            {
                //Grid
                //V
                for (int gy = (inHeight/2) % GridSize ; gy < inHeight; gy += GridSize)
                {
                    e.Graphics.DrawLine(Pens.LightGreen,0,gy,inWidth,gy);
                }
                //H
                for (int gx =(inWidth/2) % GridSize ; gx < inWidth; gx += GridSize)
                {
                    e.Graphics.DrawLine(Pens.LightGreen, gx, 0, gx,inHeight);
                }                
            }

            //以下、縦ライン描画処理
            //e.Graphics.DrawLine(Pens.Black, 40, 0, 40, inHeight);

            //以下、横ライン描画処理
            int inY = FormControl.HEAD_HEIGHT;
            //e.Graphics.DrawLine(Pens.Black, 0, inY, inWidth, inY);

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
            
            //DrawCrossBar
            if(CheckCross.Checked)
            {
                e.Graphics.DrawLine(Pens.Red, inWidth/2, 0, inWidth/2, inHeight);
                e.Graphics.DrawLine(Pens.Red, 0,inHeight/2 , inWidth,inHeight/2);
            }

        }

        private void panel_Time_Paint(object sender, PaintEventArgs e)
        {
            //TimeLine
            int inWidth = this.panel_Time.Width;
            int inHeight = this.panel_Control.Height;
            int inFrame = (int)this.InFrame.Value;
            int CellWidth = TIME_CELL_WIDTH;
            int CellHeight = HEAD_HEIGHT;

            //全消去
            e.Graphics.Clear(Color.White);

            //以下、縦ライン描画処理
            int inCnt, inMax;
            for (inCnt = 0; inCnt < inFrame; inCnt++)
            {
                var pen = Pens.Black;
                
                //5の倍数の時(グレイ)
                if (inCnt % 5 == 0) pen = Pens.LightGray;
                //現在のフレームの時(赤)
                if (inCnt == NowFlame.Value) pen = Pens.Red;
                //標準(黒)
                e.Graphics.DrawLine(pen, (inCnt + 1) * CellWidth, 0, (inCnt + 1) * CellWidth, inHeight);
            }

            //以下、横ライン描画処理

            e.Graphics.DrawLine(Pens.Black, 0, CellHeight, inWidth -1 , CellHeight);

            inMax = this.mListLine.Count;
            for (inCnt = 0; inCnt < inMax; inCnt++)
            {
                ClsLine clLine = this.mListLine[inCnt] as ClsLine;
                if (clLine == null) continue;

                //以下、境界ライン描画処理
                int inY = CellHeight + (inCnt + 1) * CellHeight;
                e.Graphics.DrawLine(Pens.Black, 0, inY, inWidth, inY);
            }


        }

        private void NowFlame_ValueChanged(object sender, EventArgs e)
        {
            //現在フレームが変更された時の処理
            PreViewRefresh();
            
        }
        private void PreViewRefresh()
        {
            //全体再描画
            panel_Control.Refresh();
            panel_Time.Refresh();
        }

        private void CheckCross_CheckStateChanged(object sender, EventArgs e)
        {
            panel_Control.Refresh();
        }

        private void panel_Control_DragDrop(object sender, DragEventArgs e)
        {
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
