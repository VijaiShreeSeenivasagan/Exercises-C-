using System;
using System.Reflection.Metadata;
namespace HelloWorld.Exercise
{
   
    class HelloWorld
    {
        public static void likes(){
           string name;
           var listOfNames = new List<string>() ;
           while(true){
                name = Console.ReadLine();
                if(!String.IsNullOrEmpty(name)){
                    listOfNames.Add(name);
                    continue;
                }
                break;      
           }
           for(int i = 1 ;i<= listOfNames.Count ; i++){
            if(listOfNames.Count == 1 || i == 1)
                Console.Write(listOfNames[i-1]);
            else if(listOfNames.Count == 2)
                Console.Write(" and {0}",listOfNames[i-1]);
            else{
                Console.Write(" , {0} and {1}",listOfNames[i-1] , listOfNames.Count - 2);
                break;
            }
                
            
           }
           Console.Write(" liked your post");

        }
    }
    
}
