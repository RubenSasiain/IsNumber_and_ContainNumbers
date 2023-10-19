using System.Text.RegularExpressions;

public static bool ContainsNumbers(string input)
{
    string regexp = @"\d";
    contains = Regex.IsMatch(input, regexp);

    return contains;
}
