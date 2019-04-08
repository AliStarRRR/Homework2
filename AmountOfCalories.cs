using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите количество продуктов:");
            Products a = new Products();

            a.Add();
            a.Sort();

            Console.ReadKey();
        }

        public class Products
        {
            static int size = int.Parse(Console.ReadLine());
            public string[] prod = new string[size]; //products's name
            public int[] id = new int[size]; //products's calories

            //Method of adding products
            public void Add()
            {
                Console.WriteLine("\nВведите название и калорийность продуктов:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write("Продукт = ");
                    prod[i] = Console.ReadLine();
                    Console.Write("Калории = ");
                    id[i] = int.Parse(Console.ReadLine());
                }
            }

            //Method of showing products
            public void Show()
            {
                Console.WriteLine("\nВаши продукты:");
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"{i + 1}. {prod[i]} = {id[i]}");
                    
                }
            }

            //Method which helps to sort products by calories
            public void Sort()
            {
                int temp1 = 0;
                string temp2;

                //Bubble sort
                for (int i = 0; i < size - 1; i++)
                {
                    for (int j = 0; j < size - i - 1; j++)
                    {
                        if (id[j] < id[j + 1])
                        {
                            temp1 = id[j];
                            id[j] =  id[j + 1];
                            id[j + 1] = temp1;

                            temp2 = prod[j];
                            prod[j] = prod[j + 1];
                            prod[j + 1] = temp2;
                        }
                    }
                }

                Show();
            }
        }
    }
}
