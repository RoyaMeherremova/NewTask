


//static int GetCountofEvenNumsFromArray(int[]nums)
//  {
//    int count = 0;
//	foreach (var item in nums)
//	{
//		if(item!=0)
//		{
//			if(item%2==0)
//			{
//				count++;
//			}
//		}
//	}
//	return count;
//}


//static int[] GetArr()
//{
//	return new int[10] {1,2,3,4,5,6,7,8,9,10 };
//}



//var arr = GetArr();

//var result = GetCountofEvenNumsFromArray(arr);
//Console.WriteLine(result);



//static bool IsDivided(int num)
//{
//	return num % 2 == 0;
//}





//static int GetCountofEvenNumsFromArray(int[] nums)
//{
//    int count = 0;
//    foreach (var item in nums)
//    {
//        if (item != 0)
//        {
//            if(IsDivided(item))

//            {
//                count++;
//            }
//        }
//    }
//    return count;
//}


////static bool NumIsZero(int num)
////{
////    return num == 0;
////}


//static int GetCountofEvenNumsFromArray(int[] nums)
//{
//    int count = 0;
//    foreach (var item in nums)
//    {
//        if (!NumIsZero(item))
//        {
//            if (IsDivided(item))

//            {
//                count++;
//            }
//        }
//    }
//    return count;
//}

//internal class Class1
//{
//static void Test()
//{

//}
//static void Test(int n)
//{

//}
//static void Test(string n)
// {

// }
//    static void Test(string n,int m)
//    {
//        Console.WriteLine(n + m);
//    }


//}

//int a = 5;
//int b = a;
// b=10;
//Console.WriteLine(b);


//int []arr1 = { 1, 2, 3, 4, 5, };
////int[] arr2 = arr1;
////arr2[0] = 100;
////Console.WriteLine(arr2[0]);
////Console.WriteLine(arr1[0]);

//int n = 5;
//Test(n);

//Console.WriteLine(n);

//static void Test(int n)
//{
//    n=10;
//    Console.WriteLine(n);
//}



//int[] arr = { 1, 2, 3, 4, };

//Arr(arr);

//Console.WriteLine(arr[0]);
//static void Arr(int[]num)
//{

//    num[0] = 200;
//    Console.WriteLine(num[0]);
//}


//int n = 5;
//Test(ref n);
//Console.WriteLine(n);

//static void Test(ref int n)
//{
//    n = 7;
//    Console.WriteLine(n);
//}



//int a = 10;
//Test(out int  n);
//Console.WriteLine(n);
//static void Test(out int n)
//{
//    n = 100;
//    Console.WriteLine(n);
//}


//string name = "Roya";

//string name2=name;

// name2 = "Cavid";
//Console.WriteLine(name2);
//Console.WriteLine(name);


//string addres = "Azerbaycan";


//Console.WriteLine(addres.Length);


//Console.WriteLine(addres.StartsWith("e"));

//Console.WriteLine(addres.EndsWith("a"));
//Console.WriteLine(addres.Contains("b"));


//if (addres.Contains("b"))
//{
//	Console.WriteLine("yes");
//}
//else
//{
//	Console.WriteLine("no");
//}


//string address = "Azerbaycan,Siyezen,Sumqayit";

//var res=address.Split(",");
//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}


//addresss="Baku";

//Console.WriteLine(addresss.ToLower());

//Console.WriteLine(addresss.ToUpper());



//using System;

//string addres = "roya";
//var letter = addres[0].ToString().ToUpper();

//var arr = addres.ToCharArray();

//arr[0] = char.Parse(letter);

//string result = " ";

//foreach (var item in arr)
//{
//    result += item;

//}
//Console.WriteLine(result);




//string name = "Roya";
//    Console.WriteLine(name.Substring(2).ToUpper());

//string name2 = "  Anar";
//Console.WriteLine(name2.Trim());


//string name3 = "Jale";

//    Console.WriteLine(name3.Replace("J","T"));




//if (string.IsNullOrEmpty(name3))
//{
//    Console.WriteLine("yes");
//}
//else
//{
//    Console.WriteLine("no");
//}





//string name4 = " ";
//if (string.IsNullOrWhiteSpace(name4))
//{
//    Console.WriteLine("yes");

//}
//else
//{
//    Console.WriteLine("no");
//}



