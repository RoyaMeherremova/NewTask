



Console.WriteLine(Test("Cavid"));
static string Test(string name)
{
    string result = " ";
    var arr = name.ToCharArray();

    for (int i = name.Length - 1; i >= 0; i--)
    {
        result += name[i];

    }
    return result;



}