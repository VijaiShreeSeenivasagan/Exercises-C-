namespace HelloWorld.Exercise{
    class LinqExamples{
        public static void linqExamples(){
            string sentence = "The only LINQ class you will ever need! Both Query and Method Syntaxes are covered in the course!";
            string[] names = {"wcwde","dwceec","dewce","acde"};
            int[] numbers = {4,33,6,8,2,1,9};
            //simple linq
            var simpleLinq = from s in sentence
                             select s;
            Console.WriteLine(string.Join("", simpleLinq));
        
            //using conditions

            var numbersLessThanFive = from number in numbers
                                      where number < 5
                                      select number;
            Console.WriteLine(string.Join(",",numbersLessThanFive));

            //with multiple conditions

            var numberGreaterThanFiveLessThanTen = from number in numbers       
                                                    where number >5 && number < 10
                                                    select number;
            
            Console.WriteLine(string.Join(",",numberGreaterThanFiveLessThanTen));

            //linq with strings

            var wordContainingA = from name in names
                                  where name.Contains("a")
                                  select name;

            Console.WriteLine(string.Join(",",wordContainingA));

            //ordering ex

            var ascendingOrderedNumbers = from number in numbers
                                           orderby number 
                                           select number;

            Console.WriteLine(string.Join(",",ascendingOrderedNumbers)); 

            var descendingOrderedNumbers = from number in numbers
                                           orderby number descending
                                           select number;

            Console.WriteLine(string.Join(",",descendingOrderedNumbers));                                 
        }


    }
}