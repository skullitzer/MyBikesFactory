using MyBikesFactory.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactory.Business
{
    public class RoadBikes : Bikes
    {
        private ETireType _tireType;

        public ETireType SuspensionType1 { get => _tireType; set => _tireType = value; }

        public override string ToString()
        {
            return $"Bike Type: Road, " + base.ToString() + ", Tire Type: " + _tireType.ToString();
        }

        public RoadBikes() : base()
        {

        }

        public RoadBikes(ETireType initialTireType) : base()
        {
            _tireType = initialTireType;
        }
    }
}
