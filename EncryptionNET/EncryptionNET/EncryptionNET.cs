using System;
using Premutation;

namespace EncryptionNET
{
    class EncryptionNET
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PremutationEncryption.Encrypt(5, "Fuck_the_system"));
            Console.WriteLine(PremutationEncryption.Encrypt(-5, PremutationEncryption.Encrypt(5, "Fuck_the_system")));
            Console.ReadKey();
        }
    }
}
