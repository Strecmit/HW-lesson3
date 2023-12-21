int[] arr = new int[10];
Random rnd = new Random();
int n = 0;
for (int i = 0; i < 10; i++){
arr[i] = rnd.Next(1, 101);
Console.Write($"{arr[i]} ");
if(arr[i] < 91 && arr[i]>19) n++;
}
Console.WriteLine();
Console.WriteLine($"Количество элементов от 20 до 90 включительно составляет {n} штук.");