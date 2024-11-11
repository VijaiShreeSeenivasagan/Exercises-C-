using System.Data.Common;

namespace HelloWorld.Exercise{
    class LongestWordInFile{
        public static void longestWordInFile(){
            var file = new FileInfo(@"/Users/vijaishrees/Documents/HelloWorld/Exercises/Refactoring.txt");
            var content = File.ReadAllText(@"/Users/vijaishrees/Documents/HelloWorld/Exercises/Refactoring.txt");
            var words = content.Split(" ");
            var maxWordLength = 0;
            string longestWord = "";
            foreach(var word in words){
                if(word.Length > maxWordLength){
                    maxWordLength = word.Length;
                    longestWord = word;
                }

            }

            Console.WriteLine(longestWord);
        }
    }
}