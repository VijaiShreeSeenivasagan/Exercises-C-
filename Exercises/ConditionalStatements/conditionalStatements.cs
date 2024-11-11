using System.Data.Common;

namespace HelloWorld.Exercise
{
    public class ConditionalStatements{

        public void checkValidityOfANumber(int number){
            if(1 <= number && number <= 10 )
                Console.WriteLine("Valid");
            else
                Console.WriteLine("InValid");

        }

        public Boolean findMaximumOfTwoNumbers(int numberOne , int numberTwo){
            checkValidityOfANumber(numberOne);
            checkValidityOfANumber(numberTwo);
            return((numberOne > numberTwo)? true : false);

        }

        public void findLandscapeOrPortrait(int width , int height){
            var decision = findMaximumOfTwoNumbers(width , height);
            Console.WriteLine((decision) ? "Landscape" : "Portrait");
        }

        public void findDemeritPoints(){
            Console.WriteLine("SpeedLimit : ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Speed Of Car");
            int speed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(findMaximumOfTwoNumbers(speedLimit,speed) ? "Ok"  : ((speed - speedLimit)/5 >= 12) ? "License Suspended" : "Not Ok") ;
           
        }

    }
}