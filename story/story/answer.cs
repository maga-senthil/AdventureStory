using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace story
{
    class Answer
    {
        string answer1;
        string answer2;

        public Answer(string answer1,string answer2)
        {
            this.answer1 = answer1;
            this.answer2 = answer2;
        }
        public void checkAnswer()
        {
            if (this.answer1  == "yes" || this.answer2  == "yes")
            {
                Console.WriteLine("You only need one of the two! You beat the troll--nice work!");

            }
            else
            {
                Console.WriteLine("You're not strong OR smart? Well, if you were smarter, you probably wouldn't have tried to fight a troll. You lose!");

            }
            
        }
        public void checkPay()
        {
            if (this.answer1  == "yes" && this.answer2  == "yes")
            {
                Console.WriteLine("Great! You pay the troll and continue on your merry way.");

            }
            else
            {
                Console.WriteLine("Dang! This troll only takes Troll Dollars. You get whomped!");

            }
        }
        public void checkRun()
        {
            if (this.answer1  == "yes" || this.answer2  == "yes")
            {
                Console.WriteLine("You got away--barely! You live to stroll through the forest another day.");
            }
            else
            {
                Console.WriteLine("You're not fast and you didn't get a head start? You never had a chance! The troll eats you.");

            }

        }




    }
}
