using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace town
{
    class Bank
    {
        public string Name { get; set; }
        public string BuildingType { get; set; }
        public int NumberOfRoom { get; set; }
        public string ConstructionMaterial { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public int Floors { get; set; }
        public int BathRooms { get; set; }
        public string Address1 { get; }
        public string Address2 { get; }
        public string City { get; }
        public string State { get; }
        public string Zip { get; }
        public int CurrentOccupants { get { return _currentOccupants; } }
        private int _currentOccupants;
        private double AmountOfMoney { get { return _amountOfMoney; } }
        private int _amountOfMoney;
        public string FullAddress
        {
            get
            {
                return Address1 + Address2 + City + State + Zip;
            }
        }
        public double SquareFootage
        {
            get
            {
                return Width * Length;
            }
        }
        public double Volume
        {
            get
            {
                return Height * Width * Length;
            }
        }

        public Bank(string bank)
        {
            this.BuildingType = bank;
        }

        public string DisplayName()
        {
            return this.Name;
        }
        public override string ToString()
        {
            return $"{this.BuildingType} : {this.Name}";
        }

        public int IncreaseOccupants()
        {
            return _currentOccupants++;
        }
        public int DecreaseOccupants()
        {
            return _currentOccupants--;
        }

        public double DipositMoney()
        {
            return _amountOfMoney++;
        }
        public double WithdrawMoney()
        {
            return _amountOfMoney--;
        }
    }
}
