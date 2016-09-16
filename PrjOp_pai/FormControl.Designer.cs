namespace PrjHikariwoAnim
{
    partial class FormControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panel_Control = new System.Windows.Forms.Panel();
            this.panel_Time = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.再生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.Panel_FlameControl_Base = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButtonFore = new System.Windows.Forms.Button();
            this.ButtonFore1 = new System.Windows.Forms.Button();
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonPrev1 = new System.Windows.Forms.Button();
            this.ButtonPrev = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NowFlame = new System.Windows.Forms.NumericUpDown();
            this.FlameZoomLevel = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.InFrame = new System.Windows.Forms.NumericUpDown();
            this.Panel_Preview_Control_base = new System.Windows.Forms.Panel();
            this.PreviewZoomLelel = new System.Windows.Forms.HScrollBar();
            this.CheckCross = new System.Windows.Forms.CheckBox();
            this.CheckGrid = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Panel_FlameControl_Base.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NowFlame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InFrame)).BeginInit();
            this.Panel_Preview_Control_base.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Location = new System.Drawing.Point(12, 27);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.AutoScroll = true;
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer.Panel1.Controls.Add(this.panel_Control);
            this.splitContainer.Panel1.Controls.Add(this.Panel_Preview_Control_base);
            this.splitContainer.Panel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.splitContainer_Panel1_Scroll);
            this.splitContainer.Panel1MinSize = 48;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.AutoScroll = true;
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer.Panel2.Controls.Add(this.panel_Time);
            this.splitContainer.Panel2.Controls.Add(this.Panel_FlameControl_Base);
            this.splitContainer.Panel2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.splitContainer_Panel2_Scroll);
            this.splitContainer.Panel2MinSize = 48;
            this.splitContainer.Size = new System.Drawing.Size(587, 247);
            this.splitContainer.SplitterDistance = 195;
            this.splitContainer.TabIndex = 0;
            // 
            // panel_Control
            // 
            this.panel_Control.AllowDrop = true;
            this.panel_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Control.Location = new System.Drawing.Point(0, 0);
            this.panel_Control.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Control.Name = "panel_Control";
            this.panel_Control.Size = new System.Drawing.Size(193, 212);
            this.panel_Control.TabIndex = 1;
            this.panel_Control.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_Control_DragDrop);
            this.panel_Control.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Control_Paint);
            this.panel_Control.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_Control_MouseClick);
            this.panel_Control.MouseEnter += new System.EventHandler(this.panel_Control_MouseEnter);
            this.panel_Control.MouseLeave += new System.EventHandler(this.panel_Control_MouseLeave);
            this.panel_Control.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Control_MouseMove);
            // 
            // panel_Time
            // 
            this.panel_Time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Time.Location = new System.Drawing.Point(0, 0);
            this.panel_Time.Name = "panel_Time";
            this.panel_Time.Size = new System.Drawing.Size(386, 212);
            this.panel_Time.TabIndex = 0;
            this.panel_Time.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Time_Paint);
            this.panel_Time.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_Time_MouseClick);
            this.panel_Time.MouseEnter += new System.EventHandler(this.panel_Time_MouseEnter);
            this.panel_Time.MouseLeave += new System.EventHandler(this.panel_Time_MouseLeave);
            this.panel_Time.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Time_MouseMove);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.再生ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(611, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 再生ToolStripMenuItem
            // 
            this.再生ToolStripMenuItem.Name = "再生ToolStripMenuItem";
            this.再生ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.再生ToolStripMenuItem.Text = "再生";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_Name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 37);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "名前";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Name.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_Name.Location = new System.Drawing.Point(49, 7);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 23);
            this.textBox_Name.TabIndex = 5;
            // 
            // Panel_FlameControl_Base
            // 
            this.Panel_FlameControl_Base.Controls.Add(this.panel2);
            this.Panel_FlameControl_Base.Controls.Add(this.panel3);
            this.Panel_FlameControl_Base.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_FlameControl_Base.Location = new System.Drawing.Point(0, 212);
            this.Panel_FlameControl_Base.Name = "Panel_FlameControl_Base";
            this.Panel_FlameControl_Base.Size = new System.Drawing.Size(386, 33);
            this.Panel_FlameControl_Base.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ButtonFore);
            this.panel3.Controls.Add(this.ButtonFore1);
            this.panel3.Controls.Add(this.ButtonPlay);
            this.panel3.Controls.Add(this.ButtonStop);
            this.panel3.Controls.Add(this.ButtonPrev1);
            this.panel3.Controls.Add(this.ButtonPrev);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 33);
            this.panel3.TabIndex = 12;
            // 
            // ButtonFore
            // 
            this.ButtonFore.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonFore.Location = new System.Drawing.Point(155, 0);
            this.ButtonFore.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonFore.Name = "ButtonFore";
            this.ButtonFore.Size = new System.Drawing.Size(31, 33);
            this.ButtonFore.TabIndex = 5;
            this.ButtonFore.Text = ">|";
            this.ButtonFore.UseVisualStyleBackColor = true;
            // 
            // ButtonFore1
            // 
            this.ButtonFore1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonFore1.Location = new System.Drawing.Point(124, 0);
            this.ButtonFore1.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonFore1.Name = "ButtonFore1";
            this.ButtonFore1.Size = new System.Drawing.Size(31, 33);
            this.ButtonFore1.TabIndex = 4;
            this.ButtonFore1.Text = ">";
            this.ButtonFore1.UseVisualStyleBackColor = true;
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonPlay.Location = new System.Drawing.Point(93, 0);
            this.ButtonPlay.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(31, 33);
            this.ButtonPlay.TabIndex = 3;
            this.ButtonPlay.Text = "|>";
            this.ButtonPlay.UseVisualStyleBackColor = true;
            // 
            // ButtonStop
            // 
            this.ButtonStop.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonStop.Location = new System.Drawing.Point(62, 0);
            this.ButtonStop.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(31, 33);
            this.ButtonStop.TabIndex = 2;
            this.ButtonStop.Text = "||";
            this.ButtonStop.UseVisualStyleBackColor = true;
            // 
            // ButtonPrev1
            // 
            this.ButtonPrev1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonPrev1.Location = new System.Drawing.Point(31, 0);
            this.ButtonPrev1.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPrev1.Name = "ButtonPrev1";
            this.ButtonPrev1.Size = new System.Drawing.Size(31, 33);
            this.ButtonPrev1.TabIndex = 1;
            this.ButtonPrev1.Text = "<";
            this.ButtonPrev1.UseVisualStyleBackColor = true;
            // 
            // ButtonPrev
            // 
            this.ButtonPrev.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonPrev.Location = new System.Drawing.Point(0, 0);
            this.ButtonPrev.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPrev.Name = "ButtonPrev";
            this.ButtonPrev.Size = new System.Drawing.Size(31, 33);
            this.ButtonPrev.TabIndex = 0;
            this.ButtonPrev.Text = "|<";
            this.ButtonPrev.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.NowFlame);
            this.panel2.Controls.Add(this.FlameZoomLevel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.InFrame);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(151, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 33);
            this.panel2.TabIndex = 13;
            // 
            // NowFlame
            // 
            this.NowFlame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NowFlame.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NowFlame.Location = new System.Drawing.Point(10, 7);
            this.NowFlame.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NowFlame.Name = "NowFlame";
            this.NowFlame.Size = new System.Drawing.Size(52, 23);
            this.NowFlame.TabIndex = 14;
            this.NowFlame.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NowFlame.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NowFlame.ValueChanged += new System.EventHandler(this.NowFlame_ValueChanged);
            // 
            // FlameZoomLevel
            // 
            this.FlameZoomLevel.Location = new System.Drawing.Point(155, 6);
            this.FlameZoomLevel.Maximum = 10;
            this.FlameZoomLevel.Minimum = 1;
            this.FlameZoomLevel.Name = "FlameZoomLevel";
            this.FlameZoomLevel.Size = new System.Drawing.Size(80, 24);
            this.FlameZoomLevel.TabIndex = 13;
            this.FlameZoomLevel.Value = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(64, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "/";
            // 
            // InFrame
            // 
            this.InFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InFrame.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InFrame.Location = new System.Drawing.Point(81, 7);
            this.InFrame.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.InFrame.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.InFrame.Name = "InFrame";
            this.InFrame.Size = new System.Drawing.Size(52, 23);
            this.InFrame.TabIndex = 10;
            this.InFrame.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.InFrame.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // Panel_Preview_Control_base
            // 
            this.Panel_Preview_Control_base.BackColor = System.Drawing.Color.DimGray;
            this.Panel_Preview_Control_base.Controls.Add(this.CheckGrid);
            this.Panel_Preview_Control_base.Controls.Add(this.CheckCross);
            this.Panel_Preview_Control_base.Controls.Add(this.PreviewZoomLelel);
            this.Panel_Preview_Control_base.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Preview_Control_base.Location = new System.Drawing.Point(0, 212);
            this.Panel_Preview_Control_base.Name = "Panel_Preview_Control_base";
            this.Panel_Preview_Control_base.Size = new System.Drawing.Size(193, 33);
            this.Panel_Preview_Control_base.TabIndex = 2;
            // 
            // PreviewZoomLelel
            // 
            this.PreviewZoomLelel.LargeChange = 2;
            this.PreviewZoomLelel.Location = new System.Drawing.Point(113, 6);
            this.PreviewZoomLelel.Maximum = 10;
            this.PreviewZoomLelel.Minimum = 1;
            this.PreviewZoomLelel.Name = "PreviewZoomLelel";
            this.PreviewZoomLelel.Size = new System.Drawing.Size(80, 24);
            this.PreviewZoomLelel.TabIndex = 14;
            this.PreviewZoomLelel.Value = 1;
            this.PreviewZoomLelel.ValueChanged += new System.EventHandler(this.NowFlame_ValueChanged);
            // 
            // CheckCross
            // 
            this.CheckCross.Appearance = System.Windows.Forms.Appearance.Button;
            this.CheckCross.AutoSize = true;
            this.CheckCross.Dock = System.Windows.Forms.DockStyle.Left;
            this.CheckCross.Location = new System.Drawing.Point(0, 0);
            this.CheckCross.Margin = new System.Windows.Forms.Padding(0);
            this.CheckCross.Name = "CheckCross";
            this.CheckCross.Size = new System.Drawing.Size(23, 33);
            this.CheckCross.TabIndex = 15;
            this.CheckCross.Text = "C";
            this.CheckCross.UseVisualStyleBackColor = true;
            this.CheckCross.CheckStateChanged += new System.EventHandler(this.CheckCross_CheckStateChanged);
            // 
            // CheckGrid
            // 
            this.CheckGrid.Appearance = System.Windows.Forms.Appearance.Button;
            this.CheckGrid.AutoSize = true;
            this.CheckGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.CheckGrid.Location = new System.Drawing.Point(23, 0);
            this.CheckGrid.Margin = new System.Windows.Forms.Padding(0);
            this.CheckGrid.Name = "CheckGrid";
            this.CheckGrid.Size = new System.Drawing.Size(23, 33);
            this.CheckGrid.TabIndex = 16;
            this.CheckGrid.Text = "G";
            this.CheckGrid.UseVisualStyleBackColor = true;
            this.CheckGrid.CheckStateChanged += new System.EventHandler(this.CheckCross_CheckStateChanged);
            // 
            // FormControl
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 311);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(16, 118);
            this.Name = "FormControl";
            this.Text = "コントロール";
            this.Load += new System.EventHandler(this.FormControl_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormControl_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormControl_DragEnter);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Panel_FlameControl_Base.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NowFlame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InFrame)).EndInit();
            this.Panel_Preview_Control_base.ResumeLayout(false);
            this.Panel_Preview_Control_base.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 再生ToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Time;
        private System.Windows.Forms.Panel panel_Control;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Panel Panel_FlameControl_Base;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown NowFlame;
        private System.Windows.Forms.HScrollBar FlameZoomLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown InFrame;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ButtonFore;
        private System.Windows.Forms.Button ButtonFore1;
        private System.Windows.Forms.Button ButtonPlay;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Button ButtonPrev1;
        private System.Windows.Forms.Button ButtonPrev;
        private System.Windows.Forms.Panel Panel_Preview_Control_base;
        private System.Windows.Forms.HScrollBar PreviewZoomLelel;
        private System.Windows.Forms.CheckBox CheckGrid;
        private System.Windows.Forms.CheckBox CheckCross;
    }
}