using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace story
{
    class Troll
    {
        
        string smart;
        string strong;
        string money;
        string dollars;
        string fast;
        string headstart;
        string option;
        


       

        public void getInput()
        {
            Console.WriteLine("You're walking through the forest, minding your own business, and you run into a troll! Do you FIGHT him, PAY him, or RUN?");
            option = (Console.ReadLine().ToLower());
        }
        public void fightCase()
        {
            Console.WriteLine("how courageous!Are you strong(YES or NO) ?");
            strong = Console.ReadLine();
            Console.WriteLine("Are you smart");
            smart = Console.ReadLine();
            Answer fightAnswer = new Answer(strong, smart);
            fightAnswer.checkAnswer();
            
        }

        public void payCase()
        {
            Console.WriteLine("All right, we'll pay the troll. Do you have any money (YES or NO)?");
            money = Console.ReadLine();
            Console.WriteLine("Is your money in Troll Dollars ? ");
            dollars = Console.ReadLine();
            Answer payAnswer = new Answer(money, dollars);
            payAnswer.checkPay();
        }

        public void runCase()
        {
            Console.WriteLine("Let's book it! Are you fast (YES or NO)?");
            fast = Console.ReadLine();
            Console.WriteLine("Did you get a head start?");
            headstart = Console.ReadLine();
            Answer runAnswer = new Answer(fast, headstart);
            runAnswer.checkRun();
        }
        public void checkCase()

        {
            switch(this.option)
            {
                case "fight":
                    fightCase();
                    break;
                case "pay":
                    payCase();
                    break;
                case "run":
                    runCase();
                    break;
                default:
                    Console.WriteLine("I didn't understand your choice. Hit Run and try again, this time picking FIGHT, PAY, or RUN!");
                    break;


            }
            
        }
        



    }
}
