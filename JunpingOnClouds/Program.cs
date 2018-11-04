using System;

namespace JunpingOnClouds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] cloudArray = new int[] { 0, 0, 1, 0, 0, 1, 0 };
            FindNumberOfCloudsJumped(cloudArray);
        }


        static int FindNumberOfCloudsJumped(int[] cloudArray)
        {
            var targetIndex = 0;
            var jumpCount = 0;
            for (int i = 0; i < cloudArray.Length; i++)
            {
                if (cloudArray[i] == 1)
                {
                    continue;
                }
              
                Console.WriteLine("Current Index is: " + i);
  
                if (i == cloudArray.Length - 2)
                {
                    //Console.WriteLine("Jump 1 cloud");
                    targetIndex = i + 1;
                    Console.WriteLine("Target Index: " + targetIndex);
                    jumpCount += 1;
                }


                if (i < cloudArray.Length - 2)
                {
                    //Console.WriteLine("Next to Next Index is: " + (i + 2));
                    var NextNextValueinArr = cloudArray[i + 2];
                    //Console.WriteLine("Next to next value is: " + cloudArray[i + 2]);

                    if (NextNextValueinArr == 0)
                    {

                        //Console.WriteLine("Jump 2 clouds");
                        targetIndex = i + 2;
                        Console.WriteLine("Target Index: " + targetIndex);
                        jumpCount += 1;
                        i += 1;
                    }
                    else
                    {
                        //Console.WriteLine("Jump 1 cloud");
                        targetIndex = i + 1;
                        Console.WriteLine("Target Index: " + targetIndex);
                        jumpCount += 1;
                    }


                }

                Console.WriteLine("Jump Count: " + jumpCount);
                Console.WriteLine();

               
            }
            Console.WriteLine("Jump Count: " + jumpCount);
            return jumpCount;
        }

    }
}
