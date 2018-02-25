using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemManager
{
    public partial class spScreen : Form
    {
        public spScreen()
        {
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                rectangleShape2.Width +=5;
                if(rectangleShape2.Width >= 462)
                {
                    timer1.Stop();

                   

                    this.Hide();
                    Admin.LoginPannel lp = new Admin.LoginPannel();
                    lp.Show();





                }
            }
            catch(Exception)
            {
                return;

            }
        }

        private void spScreen_Load(object sender, EventArgs e)
        {
        }
    }
}
