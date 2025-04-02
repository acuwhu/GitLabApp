namespace GitLabApp
{
    class Program 
    {
        static void Main(string[] args) 
        {
            //#13
            Console.Write("x: ");
            double x = double.Parse(Console.ReadLine());

            double f = Math.Sin(x) + Math.Cos(x);
            Console.WriteLine($"f = {f}");
        }
    }
}