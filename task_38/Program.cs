// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

double [] fillArray(int n)              // Метод заполнения массива
{
    double[] arr = new double [n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToDouble(new Random().Next(-100, 100)/10.0);
    }
    return arr;
}

double findMax(double[] arr1)           // Метод поиска наибольшего элемента
{
    double max = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] > max) max = arr1[i];
    }
    return max;
}

double findMin(double[] arr2)           // Метод поиска наименьшего элемента
{
    double min = 0;
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i] < min) min = arr2[i];
    }
    return min;
}

double[] array = fillArray(20);

// Далее три строки кода для вывода массива и искомых элементов, для проверки правильности решения задачи.

Console.WriteLine(string.Join("|", array));     
Console.WriteLine("Наибольший элемент массива: " + findMax(array)); 
Console.WriteLine("Наименьший элемент массива: " + findMin(array)); 

double distinction = findMax(array) - findMin(array);

Console.WriteLine("Разница между наибольшим и наименьшим элементом массива: " + distinction); 