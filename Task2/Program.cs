// Подсчитать сумму цифр в числе


/*Console.WriteLine("Введите число");
string str= Console.ReadLine();
int lenght = str.Length; 
int sum=0;
    for(int i=0; i<lenght; i++)
    {
        
        int value = Convert.ToInt32(str[i]);
        
        sum=sum+value;
        
        Console.WriteLine(value);

    }
Console.WriteLine(sum);

*/
// Здравствуйте. Особенностью метода Console.ReadLine() является то, 
// что он может считать информацию с консоли только в виде строки.
// Почему при int value = Convert.ToInt32(Console.ReadLine()); конвертация нормально проходит,  а
// при int value = Convert.ToInt32(str[i]); конвертация проходит как то криво?

Console.WriteLine("Введите число");
int value = Convert.ToInt32(Console.ReadLine());
int sum=0;
while (value > 0)
{
    int fig = value % 10;
    sum=sum+fig;
    value = value / 10;
}
Console.WriteLine(sum);