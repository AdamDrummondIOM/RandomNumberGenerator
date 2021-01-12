using System;

namespace RandomNumberGenerator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                DateTime currentTime = DateTime.Now;
                Console.Write(Math.Acos(-1).ToString().Substring(3)[currentTime.Millisecond%10]);
                Console.Write(Math.Asin(-1).ToString().Substring(3)[currentTime.Second%10]);
                Console.Write(Math.Atan(-1).ToString().Substring(3)[(currentTime.Millisecond*currentTime.Second)%10]);
                Console.ReadLine();
            }
        }
    }
}
