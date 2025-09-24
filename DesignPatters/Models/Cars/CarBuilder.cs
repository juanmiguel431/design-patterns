namespace DesignPatters.Models.Cars;

public class CarBuilder
{
    private class Impl: ISpecifyCareType, ISpecifyWheelSize, IBuildCar
    {
        private Car _car = new Car();
        
        public ISpecifyWheelSize OfType(CarType type)
        {
            _car.Type = type;
            return this;
        }

        public IBuildCar WheelSize(int size)
        {
            switch (_car.Type)
            {
                case CarType.Crossover when size < 17 || size > 20 :
                case CarType.Sedan when size < 15 || size > 17:    
                    throw new ArgumentException($"Wrong wheel size for {_car.Type}");
            }
            
            _car.WheelSize = size;
            return this;
        }

        public Car Build() => _car;
    }
    
    public static ISpecifyCareType Create()
    {
        return new Impl();
    }
}