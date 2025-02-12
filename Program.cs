using System;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 4)
        {
            Console.WriteLine("Usage: PBKDF2Hasher.exe <password> <salt> <iterations> <dkLen>");
            return;
        }

        string password = args[0];
        byte[] salt = Convert.FromBase64String(args[1]); // Salt wird als Base64 übergeben
        int iterations = int.Parse(args[2]);
        int dkLen = int.Parse(args[3]);

        using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA1))
        {
            byte[] hash = pbkdf2.GetBytes(dkLen);
            Console.WriteLine(Convert.ToBase64String(hash)); // Gibt das Ergebnis als Base64 zurück
        }
    }
}
