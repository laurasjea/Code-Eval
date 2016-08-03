using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrantOfAnAngle
{
    public class quadofangle
    {
        public static void Main(string[] args)
        {
            int angle = 0;
            int quad = 0;
            Console.WriteLine("Type an integer angle (in degrees) and press Enter:");
            angle = int.Parse(Console.ReadLine());
            Console.WriteLine(angle + ":");

            while (true)
            {
                if (angle > 360)
                {
                    angle -= 360;
                }
                else
                {
                    break;
                }
            }

            if (angle > 270)
            {
                quad = 4;
            }
            else if (angle > 180)
            {
                quad = 3;
            }
            else if (angle > 90)
            {
                quad = 2;
            }
            else if (angle > 0)
            {
                quad = 1;
            }

            Console.WriteLine("Quadrant is:");
            Console.WriteLine(quad);
        }
    }
}
