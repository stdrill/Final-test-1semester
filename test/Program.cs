// Написать программу, которая из массива строк формирует массив строк, длина которых меньше либо равна 3.


void PrintArray (string[] arr)
{
    for (int i = 0; i < arr.Length; i++) Console.Write(arr[i]+" ");
}
int SelectElements(string[] arr)
{
   int newSize = 0;
   for (int i = 0; i < arr.Length; i++){
    if (arr[i].Length <= 3) newSize += 1;
   }
    return newSize;
}
string[] FillNewArray (string[] arr, int quantity)
{
    string[] newArr = new string[quantity];
    int j = 0;
    for (int i = 0; i < arr.Length; i++){
        if(arr[i].Length <= 3){
            newArr[j] = arr[i];
            j++;
        }
    }
    return newArr;
}

string[] array = {"1234","1","12345", "123", "12", "1234"};
PrintArray(array);
Console.WriteLine();
int newArrSize = Convert.ToInt32(SelectElements(array));
string[] newArray = FillNewArray(array, newArrSize);
PrintArray(newArray);