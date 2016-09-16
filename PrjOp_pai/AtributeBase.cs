using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace PrjHikariwoAnim
{
    [Serializable]
    [DataContract]
    public class AttributeBase
    {
        //データ移動用クラスベース
        //使うか使わないかは別としてとりあえず作成
        //xml,Json化可能にする為 public
        [DataMember]
        public int X,Y,Z;//LocalPosition
        [DataMember]
        public bool isX, isY, isZ;
        [DataMember]
        public float RX, RY, RZ;//Radius
        [DataMember]
        public bool isRX, isRY, isRZ;
        [DataMember]
        public float SX, SY, SZ;//Scale
        [DataMember]
        public bool isSX, isSY, isSZ;
        [DataMember]
        public int Width;//work
        [DataMember]
        public int Height;//work
        [DataMember]
        public bool FlipH;//FlipH
        [DataMember]
        public bool FlipV;//FlipV
        [DataMember]
        public int Transparency;//0-255
        [DataMember]
        public bool Enable;
        [DataMember]
        public bool Visible;
        [DataMember]
        public int Color;
        [DataMember]
        public int OffsetX,OffsetY,OffsetZ;//offset
        [DataMember]
        public string Text;//UserData
        
        string ToJson()
        {
            //未テスト
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(AttributeBase));
            MemoryStream ms = new MemoryStream();
            serializer.WriteObject(ms,this);
            return Encoding.UTF8.GetString(ms.ToArray());
        }                  
    }
}
