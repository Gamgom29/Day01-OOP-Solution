using Common;
namespace Demo
{
    internal class Program
    {
        static void Run(ICar car)
        {

        }
        static void Main(string[] args)
        {
            TypeA obj = new TypeA();
            //obj.X = 10 ; invalid due its protection X is private
            //obj.Y = 20;  invalid due its protection Y is internal
            obj.Z = 30;   // valid as Z is Public
        }
    }
}
