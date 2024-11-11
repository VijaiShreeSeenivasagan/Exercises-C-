using System.Data.Common;
using System.Globalization;
using System.Threading.Channels;
using Microsoft.VisualBasic;

namespace HelloWorld.Exercise
{
    public class Loops{
        public void findNumbersDivisibleByThree(){
            Console.WriteLine("LowerLimit");
            int lowerLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("UpperLimit");
            int upperLimit = Convert.ToInt32(Console.ReadLine());
            int count =0;
            for(int number = lowerLimit+1 ; number< upperLimit;number++){
                count = number%3==0 ? count+1:count ;
            }
            Console.WriteLine("Count Of Numbers divisible by 3 between {0} and  {1} is {2}",lowerLimit , upperLimit, count);
        }

        public void countEnteredNumbers(){

            int count = 0;
            var number = "0";
            do{
                count += Convert.ToInt32(number);
                number = Console.ReadLine();
             }while(number != "ok");

             Console.WriteLine("Sum of entered numbers = {0}" , count);
        }

        public void findFactorial(){
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factorial of {0} is {1}" , number , factorial(number));
        }

        private int factorial(int number){
            if(number == 0 || number ==1)
                return 1;
            else
                return number * factorial(number-1);
        }

        public void numberGuessing(){
            Random random = new Random();
            var number = random.Next(1,10);
            int chance = 0;
            int guess;
            do{
                Console.WriteLine("Guess :");
                guess = Convert.ToInt32(Console.ReadLine());
                chance++;
            }while(chance < 4 && number!=guess);

            Console.WriteLine((chance == 4 )?"You Lost" : "You Won" );
            
        }

        public void findMaximumOfArray(){
            Console.WriteLine("Input series of comma separated numbers");
            var numbers = Console.ReadLine();
            string[] stringArrayOfNumbers = numbers.Split(",");
            var intArrayOfNumbers = new int[stringArrayOfNumbers.Length];
            ConditionalStatements conditionalStatements = new ConditionalStatements();
            for(int index =0 ; index < stringArrayOfNumbers.Length ; index++){
                intArrayOfNumbers[index] = Convert.ToInt32(stringArrayOfNumbers[index]);
            }
            int max = intArrayOfNumbers[0];
            foreach (var value in intArrayOfNumbers)
            {
                max = conditionalStatements.findMaximumOfTwoNumbers(max , value) ? max : value ;
            }

            Console.WriteLine("Maximum of numbers is {0}" , max);
        }
    }
}