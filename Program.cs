/* написать программу, которая из имеющегося массива строк 
формирует массив из тех строк, которые <= 3 символов */

string FillYourArray (int size)
{
    string[] newArray = new int[size];
    for (int i = 0; i<size; i++)
    {
        Console.Write("Input ", i+1, " row in your array: ");
        newArray[i]=Console.ReadLine();
    }
    Console.WriteLine();
    return newArray;
}

void NewArrayLessThan4 (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <=3)
        {
            Console.WriteLine(array[i] + ", ");
            Console.WriteLine();
        }
    }
}
/* 
void ShowArray(int[] array)     // вывести массив
{
    for(int i = 0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
*/
Console.Write("Input number of rows in your array: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] YourArray = FillYourArray(size);
NewArrayLessThan4(YourArray);