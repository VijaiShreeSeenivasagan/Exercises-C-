namespace HelloWorld.Exercise{
    class DuplicateNumbers{
        public static void duplicateNumbers(){
            var numbers = Console.ReadLine();
            var extractedNumbers = numbers.Trim().Split('-');
            var convertedNumbers = new int[extractedNumbers.Length];
            for(int index = 0 ;index<extractedNumbers.Length ; index++){
                convertedNumbers[index] = Convert.ToInt32(extractedNumbers[index]);
            }
            var nonDuplicatedList = convertedNumbers.Distinct().ToList();
            if(nonDuplicatedList.Count == convertedNumbers.Length)
                Console.WriteLine("No duplicates");
            else
                Console.WriteLine("Duplicates");
            
            
        }
    }
}