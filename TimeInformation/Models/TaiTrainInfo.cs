﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.18033
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此原始程式碼由 xsd 版本=4.0.30319.17929 自動產生。
// 
namespace TimeInformation.Models
{
    using System.Xml.Serialization;


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class TaiTrainList
    {

        private TrainInfo[] trainInfoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TrainInfo")]
        public TrainInfo[] TrainInfo
        {
            get
            {
                return this.trainInfoField;
            }
            set
            {
                this.trainInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class TrainInfo
    {

        private TimeInfo[] timeInfoField;

        private string carClassField;

        private string crippleField;

        private string dinningField;

        private string lineField;

        private string lineDirField;

        private string noteField;

        private string overNightStnField;

        private string packageField;

        private string routeField;

        private string trainField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TimeInfo")]
        public TimeInfo[] TimeInfo
        {
            get
            {
                return this.timeInfoField;
            }
            set
            {
                this.timeInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CarClass
        {
            get
            {
                return this.carClassField;
            }
            set
            {
                this.carClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Cripple
        {
            get
            {
                return this.crippleField;
            }
            set
            {
                this.crippleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Dinning
        {
            get
            {
                return this.dinningField;
            }
            set
            {
                this.dinningField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Line
        {
            get
            {
                return this.lineField;
            }
            set
            {
                this.lineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LineDir
        {
            get
            {
                return this.lineDirField;
            }
            set
            {
                this.lineDirField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OverNightStn
        {
            get
            {
                return this.overNightStnField;
            }
            set
            {
                this.overNightStnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Package
        {
            get
            {
                return this.packageField;
            }
            set
            {
                this.packageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Route
        {
            get
            {
                return this.routeField;
            }
            set
            {
                this.routeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Train
        {
            get
            {
                return this.trainField;
            }
            set
            {
                this.trainField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class TimeInfo
    {

        private string aRRTimeField;

        private string dEPTimeField;

        private string orderField;

        private string routeField;

        private string stationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ARRTime
        {
            get
            {
                return this.aRRTimeField;
            }
            set
            {
                this.aRRTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DEPTime
        {
            get
            {
                return this.dEPTimeField;
            }
            set
            {
                this.dEPTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Order
        {
            get
            {
                return this.orderField;
            }
            set
            {
                this.orderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Route
        {
            get
            {
                return this.routeField;
            }
            set
            {
                this.routeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Station
        {
            get
            {
                return this.stationField;
            }
            set
            {
                this.stationField = value;
            }
        }
    }
}
