// Написать программу, которая из имеющегося массива строк 
//формирует массив из строк, длина которых меньге либо равна 3 символа.
string [] CreateArray ()
{
    string [] array = {"abcdf", "XYY", "99", "Twix", "Lunchik"};
    return array;

}
void PrintArray(string []array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}; ");
    }
    
    System.Console.Write("]");
}

string [] CheckSize (string [] array) 
{
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            System.Console.Write(array[i] + ";");
        }
    }
    return array;
}

string [] massivStrok = CreateArray();
PrintArray(massivStrok);
System.Console.Write(" = ");
System.Console.Write("[");
string [] newArr = CheckSize(massivStrok);
System.Console.WriteLine("]");
