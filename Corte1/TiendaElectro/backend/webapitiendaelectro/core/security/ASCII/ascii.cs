using System;
using System.Text;

public static class AsciiConverter
{
    // Codifica a valores ASCII separados por espacios
    public static string Encode(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "";

        byte[] bytes = Encoding.ASCII.GetBytes(input);
        return string.Join(" ", bytes); // Ej: "Hola" -> "72 111 108 97"
    }

    // Decodifica de valores ASCII separados por espacios a texto
    public static string Decode(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return "";

        string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        byte[] bytes = Array.ConvertAll(parts, byte.Parse);
        return Encoding.ASCII.GetString(bytes);
    }
}
