using System;

namespace HomeWork3
{
    class Work
    {
        private String worke;

        public Work(string str)
        {
            worke = str;
        }

        public void PrintPolindromTest()
        {
            String varPrintPolindromTest = worke;
            varPrintPolindromTest = varPrintPolindromTest.ToLower();
            varPrintPolindromTest = varPrintPolindromTest.Replace(" ", string.Empty);
            varPrintPolindromTest = varPrintPolindromTest.Replace(".", string.Empty);
            varPrintPolindromTest = varPrintPolindromTest.Replace(",", string.Empty);

            char[] strMas = varPrintPolindromTest.ToCharArray(); // из строки в массив символов char

            Array.Reverse(strMas); // изменяет порядок элементов на обратный

            string rotateStr = new string(strMas);

            if (varPrintPolindromTest == rotateStr)
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом");
            }
        }

        public void PrintHowManyWord()
        {
            string[] workeMas = worke.Split(' '); // разделяет строку на подстроки 
            Console.WriteLine("Количество слов: " + workeMas.Length);
        }

        public void PrintInverse()
        {
            String varPrintInverse = worke;
            char[] strMas = varPrintInverse.ToCharArray();
            Array.Reverse(strMas);
            Console.WriteLine(strMas);
        }
    }
}

