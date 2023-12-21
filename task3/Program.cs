double[] arr = new double[10];
Random rnd = new Random();
int n = 0;
double min = 10, max = 0, result = 0;
for (int i = 0; i < 10; i++){
double j = rnd.Next(1, 1001)/100.0;
arr[i] = j;
Console.Write($"{arr[i]} ");
if (min > arr[i]) min = arr[i];
if (max < arr[i]) max = arr[i];
}
result = max - min;
Console.WriteLine();
Console.WriteLine($"Разница между минимальным {min} и {max} значениями составляет {result}.");