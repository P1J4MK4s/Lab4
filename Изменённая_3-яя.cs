using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class Arrs
    {
        private Random rnd { get; set; }

        public Arrs()
        {
            rnd = new Random();
        }
        public void CreateOneDimAr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(10);
            }
        }
        public void CreateAr2(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(10);
                }
            }
        }
        public void CreateAr3(int[][] jagger)
        {
            for (int i = 0; i < jagger.Length; i++)
            {
                for (int j = 0; j < jagger[i].Length; j++)
                {
                    jagger[i][j] = rnd.Next(10);
                }
            }
        }

        public void SummOfArr(int[] first, int[] second, int[] result)
        {
            for (int i = 0; i < first.Length; i++)
            {
                result[i] = first[i] + second[i];
            }
        }
        public void DiffOfArr(int[] first, int[] second, int[] result)
        {
            for (int i = 0; i < first.Length; i++)
            {
                result[i] = first[i] - second[i];
            }
        }
        public void MultOfArr(int[] first, int[] second, int[] result)
        {
            for (int i = 0; i < first.Length; i++)
            {
                result[i] = first[i] * second[i];
            }
        }
        public void DivOfArr(int[] first, int[] second, int[] result)
        {
            for (int i = 0; i < first.Length; i++)
            {
                result[i] = first[i] / second[i];
            }
        }

        public void PrintArrl(string name, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public void PrintArrl2(string name, int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        public void PrintArrl3(string name, int[][] jagger)
        {
            for (int i = 0; i < jagger.Length; i++)
            {
                for (int j = 0; j < jagger[i].Length; j++)
                {
                    Console.Write(jagger[i][j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public int[,] MultMatr(int[,] first, int[,] second)
        {
            int[,] wrong = new int[2, 2] { { 0, 0 }, { 0, 0 } };
            if (first.GetLength(0) != second.GetLength(0)) return wrong;
            if (first.GetLength(1) != second.GetLength(1)) return wrong;
            int[,] result = new int[first.GetLength(0), first.GetLength(1)];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = first[i, j] * second[i, j];
                }
            }
            return result;
        }




        public void PrintAnyArr(Array arr)
        {
            if (arr.Rank == 1)
            {
                object elem = arr.GetValue(0);
                if (elem.GetType().IsArray)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        for (int j = 0; j < arr.GetLength(i); j++)
                        {
                            Console.Write(arr.GetValue(i, j));
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine(arr.GetValue(i));
                    }
                }
            }
            if (arr.Rank == 2)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(arr.GetValue(i, j));
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }
        public static void PrintAnyArr2(Object A, params int[] coef)
        {
            Array arr = A as Array;
            if (arr == null)
            {
                Console.Write(A + " ");
                return;
            }
            if (arr.Rank == 1)
            {
                object elem = arr.GetValue(0);
                if (elem.GetType().IsArray)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        for (int j = 0; j < arr.GetLength(i); j++)
                        {
                            Console.Write(arr.GetValue(i, j));
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine(arr.GetValue(i));
                    }
                }
            }
            if (arr.Rank == 2)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(arr.GetValue(i, j));
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }

        public static void PrintArrObj(string name, object[] A)
        {
            foreach(int counter in A)
            {
                Array arr = A as Array;
                if (arr == null)
                {
                    Console.Write(A + " ");
                    return;
                }
                if (arr.Rank == 1)
                {
                    object elem = arr.GetValue(0);
                    if (elem.GetType().IsArray)
                    {
                        for (int i = 0; i < arr.Length; i++)
                        {
                            for (int j = 0; j < arr.GetLength(i); j++)
                            {
                                Console.Write(arr.GetValue(i, j));
                                Console.Write(" ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        for (int i = 0; i < arr.Length; i++)
                        {
                            Console.WriteLine(arr.GetValue(i));
                        }
                    }
                }
                if (arr.Rank == 2)
                {
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            Console.Write(arr.GetValue(i, j));
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                } 
            }
        }
        public void PrintOneElem(int[] arr ,int number)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (i == number) Console.WriteLine("The element is {0}", arr[i]);
            }
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                Arrs A = new Arrs();
                int[] a = new int[5], b = new int[5], c = new int[5];
                Console.WriteLine("Array A : ");
                A.CreateOneDimAr(a);
                A.PrintArrl("A", a);
                Console.WriteLine("Array B : ");
                A.CreateOneDimAr(b);
                A.PrintArrl("B", b);
                Console.WriteLine("Array C : ");
                A.CreateOneDimAr(c);
                A.SummOfArr(a, b, c);
                A.PrintArrl("C", c);

                int[] x = new int[6] { 5, 5, 6, 6, 7, 7 };
                int[] u, v;
                v = new int[3] { 1, 2, 3 };
                //u = const new int[3]{ 1, 2, 3 };
                u = new int[3];
                u = v;
                v[0] = 9;
                Console.WriteLine("Array X : ");
                A.PrintArrl("X", x);
                Console.WriteLine("Array U : ");
                A.PrintArrl("U", u);
                Console.WriteLine("Array V : ");
                A.PrintArrl("V", v);

                Console.WriteLine("Введите размерность массива:");
                int size = int.Parse(Console.ReadLine());
                int[] d = new int[size];
                A.CreateOneDimAr(d);
                Console.WriteLine("Array D : ");
                A.PrintArrl("D", d);

                int[,] arr1 = new int[3, 3], arr2 = new int[3, 3];
                A.CreateAr2(arr1);
                A.CreateAr2(arr2);
                Console.WriteLine("Array Arr1 : ");
                A.PrintArrl2("Arr1", arr1);
                Console.WriteLine("Array Arr2 : ");
                A.PrintArrl2("Arr2", arr2);
                int[,] arr3 = A.MultMatr(arr1, arr2);
                Console.WriteLine("Array Arr3 : ");
                A.PrintArrl2("Arr3", arr3);

                int[][] jagger = new int[10][];
                for (int i = 0; i < 10; i++)
                {
                    jagger[i] = new int[i + 1];
                }
                A.CreateAr3(jagger);
                Console.WriteLine("Array Jagger : ");
                A.PrintArrl3("Jagger", jagger);


                A.PrintAnyArr(a);

                int[] arr4 = new int[5];
                Array.Copy(a, arr4, 5);
                Console.WriteLine("Copyd Array : ");
                A.PrintAnyArr(arr4);
                int res = Array.IndexOf(arr4, 4);
                Console.WriteLine("Index of 4 = {0} ", res);
                int res1 = Array.LastIndexOf(arr4, 4);
                Console.WriteLine("Last index of 4 = {0} ", res1);
                Array.Reverse(arr4);
                Console.WriteLine("Reversed Array : ");
                A.PrintAnyArr(arr4);
                Array.Sort(arr4);
                Console.WriteLine("Sorted Array : ");
                A.PrintAnyArr(arr4);
                int res2 = Array.BinarySearch(arr4, 4);
                Console.WriteLine("Result of binary search = {0} ", res2);
                int res4 = arr1.Length;
                int res5 = arr1.GetLength(0);
                Console.WriteLine("Length = {0} , GetLength = {1} ", res4, res5);

            }
        }
}
