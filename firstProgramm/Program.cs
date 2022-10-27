using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApplication1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var isWorking = true;
            while (isWorking)
            {
                Console.WriteLine("Отправьте мне соответствующую с вашим запросом цифру:\n" +
                                  "1 - Введение одномерного массива\n" +
                                  "2 - Введение двумерного массива\n" +
                                  "3 - Введение ступенчатого массива\n" +
                                  "4 - Завершить работу\n");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Отправьте мне соответствующую с вашим запросом цифру:\n" +
                                          "1 - Введение массива из консоли\n" +
                                          "2 - Введение массива из файла\n" +
                                          "3 - Вернуться к началу\n");
                        int[] array;
                        switch (Console.ReadLine())
                        {
                            case "1":
                                array = InputArray();
                                Console.WriteLine("Отправьте мне соответствующую с вашим запросом цифру:\n" +
                                                  "1 - Вывести максимальное число в массиве и его индекс\n" +
                                                  "2 - Вывести минимальное число в массиве и его индекс\n" +
                                                  "3 - Отсортировать массив\n" +
                                                  "4 - Заменить случайный элемент в массиве\n" +
                                                  "5 - Вывести массив на экран\n" +
                                                  "6 - Вернуться назад\n");
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        MaxValue(array);
                                        continue;
                                    case "2":
                                        MinValue(array);
                                        continue;
                                    case "3":
                                        Console.WriteLine("Отправьте мне соответствующую с вашим запросом цифру:\n" +
                                                          "1 - Прямая сортировка массива\n" +
                                                          "2 - Обратная сортировка массива\n" +
                                                          "3 - Вернуться к началу\n");
                                        switch (Console.ReadLine())
                                        {
                                            case "1":
                                                Console.WriteLine(
                                                    "Отправьте мне соответствующую с вашим запросом цифру:\n" +
                                                    "1 - Собственный алгоритм\n" +
                                                    "2 - Сортировка при помощи System.Array\n" +
                                                    "3 - Вернуться к началу\n");
                                                switch (Console.ReadLine())
                                                {
                                                    case "1":
                                                        BubbleSort(array);
                                                        PrintArray(array);
                                                        continue;
                                                    case "2":
                                                        Array.Sort(array);
                                                        PrintArray(array);
                                                        continue;


                                                    case "3":
                                                        continue;
                                                }

                                                break;
                                            case "2":
                                                Console.WriteLine(
                                                    "Отправьте мне соответствующую с вашим запросом цифру:\n" +
                                                    "1 - Собственный алгоритм\n" +
                                                    "2 - Сортировка при помощи System.Array\n" +
                                                    "3 - Вернуться к началу\n");
                                                switch (Console.ReadLine())
                                                {
                                                    case "1":
                                                        BubbleSort(array);
                                                        PrintArray(array);
                                                        continue;
                                                    case "2":
                                                        Array.Sort(array);
                                                        Array.Reverse(array);
                                                        PrintArray(array);
                                                        continue;
                                                    case "3":
                                                        continue;
                                                }

                                                break;
                                            case "3":
                                                continue;
                                        }

                                        break;
                                    case "4":
                                        RandomSwap(array);
                                        PrintArray(array);
                                        continue;
                                    case "5":
                                        PrintArray(array);
                                        continue;
                                    case "6":
                                        continue;
                                }

                                break;
                            case "2":
                                try
                                {
                                    Console.WriteLine("Введите путь к файлу: ");
                                    var arrayData = File.ReadAllText(@Console.ReadLine());
                                    var x = arrayData.Split();
                                    array = new int[x.Length];
                                    for (int i = 0; i < x.Length; i++)
                                    {
                                        array[i] = Convert.ToInt32(x[i]);
                                    }
                                }
                                catch
                                {
                                    throw new ArgumentException("Неверный формат пути файла или дaнные в файле");
                                }

                                Console.WriteLine("Отправьте мне соответствующую с вашим запросом цифру:\n" +
                                                  "1 - Вывести максимальное число в массиве и его индекс\n" +
                                                  "2 - Вывести минимальное число в массиве и его индекс\n" +
                                                  "3 - Отсортировать массив\n" +
                                                  "4 - Заменить случайный элемент в массиве\n" +
                                                  "5 - Вывести массив на экран\n" +
                                                  "6 - Вернуться назад\n");
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        MaxValue(array);
                                        continue;
                                    case "2":
                                        MinValue(array);
                                        continue;
                                    case "3":
                                        Console.WriteLine("Отправьте мне соответствующую с вашим запросом цифру:\n" +
                                                          "1 - Прямая сортировка массива\n" +
                                                          "2 - Обратная сортировка массива\n" +
                                                          "3 - Вернуться к началу\n");
                                        switch (Console.ReadLine())
                                        {
                                            case "1":
                                                Console.WriteLine(
                                                    "Отправьте мне соответствующую с вашим запросом цифру:\n" +
                                                    "1 - Собственный алгоритм\n" +
                                                    "2 - Сортировка при помощи System.Array\n" +
                                                    "3 - Вернуться к началу\n");
                                                switch (Console.ReadLine())
                                                {
                                                    case "1":
                                                        BubbleSort(array);
                                                        PrintArray(array);
                                                        continue;
                                                    case "2":
                                                        Array.Sort(array);
                                                        PrintArray(array);
                                                        continue;
                                                    case "3":
                                                        continue;
                                                }

                                                break;
                                            case "2":
                                                Console.WriteLine(
                                                    "Отправьте мне соответствующую с вашим запросом цифру:\n" +
                                                    "1 - Собственный алгоритм\n" +
                                                    "2 - Сортировка при помощи System.Array\n" +
                                                    "3 - Вернуться к началу\n");
                                                switch (Console.ReadLine())
                                                {
                                                    case "1":
                                                        BubbleSort(array);
                                                        PrintArray(array);
                                                        continue;
                                                    case "2":
                                                        Array.Sort(array);
                                                        Array.Reverse(array);
                                                        PrintArray(array);
                                                        continue;
                                                    case "3":
                                                        continue;
                                                }

                                                break;
                                            case "3":
                                                continue;
                                        }

                                        break;
                                    case "4":
                                        RandomSwap(array);
                                        PrintArray(array);


                                        continue;
                                    case "5":
                                        PrintArray(array);
                                        continue;
                                    case "6":
                                        continue;
                                }

                                break;
                        }

                        break;
                    case "2":
                        int[,] twoDimArray;
                        Console.WriteLine("Отправьте мне соответствующую с вашим запросом цифру:\n" +
                                          "1 - Ввести двумерный массив из консоли\n" +
                                          "2 - Ввести двумерный массив из файла\n" +
                                          "3 - Вернуться к началу\n");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                twoDimArray = InputTwoDimArray();
                                Console.WriteLine("Отправьте мне соответствующую с вашим запросом цифру:\n" +
                                                  "1 - Максимальное число в двумерном массиве\n" +
                                                  "2 - Минимальное число в двумерном массиве\n" +
                                                  "3 - Вывести массив на экран\n" +
                                                  "4 - Вернуться к началу");
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        MaxValueOfTwoDimArray(twoDimArray);
                                        continue;
                                    case "2":
                                        MinValueOfTwoDimArray(twoDimArray);
                                        continue;
                                    case "3":
                                        PrintTwoDimArray(twoDimArray);
                                        continue;
                                    case "4":
                                        continue;
                                }

                                continue;
                            case "2":
                                try
                                {
                                    Console.WriteLine("Введите путь к файлу: ");
                                    var arrayData = File.ReadAllLines(@Console.ReadLine());
                                    twoDimArray = new int[arrayData.Length, arrayData[0].Split().Length];
                                    for (var i = 0; i < arrayData.Length; i++)
                                    {
                                        var x = arrayData[i].Split();
                                        var x2 = new int[x.Length];
                                        for (var i2 = 0; i2 < x.Length; i2++)
                                        {
                                            x2[i2] = Convert.ToInt32(x[i2]);
                                        }

                                        for (var i3 = 0; i3 < x2.Length; i3++)
                                        {
                                            twoDimArray[i, i3] = x2[i3];
                                        }
                                    }

                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Отправьте мне соответствующую с вашим запросом цифру:\n" +
                                                          "1 - Максимальное число в двумерном массиве\n" +
                                                          "2 - Минимальное число в двумерном массиве\n" +
                                                          "3 - Вывести массив на экран\n" +
                                                          "4 - Вернуться к началу");
                                        switch (Console.ReadLine())


                                        {
                                            case "1":
                                                MaxValueOfTwoDimArray(twoDimArray);
                                                continue;
                                            case "2":
                                                MinValueOfTwoDimArray(twoDimArray);
                                                continue;
                                            case "3":
                                                PrintTwoDimArray(twoDimArray);
                                                continue;
                                            case "4":
                                                continue;
                                        }
                                        //for (var h = 0; h < twoDimArray.GetLength(0); h++)
                                        //{
                                        //    for (var w = 0; w < twoDimArray.Length / twoDimArray.GetLength(0); w++)
                                        //    {
                                        //        Console.Write($"{twoDimArray[h, w]} ");
                                        //    }
//
                                        //    Console.WriteLine();
                                        //}
                                        //Console.WriteLine();
                                    }
                                    ;
                                }
                                catch
                                {
                                    throw new ArgumentException("Неверный формат пути файла или днные в файле");
                                }

                                continue;
                            case "3":
                                continue;
                        }

                        break;
                    case "3":
                        int[][] steppedArray;
                        Console.WriteLine("Отправьте мне соответствующую с вашим запросом цифру:\n" +
                                          "1 - Ввести ступенчатый массив вручную\n" +
                                          "2 - Ввести ступенчатый массив из файла\n" +
                                          "3 - Вернуться к началу\n");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                steppedArray = InputStepArray();
                                Console.WriteLine("Отправьте мне соответствующую с вашим запросом цифру:\n" +
                                                  "1 - Вывести массив на экран\n" +
                                                  "2 - Вернуться к началу\n");
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        PrintSteppedArray(steppedArray);
                                        continue;
                                    case "2":
                                        continue;
                                }

                                continue;
                            case "2":

                                try
                                {
                                    Console.WriteLine("Введите путь к файлу: ");
                                    var arrayData = File.ReadAllLines(@Console.ReadLine());
                                    steppedArray = new int[arrayData.Length][];
                                    for (var i = 0; i < arrayData.Length; i++)
                                    {
                                        var x = arrayData[i].Split();
                                        var x2 = new int[x.Length];
                                        for (var i2 = 0; i2 < x.Length; i2++)
                                        {
                                            x2[i2] = Convert.ToInt32(x[i2]);
                                        }

                                        steppedArray[i] = x2;
                                    }
                                }
                                catch
                                {
                                    throw new Exception("Неверный путь файла или формат данных в нём");
                                }

                                Console.WriteLine("Отправьте мне соответствующую с вашим запросом цифру:\n" +
                                                  "1 - Вывести массив на экран\n" +
                                                  "2 - Вернуться к началу\n");
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        PrintSteppedArray(steppedArray);
                                        continue;
                                    case "2":
                                        continue;
                                }

                                continue;
                            case "3":
                                continue;
                        }

                        continue;
                    case "4":
                        isWorking = false;
                        break;
                }
            }
        }

        static void PrintSteppedArray(int[][] steppedArray)
        {
            Console.WriteLine();
            foreach (var i1 in steppedArray)
            {
                foreach (var i2 in i1)
                {
                    Console.Write($"{i2} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void PrintTwoDimArray(int[,] twoDimArray)
        {
            Console.WriteLine();
            for (var h = 0; h < twoDimArray.GetLength(0); h++)
            {
                for (var w = 0; w < twoDimArray.Length / twoDimArray.GetLength(0); w++)
                {
                    Console.Write($"{twoDimArray[h, w]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine();
            foreach (var i in array)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }

        static int[] InputElements(int[] array, int size)
        {
            try
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Введите " + i + " элемент массива");
                    array[i] = Int32.Parse(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine("Массив может состоять только из чисел!");
                Console.WriteLine("Попробуйте ещё раз.");
                InputElements(array, size);
            }

            return array;
        }

        static int[] InputArray()
        {
            int size;
            int[] inputArray;
            Console.WriteLine("Введите размер массива: ");
            try
            {
                inputArray = new int[size = Int32.Parse(Console.ReadLine())];
            }
            catch
            {
                throw new ArgumentException("Размер массива должен быть числом!");
            }

            InputElements(inputArray, size);
            return inputArray;
        }

        static void MaxValue(int[] array)
        {
            Dictionary<string, int> result = new Dictionary<string, int>()
            {
                { "index", 0 },
                { "value", array[0] }
            };
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] <= result["value"]) continue;
                result["value"] = array[i];
                result["index"] = i;
            }

            Console.WriteLine($"Максмальное число: {result["value"]}\n" +
                              $"Его индекс: {result["index"]}");
        }

        static void MinValue(int[] array)
        {
            Dictionary<string, int> result = new Dictionary<string, int>()
            {
                { "index", 0 },
                { "value", array[0] }
            };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < result["value"])
                {
                    result["value"] = array[i];
                    result["index"] = i;
                }
            }

            Console.WriteLine($"Минимальное число: {result["value"]}\n" +
                              $"Его индекс: {result["index"]}");
        }

        static int[,] InputTwoDimArray()
        {
            var height = 0;
            var width = 0;
            try
            {
                Console.WriteLine("Введите ширину двумерного массива");
                width = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите высоту двумерного массива");
                height = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Размерность двумерного массива должна указываться в числах!!");
                InputTwoDimArray();
            }

            int[,] twoDimArray = new int[height, width];
            InputTwoDimArrayElements(twoDimArray);
            return twoDimArray;
        }

        static int[,] InputTwoDimArrayElements(int[,] array)
        {
            try
            {
                for (var height = 0; height < array.GetLength(0); height++)
                {
                    for (var width = 0; width < array.Length / array.GetLength(0); width++)
                    {
                        Console.WriteLine($"Введите {height}, {width} элемент массива: ");
                        array[height, width] = Int32.Parse(Console.ReadLine());
                    }
                }
            }
            catch
            {
                Console.WriteLine("Элементы двумерного массива должны быть числами");
                InputTwoDimArrayElements(array);
            }

            return array;
        }

        static void MaxValueOfTwoDimArray(int[,] twoDimArray)
        {
            Dictionary<string, int[]> result = new Dictionary<string, int[]>()
            {
                { "index", new[] { 0, 0 } },
                { "value", new[] { twoDimArray[0, 0] } }
            };
            for (var h = 0; h < twoDimArray.Length / twoDimArray.GetLength(0); h++)
            {
                for (var w = 0; w < twoDimArray.GetLength(0); w++)
                {
                    if (result["value"][0] < twoDimArray[w, h])
                    {
                        result["value"][0] = twoDimArray[w, h];
                        result["index"][0] = w;
                        result["index"][1] = h;
                    }
                }
            }

            Console.WriteLine($"Максимальное число: {result["value"][0]}\n" +
                              $"Его индекс: {result["index"][0]}, {result["index"][1]}");
        }

        static void MinValueOfTwoDimArray(int[,] twoDimArray)
        {
            Dictionary<string, int[]> result = new Dictionary<string, int[]>()
            {
                { "index", new[] { 0, 0 } },
                { "value", new[] { twoDimArray[0, 0] } }
            };
            for (var h = 0; h < twoDimArray.Length / twoDimArray.GetLength(0); h++)
            {
                for (var w = 0; w < twoDimArray.GetLength(0); w++)
                {
                    if (result["value"][0] > twoDimArray[w, h])
                    {
                        result["value"][0] = twoDimArray[w, h];
                        result["index"][0] = w;
                        result["index"][1] = h;
                    }
                }
            }

            Console.WriteLine($"Минимальное число: {result["value"][0]}\n" +
                              $"Его индекс: {result["index"][0]}, {result["index"][1]}\n");
        }

        static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        static void ReversedBubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        static void Swap(ref int firstElem, ref int secondElem)
        {
            int startParam = firstElem;
            firstElem = secondElem;
            secondElem = startParam;
        }

        static void RandomSwap(int[] arr)
        {
            var rnd = new Random();
            arr[rnd.Next(0, arr.Length)] = rnd.Next(int.MinValue, int.MaxValue);
        }

        static int[][] InputStepArray()
        {
            var steppedArray = new int[1][];
            Console.WriteLine("Введите высоту ступенчатого массива: ");
            try
            {
                steppedArray = new int[int.Parse(Console.ReadLine())][];
            }
            catch
            {
                Console.WriteLine("Высота ступенчатого массива должна быть числом!");
                InputStepArray();
            }

            var arrayNum = 0;
            foreach (var innerArray in steppedArray)
            {
                int size;
                Console.WriteLine($"Введите размер для {arrayNum}-го массивы");
                try
                {
                    size = int.Parse(Console.ReadLine());
                }
                catch
                {
                    throw new ArgumentException("Размер массива должен быть числом");
                }

                steppedArray[arrayNum] = new int[size];
                InputElements(steppedArray[arrayNum], size);
                arrayNum += 1;
            }

            return steppedArray;
        }
    }
}