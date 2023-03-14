Console.WriteLine ("Введите элементы массива через клавишу Enter. Напишите 'stop', чтобы перейти к выполнению задачи");
string[] FirstArray = new string[1];
string[] SecondArray = new string [0];
    int index = 0; 
    string element;
 
do
{
    element = Console.ReadLine() ?? "Null";
    if (element == "stop") break;
    FirstArray[index] = (element) ?? "Null";
    ++index; Array.Resize(ref FirstArray, FirstArray.Length + 1);
} while (true);

for (int i = 0; i < FirstArray.Length - 1; i++)
{
    if ( FirstArray[i].Length <= 3){
    Array.Resize(ref SecondArray, SecondArray.Length + 1);
    SecondArray[SecondArray.Length - 1] = FirstArray[i];
    }   
}

Console.WriteLine(string.Join( ", " , SecondArray));