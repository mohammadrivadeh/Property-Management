using System;
using System.Windows.Forms;

namespace MoshaverAmlak
{
    
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            
        }
        
        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            
            CircleProgressbar.Value = CircleProgressbar.Value + 1;
            if (CircleProgressbar.Value == 1)
            {
                StatusLable.Text = "Loding Forms";
            }
            else if (CircleProgressbar.Value == 10)
            {
                StatusLable.Text = "Loding Content";
            }
            else if (CircleProgressbar.Value == 30)
            {
                StatusLable.Text = "Loading Style";
            }
            else if (CircleProgressbar.Value == 50)
            {
                StatusLable.Text = "Loading Fonts";
            }
            else if (CircleProgressbar.Value == 70)
            {
                StatusLable.Text = "Syncing to DB";
            }
            else if (CircleProgressbar.Value == 90)
            {
                StatusLable.Text = "Almost Done";
                
            }

            if (CircleProgressbar.Value == 100)
            {
                var Main = new Main();
                SplashScreenTimer.Enabled = false;
                
                Main.Show();
                this.Hide();
            }
        }
    }
}
