using System;
using System.Collections.Generic;

namespace Bank
{
    static class BankOperation
    {
        private static List<string> vendor = new List<string> { "American Express", "JCB", "Maestro", "MasterCard", "VISA" };

        public static string GetCreditCardVendor(string cardNumber)
        {
            string number = cardNumber.Replace(" ", string.Empty);
            int code = Convert.ToInt32(number.Substring(0, 4));

            if (LuhnAlgorithmChecker(cardNumber) == false)
                return "Unknown";

            if (((code >= 3400 && code <= 3499) || (code >= 3700 && code <= 3799)) && number.Length == 15)
            {
                return vendor[0];
            }

            else if ((code >= 3528 && code <= 3589) && number.Length == 16)
            {
                return vendor[1];
            }

            else if (((code >= 5000 && code <= 5099) || (code >= 5600 && code <= 5699) || (code >= 6900 && code <= 6999)) && (number.Length >= 12 && number.Length <= 19))
            {
                return vendor[2];
            }

            else if (((code >= 2221 && code <= 2720) || (code >= 5100 && code <= 5599)) && number.Length == 16)
            {
                return vendor[3];
            }

            else if (((code >= 4000 && code <= 4999)) && (number.Length == 13 || number.Length == 16 || number.Length == 19))
            {
                return vendor[4];
            }

            return "Unknown";
        }

        public static bool IsCreditCardNumberValid(string cardNumber)
        {
            if (GetCreditCardVendor(cardNumber) != "Unknown")
                return true;
            return false;
        }

        public static string GenerateNextCreditCardNumber(string cardNumber)
        {
            int controler = 20;
            string strCode = cardNumber.Replace(" ", string.Empty);
            string tempVendor = null;

            if (GetCreditCardVendor(strCode) != "Unknown")
                tempVendor = GetCreditCardVendor(strCode);

            else
                return null;

            ulong code = Convert.ToUInt64(strCode) + 1;

            while (IsCreditCardNumberValid(code.ToString()) == false)
            {
                code++;
                controler--;
                if (controler == 0)
                    return String.Format("no more numbers left for {0}", tempVendor);
            }

            if(GetCreditCardVendor(code.ToString()) != tempVendor)
                return String.Format("no more numbers left for {0}", tempVendor);

            return code.ToString();
        }

        public static bool LuhnAlgorithmChecker(string cardNumber)
        {
            string code = cardNumber.Replace(" ", string.Empty);
            List<int> oddNumbers = new List<int>();
            List<int> pairNumbers = new List<int>();
            int result = 0;

            #region PAIR CARD NUMBER LENGTH
            if (code.Length % 2 == 0)
            {

                for (int i = 0; i < code.Length; i += 2)
                {
                    oddNumbers.Add(Convert.ToInt32(code.Substring(i, 1)));
                }

                for (int i = 1; i < code.Length; i += 2)
                {
                    pairNumbers.Add(Convert.ToInt32(code.Substring(i, 1)));
                }

                for (int i = 0; i < oddNumbers.Count; i++)
                {
                    int x = oddNumbers[i] * 2;

                    if (x > 9)
                    {
                        x = x - 9;
                    }

                    oddNumbers[i] = x;
                }

                for (int i = 0; i < oddNumbers.Count; i++)
                {
                    result += (oddNumbers[i] + pairNumbers[i]);
                }

                if (result % 10 == 0)
                {
                    return true;
                }
            }
            #endregion

            #region ODD CARD NUMBER LENGTH
            else
            {
                for (int i = 1; i < code.Length; i += 2)
                {
                    pairNumbers.Add(Convert.ToInt32(code.Substring(i, 1)));
                }

                for (int i = 0; i < code.Length; i += 2)
                {
                    oddNumbers.Add(Convert.ToInt32(code.Substring(i, 1)));
                }

                for (int i = 0; i < pairNumbers.Count; i++)
                {
                    int x = pairNumbers[i] * 2;

                    if (x > 9)
                    {
                        x = x - 9;
                    }

                    pairNumbers[i] = x;
                }

                for (int i = 0; i < oddNumbers.Count; i++)
                {
                    result += oddNumbers[i];

                    if (i < pairNumbers.Count)
                    {
                        result += pairNumbers[i];
                    }
                }

                if (result % 10 == 0)
                {
                    return true;
                }
            }
            #endregion

            return false;
        }
    }
}
