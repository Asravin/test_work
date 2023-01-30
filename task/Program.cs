string[] massiv = new string[]{"hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan"};

void Print_massiv_1(string[] massive)
{
    for(int i = 0; i < massiv.Length; i++)
    {
        Console.Write(massiv[i] + ", ");
    }
    Console.WriteLine();
}

void Print_massiv_2(string[] massiv)
{
    for(int i = 0; i < massiv.Length; i++)
    {
        string element = massiv[i];
        if(element.Length <= 3)
        {
            massiv[i] = element;
        }
        else
        massiv[i] = string.Empty;
    }
}
Console.WriteLine("В массиве стостоящем из:");
Print_massiv_1(massiv);
Print_massiv_2(massiv);
Console.Write("Длина меньше или равна 3:");
Print_massiv_1(massiv);
