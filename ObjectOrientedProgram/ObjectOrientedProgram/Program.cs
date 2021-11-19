using System;

namespace ObjectOrientedProgram
{
    class Program
    {
        static string filepath = @"D:\JSON\Object-Oriented-Program\OOPsJSon\OOPsJSon\Files\InventoryMain.json";
        static void Main(string[] args)
        {
            bool flag = true;
            InventoryMain im = new InventoryMain();
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the Address Program Press- 1-Name, 2-Weight, 3-Price");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        im.DisplayData(filepath);
                        break;
                    case 2:
                        flag = false;
                        break;

                }
            }
        }
    }
}
