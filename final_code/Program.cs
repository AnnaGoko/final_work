string[] FirstArray = new string[100];
            int element = 0; 
            string test;
            int count = 0;
 
            do
            {
                test = Console.ReadLine();
                if (test == "end") break;
                FirstArray[element] = (test);
                ++element; ++count;
            } while (true);
            //for (int j = 0; j < count; j++)
            //{
            //    Console.Write("{0} ",FirstArray[j]);
            //}
            Console.ReadLine();

//string[] FirstArray = new string [] { "Tom", "Pit", "Posa", "Lisa", "Ann", "Kate", "Loid", "MJ" };
string[] SecondArray = new string [0];

for (int i = 0; i < FirstArray.Length; i++)
{
    if ( FirstArray[i].Length <= 3){
    Array.Resize(ref SecondArray, SecondArray.Length + 1);
    SecondArray[SecondArray.Length - 1] = FirstArray[i];
    }   
}

Console.WriteLine(string.Join( ", " , SecondArray));