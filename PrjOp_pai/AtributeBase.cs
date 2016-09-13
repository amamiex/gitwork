using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjHikariwoAnim
{
    public class AttributeBase
    {
        //データ移動用クラスベース
        public int X,Y,Z;//LocalPosition
        public bool isX, isY, isZ;
        public float RX, RY, RZ;//Radius
        public bool isRX, isRY, isRZ;
        public float SX, SY, SZ;//Scale
        public bool isSX, isSY, isSZ;
        public int Width;//work
        public int Height;//work
        public bool FlipH;//FlipH
        public bool FlipV;//FlipV
        public int Transparency;//0-255
        public bool Enable;
        public bool Visible;
        public int Color;
        public int OffsetX,OffsetY,OffsetZ;//offset
        public string Text;//UserData
                  
    }
}
