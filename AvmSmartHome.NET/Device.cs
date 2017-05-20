﻿using System.Xml.Serialization;

namespace AvmSmartHome.NET
{
    [XmlRoot(ElementName = "device")]
    public class Device
    {
        [XmlElement(ElementName = "present")]
        public string Present { get; set; }

        [XmlIgnore]
        public bool IsPresent { get { return Present == "1"; } }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "switch")]
        public Switch Switch { get; set; }

        [XmlElement(ElementName = "powermeter")]
        public Powermeter Powermeter { get; set; }

        [XmlElement(ElementName = "temperature")]
        public Temperature Temperature { get; set; }

        [XmlAttribute(AttributeName = "identifier")]
        public string Identifier { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "functionbitmask")]
        public string FunctionBitmask { get; set; }

        [XmlAttribute(AttributeName = "fwversion")]
        public string FirmwareVersion { get; set; }

        [XmlAttribute(AttributeName = "manufacturer")]
        public string Manufacturer { get; set; }

        [XmlAttribute(AttributeName = "productname")]
        public string ProductName { get; set; }

        public Device()
        {

        }
    }
}
