using System.Text;


namespace PasswordCreator;

public class RPasswordCreator
{
    private static Random randomizer = new Random();
    private static StringBuilder password = new StringBuilder();
    public static string Create(string length, bool[] conditions)
    {
        string charSet = CharSetCreator(conditions);
        int lengthInt = Int32.Parse(length);
        StringBuilder password = new StringBuilder();
        for(int i = 0; i < lengthInt; i++)
        {
            int index = randomizer.Next(0, charSet.Length - 1);
            password.Append(charSet.ElementAt(index));
        }
        return password.ToString();
    }

    private static string CharSetCreator(bool[] conditions)
    {
        string lowercaseSet = new string(Enumerable.Range('a',26).Select(i=> (char)i).ToArray());
        StringBuilder charSet = new StringBuilder();
        charSet.Append(lowercaseSet);
        if (conditions[0] == true)
        {
            charSet.Append(lowercaseSet.ToUpper());
        }
        if (conditions[1] == true)
        {
            charSet.Append(Enumerable.Range(0,9).Select(i=>(int)i).ToString());
        }
        if (conditions[2] == true)
        {
            char[] symbols = new char[] { '-', '_', '#', '^' };
            charSet.Append(symbols);
        }
        return charSet.ToString();
    }
}
