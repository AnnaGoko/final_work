string? a = Console.ReadLine();
string[] FirstArray = new string [] {  "ete", "rdfs"};
string[] SecondArray = new string [0];
//Console.WriteLine (FirstArray);
//PrintArray (FirstArray);
//void PrintArray(string [] FirstArray ){

for (int i = 0; i < FirstArray.Length; i++)
{
    if ( FirstArray[i].Length <= 3){
    Console.Write(FirstArray[i] + " ");
    Array.Resize(ref SecondArray, SecondArray.Length + 1);
    for (int j = 0;j < SecondArray.Length;j++)
    {
        
    }
    //string[]SecondArray = new string [FirstArray.Length + 1];

}
}