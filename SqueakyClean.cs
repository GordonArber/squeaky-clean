using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder stringBuilder = new();
        for (var i = 0; i < identifier.Length; i++)
        {
            if (identifier[i] == ' ')
                stringBuilder.Append('_');
            else if (char.IsControl(identifier[i]))
                stringBuilder.Append("CTRL");
            else if (identifier[i] == '-' && i < identifier.Length - 1)
                stringBuilder.Append(char.ToUpperInvariant(identifier[++i]));
            else if (char.IsLetter(identifier[i]) && (identifier[i] < 'α' || identifier[i] > 'ω'))
                stringBuilder.Append(identifier[i]);
        }
        return stringBuilder.ToString();
    }
}
