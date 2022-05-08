
int[] a = new int[Convert.ToInt32(Console.ReadLine())];
string b1 = "";
string c1 = "";
Random rnd = new Random();
for (int i = 0; i < a.Length; i++)
{
    a[i] = rnd.Next(0, 27);
    if (a[i] % 2 == 1)
    {

        b1 += a[i] + " ";
    }
    else
    {

        c1 += a[i] + " ";
    }

    Console.Write($"{a[i]} ");

}
string[] odd = b1.Split(new char[] { ' ' });
string[] even = c1.Split(new char[] { ' ' });

Console.WriteLine();
for (int i = 0; i < odd.Length; i++)
{
    Console.Write($"{odd[i]} ");
}

Console.WriteLine();
for (int i = 0; i < even.Length; i++)
{
    Console.Write($"{even[i]} ");
}
Console.WriteLine();
string ABC(string[] array )
{
    string abc = " ";
    for(int i=0; i<array.Length; i++)
    {
        
        switch (array[i])
        {
            case "1":
                abc += "A" + " ";
                break;
            case "2":
                abc += "b" + " ";
                break;
            case "3":
                abc += "c" + " ";
                break;
            case "4":
                abc += "D" + " ";
                break;
            case "5":
                abc += "e" + " ";
                break;
            case "6":
                abc += "f" + " ";
                break;
            case "7":
                abc += "g" + " ";
                break;
            case "8":
                abc += "H" + " ";
                break;
            case "9":
                abc += "I" + " ";
                break;
            case "10":
                abc += "J" + " ";
                break;
            case "11":
                abc += "k" + " ";
                break;
            case "12":
                abc += "l" + " ";
                break;
            case "13":
                abc += "m" + " ";
                break;
            case "14":
                abc += "n" + " ";
                break;
            case "15":
                abc += "o" + " ";
                break;
            case "16":
                abc += "p" + " ";
                break;
            case "17":
                abc += "q" + " ";
                break;
            case "18":
                abc += "r" + " ";
                break;
            case "19":
                abc += "s" + " ";
                break;
            case "20":
                abc += "t" + " ";
                break;
            case "21":
                abc += "u" + " ";
                break;
            case "22":
                abc += "v" + " ";
                break;
            case "23":
                abc += "w" + " ";
                break;
            case "24":
                abc += "x" + " ";
                break;
            case "25":
                abc += "y" + " ";
                break;
            case "26":
                abc += "z" + " ";
                break;
           
        }
        
       
    }
    return abc;
}
Console.WriteLine("Change odd");
Console.WriteLine(ABC(odd));
Console.WriteLine("Change even");
Console.WriteLine(ABC(even));
Console.WriteLine();
string[] ABCodd = ABC(odd).Split(new char[] { ' ' });
string[] ABCeven = ABC(even).Split(new char[] { ' ' });
int CountBigodd=0;
int CountBigeven=0;
for (int i = 0; i < ABCodd.Length; i++)
{
    switch (ABCodd[i])
    {
        case "A":
            CountBigodd += 1;
            
            break;
        case "E":
            CountBigodd += 1;
            break;
        case "I":
            CountBigodd += 1;
            break;
        case "D":
            CountBigodd += 1;
            break;
        case "H":
            CountBigodd += 1;
            break;
        case "J":
            CountBigodd += 1;
            break;
        default:
            break;
    }

}
for (int i = 0; i < ABCeven.Length; i++)
{
    switch (ABCeven[i])
    {
        case "A":
            CountBigeven += 1;

            break;
        case "E":
            CountBigeven += 1;
            break;
        case "I":
            CountBigeven += 1;
            break;
        case "D":
            CountBigeven += 1;
            break;
        case "H":
            CountBigeven += 1;
            break;
        case "J":
            CountBigeven += 1;
            break;
        default:
            break;
    }

}
Console.WriteLine("The bigger");
if (CountBigodd> CountBigeven)
{
    Console.Write("odd:");
    
    
        Console.Write(ABC(odd));
    
        
       
}
else
{
    Console.Write("even:");
    
        Console.Write(ABC(even));
    
}