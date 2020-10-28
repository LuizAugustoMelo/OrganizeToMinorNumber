using OrganizeToMinorNumber.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrganizeToMinorNumber.Entities
{
    class OrganizeNumbers
    {
        public int Number { get; protected set; }

        public OrganizeNumbers(int number)
        {
            if (number <= 0)
            {
                throw new OrganizeExceptions("O numero digitado deve ser maior que zero.");
            }
            Number = number;
        }

        public string MinorNumber()
        {
            string numReturn = "";
            int index = -1, lowestValue = -1;
            List<char> charNumber = new List<char>();
            List<int> tempNum = new List<int>();

            for (int i = 0; i < Number.ToString().Length; i++)
            {
                charNumber.Add(char.Parse(Number.ToString().Substring(i, 1)));
            }

            while(charNumber.Count > 0)
            {
                for (int i = 0; i < charNumber.Count; i++)
                {
                    int value = int.Parse(charNumber[i].ToString());

                    if (i == 0)
                    {
                        lowestValue = value;
                        index = i;
                    }
                    else if (value < lowestValue)
                    {
                        index = i;
                        lowestValue = value;
                    }
                }

                tempNum.Add(lowestValue);
                charNumber.RemoveAt(index);
            }

            for (int i = 0; i < tempNum.Count; i++)
            {
                numReturn += tempNum[i].ToString();
            }

            return numReturn;
        }
    }
}
