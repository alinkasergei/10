//Задайте массив строк. Напишите программу,
//которая считает кол-во слов в массиве, начинающихся на гласную букву.

//Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1

string[] names = { "iqwe", "wer", "ert", "arty", "tyu" };
int wordsWithVowels(string[] words)
{
    int count = 0;
    string[] vowels = { "a", "e", "i", "o", "u", "y" };
    for (int i = 0; i < words.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
            if ($"{words[i][0]}" == $"{vowels[j]}")
                count++;
    }
    return count;
}
int number = wordsWithVowels(names);
Console.WriteLine($"Количество слов, начинающихся с гласной буквы - {number}");*/

//Задайте массив строк. Напишите программу, которая генерирует новый массив, 
//объединяя элементы исходного массива попарно.

//Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} 
//-> { "qwewer", "ertrty", "tyuyui"}

void ShowStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i] + " ");
    }
}
//ShowStringArray(CreateStringArray(2));

string[] combineArray(string[] array1, string[] array2)
{
    string[] newArray = new string[array1.Length];
    for (int i = 0; i < array1.Length; i++)
    {
        newArray[i] = array1[i] + array2[i];
    }
    return newArray;
}
string[] array1 = { "qwe", "ert", "tyu" };
string[] array2 = { "wer", "rty", "yui" };

ShowStringArray(array1);
System.Console.WriteLine();
ShowStringArray(array2);
System.Console.WriteLine();
ShowStringArray(combineArray(array1, array2));

