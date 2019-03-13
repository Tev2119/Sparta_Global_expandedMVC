using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Properties.Models
{
    public class PropertiesClass
    {
        private int id;
        private int squareAcres;
        private int numOfBedrooms;
        private int numOfBathrooms;
        private int propPrice;
        private int numOfFloors;
        private string propType;
        private string location;
        private string country;

        public int Id { get => id; set => id = value; }

        public int SquareAcres { get => squareAcres; set => squareAcres = value; }

        public int NumOfBedrooms { get => numOfBedrooms; set => numOfBedrooms = value; }

        public int NumOfBathrooms { get => numOfBathrooms; set => numOfBathrooms = value; }

        public int PropPrice { get => propPrice; set => propPrice = value; }

        public int NumOfFloors { get => numOfFloors; set => numOfFloors = value; }

        public string PropType { get => propType; set => propType = value; }

        public string Location { get => location; set => location = value; }

        public string Country { get => country; set => country = value; }
    }
}