string[] FirstArray = new string [] { "Tom", "Pit", "Posa", "Lisa", "Ann", "Kate", "Loid", "MJ" };
string[] SecondArray = new string [0];

for (int i = 0; i < FirstArray.Length; i++)
{
    if ( FirstArray[i].Length <= 3){
    Array.Resize(ref SecondArray, SecondArray.Length + 1);
    SecondArray[SecondArray.Length - 1] = FirstArray[i];
    }   
}

Console.WriteLine(string.Join( ", " , SecondArray));