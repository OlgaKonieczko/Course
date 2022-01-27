using System;

namespace KursS02Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"To start press 's', to pause press 'p', press any other key to stop");

            string start = "s";
            string pause = "p";
            var stopwatch = new Stopwatch();
            bool end = false;


            while (end == false)

            {
                string help = Console.ReadLine();

                if (help == start || help == start.ToLower())
                {
                    stopwatch.Start();
                }

                else if (help == pause || help == pause.ToLower())
                {
                    stopwatch.Stop();
                    Console.WriteLine(stopwatch.Stop().ToString(@"mm\:ss\.fff"));
                }

                else
                {
                    end = true;
                    break;
                }

            }
        }

    }
}

