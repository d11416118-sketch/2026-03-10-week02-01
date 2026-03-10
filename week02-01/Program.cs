namespace week02_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 5;
                int c;
                if (b > 10)
                {
                    throw new ArithmeticException("值大於10");
                }

                if (a > 10)
                {
                    throw new MyExce("a值大於10");
                }

                c = a / b;

                string[] names = new string[5];
                string id = names[4];


            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error" + ex.ToString());
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error" + ex.ToString());
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Error" + ex.ToString());
            }
            catch ( MyExce ex)
            {
                Console.WriteLine("Error:" + ex.ToString());
            }
            finally
            {
                Console.WriteLine("END");
            }





        }
    }
}
