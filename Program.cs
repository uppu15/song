using System;

namespace Song
{
    // this is an example using overloads and optional parameters
    //intentionally confusing
    class Program
    {
        static void SingASong(string Title = "AppleBottomJeans",string key = "C", int nrTimes = 3)
        {
            for (int i = 0; i < nrTimes; i++)
            {
                Console.WriteLine($"Sing {Title} in {key}");
            }
        }
        static void SingASong()
        {
            SingASong("Baby Shark!");
        }

        static void SingASong(string Title)
        {
            SingASong(Title, "C");
        }

        static void SingASong(string Title, string key)
        {
            SingASong(Title, key, 5);
            //Console.WriteLine($"Lets' sing {Title} in the key of {key}");
        }

        //static void SingASong(string Title, string key, int nrTimes)
        //{
        //    for (int i = 0; i < nrTimes; i++)
        //    {
        //        Console.WriteLine($"sing {Title} (in the key of {key})");
        //    }
        //}
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tSong.Program.Main()");
            SingASong(Title:"Wheels on the bus");
            //SingASong("Get Low");
            //SingASong("Baby Shark!");
            //SingASong("Baby Shark!", "F#");
            //SingASong("Happy Birdthday", "B minor", 2);
        }
    }
}
