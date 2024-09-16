using StringSorterApplicatoin.Model.Interfaces;

namespace StringSorterApplication.Model
{
    public class Sort
    {
        private ISortStrategy? _sortStrategy;

        public void SetStrategy(ISortStrategy strategy)
        {
            this._sortStrategy = strategy;
        }

        public string SortString(string input)
        {
            return _sortStrategy?.Sort(input) ?? throw new InvalidOperationException("Sort strategy not set.");
        }
    }
}