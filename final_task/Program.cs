// ЗАДАЧА .   Написать программу которая из имеющегося массива строк формирует массив из строк длина которых меньше либо равна 3 символа.
// Первоночальный массив можно ввести с клавиатуры , либо задать на старте выполнения алгоритма.

string[] Getarray(int[] num)
{
    string[] arr1 = new string[4];

    for (int i = 0; i < arr1.Length; i++)
    {
        Console.WriteLine("enter text");
        arr1[i] = Console.ReadLine();

    }
    Console.WriteLine($"[{string.Join(",", arr1)}]");
    return arr1;
}