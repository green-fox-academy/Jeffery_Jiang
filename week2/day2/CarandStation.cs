namespace PertrolStation 
{
    class Station
    {
        public int GasAmount;

        public void Refill(Car car)
        {
            GasAmount -= car.Capacity;
            car.GasAmount += car.Capacity;
        }
    }

    class Car
    {
        public int GasAmount;
        public int Capacity;

        public Car()
        {
            GasAmount = 0;
            Capacity = 100;
        }
    }

}