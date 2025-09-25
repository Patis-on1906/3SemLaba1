using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba1;

namespace Laba1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ComputerTechnology> compTechList = new List<ComputerTechnology>();

            while (true)
            {
                Console.WriteLine("What object do you want to make?\n1 - Computer technology\n2 - Monitor\n3 - Keyboard\n" +
                    "4 - Print objects\n5 - Exit");

                int input;
                if (!int.TryParse(Console.ReadLine(), out input))
                    continue;

                switch (input)
                {
                    case 1:
                        {
                            Console.Write("Enter manufacturer: ");
                            string manufacturer = Console.ReadLine();
                            compTechList.Add(new ComputerTechnology(manufacturer));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter manufacturer, resolution (WIDTHxHEIGHT), screen size and refresh rate:");
                            string manufacturer = Console.ReadLine();

                            Console.Write("Resolution (e.g. 1920x1080): ");
                            string resolution = Console.ReadLine();
                            string[] parts = resolution.Split('x');
                            int width = int.Parse(parts[0]);
                            int height = int.Parse(parts[1]);

                            Console.Write("Screen size: ");
                            float screenSize = float.Parse(Console.ReadLine());

                            Console.Write("Refresh rate: ");
                            int refreshRate = int.Parse(Console.ReadLine());

                            compTechList.Add(new MonitorTech(manufacturer, new List<int> { width, height }, screenSize, refreshRate));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter manufacturer, color, type of keys (membrane, mechanical or optical), connection type (wired or wireless) and whether there is a backlight (1 or 0):");

                            Console.Write("Manufacturer: ");
                            string manufacturer = Console.ReadLine();

                            Console.Write("Color: ");
                            string color = Console.ReadLine();

                            Console.Write("Keys type: ");
                            string keys = Console.ReadLine();

                            Console.Write("Connection type: ");
                            string connection = Console.ReadLine();

                            Console.Write("Has backlight (1 or 0): ");
                            bool hasBacklight = Console.ReadLine() == "1";

                            compTechList.Add(new Keyboard(manufacturer, color, keys, connection, hasBacklight));
                            break;
                        }
                    case 4:
                        {
                            int i = 1;
                            foreach (var item in compTechList)
                            {
                                Console.Write($"{i++}: ");
                                item.Print();
                            }
                            break;
                        }
                    case 5:
                        return;
                    default:
                        break;
                }
            }
        }
    }
}

