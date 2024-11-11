namespace HelloWorld.Exercise{
    class ConsecutiveNumbers{
        public static void consecutiveNumbers(){
            var numbers = Console.ReadLine();
            var extractedNumbers = numbers.Trim().Split('-');
            int addedCount = Convert.ToInt32(extractedNumbers[0]);
            int subtractedCount = Convert.ToInt32(extractedNumbers[0]);
            int sum = Convert.ToInt32(extractedNumbers[0]);
            int flag =0 ;
            for(int index = 1 ;index<extractedNumbers.Length ; index++){
                sum += Convert.ToInt32(extractedNumbers[index]);
                addedCount += Convert.ToInt32(extractedNumbers[0])+index;
                subtractedCount += Convert.ToInt32(extractedNumbers[0])-index;

                if(sum != addedCount && sum != subtractedCount){
                    flag++;
                    break;
                }
            }

            if(flag ==0)
                Console.WriteLine("Consecutive");
            else
                Console.WriteLine("Not Consecutive");
            
            
        }
    }
}