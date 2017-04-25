using System;
using Premutation;
using Substitution;

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
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Substitution Encryption");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Existing string: Fuck_the_system");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Existing alphabetA: ABCDEFGHIJKLMNOPQRSTUVWXYZ_");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Existing alphabetB: _ZYXWVUTSRQPONMLKJIHGFEDCBA");
            Console.WriteLine("----------------------------------------");
            SubstitutionEncryption.alphabetA = "ABCDEFGHIJKLMNOPQRSTUVWXYZ_";
            SubstitutionEncryption.alphabetB = "_ZYXWVUTSRQPONMLKJIHGFEDCBA";
            Console.Write("Encrypted:   ");
            Console.WriteLine(SubstitutionEncryption.Encryption("Fuck_the_system"));
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Existing alphabetA: _ZYXWVUTSRQPONMLKJIHGFEDCBA");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Existing alphabetB: ABCDEFGHIJKLMNOPQRSTUVWXYZ_");
            Console.WriteLine("----------------------------------------");
            SubstitutionEncryption.alphabetB = "ABCDEFGHIJKLMNOPQRSTUVWXYZ_";
            SubstitutionEncryption.alphabetA = "_ZYXWVUTSRQPONMLKJIHGFEDCBA";
            Console.Write("Decrypted with the same params:   ");
            Console.WriteLine(SubstitutionEncryption.Encryption(SubstitutionEncryption.Encryption("Fuck_the_system")));
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Substitution+Permutation Encryption");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Existing string: Fuck_the_system");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Existing alphabetA: ABCDEFGHIJKLMNOPQRSTUVWXYZ_");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Existing alphabetB: _ZYXWVUTSRQPONMLKJIHGFEDCBA");
            Console.WriteLine("----------------------------------------");
            SubstitutionEncryption.alphabetA = "ABCDEFGHIJKLMNOPQRSTUVWXYZ_";
            SubstitutionEncryption.alphabetB = "_ZYXWVUTSRQPONMLKJIHGFEDCBA";
            Console.Write("Encrypted:   ");
            string s = SubstitutionEncryption.Encryption("Fuck_the_system", 2);
            Console.WriteLine(s);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Existing alphabetA: _ZYXWVUTSRQPONMLKJIHGFEDCBA");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Existing alphabetB: ABCDEFGHIJKLMNOPQRSTUVWXYZ_");
            Console.WriteLine("----------------------------------------");
            SubstitutionEncryption.alphabetB = "ABCDEFGHIJKLMNOPQRSTUVWXYZ_";
            SubstitutionEncryption.alphabetA = "_ZYXWVUTSRQPONMLKJIHGFEDCBA";
            Console.Write("Decrypted with the same params:   ");
            Console.WriteLine(SubstitutionEncryption.Encryption(s, -2));

            Console.ReadKey();
        }
    }
}
