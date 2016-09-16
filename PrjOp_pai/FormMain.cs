using System;
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
    public partial class FormMain : Form
    {
        private FormImageList mFormImageList;
        private FormControl mFormControl;
        private FormAttribute mFormAttribute;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //以下、初期化処理
            ClsTool.Init();

            this.mFormImageList = new FormImageList();
            this.mFormImageList.Show();

            this.mFormControl = new FormControl();
            this.mFormControl.Show();

            this.mFormAttribute = new FormAttribute();
            this.mFormAttribute.Show();

        }

        private void TSMenu_ImageList_Click(object sender, EventArgs e)
        {
            if (this.mFormImageList == null)
            {
                this.mFormImageList = new FormImageList();
                this.mFormImageList.Show();
            }
            else
            {                                
                this.mFormImageList.Close();
                this.mFormImageList.Dispose();
                this.mFormImageList = null;
            }
        }

        private void TSMenu_Control_Click(object sender, EventArgs e)
        {
            if (this.mFormControl == null)
            {
                this.mFormControl = new FormControl();
                this.mFormControl.Show();
            }
            else
            {
                this.mFormControl.Close();
                this.mFormControl.Dispose();
                this.mFormControl = null;
            }
        }

        private void TSMenu_Attribute_Click(object sender, EventArgs e)
        {
            if (this.mFormAttribute == null)
            {
                this.mFormAttribute = new FormAttribute();
                this.mFormAttribute.Show();
            }
            else
            {
                this.mFormAttribute.Close();
                this.mFormAttribute.Dispose();
                this.mFormAttribute = null;
            }
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            if (this.mFormImageList != null)
            {
                if (this.mFormImageList.IsDisposed)
                {
                    this.mFormImageList.Dispose();
                    this.mFormImageList = null;
                }
            }

            if (this.mFormControl != null)
            {
                if (this.mFormControl.IsDisposed)
                {
                    this.mFormControl.Dispose();
                    this.mFormControl = null;
                }
            }

            if (this.mFormAttribute != null)
            {
                if (this.mFormAttribute.IsDisposed)
                {
                    this.mFormAttribute.Dispose();
                    this.mFormAttribute = null;
                }
            }

            this.TSMenu_ImageList.Checked = (this.mFormImageList != null);

            this.TSMenu_Control.Checked = (this.mFormControl != null);

            this.TSMenu_Attribute.Checked = (this.mFormAttribute != null);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default["FormMainLocate"] = this.Location;
            Properties.Settings.Default.Save();
        }
    }
}
