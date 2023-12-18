
namespace CarRaceCodeAlong
{
    internal class Car
    {
        internal string Name { get; set; }
        internal int MeterS { get; set; }
        internal int Distance { get; set; }


        internal Car(string name, int meterS, int distance)
        {
            Name = name;
            MeterS = meterS;
            Distance = distance;
        }

        internal void DriveCar()
        {
            Console.Clear();

            while (true)
            {
                Distance += MeterS;

                if (Distance <= 500)
                {
                    MeterS += 10;

                }
                else
                {
                    MeterS -= 10;
                }

                if (Distance >= 1000)
                {
                    Console.WriteLine($"\nYou are going {MeterS}Meters/s.\nYou have driven {Distance} Meters ");

                    return;
                }

                Thread.Sleep(1000);
                Console.WriteLine($"\nYou are going {MeterS}Meters/s.\nYou have driven {Distance} Meters ");
            }

        }
        internal async Task RaceTwoCarsAsync()
        {
            var speed = new Random();

            while (true)
            {
                Distance += MeterS;

                MeterS = speed.Next(60, 200);

                Console.WriteLine($"\n{Name} is driving at {MeterS} meters/s and is at {Distance} meters.");

                if (Distance >= 10000)
                {
                    Console.WriteLine($"Car {Name} is done!");
                    return;
                }

                await Task.Delay(200);
            }

        }
    }
}
