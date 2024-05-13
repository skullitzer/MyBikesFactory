using MyBikesFactory.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactory.Business
{
    public class MountainBikes : Bikes
    {
        private ESuspensionType _suspensionType;

        public ESuspensionType SuspensionType1 { get => _suspensionType; set => _suspensionType = value; }

        public override string ToString()
        {
            return $"Bike Type: Mountain, " + base.ToString() + ", Suspension Type: " + _suspensionType.ToString();
        }

        public MountainBikes() : base()
        {

        }

        public MountainBikes(ESuspensionType initialSuspensionType) : base()
        {
            _suspensionType = initialSuspensionType;
        }
    }
}
