namespace Premutation
{
    public class PremutationEncryption
    {
        private static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ_";

        public static string Encrypt(int shift, string sourceString)
        {
            string resultStringEnc = "";
            sourceString = sourceString.ToUpper();
            for (int i = 0; i < sourceString.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (sourceString[i] == alphabet[j])
                    {
                        resultStringEnc = resultStringEnc + alphabet[getNewPosition(shift, j)];
                        break;
                    }
                }
            }
            return resultStringEnc;
        }

        private static int getNewPosition(int shift, int CurrentPosition)
        {
            int newPosition;
            if ((CurrentPosition + shift) >= alphabet.Length)
            {
                newPosition = (CurrentPosition + shift) - alphabet.Length;
                return (0 + newPosition);
            }
            else if (CurrentPosition + shift < 0)
            {
                newPosition = alphabet.Length - System.Math.Abs(CurrentPosition + shift);
                return newPosition;
            }
            else
            {
                return (CurrentPosition + shift);
            }

        }
    }
}
