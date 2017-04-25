using System;
using Premutation;

namespace EncryptionNET
{
    class EncryptionNET
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Permutation Encryption");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Existing string: Fuck_the_system");
            Console.WriteLine("----------------------------------------");
            Console.Write("Encrypted:        ");
            Console.WriteLine(PremutationEncryption.Encrypt(5, "Fuck_the_system"));
            Console.WriteLine("----------------------------------------");
            Console.Write("Decrypted with the same params:   ");
            Console.WriteLine(PremutationEncryption.Encrypt(-5, PremutationEncryption.Encrypt(5, "Fuck_the_system")));
            Console.WriteLine("----------------------------------------");
            Console.ReadKey();
        }
    }
}
