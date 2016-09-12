using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PrjHikariwoAnim
{
    public class ClsImage
    {
        public Image mImageOriginal;
        public Image mImageBig;
        public Image mImageSmall;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ClsImage()
        {
            this.mImageOriginal = null;
            this.mImageBig = null;
            this.mImageSmall = null;
        }
    }
}
