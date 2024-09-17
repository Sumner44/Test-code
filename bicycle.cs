using System;

namespace CisPkg2087.Bicycle
{

    public class Bicycle
    {
        // The Bicycle class has three fields
        protected int cadence;
        protected int gear;
        protected int speed;

        // The Bicycle class has one constructor
        public Bicycle(int startCadence, int startSpeed, int startGear)
        {
            gear = startGear;
            cadence = startCadence;
            speed = startSpeed;
        }

        // The Bicycle class has four methods
        public void SetCadence(int newValue)
        {
            cadence = newValue;
        }

        public void SetGear(int newValue)
        {
            gear = newValue;
        }

        public int GetCadence()
        {
            return this.cadence;
        }

        public int GetGear()
        {
            return this.gear;
        }

        public int GetSpeed()
        {
            return this.speed;
        }

        public void ApplyBrake(int decrement)
        {
            speed -= decrement;
        }

        public void SpeedUp(int increment)
        {
            speed += increment;
        }

        public override string ToString()
        {
            string bike = $"My Bike: {this.speed}, {GetCadence()}, {this.gear}";
            return bike;
        }
    }
}
