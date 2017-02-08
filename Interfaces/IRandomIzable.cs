namespace ConsoleApplication
{
    public class Program : IRandomizable, IWork, IWork2
    {
        public static void Main(string[] args)
        {
            var keepGoing = true;
            int parsedResult = 0;

            while (keepGoing)
            {
                Console.WriteLine("Enter the upper bound int");
                var input = Console.ReadLine();
                Program p = new Program();
                IWork2 work2 = new Program();
                work2.doWork();

                IWork work = new Program();
                work.doWork();

                if (input == "exit")
                {
                    keepGoing = false;
                }
                else if (int.TryParse(input, out parsedResult))
                {
                    Console.WriteLine(p.GetRandomNumber(parsedResult));
                }
            }
        }

        public float GetRandomNumber(int upperBound)
        {
            Random r = new Random();
            var result = r.NextDouble() * upperBound;

            return (float)result;
        }

        void IWork2.doWork()
        {
            throw new NotImplementedException();
        }

        void doWork()
        {
            throw new NotImplementedException();
        }

        void IWork.doWork()
        {
            throw new NotImplementedException();
        }
    }
    interface IRandomizable
    {
        float GetRandomNumber(int upperBound);
    }

    interface IWork
    {
        void doWork();
    }
    interface IWork2
    {
        void doWork();
    }
}

