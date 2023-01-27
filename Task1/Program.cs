// Найти кубы чисел от 1 до N
Console.WriteLine("Введите количество чисел N");
int N = int.Parse(Console.ReadLine()!);
 Console.WriteLine();
int i=1;
while ( i<=N)    
    {
        int Cub= i*i*i;
        Console.WriteLine(Cub);
        i++;       
    }
