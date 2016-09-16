using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjHikariwoAnim
{
    public partial class FormAttribute : Form
    {

        //一時記録用
        //AllSet,AllGet時に更新
        private AttributeBase ValuesPool;
        public FormAttribute()
        {
            InitializeComponent();
        }

        public void SetAllParam(AttributeBase atr)
        {
            ValuesPool = atr;

            UDnumX.Value = atr.X;
            UDnumY.Value = atr.Y;
            //UDnumZ.Value = atr.Z;
            UDnumRX.Value = (decimal)atr.RX;
            UDnumRY.Value = (decimal)atr.RY;
            UDnumRZ.Value = (decimal)atr.RZ;

            UDnumSX.Value = (decimal)atr.SX;
            UDnumSY.Value = (decimal)atr.SY;
            //UDnumSZ.Value = (decimal)atr.SZ;

            checkX.Checked = atr.isX;
            checkY.Checked = atr.isY;
            //checkZ.Checked = atr.isZ;

            checkRX.Checked = atr.isRX;
            checkRY.Checked = atr.isRY;
            checkRZ.Checked = atr.isRZ;

            checkSX.Checked = atr.isSX;
            checkSY.Checked = atr.isSY;
            //checkSZ.Checked = atr.isSZ;

            checkFlipH.Checked = atr.FlipH;
            checkFlipV.Checked = atr.FlipV;



            //checkEnable.Checked = atr.Enable;
            checkVisible.Checked = atr.Visible;

            UDnumT.Value = atr.Transparency;

            ColorCode.Text = $"{atr.Color:X8}";

            UDnumXoff.Value = atr.OffsetX;
            UDnumYoff.Value = atr.OffsetY;

            UserText.Text = atr.Text;

        }
        public AttributeBase GetAllParam()
        {
            AttributeBase ret = new AttributeBase();
            ret.X = (int)UDnumX.Value;
            ret.Y = (int)UDnumY.Value;
            //ret.Z = Decimal.ToInt32(UDnumZ.Value);

            ret.RX = (float)UDnumRX.Value;
            ret.RY = (float)UDnumRY.Value;
            ret.RZ = (float)UDnumRZ.Value;

            ret.SX = (float)UDnumSX.Value;
            ret.SY = (float)UDnumSY.Value;
            //ret.SZ = (float)UDnumSZ.Value;

            ret.FlipH = checkFlipH.Checked;
            ret.FlipV = checkFlipV.Checked;

            //ret.Enable = checkEnable.Checked;
            ret.Visible = checkVisible.Checked;

            ret.Transparency = (int)UDnumT.Value;

            if (ColorCode.Text != "")
            {
                ret.Color = int.Parse(ColorCode.Text, System.Globalization.NumberStyles.HexNumber);
            }
            ret.OffsetX = (int)UDnumXoff.Value;
            ret.OffsetY = (int)UDnumYoff.Value;
            //ret.OffsetZ = (int)UDnumZoff.Value;

            ret.Text = UserText.Text;

            ValuesPool = ret;
            return ret;
        }

        private void ColorCode_TextChanged(object sender, EventArgs e)
        {
            //PreViewColor
            if (ColorCode.Text != "")
            {
                ColorPanel.BackColor = Color.FromArgb(int.Parse(ColorCode.Text, System.Globalization.NumberStyles.HexNumber));
            }
        }

        private void ColorPanel_Click(object sender, EventArgs e)
        {
            //PickUP ColorDialog
            ColorDialog dlg = new ColorDialog();
            dlg.Color = ColorPanel.BackColor;
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                ColorPanel.BackColor = dlg.Color;
                ColorCode.Text = $"{dlg.Color.ToArgb():X8}";//ARGB
                //ColorCode.Text =  dlg.Color.R.ToString("X2") + dlg.Color.G.ToString("X2") + dlg.Color.B.ToString("X2"); //RGB 6
            }
        }
    }
}
