// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Для того, чтобы вывести на экран сумму натуральных чисел от M до N");
int numberM = UserInput("Введите M: ");
int numberN = UserInput("Введите N: ");
var maximum = 0;
var minimum = 0;
MaxMin(numberM,numberN);
Console.WriteLine($"Сумма натуральный чисел в промежуке от {minimum} до {maximum} = {SummNaturalNumber(maximum, minimum)}");
void MaxMin(int numM, int numN)
{
    if(numM> numN)
    {
        maximum = numM;
        minimum = numN;
    }
    else
    {
        maximum = numN;
        minimum = numM;
    }
}
double SummNaturalNumber(int max, int min)
{
    
    if (min == max + 1) return 0; 
    else return min + SummNaturalNumber(max, min + 1);
    
}


int UserInput(string massage)
{
    Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
