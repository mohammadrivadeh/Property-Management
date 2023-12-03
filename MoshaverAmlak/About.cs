using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoshaverAmlak
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void BtnExit_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void BtnExit_MouseEnter(object sender, EventArgs e)
        {
            BtnExit.BackColor = Color.Red;
        }

        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            BtnExit.BackColor = Color.FromArgb(0, 98, 211);
        }



        private void RightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
