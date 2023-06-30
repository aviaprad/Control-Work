// 
string[] array = new string[] {"Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan"};

int lengthNewArray = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3) lengthNewArray++;
}

string[] newArray = new string[lengthNewArray];
int index = 0;

for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[index] = array[i];
        index++;
    }
}

void PrintArray(string[] array) // метод печати массива
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}

PrintArray(array);
Console.Write("→ ");
PrintArray(newArray);