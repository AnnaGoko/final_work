Console.WriteLine("Введите что-то: "); 
string? a = Console.ReadLine();

string[] FirstArray = new string [] {  "ete", "rdfs", "zf", "dsfd", "dfs"};
string[] SecondArray = new string [0];

for (int i = 0; i < FirstArray.Length; i++)
{
    if ( FirstArray[i].Length <= 3){
    //Console.Write(FirstArray[i] + " ");
    Array.Resize(ref SecondArray, SecondArray.Length + 1);
    SecondArray[SecondArray.Length - 1] = FirstArray[i];
    }   
}

PrintArray(SecondArray);

void PrintArray(string [] SecondArray){
    Console.WriteLine(string.Join( ", " , SecondArray));
}