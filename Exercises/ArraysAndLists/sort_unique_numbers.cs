namespace HelloWorld.Exercise{
    class SortUniqueNumbers{
        public static void sortUniqueNumbers(){
            var numbers = new int[5];

            for(int i = 0; i < numbers.Length ; i++){
                var number = Convert.ToInt32(Console.ReadLine());
                if(numbers.Contains(number)){
                    Console.WriteLine("number already exists");
                    i--;
                    continue;
                }
                    
                numbers[i] = number ;
            }

            Array.Sort(numbers);
            foreach(int number in numbers)
                Console.Write(number + " , ");

        }
    }
}