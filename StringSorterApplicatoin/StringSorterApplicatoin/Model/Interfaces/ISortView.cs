namespace StringSorterApplicatoin.Model.Interfaces
{
    public interface ISortView
    {
        string InputString { get; }
        string? SelectedStrategy { get; }
        string OutputString { set; }
    }
}
