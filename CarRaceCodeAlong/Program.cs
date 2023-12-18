namespace CarRaceCodeAlong
{
    internal class Program
    {
        internal Car car;
        internal List<Car> cars;


        internal Program()
        {
            car = new Car("Lone Car", 10, 0);

            cars = new List<Car>
            {
               new Car("Car One", 10, 0),
               new Car("Car Two", 10, 0),
            };
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        internal void Run()
        {
            Console.WriteLine("Hello, and welcome to Car race console app");

            while (true)
            {
                Console.WriteLine("1. Drive one car \n2. Race two cars \n0. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        car.DriveCar();
                        break;
                    case "2":
                        RaceAllCarsAsync();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid input, try again");
                        break;
                }
            }
        }

        internal async Task RaceAllCarsAsync()
        {
            List<Task> raceTasks = new List<Task>();

            foreach (var singleCar in cars)
            {
                raceTasks.Add(singleCar.RaceTwoCarsAsync());
            }

            await Task.WhenAny(raceTasks);
        }
    }
}
