namespace InterfaceExerciseA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var program1 = new Program1();
            //program1.Run();
            program1.Describe();
            program1.Start();

            var program2 = new Program2();
            //program2.Go();
            program2.Start();
        }
    }
}
