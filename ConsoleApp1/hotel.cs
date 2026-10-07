using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal record hotel(string Name,string City,string Category,string Owner,int TotalRooms)
    {
        private string _owner {  get; init; } = Owner;
        private int _totalRooms { get; init; } = TotalRooms;
        public int PricePerNight { get; set; }
        public double Rating {  get; set; }
        private int _availableRooms { get; set; }

        public int GetPricePerNight()
        {
            return PricePerNight;
        }

        public double GetRating()
        {
            return Rating;
        }
        public string GetOwner()
        {
            return _owner;
        }
        public void SetAvailableRooms(int room)
        {
            _availableRooms = room;
        }
        public void DecreasePrice(int percet)
        {
            PricePerNight *= (100 - percet) / 100;
        }
        public void IncreasePrice(int percet)
        {
            PricePerNight *= (100 + percet) / 100;
        }
        public void UpdateRating(double rating)
        {
            Rating = rating;
        }
        public bool IsOutStanding()
        {
            return Rating >= 9.0;
        }
        public bool IsMin10Room()
        {
            return _availableRooms >= 10;
        }
        public int GetAvailableRooms()
        {
            return _availableRooms;
        }
        public int GetUnavRooms()
        {
            return _totalRooms - _availableRooms;
        }
        public double ReservedPercent()
        {
            return Math.Round(GetUnavRooms()/ Convert.ToDouble(_totalRooms)* 100,2);
        }
        public void ReserveRoom(int number)
        {
            _availableRooms = _availableRooms >= number ? _availableRooms - number : _availableRooms;

            
        }
        public void PlusAvailableRooms(int number)
        {
            _availableRooms = _availableRooms + number >= _totalRooms ? _availableRooms + number : _availableRooms;
        }
        public int SummaPrice(int night,int room_number)
        {
            return (night) * room_number;
        }
        public bool IsCheaper(int money)
        {
            return money >= PricePerNight;
  
        }
        public bool IsOk(double rating)
        {
            return rating <= Rating;
        }
        public override string ToString()
        {
            return $"{Name}{City}{Category}{PricePerNight}{Rating}";
        }
    }
   
    
}
