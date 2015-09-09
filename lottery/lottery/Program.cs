using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            var max = 49;

            var range = new int[max];

            var random = new Random();

            for(var i=0;i< max; i++)
            {
                range[i] = i+1;
            }
            
            for(var x = 0; x < 6; x++)
            {
                var pickIndex = range[random.Next(max)];
                var pick = range[pickIndex];
                Console.WriteLine("Pick {0}: {1}", x+1, pick);
            }
        }
    }
}
