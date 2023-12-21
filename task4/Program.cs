int num = 0;
Console.Write("Введите число от 1 до 100'000: ");
num = Convert.ToInt32(Console.ReadLine());
if (num <1 || num > 100000) {Console.WriteLine("Неверный ввод!"); return;}

int temp = num;
int n = 1;
while ((temp / 10) !=0){
    n++;
    temp = temp/10;
}

int[] arr = new int[n];
n--;
while ((n+1) !=0){
    arr[n] = (num % 10);
    num = num/10;
    n--;
}
for (int i = 0; i <= (arr.GetLength(0) - 1); i++) Console.WriteLine($"Arr[{i}]= {arr[i]}");