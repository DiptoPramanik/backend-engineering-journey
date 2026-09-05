using System;
using System.Collections.Generic;

class Program
{
    // METHOD defined OUTSIDE Main() but inside the class
    // Returns the product of two integers
    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static void Main()
    {
        // ========================
        // 1. HELLO WORLD
        // ========================
        Console.WriteLine("Hello World, Dipto!");

        // ========================
        // 2. VARIABLES AND DATATYPES
        // ========================
        int age = 24;           // whole number
        double height = 5.7;    // decimal number
        string name = "Dipto";  // text
        char grade = 'A';       // single character (use single quotes)
        bool isStudent = true;  // true or false

        Console.WriteLine("Name: " + name);
        Console.WriteLine($"Age: {age}");           // string interpolation ($"...")
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Is Student: " + isStudent);

        // ========================
        // 3. TAKING INPUT FROM USER
        // ========================
        // FIX: Renamed to 'inputName' and 'inputAge' to avoid duplicate variable names
        Console.WriteLine("Enter your name:");
        string inputName = Console.ReadLine();  // reads a line of text from keyboard

        Console.WriteLine("Enter your age:");
        // Console.ReadLine() always returns STRING, so convert to int:
        int inputAge = Convert.ToInt32(Console.ReadLine());
        // You can also use Convert.ToDouble() for decimal numbers

        Console.WriteLine("Hello " + inputName);
        Console.WriteLine("Your age is " + inputAge);

        // ========================
        // 4. ARITHMETIC OPERATORS
        // ========================
        int a = 10;
        int b = 5;
        Console.WriteLine(a + b);  // Addition:    15
        Console.WriteLine(a - b);  // Subtraction:  5
        Console.WriteLine(a * b);  // Multiplication: 50
        Console.WriteLine(a / b);  // Division:     2

        // ========================
        // 5. IF-ELSE CONDITION
        // ========================
        int my_age = 20;

        if (my_age >= 18)
        {
            Console.WriteLine("Adult");
        }
        else
        {
            Console.WriteLine("Not Adult");
        }

        // ========================
        // 6. LOOPS
        // ========================

        // --- FOR LOOP ---
        // Use when you KNOW how many times to repeat
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

        // FIX: Added '//' to fix "while loops" — it was missing the comment marker
        // --- WHILE LOOP ---
        // Use when you repeat based on a CONDITION (don't know exact count)
        int wi = 1;  // FIX: renamed from 'i' to 'wi' to avoid duplicate declaration
        while (wi <= 5)
        {
            Console.WriteLine(wi);
            wi++;
        }
        /* Difference:
           for   → when you KNOW how many times
           while → when condition-based repeat */

        // --- DO-WHILE LOOP ---
        // Always runs AT LEAST ONCE, then checks condition
        int ii = 1;
        do
        {
            Console.WriteLine(ii);
            ii++;
        }
        while (ii <= 5);

        // ========================
        // 7. BASIC ARRAY
        // ========================
        // FIX: Renamed to 'numbers1' to avoid duplicate 'numbers' declaration
        int[] numbers1 = { 10, 20, 30, 40, 50 };

        // Access using index (starts at 0)
        for (int j = 0; j < numbers1.Length; j++)
        {
            Console.WriteLine(numbers1[j]);
        }

        // --- FOREACH LOOP (simpler way to iterate array) ---
        foreach (int num in numbers1)
        {
            Console.WriteLine(num);
        }

        // ========================
        // 8. ARRAY WITH FIXED SIZE
        // ========================
        // FIX: Renamed to 'numbers2' to avoid duplicate
        int[] numbers2 = new int[5];   // creates array of 5 integers (all 0 by default)
        for (int fi = 0; fi < 5; fi++) // FIX: renamed loop var to 'fi'
        {
            numbers2[fi] = fi * 10;
        }
        for (int fi = 0; fi < 5; fi++)
        {
            Console.WriteLine(numbers2[fi]);
        }

        // ========================
        // 9. 2D ARRAY
        // ========================

        // --- Hard approach: Jagged Array (array of arrays) ---
        int[][] arr = new int[5][];    // 5 rows, columns defined separately
        for (int ri = 0; ri < 5; ri++) // FIX: renamed to 'ri'
        {
            arr[ri] = new int[3];      // each row has 3 columns
        }
        for (int ri = 0; ri < 5; ri++)
        {
            for (int ci = 0; ci < 3; ci++) // FIX: renamed to 'ci'
            {
                arr[ri][ci] = ri * ci;
            }
        }
        for (int ri = 0; ri < 5; ri++)
        {
            for (int ci = 0; ci < 3; ci++)
            {
                Console.Write(arr[ri][ci] + " ");
            }
            Console.WriteLine();
        }

        // --- Easy approach: True 2D Array (int[,]) ---
        // More readable and recommended for fixed-size grids
        int[,] grid2D =
        {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };
        for (int row = 0; row < 2; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write(grid2D[row, col] + " ");
            }
            Console.WriteLine();
        }

        // 2D array with computed values
        int[,] arr2D = new int[5, 7];
        for (int ri = 0; ri < 5; ri++)
        {
            for (int ci = 0; ci < 7; ci++)
            {
                arr2D[ri, ci] = ri * ci;
            }
        }
        for (int ri = 0; ri < 5; ri++)
        {
            for (int ci = 0; ci < 7; ci++)
            {
                Console.Write(arr2D[ri, ci] + " ");
            }
            Console.WriteLine();
        }

        // ========================
        // 10. 3D ARRAY
        // ========================

        // --- Hard approach: Jagged 3D Array ---
        int[][][] arr3 = new int[3][][];
        for (int i3 = 0; i3 < 3; i3++) // FIX: renamed to 'i3'
        {
            arr3[i3] = new int[2][];
            for (int j3 = 0; j3 < 2; j3++) // FIX: renamed to 'j3'
            {
                arr3[i3][j3] = new int[4];
            }
        }
        for (int i3 = 0; i3 < 3; i3++)
        {
            for (int j3 = 0; j3 < 2; j3++)
            {
                for (int k3 = 0; k3 < 4; k3++) // FIX: renamed to 'k3'
                {
                    arr3[i3][j3][k3] = i3 * j3 * k3;
                }
            }
        }
        for (int i3 = 0; i3 < 3; i3++)
        {
            Console.WriteLine("Layer " + i3);
            for (int j3 = 0; j3 < 2; j3++)
            {
                for (int k3 = 0; k3 < 4; k3++)
                {
                    Console.Write(arr3[i3][j3][k3] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // --- Easy approach: True 3D Array (int[,,]) ---
        int[,,] cube =
        {
            {
                { 1,  2,  3,  4 },
                { 5,  6,  7,  8 }
            },
            {
                { 9,  10, 11, 12 },
                { 13, 14, 15, 16 }
            },
            {
                { 17, 18, 19, 20 },
                { 21, 22, 23, 24 }
            }
        };
        for (int depth = 0; depth < 3; depth++)
        {
            Console.WriteLine("Layer: " + depth);
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Console.Write(cube[depth, row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // 3D array with computed values
        int[,,] arr3D = new int[3, 2, 4];
        for (int i3 = 0; i3 < 3; i3++)
        {
            for (int j3 = 0; j3 < 2; j3++)
            {
                for (int k3 = 0; k3 < 4; k3++)
                {
                    arr3D[i3, j3, k3] = i3 * j3 * k3;
                }
            }
        }
        for (int i3 = 0; i3 < 3; i3++)
        {
            Console.WriteLine("Layer " + i3);
            for (int j3 = 0; j3 < 2; j3++)
            {
                for (int k3 = 0; k3 < 4; k3++)
                {
                    Console.Write(arr3D[i3, j3, k3] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // ========================
        // 11. CHARACTER ARRAY AND STRING
        // ========================

        // --- Char array (hard way) ---
        char[] str = new char[10];
        str[0] = 'a';
        str[1] = 'b';
        Console.WriteLine(str);   // prints: ab (rest are null chars)

        char[] letters = { 'C', 'S', 'h', 'a', 'r' };
        for (int li = 0; li < letters.Length; li++) // FIX: renamed to 'li'
        {
            Console.Write(letters[li]);
        }

        // ========================
        // 12. STRING
        // ========================
        string firstName = "Dipto";
        string city = "Gaibandha";
        Console.WriteLine(firstName);
        Console.WriteLine(city);

        string lastName = "Pramanik";
        string fullName = firstName + " " + lastName;  // String Concatenation
        Console.WriteLine(fullName);

        string nam = "dipto";
        Console.WriteLine(nam.ToUpper());           // "DIPTO"
        Console.WriteLine(nam.ToLower());           // "dipto"
        Console.WriteLine(nam.StartsWith("Di"));    // false (case-sensitive!)
        Console.WriteLine(nam.EndsWith("to"));      // true

        // Split() breaks a string into parts based on a separator character
        string sentence = "I love C#";
        string[] words = sentence.Split(' ');       // splits by space
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // ========================
        // 13. ARRAY SORT AND REVERSE
        // ========================

        // Sort ascending
        int[] sortArr = { 5, 2, 8, 1, 3 };         // FIX: renamed from 'num' (conflicts with foreach var above)
        Array.Sort(sortArr);                        // modifies array in-place
        foreach (int x in sortArr)
        {
            Console.Write(x + " ");                 // 1 2 3 5 8
        }

        // Reverse array
        int[] revArr = { 1, 2, 3, 4, 5 };          // FIX: renamed from 'n' (conflicts with enclosing scope)
        Array.Reverse(revArr);                      // modifies array in-place
        foreach (int y in revArr)
        {
            Console.Write(y + " ");                 // 5 4 3 2 1
        }
        Console.WriteLine();

        // Reverse a string (strings are immutable, so convert to char array first)
        string s = "bbccaccbb";
        char[] ar = s.ToCharArray();                // convert string → char array
        Array.Reverse(ar);                          // reverse it
        string reversed = new string(ar);           // convert back to string
        Console.WriteLine(reversed);

        // Sort a string alphabetically
        string s2 = "dcba";
        char[] array = s2.ToCharArray();
        Array.Sort(array);
        string result = new string(array);
        Console.WriteLine(result);                  // "abcd"

        // ========================
        // 14. 2D CHARACTER ARRAY
        // ========================
        char[,] st =
        {
            { 'A', 'B', 'C' },
            { 'D', 'E', 'F' },
            { 'G', 'H', 'I' },
            { 'J', 'K', 'L' }
        };
        for (int si = 0; si < 4; si++) // FIX: renamed to 'si'
        {
            for (int sj = 0; sj < 3; sj++) // FIX: renamed to 'sj'
            {
                Console.Write(st[si, sj] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // 2D string array
        string[,] strName =
        {
            { "A", "B", "C" },
            { "D", "E", "F" }
        };
        for (int row = 0; row < 2; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write(strName[row, col] + " ");
            }
            Console.WriteLine();
        }

        // ========================
        // 15. ARRAY OF STRINGS
        // ========================

        // Dynamically fill string array from input
        string[] namess = new string[3];
        for (int ni = 0; ni < 3; ni++) // FIX: renamed to 'ni'
        {
            namess[ni] = Console.ReadLine();
        }
        Console.WriteLine("Names are:");
        foreach (string stName in namess)
        {
            Console.WriteLine(stName);
        }

        // Predefined string array
        string[] strNames = { "Dipto", "Rahim", "Karim", "Sakib" };
        for (int si = 0; si < strNames.Length; si++)
        {
            Console.WriteLine(strNames[si]);
        }

        // ========================
        // 16. LIST
        // ========================
        // Requires: using System.Collections.Generic;
        // List is like an array but DYNAMIC (can grow/shrink)

        IList<int> numList = new List<int>(); // FIX: renamed to 'numList'
        numList.Add(10);
        numList.Add(20);
        numList.Add(30);
        foreach (int ln in numList) // FIX: renamed to 'ln'
        {
            Console.WriteLine(ln);
        }

        IList<string> nameList = new List<string>(); // FIX: renamed to 'nameList'
        nameList.Add("Dipto");
        nameList.Add("Rahim");
        nameList.Add("Karim");
        nameList.Remove("Rahim");   // removes by value, not index
        foreach (string nm in nameList) // FIX: renamed to 'nm'
        {
            Console.WriteLine(nm);
        }

        // ========================
        // 17. DICTIONARY
        // ========================
        // Dictionary<TKey, TValue> stores KEY-VALUE pairs (like a real dictionary: word → meaning)
        // Keys must be UNIQUE

        Dictionary<int, string> students = new Dictionary<int, string>();
        students.Add(1, "Dipto");
        students.Add(2, "Rahim");
        students.Add(3, "Karim");
        students.Remove(2);         // removes entry with key 2

        foreach (KeyValuePair<int, string> item in students)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }

        // Handling duplicate keys safely
        string[] key = { "one", "two", "three", "two" };
        int[] value = { 1, 2, 3, 5 };
        Dictionary<string, int> dict = new Dictionary<string, int>();

        for (int ki = 0; ki < key.Length; ki++) // FIX: renamed to 'ki'
        {
            if (dict.ContainsKey(key[ki]))
            {
                dict[key[ki]] = value[ki]; // key exists → update value
            }
            else
            {
                dict.Add(key[ki], value[ki]); // new key → add entry
            }
        }
        foreach (KeyValuePair<string, int> kv in dict)
        {
            Console.WriteLine($"{kv.Key} : {kv.Value}");
        }

        // ========================
        // 18. FUNCTION CALL
        // ========================
        // Calling Multiply() defined above (outside Main)
        int mulResult = Multiply(4, 5); // FIX: renamed to 'mulResult' to avoid duplicate 'result'
        Console.WriteLine(mulResult);   // 20
    }
}