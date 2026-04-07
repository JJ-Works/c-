using System;

class StringMethodsDemo
{
    public static void Run()
    {
        string text = "  Hello World  ";
        string text2 = "hello world";

        // Length
        Console.WriteLine("Length: " + text.Length);

        // ToUpper & ToLower
        Console.WriteLine("ToUpper: " + text.ToUpper());
        Console.WriteLine("ToLower: " + text.ToLower());

        // Contains
        Console.WriteLine("Contains 'World': " + text.Contains("World"));

        // StartsWith & EndsWith
        Console.WriteLine("StartsWith '  He': " + text.StartsWith("  He"));
        Console.WriteLine("EndsWith 'ld  ': " + text.EndsWith("ld  "));

        // IndexOf
        Console.WriteLine("IndexOf 'World': " + text.IndexOf("World"));

        // Substring
        Console.WriteLine("Substring (2,5): " + text.Substring(2, 5));

        // Replace
        Console.WriteLine("Replace: " + text.Replace("World", "C#"));

        // Trim
        Console.WriteLine("Trim: '" + text.Trim() + "'");

        // Split
        string sentence = "C# is fun to learn";
        string[] words = sentence.Split(' ');
        Console.WriteLine("Split:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // Equals
        Console.WriteLine("Equals: " + text.Trim().Equals(text2));

        // Insert
        Console.WriteLine("Insert: " + text.Insert(2, "Beautiful "));

        // Remove
        Console.WriteLine("Remove: " + text.Remove(2, 5));

        // PadLeft & PadRight
        Console.WriteLine("PadLeft: '" + text.Trim().PadLeft(20) + "'");
        Console.WriteLine("PadRight: '" + text.Trim().PadRight(20) + "'");

        // Compare
        Console.WriteLine("Compare: " + String.Compare(text.Trim(), text2));

        // CompareTo
        Console.WriteLine("CompareTo: " + text.Trim().CompareTo(text2));

        // IsNullOrEmpty
        string empty = "";
        Console.WriteLine("IsNullOrEmpty: " + String.IsNullOrEmpty(empty));

        // IsNullOrWhiteSpace
        string space = "   ";
        Console.WriteLine("IsNullOrWhiteSpace: " + String.IsNullOrWhiteSpace(space));
    }
}

