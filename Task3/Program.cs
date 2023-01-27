// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите количество чисел N");
int N = int.Parse(Console.ReadLine()!);
 Console.WriteLine();
int i=1;
int sum=0;
while ( i<=N)    
    {
        sum= sum+i;        
        i++;       
    }
Console.WriteLine(sum);