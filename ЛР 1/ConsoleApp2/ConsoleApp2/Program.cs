using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sbyte sb = -128;
            //short sh = -32768;
            //long l = -9223372036854775808;
            //int i = -2147483648;
            //float f = 1.23f;
            //double d = 2.7418529;
            //decimal dec = 1.1123456789545454544m;
            //char c = 'I';
            //bool bl = true;

            //Console.WriteLine($"sbyte: {sb}\n,short:{sh}\n,int: {i}\n,long: {l}\n,float:{f}\n");
            //Console.WriteLine($"double:{d}\n, decimal: {dec}\n, char: {c}\n,bool: {bl}\n\n\n");


            //Console.Write("Введите число: ");
            //i = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите число с плавающей запятой: ");
            //d = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите символ: ");
            //c = Convert.ToChar(Console.ReadLine());
            //Console.Write("Введите логическое значение: ");
            //bl = Convert.ToBoolean(Console.ReadLine());


            //Console.WriteLine($"\n\n\n\nВведенное int: {i}");
            //Console.WriteLine($"Введенное double: {d}");
            //Console.WriteLine($"Введенное char: {c}");
            //Console.WriteLine($"Введенное bool: {bl}");


            //int prostoe = 100;
            //long slozhnoe = prostoe;
            //float poslozhnee = prostoe;
            //double echeslozhnee = poslozhnee;
            //decimal ochenslozhnoe = prostoe;

            //Console.WriteLine($"int -> long: {slozhnoe}");
            //Console.WriteLine($"int -> float: {poslozhnee}");
            //Console.WriteLine($"float -> double: {echeslozhnee}");
            //Console.WriteLine($"int -> decimal: {ochenslozhnoe}");



            //double doubleValue2 = 123.456;
            //int intValue2 = (int)doubleValue2;


            //int a = 42;
            //object b = a;
            //Console.WriteLine($"Упаковка значимого в ссылочный: {b}");

            //int с = (int)b;
            //Console.WriteLine($"Наоборот: {с}");



            //var integer = 15;
            //var dauble = 1.234;
            //var str = "Дарова";

            //Console.WriteLine($"тип int: {integer.GetType()}");
            //Console.WriteLine($"Тип double: {dauble.GetType()}");
            //Console.WriteLine($"тип string: {str.GetType()}");


            //int? ilya = null;
            //double? ilyaIgorevich = 1.125;

            //Console.WriteLine($"Илья: {ilya}");
            //Console.WriteLine($"илья игоревич: {ilyaIgorevich}");

            //var stochka = "це буквы в сточке";
            //Console.WriteLine($"{stochka.GetType()}");
            ////stochka = 42;


























            //string str1 = "п";
            //string str2 = "ри";
            //string str3 = "п";
            //string str4 = "лыли";

            //bool pstr1 = (str1 == str2);
            //bool pstr2 = (str1 == str3);
            //bool pstr3 = str1.Equals(str3);
            //bool pstr4 = String.Equals(str1, str3);
            //Console.WriteLine($"str1 == str2: {pstr1}");
            //Console.WriteLine($"str1 == str3: {pstr2}");
            //Console.WriteLine($"str1.Equals(str3): {pstr3}");
            //Console.WriteLine($"String.Equals(str1, str3): {pstr3}");


            //string s1 = "Я";
            //string s2 = "хочу";
            //string s3 = "домой";

            //string concatenasia = s1 + "очень " + s2 + "к себе " + s3;
            //string concatenasia2 = String.Concat(s1, " ", s2, " ", s3);
            //Console.WriteLine($"Конкатенация: {concatenasia}");
            //Console.WriteLine($"конкатенация2: {concatenasia2}");

            //string s4 = s1;
            //string s5 = String.Copy(s1);
            //Console.WriteLine($"s4: {s4}, s5 (copy): {s5}");

            //string substr = concatenasia.Substring(6, 4);
            //Console.WriteLine($"Подстрока с 6 места 4 симовла: {substr}");

            //string sentence = "Привет, меня зовут Джорж";
            //string[] words = sentence.Split(' ');
            //Console.WriteLine("Слова после пробела:");
            //foreach (var word in words)
            //{
            //    Console.WriteLine($"- {word}");
            //}

            //string original = "ёу, с вами ";
            //string parodia = original.Insert(6, "Ян");
            //Console.WriteLine($"Итого: {parodia}");

            //string toRemove = "Ян";
            //int index = parodia.IndexOf(toRemove);
            //if (index >= 0)
            //{
            //    string afterRemoval = parodia.Remove(index, toRemove.Length);
            //    Console.WriteLine($"После удаления: {afterRemoval}");
            //}

            //string name = "Илья";
            //int age = 18;
            //string innterpolasiastroki = $"Меня зовут {name}. мне {age} ерс олд.";
            //Console.WriteLine(innterpolasiastroki);

            //double salary = 12345.6789;
            //string FI = $"Salary: {salary:C2}";
            //Console.WriteLine(FI);

            //string emptyString = "";
            //string nullString = null;

            //bool strin1 = String.IsNullOrEmpty(emptyString);
            //bool strin2 = String.IsNullOrEmpty(nullString);
            //bool strin3 = String.IsNullOrEmpty("ООП");

            //Console.WriteLine($"1-fz пустая? {strin1}");
            //Console.WriteLine($"2-ая пустая? {strin2}");
            //Console.WriteLine($"3-ая пустая? {strin3}");
            //string strochka = emptyString + "буква";

            //StringBuilder sb = new StringBuilder("пим пум пам пам");
            //Console.WriteLine($"{sb}");
            //Console.WriteLine($"{sb.Length}");

            //sb.Remove(0, 8);
            //Console.WriteLine($"После удаления: {sb}");

            //sb.Insert(0, "лалала");
            //Console.WriteLine($"Добавление в начало {sb}");

            //sb.Append(" ОКАК");
            //Console.WriteLine($"В конец: {sb}");











            //int[,] matrix = {
            //{ 1, 2, 3 },
            //{ 4, 5, 6 } 
            //};

            //Console.WriteLine("Двумерный массив:");

            //int rows = matrix.GetUpperBound(0) + 1;
            //int columns = matrix.GetUpperBound(1) + 1;

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write($"{matrix[i, j]} \t");
            //    }
            //    Console.WriteLine();
            //}





            //string[] strA = { "Илья", "Юра", "Ярик", "Ден" };

            //Console.WriteLine("Содержимое массива:");
            //foreach (string word in strA)
            //{
            //    Console.Write($"{word} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Длина массива: {strA.Length}");

            //Console.Write("Введите индекс для изменения: ", strA.Length - 1);
            //int position = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Введите новое значение: ");
            //string newValue = Console.ReadLine();

            //strA[position] = newValue;
            //Console.WriteLine("Массив после изменения:");
            //foreach (string word in strA)
            //{
            //    Console.Write($"{word} ");
            //}
            //Console.WriteLine();


            //double[][] A2 = new double[3][];

            //A2[0] = new double[2]; 
            //A2[1] = new double[3]; 
            //A2[2] = new double[4];

            //Console.WriteLine("Введите значения для ступенчатого массива:");

            //for (int i = 0; i < A2.Length; i++)
            //{
            //    Console.WriteLine($"Строка {i} (количество элементов: {A2[i].Length}):");
            //    for (int j = 0; j < A2[i].Length; j++)
            //    {
            //        Console.Write($"  Элемент [{j}]: ");
            //        A2[i][j] = Convert.ToDouble(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("Ступенчатый массив:");
            //for (int i = 0; i < A2.Length; i++)
            //{
            //    for (int j = 0; j < A2[i].Length; j++)
            //    {
            //        Console.Write($"{A2[i][j]} \t");
            //    }
            //    Console.WriteLine();
            //}

            //var Array = new[] { 10, 20, 30, 40, 50 };
            //var String = "Это неявно типизированная строка";






























            //(int t11, string t12, char t13, string t14, ulong t15) t1 = (12, "Илья", 'A', "тоже", 1234556789);
            //Console.WriteLine($"{t1.t11}, {t1.t12}, {t1.t13}");

            //var kortesh = ("laba", 120);
            //var (subject, count) = kortesh;
            //Console.WriteLine($"Предмет: {subject}, Количество: {count}");


            //(int a, byte b) left = (5, 10);
            //(long a, int b) right = (5, 10);
            //Console.WriteLine(left == right);
            //Console.WriteLine(left != right);

            //var p1 = (A: 5, B: 10);
            //var p2 = (B: 5, A: 10);
            //Console.WriteLine(p1 == p2);
            //Console.WriteLine(p1 != p2);

            //string oop = "Яблоня";
            //var arrayF = new[] { 10, 20, 30, 40, 50 };

            //(int max, int min, int sum, char fl) function(int[] arr, string str)
            //{
            //    int max = arr[0];
            //    int min = arr[0];
            //    int sum = 0;
            //    foreach (var item in arr)
            //    {
            //        if (item > max)
            //        {
            //            max = item;
            //        }
            //        if (item < min)
            //        {
            //            min = item;
            //        }
            //    }
            //    char fl = str[0];
            //    return (max, min, sum, fl);
            //}
            //var result = function(arrayF, oop);

            //Console.WriteLine($"max = {result.max}");
            //Console.WriteLine($"min = {result.min}");
            //Console.WriteLine($"sum = {result.sum}");
            //Console.WriteLine($"Перваы буква = {result.fl}");







            void localfunction1()
            {
                unchecked
                {
                    int a = int.MaxValue;
                    Console.WriteLine("Max: " + a);
                    a = a + 10;
                    Console.WriteLine("После игнора: " + a);
                }
                checked
                {
                    int a = int.MaxValue;
                    Console.WriteLine("Max: " + a);
                    a = a + 1;
                }
            }

            localfunction1();
       
        }
    }
}
