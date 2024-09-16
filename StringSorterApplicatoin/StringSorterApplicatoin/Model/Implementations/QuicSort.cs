using StringSorterApplicatoin.Model.Interfaces;

namespace StringSorterApplicatoin.Model.Implementations
{
    public class QuickSort : ISortStrategy
    {
        public string Sort(string input)
        {
            char[] characters = input.ToCharArray();
            QuickSortAlgorithm(characters, 0, characters.Length - 1);
            return new string(characters);
        }

        private void QuickSortAlgorithm(char[] arr, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(arr, low, high);
                QuickSortAlgorithm(arr, low, partitionIndex - 1);
                QuickSortAlgorithm(arr, partitionIndex + 1, high);
            }
        }

        private int Partition(char[] arr, int low, int high)
        {
            char pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    char temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            char temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
    }
}
