// See https://aka.ms/new-console-template for more information

//*************************** CHECK ****************************//
Random singleNumber = new Random();
Console.WriteLine("This is a NextSingle function to print value between 0.0 and 1.0 : " + Math.Round( singleNumber.NextSingle(), 1) + "\n");


//************** Print Random Numbers ***********************//
Console.WriteLine("Random number With one value "+ getRandomNumber(100));
Console.WriteLine("Random number With two values "+ getRandomNumber(53, 100) + "\n");

//############################# EXERCISE 01 ######################

//************** GET Random Sized array ***********************//
int[] result = GetRandomSizedArray();
Console.WriteLine("Empty Array of random size between 2 and 25: EmptyArray[" + result.Length+"].\n");


//############################# EXERCISE 02 #####################

//************** Get Array of size 8 and Print its values ***********************//
int[] arr = randomValueArray();
Console.WriteLine("Array of Size 8:");
for (int i = 0; i < arr.Length; i++)
{
    if(i == arr.Length-1)
        Console.Write(arr[i]);
    else
        Console.Write( arr[i] + ", ");
}

//############################# EXERCISE 03 #####################

//************** String Array of Size 6 ***********************//
string[] stringsArray= ["overwrite", "depending", "incorrect", "endpoint", "using", "document"];
Console.WriteLine("\n\nString Array before changing value:");
foreach (string s in stringsArray)
{
    Console.Write(s +"  ");
}
int index = getRandomNumber(0, 6);
stringsArray[index] = "-";
Console.WriteLine("\n\nString Array after changing one value randomly:");
foreach (string s in stringsArray)
{
    Console.Write(s + "  ");
}

//########################## METHODS ########################//

//************** Get Random Number ***********************//
static int getRandomNumber(int maxValue, int minValue=0)
{
        Random RandNumber = new Random();
    if (minValue > maxValue)
    {
        int num = RandNumber.Next(maxValue, minValue);
        return num;
    }
    else
    {
        int num = RandNumber.Next(minValue, maxValue);
        return num;
    }    
}


//************** Get Random Sized Empty Array ***********************//
static int[] GetRandomSizedArray()
    {
        Random rand = new Random();
        int size = rand.Next(2, 25);
        return new int[size];
    }
Console.ReadLine();

//************** Get Random values in an Array of size 8 ***********************//
static int[] randomValueArray()
{
    int[] ints = new int[8];
    Random intsValue = new Random();
    for (int i = 0; i < ints.Length; i++)
    {
        ints[i] = intsValue.Next(0, 5);
    }
    return ints;
}