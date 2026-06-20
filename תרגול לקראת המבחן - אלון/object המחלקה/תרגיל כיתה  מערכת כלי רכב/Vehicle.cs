using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_כיתה__מערכת_כלי_רכב
{
    internal class Vehicle
    {
        public string LisensePlate;
        public int Speed;

        public Vehicle(string licensePlate, int speed)
        {
            this.LisensePlate = licensePlate;
            this.Speed = speed;
        }

        public virtual void Move()
        {
            Console.WriteLine($"Vehicle is moving at {Speed} km/h");
        }
        public override string ToString()
        {
            return $"License Plate: {LisensePlate}, Speed: {Speed} km/h";
        }
        public override bool Equals(object? obj)
        {
           Vehicle otherVehicle = obj as Vehicle;
            if (otherVehicle != null)
            {
                return this.LisensePlate == otherVehicle.LisensePlate;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return LisensePlate.GetHashCode();
        }
}
}
