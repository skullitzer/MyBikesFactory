using MyBikesFactory.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyBikesFactory.Business
{
    [Serializable]
    [XmlInclude(typeof(MountainBikes))]
    [XmlInclude(typeof(RoadBikes))]
    public abstract class Bikes
    {
        private int _serialNumber;
        private string _model;
        private int _manufacturingYear;
        private EColor _color;
        private ESuspensionType _suspensionType;
        private ETireType _tireType;

        public int SerialNumber { get => _serialNumber; set => _serialNumber = value; }
        public string Model { get => _model; set => _model = value; }
        public int ManufacturingYear { get => _manufacturingYear; set => _manufacturingYear = value; }
        public EColor Color { get => _color; set => _color = value; }
        public ESuspensionType SuspensionType { get => _suspensionType; set => _suspensionType = value; }
        public ETireType TireType { get => _tireType; set => _tireType = value; }

        public Bikes()
        {
            _serialNumber = 0;
            _model = "";
            _manufacturingYear = 0;
            _color = EColor.Black;
            _suspensionType = ESuspensionType.Front;
            _tireType = ETireType.Regular;
        }

        public Bikes(int initialSerialNumber) : this()
        {
            _serialNumber = initialSerialNumber;
        }

        public override string ToString()
        {
            return $"Serial Number: {_serialNumber}, Model: {_model},Manufacturing Year: {_manufacturingYear}, Color: {_color}, Suspension Type: {_suspensionType}, Tire Type: {_tireType}";
        }
    }
}
