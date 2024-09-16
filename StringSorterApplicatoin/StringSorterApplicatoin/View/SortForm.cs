using StringSorterApplicatoin.Model.Interfaces;

namespace StringSorterApplicatoin
{
    public partial class SortForm : Form , ISortView
    {
        private SortController _controller;
        public SortForm()
        {
            InitializeComponent();
            _controller = new SortController(this);
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            comboBoxStrategy.Items.AddRange(new object[] { "BubbleSort", "QuickSort" });
            comboBoxStrategy.SelectedIndex = 0;
        }


        private void sortBtn_Click(object sender, EventArgs e)
        {
            _controller.SortString();
        }


        public string InputString
        {
            get { return textBoxInput.Text; }
        }

        public string? SelectedStrategy
        {
            get { return comboBoxStrategy.SelectedItem?.ToString() ?? string.Empty; }
        }


        public string OutputString
        {
            set { textBoxOutput.Text = value; }
        }


    }
}
