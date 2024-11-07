using System;
using Vector3DLibrary;

namespace Vector3DConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3D v1 = new Vector3D(3, 4, 5);
            Vector3D v2 = new Vector3D(1, 2, 3);

            Console.WriteLine($"v1: {v1}");
            Console.WriteLine($"v2: {v2}");

            // Додавання
            Vector3D sum = v1 + v2;
            Console.WriteLine($"v1 + v2 = {sum}");

            // Віднімання
            Vector3D difference = v1 - v2;
            Console.WriteLine($"v1 - v2 = {difference}");

            // Множення на число
            Vector3D scaled = v1 * 2;
            Console.WriteLine($"v1 * 2 = {scaled}");

            // Скалярний добуток
            double dotProduct = v1 * v2;
            Console.WriteLine($"v1 * v2 (скалярний добуток) = {dotProduct}");

            // Перевірка рівності
            Console.WriteLine($"v1 == v2? {v1 == v2}");
        }
    }
}