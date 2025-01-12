using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBiblioteka
{
    public partial class Take_ReturnForm : Form
    {
        public Take_ReturnForm()
        {
            InitializeComponent();
        }

        public void TakeReturnFormLoad(object sender, EventArgs e)
        {

        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            this.Close();
            HeroPage heroPage = new();
            heroPage.Show();
        }

        private void SubmitButtonClick(object sender, EventArgs e)
        {
            
        }
        
    }
}
