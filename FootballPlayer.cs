using System;

namespace Opgave1
{
    public class FootballPlayer
    {
        private int _id;
        private string _name;
        private double _price;
        private int _shirtNumber;


        public FootballPlayer(int id, string name, double price, int shirtNumber)
        {
            _id = id;
            _name = name;
            _price = price;
            _shirtNumber = shirtNumber;
        }

        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 4) throw new ArgumentException("Name is too short");
                _name = value;
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                if (value > 0) throw new ArgumentOutOfRangeException("Price", Price, "Price has to be more than 0");
                _price = value;
            }
        }

        public int ShirtNumber
        {
            get => _shirtNumber;
            set
            {
                if (value <= 1 || value >= 100) throw new ArgumentOutOfRangeException("ShirtNumber", ShirtNumber, "Shirt Number has to be from 1-100");
                _shirtNumber = value;
            }
        }
    }
}
