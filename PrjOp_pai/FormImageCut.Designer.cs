namespace PrjHikariwoAnim
{
    partial class FormImageCut
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
            this.components = new System.ComponentModel.Container();
            this.comboBox_Mag = new System.Windows.Forms.ComboBox();
            this.button_Cut = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.panel = new System.Windows.Forms.Panel();
            this.panel_Image = new System.Windows.Forms.Panel();
            this.radioButton_8dot = new System.Windows.Forms.RadioButton();
            this.radioButton_16dot = new System.Windows.Forms.RadioButton();
            this.radioButton_32dot = new System.Windows.Forms.RadioButton();
            this.checkBox_Grid = new System.Windows.Forms.CheckBox();
            this.checkBox_Magnet = new System.Windows.Forms.CheckBox();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_ColorGrid = new System.Windows.Forms.Panel();
            this.panel_ColorRect = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Mag
            // 
            this.comboBox_Mag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Mag.FormattingEnabled = true;
            this.comboBox_Mag.Items.AddRange(new object[] {
            "100%",
            "200%",
            "400%",
            "800%",
            "1600%"});
            this.comboBox_Mag.Location = new System.Drawing.Point(549, 14);
            this.comboBox_Mag.Name = "comboBox_Mag";
            this.comboBox_Mag.Size = new System.Drawing.Size(64, 20);
            this.comboBox_Mag.TabIndex = 3;
            this.comboBox_Mag.SelectedIndexChanged += new System.EventHandler(this.comboBox_Mag_SelectedIndexChanged);
            // 
            // button_Cut
            // 
            this.button_Cut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cut.Enabled = false;
            this.button_Cut.Location = new System.Drawing.Point(762, 12);
            this.button_Cut.Name = "button_Cut";
            this.button_Cut.Size = new System.Drawing.Size(75, 23);
            this.button_Cut.TabIndex = 4;
            this.button_Cut.Text = "切り取り";
            this.button_Cut.UseVisualStyleBackColor = true;
            this.button_Cut.Click += new System.EventHandler(this.button_Cut_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 500);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(849, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoScroll = true;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.panel_Image);
            this.panel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel.Location = new System.Drawing.Point(12, 41);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(825, 456);
            this.panel.TabIndex = 6;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel_Image
            // 
            this.panel_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Image.Location = new System.Drawing.Point(-1, -1);
            this.panel_Image.Name = "panel_Image";
            this.panel_Image.Size = new System.Drawing.Size(256, 256);
            this.panel_Image.TabIndex = 0;
            this.panel_Image.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Image_Paint);
            this.panel_Image.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Image_MouseDown);
            this.panel_Image.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Image_MouseUp);
            // 
            // radioButton_8dot
            // 
            this.radioButton_8dot.AutoSize = true;
            this.radioButton_8dot.Checked = true;
            this.radioButton_8dot.Location = new System.Drawing.Point(160, 15);
            this.radioButton_8dot.Name = "radioButton_8dot";
            this.radioButton_8dot.Size = new System.Drawing.Size(70, 16);
            this.radioButton_8dot.TabIndex = 7;
            this.radioButton_8dot.TabStop = true;
            this.radioButton_8dot.Text = "8dot Grid";
            this.radioButton_8dot.UseVisualStyleBackColor = true;
            this.radioButton_8dot.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_16dot
            // 
            this.radioButton_16dot.AutoSize = true;
            this.radioButton_16dot.Location = new System.Drawing.Point(236, 15);
            this.radioButton_16dot.Name = "radioButton_16dot";
            this.radioButton_16dot.Size = new System.Drawing.Size(76, 16);
            this.radioButton_16dot.TabIndex = 8;
            this.radioButton_16dot.Text = "16dot Grid";
            this.radioButton_16dot.UseVisualStyleBackColor = true;
            this.radioButton_16dot.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_32dot
            // 
            this.radioButton_32dot.AutoSize = true;
            this.radioButton_32dot.Location = new System.Drawing.Point(318, 15);
            this.radioButton_32dot.Name = "radioButton_32dot";
            this.radioButton_32dot.Size = new System.Drawing.Size(76, 16);
            this.radioButton_32dot.TabIndex = 9;
            this.radioButton_32dot.Text = "32dot Grid";
            this.radioButton_32dot.UseVisualStyleBackColor = true;
            this.radioButton_32dot.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // checkBox_Grid
            // 
            this.checkBox_Grid.AutoSize = true;
            this.checkBox_Grid.Location = new System.Drawing.Point(85, 16);
            this.checkBox_Grid.Name = "checkBox_Grid";
            this.checkBox_Grid.Size = new System.Drawing.Size(69, 16);
            this.checkBox_Grid.TabIndex = 10;
            this.checkBox_Grid.Text = "Grid表示";
            this.checkBox_Grid.UseVisualStyleBackColor = true;
            this.checkBox_Grid.CheckedChanged += new System.EventHandler(this.checkBox_Grid_CheckedChanged);
            // 
            // checkBox_Magnet
            // 
            this.checkBox_Magnet.AutoSize = true;
            this.checkBox_Magnet.Location = new System.Drawing.Point(12, 16);
            this.checkBox_Magnet.Name = "checkBox_Magnet";
            this.checkBox_Magnet.Size = new System.Drawing.Size(67, 16);
            this.checkBox_Magnet.TabIndex = 11;
            this.checkBox_Magnet.Text = "マグネット";
            this.checkBox_Magnet.UseVisualStyleBackColor = true;
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Interval = 16;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Grid色";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "選択色";
            // 
            // panel_ColorGrid
            // 
            this.panel_ColorGrid.BackColor = System.Drawing.Color.Silver;
            this.panel_ColorGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ColorGrid.Location = new System.Drawing.Point(444, 12);
            this.panel_ColorGrid.Name = "panel_ColorGrid";
            this.panel_ColorGrid.Size = new System.Drawing.Size(23, 23);
            this.panel_ColorGrid.TabIndex = 14;
            this.panel_ColorGrid.Click += new System.EventHandler(this.panel_ColorGrid_Click);
            // 
            // panel_ColorRect
            // 
            this.panel_ColorRect.BackColor = System.Drawing.Color.Lime;
            this.panel_ColorRect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ColorRect.Location = new System.Drawing.Point(520, 12);
            this.panel_ColorRect.Name = "panel_ColorRect";
            this.panel_ColorRect.Size = new System.Drawing.Size(23, 23);
            this.panel_ColorRect.TabIndex = 15;
            this.panel_ColorRect.Click += new System.EventHandler(this.panel_ColorRect_Click);
            // 
            // FormImageCut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 522);
            this.Controls.Add(this.panel_ColorRect);
            this.Controls.Add(this.panel_ColorGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_Magnet);
            this.Controls.Add(this.checkBox_Grid);
            this.Controls.Add(this.radioButton_32dot);
            this.Controls.Add(this.radioButton_16dot);
            this.Controls.Add(this.radioButton_8dot);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.button_Cut);
            this.Controls.Add(this.comboBox_Mag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Name = "FormImageCut";
            this.Text = "イメージカッター";
            this.Load += new System.EventHandler(this.FormImageCut_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormImageCut_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormImageCut_KeyUp);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Mag;
        private System.Windows.Forms.Button button_Cut;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.RadioButton radioButton_8dot;
        private System.Windows.Forms.RadioButton radioButton_16dot;
        private System.Windows.Forms.RadioButton radioButton_32dot;
        private System.Windows.Forms.CheckBox checkBox_Grid;
        private System.Windows.Forms.CheckBox checkBox_Magnet;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Panel panel_Image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_ColorGrid;
        private System.Windows.Forms.Panel panel_ColorRect;
    }
}