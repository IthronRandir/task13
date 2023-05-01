class Programm
{
    static int Compare(string str1, string str2)
    {
        int MinLength = Math.Min(str1.Length, str2.Length);
        int b = 3;

        for (int i = 0; i < MinLength; i++)
        {
            do
            {
                i++;
            }
            while (str1[i] == '0' && str2[i] == '0');
            
            if (str1[i] != '.' && str2[i] != '.')
            {
                if (str1[i] < str2[i])
                {
                    b = -1;
                    break;
                }
                else if (str1[i] == str2[i])
                {
                    b = 0;
                }
                else
                {
                    b = 1;
                    break;
                }
            }
        }

        bool b1 = b == 0 && str1.Length < str2.Length;
        bool b2 = b == 0 && str2.Length < str1.Length;

        if (b1 == true) b = -1; else if (b2 == true) b = 1;

        return b;
    }

    static void Main(string[] args)
    {
        string version1 = "01.010.41";
        string version2 = "01.010.41";
        int answer = Compare(version1, version2);
        Console.WriteLine(answer);
    }
}
