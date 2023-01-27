// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Введите количество чисел N");
int N = int.Parse(Console.ReadLine()!);
 Console.WriteLine();
int i=1;
while ( i<=N)    
    {
        int Cub= i*i*i;
        if(Cub%2==0)
        {
            Console.Write("куб числа, заканчивающийся на четную цифру ");
            Console.WriteLine(Cub);

        }
        
        i++;       
    }
