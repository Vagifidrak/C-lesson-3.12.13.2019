using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bucaqlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hesablamaq istediyin bucaqlari yaz");
            int bucaq = Convert.ToInt32(Console.ReadLine());
            dordBucaq drd = new dordBucaq(bucaq);
            Console.WriteLine("Dordbucaqlinin sahesi:");
            
            {
            }
        }

    }
}
