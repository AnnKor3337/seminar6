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

/* Решение задачи 43

void Point ();
{
    Console.WriteLine("Введите значение переменной b1: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение переменной k1: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение переменной b2: ");
    int c = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение переменной k2: ");
    int d = Convert.ToInt32(Console.ReadLine());  

    int x, y;

    if (b != d)
    {
        x = (c-a)/(b-d);
        y = b * x + a;
        Console.WriteLine("точка пересечения: (", +x ,";", +y,")");
    }
    else Console.WriteLine("поскольку k1 = k2 - прямые являются параллельными.");
}

Point (); */

