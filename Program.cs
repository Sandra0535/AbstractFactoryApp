using AbstractFactoryLibrary.Model;

namespace AbstractFactoryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAutoFactory teslaSUVFactory = new SUVFactory();
            ITesla teslaSUV = teslaSUVFactory.CreateTesla();
            teslaSUV.Start();
            teslaSUV.Stop();
            Console.WriteLine();
            IAutoFactory teslaSedanFactory = new SedanFactory();
            ITesla teslaSedan = teslaSedanFactory.CreateTesla();
            teslaSedan.Start();
            teslaSedan.Stop();
        }
    }
}