namespace Substitution
{
    public class SubstitutionEncryption
    {
        public static string alphabetA { get; set; } // normal alphabet
        public static string alphabetB { get; set; } // alphabet for replace

        static SubstitutionEncryption()
        {
            if (alphabetA == null)
                alphabetA = "ABCDEFGHIJKLMNOPQRSTUVWXYZ_";
            if (alphabetB == null)
                alphabetB = "_ZYXWVUTSRQPONMLKJIHGFEDCBA";
        }

        public static string Encryption(string sourceString)
        {
            string result = "";
            sourceString = sourceString.ToUpper();
            for(int i = 0; i < sourceString.Length; i++)
                for(int j = 0; j < alphabetA.Length; j++)
                    if (sourceString[i] == alphabetA[j])
                        result = result + alphabetB[j];
            return result;
        }

        public static string Encryption(string sourceString, int shift)
        {
            string result = "";
            sourceString = sourceString.ToUpper();
            for (int i = 0; i < sourceString.Length; i++)
                for (int j = 0; j < alphabetA.Length; j++)
                    if (sourceString[i] == alphabetA[j])
                        result = result + alphabetB[getNewPosition(shift, j)];
            return result;
        }


        private static int getNewPosition(int shift, int CurrentPosition)
        {
            int newPosition;
            if ((CurrentPosition + shift) >= alphabetB.Length)
            {
                newPosition = (CurrentPosition + shift) - alphabetB.Length;
                return (0 + newPosition);
            }
            else if (CurrentPosition + shift < 0)
            {
                newPosition = alphabetB.Length - System.Math.Abs(CurrentPosition + shift);
                return newPosition;
            }
            else
            {
                return (CurrentPosition + shift);
            }

        }
    }
}
