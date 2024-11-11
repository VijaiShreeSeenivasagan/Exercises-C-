namespace HelloWorld.Exercise{
    class DisplayUniqueNumbers{
        public static void displayUniqueNumbers(){
            var numbersList = new List<int>() ;
            while(true){
                Console.WriteLine("Enter a number or Enter 'Quit' to exit : " );
                var enteredValue = Console.ReadLine();
                if(enteredValue == "Quit")
                    break;
                numbersList.Add(Convert.ToInt32(enteredValue));
            }
            var uniqueList = numbersList.Distinct().ToList();
            foreach(var number in uniqueList)
                Console.WriteLine(number);
        } 
    }
}