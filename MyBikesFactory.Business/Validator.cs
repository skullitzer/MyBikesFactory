using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MyBikesFactory.Business
{
    public static class Validator
    {
        public static bool ValidateSerialNumber(string inputToCheck)
        {
            //return int.TryParse(inputToCheck, out _); 
            return Regex.IsMatch(inputToCheck, "^[0-9]+$");
        }
        public static bool ValidateUniqueSerialNumber(string inputToCheck, List<Bikes> listOfBikes)
        {
            int serialNumber = Convert.ToInt32(inputToCheck);
            foreach (var Bikes in listOfBikes)
            {
                if (Bikes.SerialNumber == serialNumber)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool ValidateModel(string inputToCheck)
        {
            return Regex.IsMatch(inputToCheck, @"^\w{5}$");//just 5 characters
        }
        public static bool ValidateManYear(string inputToCheck)
        {
            return Regex.IsMatch(inputToCheck, @"^[0-9]{4}$");
        }
    }
}