/* Решение задачи 41

int[] HandArray(int size)
{
    int [] newArray = new int[size];
    Console.WriteLine("Создадим здесь массив: ");

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} элемент: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}

void ShowArray (int[] array)
{
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int PoziEl (int[] array)
{
    int count = 0;
    for(int i=0; i<array.Length; i++)
        if (array[i] > 0)
            count++;
    return count;
}


Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = HandArray(size);
Console.Write("Созданный Вами массив: ");
ShowArray(array);

int Pozitiv = PoziEl (array);
Console.WriteLine("Количество чисел больше 0: " + Pozitiv); */



