// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int [] fillArray(int n)        // Метод заполнения массива
{
    int[] arr = new int [n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

int findSum(int[] arr1)        // Метод поиска суммы элементов с нечетным индексом
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (i % 2 != 0)
        count = count + arr1[i];
    }
    return count;
}  

int[] array = fillArray(10);

Console.WriteLine(string.Join("|", array));     // Вывод массива для проверки правильности решения.

int sum = findSum(array);

Console.WriteLine("Сумма элементов с нечётными индексами в заданном массиве: " + sum);