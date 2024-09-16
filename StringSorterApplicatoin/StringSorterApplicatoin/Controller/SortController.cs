using StringSorterApplication.Model;
using StringSorterApplicatoin.Model.Implementations;
using StringSorterApplicatoin.Model.Interfaces;
namespace StringSorterApplicatoin
{
    public class SortController
    {
        private Sort _sort;
        private ISortView _view;

        public SortController(ISortView view)
        {
            this._view = view;
            this._sort = new Sort();
        }

        public void SortString()
        {
            string input = _view.InputString;
            string? strategyName = _view.SelectedStrategy;

            if (strategyName == null)
            {
                throw new ArgumentNullException(nameof(strategyName), "No sorting strategy selected.");
            }

            ISortStrategy strategy = GetSortStrategy(strategyName);
            _sort.SetStrategy(strategy);
            string result = _sort.SortString(input);

            _view.OutputString = result;
        }

        private ISortStrategy GetSortStrategy(string strategyName)
        {
            switch (strategyName)
            {
                case "BubbleSort":
                    return new BubbleSort();
                case "QuickSort":
                    return new QuickSort();
                default:
                    throw new ArgumentException("Invalid sorting strategy selected.");
            }
        }
    }
}