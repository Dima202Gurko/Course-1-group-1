namespace PracticeAB;

class Program
{

    
    // Творим тут


    //1
    static int add(int a, int b)
    {
        return a + b;
    }

    //2
    static bool is_even(int number)
    {
        return number % 2 == 0;
    }

    //3
    static string reverse_string(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        s = new string(charArray);
        return s;
    } 

    //4
    static int find_max(int[] arr)
    {
        return arr.Max();
    }

    // 5
    static int factorial(int sallary)
    {
        return sallary * 12;
    }


    // 6
    static double celsius_to_fahrenheit(int celsius)
    {
        return celsius * 1.8 + 32;
    }


    //7
    static int count_vowels(string s)
    {
        string vowels = "аиоуеэАИОУЕЭ";
        int sum = 0;
        foreach (char c in s)
        {
            if(vowels.Contains(c))
            {
                sum++;
            }           
        }
        return sum;
    }


    //8
    int generate_password(string passtohack)
    {
        int count = 0;
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                for (int z = 0; z < 10; z++)
                {
                    for (int h = 0; h < 10; h++)
                    {
                        count += 1;
                        string generatedpass = x.ToString() + y.ToString() + z.ToString() + h.ToString();
                        if(generatedpass == passtohack)
                        {
                            Console.WriteLine("Ура! Вы взломали пароль теперь вы хакер");
                            return count - 1;                                  
                        }
                    }
                }
            }
        }
        return count;
    }
    

    static void Main(string[] args)
    {
        // это функция мейн которая вызывает все остальные функции для практики А и Б
        //вызов первой функци.... и т.п.
        Program.add(2, 3);
        Program.is_even(4);
        Program.reverse_string("Loed");
        Program.find_max(int[] ma = {1, 2, 5, 7});
        Program.factorial(5100);
        Program.celsius_to_fahrenheit(42);
        Program.count_vowels("Привет");
        Program.generate_password("6534")
    }
}
