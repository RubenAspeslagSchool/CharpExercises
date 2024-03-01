namespace AdvancedTopics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            //Exercise1Yield.Run();

           (_, string statment) =  new Exercise4PaternMaching().Run(Console.ReadLine());
            Console.WriteLine(statment);
        }

       
    }
}
