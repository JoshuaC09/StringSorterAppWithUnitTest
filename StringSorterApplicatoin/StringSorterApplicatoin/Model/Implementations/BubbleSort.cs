using StringSorterApplicatoin.Model.Interfaces;

namespace StringSorterApplicatoin.Model.Implementations
{
    public class BubbleSort : ISortStrategy
    {
        public string Sort(string input)
        {
            char[] characters = input.ToCharArray();
            int n = characters.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (characters[j] > characters[j + 1])
                    {
                        char temp = characters[j];
                        characters[j] = characters[j + 1];
                        characters[j + 1] = temp;
                    }
                }
            }
            return new string(characters);
        }
    }
}
