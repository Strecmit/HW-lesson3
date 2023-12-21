int[] arr = new int[10];
Random rnd = new Random();
int n = 0;
for (int i = 0; i < 10; i++){
arr[i] = rnd.Next(1, 101);
Console.Write($"{arr[i]} ");
if((arr[i] % 2) == 0) n++;
}
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел составляет {n} штук.");