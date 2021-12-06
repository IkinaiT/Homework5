using System;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string[] userInput = SplitStringBySpace(Console.ReadLine());
            WliteLineArray(userInput);

            Delay();

            Console.Write("Введите строку: ");
            userInput = ReverseStringArray();
            WliteLineArray(userInput);

            Delay();
        }

        /// <summary>
        /// Разделение строки на массив строк. Разделитель пробел
        /// </summary>
        /// <param name="s">Исходный текст</param>
        /// <returns></returns>
        static private string[] SplitStringBySpace(string s)
        {
            return s.Split(' ');
        }
        /// <summary>
        /// Вывод массива строк, каждый элемент с новой строки. Строки содержащие пробел игнорируются
        /// </summary>
        /// <param name="s">Исходный массив строк</param>
        static private void WliteLineArray(string[] s)
        {
            foreach (string str in s)
                if(str != "") Console.WriteLine(str);
        }
        /// <summary>
        /// Создание реверсного (перевернутого) массива из строки, введенной пользователем, разделитель пробел
        /// </summary>
        /// <returns></returns>
        static private string[] ReverseStringArray()
        {
            string[] s = SplitStringBySpace(Console.ReadLine());
            string[] methodString = new string[s.Length];
            int i = methodString.Length - 1;

            foreach (string str in s)
            {
                methodString[i] = str;
                i--;
            }

            return methodString;
        }
        /// <summary>
        /// Ожидание нажатия клавиши пользователем для продолжения выполнения программы или выхода из нее
        /// </summary>
        static private void Delay()
        {
            Console.ReadKey();
        }
    }
}
