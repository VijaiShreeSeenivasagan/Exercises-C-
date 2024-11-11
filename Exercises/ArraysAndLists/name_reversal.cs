using System;

namespace HelloWorld.Exercise{
    class Name_Reversal{

        public static void nameReversal(string name){
            
            string reversedName = "";
            for(int letterIndex = name.Length ; letterIndex > 0 ; letterIndex--){
                reversedName += name[letterIndex-1];
            }
            Console.WriteLine(reversedName);
        }
        
    }
}