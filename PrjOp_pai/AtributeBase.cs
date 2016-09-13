using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjHikariwoAnim
{
    public class AttributeBase
    {
        public int X,Y,Z;//LocalPosition
        public float RX, RY, RZ;//Radius
        public float SX, SY, SZ;//Scale
        public int Width;
        public int Height;
        public bool FlipH;
        public bool FlipV;
        public int TransParent;//0-255
        public bool Enable;
        public bool Visible;
        public int Color;
        public int OffsetX,OffsetY,OffsetZ;//offset
        public string Text;//UserData
                  
    }
}
