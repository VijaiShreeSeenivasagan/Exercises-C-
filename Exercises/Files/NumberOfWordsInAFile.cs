namespace HelloWorld.Exercise{
    class NumberOƒWordsInFile{
        public static void numberofWordsInFile(){
            var file = new FileInfo(@"/Users/vijaishrees/Documents/HelloWorld/Exercises/Refactoring.txt");
            var content = File.ReadAllText(@"/Users/vijaishrees/Documents/HelloWorld/Exercises/Refactoring.txt");
            var words = content.Split(" ");
            Console.WriteLine("Number Of Words = {0}" , words.Length);
        }
    }
}