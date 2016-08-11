using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace story
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Troll newTroll = new Troll();
            newTroll.getInput();
            newTroll.checkCase();
            Console.ReadLine();


        }
    }
}
