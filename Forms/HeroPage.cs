using System.Runtime.InteropServices;

namespace FormBiblioteka
{
    public partial class HeroPage : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn (int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public HeroPage()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void AddBookButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            AddBooks addBooksForm = new();
            addBooksForm.ShowDialog();
        }

        private void ListOfBooksButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            ListOfBooks listOfBooksForm = new();
            listOfBooksForm.Show();
        }

        private void TakeReturnFormButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            Take_ReturnForm takeReturnForm = new();
            takeReturnForm.ShowDialog();
        }
    }
}
