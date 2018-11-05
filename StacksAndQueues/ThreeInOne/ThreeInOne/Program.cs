using System;

namespace ThreeInOne
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeStacksOneArrayFixed test = new ThreeStacksOneArrayFixed(3);
            test.PushFirstStack(1);
            test.PushFirstStack(2);
            test.PushFirstStack(3);
            try
            {
                test.PushFirstStack(4);
            }
            catch (Exception)
            {

                Console.WriteLine("Push Failed");
            }
            Console.WriteLine(test.PopFirstStack());
            Console.WriteLine(test.PopFirstStack());
            Console.WriteLine(test.PopFirstStack());
            try
            {
                test.PopFirstStack();
            }
            catch (Exception)
            {
                Console.WriteLine("Pop Failed");
            }

            test.PushSecondStack(1);
            test.PushSecondStack(2);
            test.PushSecondStack(3);
            try
            {
                test.PushSecondStack(4);
            }
            catch (Exception)
            {

                Console.WriteLine("Push Failed");
            }
            Console.WriteLine(test.PopSecondStack());
            Console.WriteLine(test.PopSecondStack());
            Console.WriteLine(test.PopSecondStack());
            try
            {
                test.PopSecondStack();
            }
            catch (Exception)
            {
                Console.WriteLine("Pop Failed");
            }

            test.PushThirdStack(1);
            test.PushThirdStack(2);
            test.PushThirdStack(3);
            try
            {
                test.PushThirdStack(4);
            }
            catch (Exception)
            {

                Console.WriteLine("Push Failed");
            }
            Console.WriteLine(test.PopThirdStack());
            Console.WriteLine(test.PopThirdStack());
            Console.WriteLine(test.PopThirdStack());
            try
            {
                test.PopThirdStack();
            }
            catch (Exception)
            {
                Console.WriteLine("Pop Failed");
            }
        }
    }
}
