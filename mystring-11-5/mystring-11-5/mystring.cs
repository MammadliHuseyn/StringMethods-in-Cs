using System;

namespace mystring_11_5
{
    class Mystring
    {
        public string Str;

        public int Getlength()
        {
            int counter = 0;
            foreach (char c in Str)
            {
                counter++;
            }
            return counter;
        }

        public string Substring(int fromIndex, int count)
        {
            string str = string.Empty;

            for (int i = fromIndex; i < fromIndex + count; i++)
            {
                str += Str[i];
            }
            return str;
        }

        public string Remove(int fromIndex)
        {
            return Substring(0, fromIndex);
        }

        public string Remove(int fromIndex, int To)
        {
            string leftSide = Substring(0, fromIndex);
            string rightSide = Substring(To, Str.Length - To);
            return $"{leftSide}{rightSide}";
        }

        public string PadLeft(int count, char symbol)
        {
            string leftSide = string.Empty;
            for (int i = 0; i <= count - Str.Length; i++)
            {
                leftSide += symbol;
            }
            return $"{leftSide}{Str}";
        }

        public string PadRight(int count, char symbol)
        {
            string leftSide = string.Empty;
            for (int i = 0; i <= count - Str.Length; i++)
            {
                leftSide += symbol;
            }
            return $"{Str}{leftSide}";
        }

        public bool StartsWith(string phrase)
        {
            return Substring(0, phrase.Length) == phrase ? true : false;
        }

        public bool EndsWith(string phrase)
        {
            return Substring(Str.Length - phrase.Length, phrase.Length) == phrase ? true : false;
        }

        public string Replace(string oldValue, string newValue)
        {
            if (!Str.Contains(oldValue))
            {
                return Str;
            }

            string leftSide = Substring(0, IndexOf(oldValue));
            string rightSide = Substring(IndexOf(oldValue) + oldValue.Length, Str.Length - (leftSide.Length + oldValue.Length));
            return $"{leftSide}{newValue}{rightSide}";
        }

        public int LastIndexOf(char symbol)
        {
            int lastIndex = -1;
            for (int i = Str.Length - 1; i >= 0; i--)
            {
                if (Str[i] == symbol)
                {
                    lastIndex = i;
                    break;
                }
            }
            return lastIndex;
        }

        public string Trim(char symbol)
        {
            string result = string.Empty;
            for (int i = 0; i < Str.Length; i++)
            {
                if ((Str[i] != symbol))
                {
                    result += Str[i];
                }
            }
            return result;
        }

        public string TrimStarts(char symbol)
        {
            string result = string.Empty;
            for (int i = 0; i < Str.Length; i++)
            {
                if ((Str[i] != symbol))
                {
                    result += Str[i];
                }
            }
            return result;
        }

        public string ToLower()
        {
            char[] Lowletters = { 'a', 'h', 'u', 'i', 'm', 'u', 's', 'y', 'n' };
            char[] Upletters = { 'A', 'H', 'W', 'I', 'M', 'U', 'S', 'Y', 'N' };
            string result = String.Empty;

            for (int i = 0; i < Str.Length; i++)
            {
                for (int j = 0; j < Upletters.Length; j++)
                {
                    if (Str[i] == Upletters[j])
                    {
                         result+= Lowletters[j];
                    }
                    else
                    {
                        result += Str[i];
                        
                    }
                    break;
                }
            }
            return result;
        }

        public string Insert(int fromIndex , string phrase)
        {
            string leftSide = Substring(0, fromIndex);
            string rightSide = Substring(fromIndex, Str.Length - fromIndex);
            return $"{leftSide}{phrase}{rightSide}";
        }



        public bool Contains(string phrase)
        {
            int phraseLength = phrase.Length;
            int strlength = Str.Length;
            bool _contain = false;
            for (int i = 0; i <= strlength - phraseLength ; i++)
            {
                if(Str.Substring(i,phraseLength) == phrase)
                {
                    _contain = true;
                    break;
                }
            }

            return _contain;
        }

        public int IndexOf(string phrase)
        {
            int phraseLength = phrase.Length;
            int strlength = Str.Length;
            int startIndex = -1;
            for (int i = 0; i <= strlength - phraseLength; i++)
            {
                if (Str.Substring(i, phraseLength) == phrase)
                {
                    startIndex = i;
                    break;
                }
            }

            return startIndex;
        }

        

    }
}
