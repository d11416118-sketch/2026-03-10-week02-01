using System;

namespace Exercise_Ch12_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Console.Write("請輸入第1個運算元=>");
            userInput = Console.ReadLine();
            int x = Convert.ToInt32(userInput);
            Console.Write("請輸入第2個運算元=>");
            userInput = Console.ReadLine();
            int y = Convert.ToInt32(userInput);
            Console.Write("請輸入索引值=>");
            userInput = Console.ReadLine();
            int index = Convert.ToInt32(userInput);

            try
            {
                Console.WriteLine("例外處理開始");
                // 產生超過陣列範圍的例外
                string[] names = new string[5];
                string name = names[index];
                // 產生除以0的例外
                Console.WriteLine(":" + (x / y));

                Console.WriteLine("例外處理開始");
                // 丟出ArithmeticException例外
                if (x < 10)
                    throw new ArithmeticException("值小於10");

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("程式錯誤: " + ex.ToString());
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("程式錯誤: " + ex.ToString());
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("程式錯誤: " + ex.ToString());
            }
            finally
            {
                Console.WriteLine("例外處理結束");
            }
            Console.Read();
        }
    }
}
