namespace InterfaceExerciseA
{
    internal class Program1 : IRunner, IDescriber
    {
        //public void Run()
        //{
        //    Console.WriteLine("Nu kör vi program 1");
        //}
        public void Describe()
        {
            Console.WriteLine("I am program 1");
        }
        public void Start()
        {
            Console.WriteLine("Nu kör vi program 1");
        }
    }
}
