using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_csharp
{
    public class Array
    {
        public int[] mas;
        public string name;
        public int size;
        Random random;

        public Array()
        {
            random = new Random();
        }

        public void InitializeArray()
        {
            //Console.WriteLine("\nСоздание массива: " + name);
            mas = new int[size];
            for (int i = 0; i < size; i++)
            {
                mas[i] = random.Next(100);
            }
        }

        public void PrintArray()
        {
            Console.WriteLine("\nМассив: " + name);
            for (int i = 0; i < size; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
        }
        public void PrintArray(int[] mas, string name)
        {
            Console.WriteLine("\nМассив: " + name);
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
        }
        public void IntersectArrays(int[] mas1, int[] mas2)
        {
            Console.WriteLine("\nСоздадим временный массив с размером - сумма размеров этих массивов");
            Console.WriteLine("Найдем общие элементы двух массивов и занесем во временной массив");
            //int tempSize = (mas1.Length > mas2.Length) ? mas1.Length : mas2.Length;
            int tempSize = mas1.Length + mas2.Length;
            int[] tempMas = new int[tempSize];

            int newSize = 0;
            int t = 0;
            for (int i = 0; i < mas1.Length; i++)
            {
                for (int j = 0; j < mas2.Length; j++)
                {
                    if (mas1[i] == mas2[j])
                    {
                        tempMas[t] = mas1[i];
                        t++;
                        newSize++;
                        break;
                    }
                }
            }
            PrintArray(tempMas, "tempMas");

            if (newSize > 0)
            {
                Console.WriteLine("Размер массива без учета уникальных элементов: " + newSize);

                int[] newMas = new int[newSize];
                for (int i = 0; i < newSize; i++)
                {
                    newMas[i] = tempMas[i];
                }
                PrintArray(newMas, "newMas");

                int newSize2 = 0;
                for (int i = 0; i < newSize; i++)
                {
                    bool isUnique = true;
                    for (int j = 0; j < newSize; j++)
                    {
                        if (i == j)
                        {
                            continue;
                        }
                        if (newMas[i] == newMas[j])
                        {
                            isUnique = false;
                            break;
                        }
                    }
                    if (isUnique == true)
                    {
                        newSize2++;
                    }
                }
                Console.WriteLine("Размер массива c учетом уникальных элементов: " + newSize2);
                Console.WriteLine("Теперь создадим новый массив с учетом уникальных элементов");

                int[] newMas2 = new int[newSize2];
                int n = 0;
                for (int i = 0; i < newSize; i++)
                {
                    bool isUnique = true;
                    for (int j = 0; j < newSize; j++)
                    {
                        if (i == j)
                        {
                            continue;
                        }
                        if (newMas[i] == newMas[j])
                        {
                            isUnique = false;
                            break;
                        }
                    }
                    if (isUnique == true)
                    {
                        newMas2[n] = newMas[i];
                        n++;
                    }
                }
                PrintArray(newMas2, "newMas2");

            }
            else
            {
                Console.WriteLine("Не найдены пересечения 2 массивов");
            }
        }
    }
}
