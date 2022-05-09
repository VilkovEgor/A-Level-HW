using HW3;

ABC eee = new ABC();
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

Console.WriteLine("Change odd");
Console.WriteLine(eee.ABC1(odd));
Console.WriteLine("Change even");
Console.WriteLine(eee.ABC1(even));
Console.WriteLine();
string[] ABCodd = eee.ABC1(odd).Split(new char[] { ' ' });
string[] ABCeven = eee.ABC1(even).Split(new char[] { ' ' });
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
    
    
        Console.Write(eee.ABC1(odd));
    
        
       
}
else
{
    Console.Write("even:");
    
        Console.Write(eee.ABC1(even));
    
}