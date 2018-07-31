using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingApp
{
    public partial class Form1 : Form
    {
        static public Workers[] wrks = new Workers[1];

        public Form1()
        {
            InitializeComponent();
        }

       

        public void Form1_Load(object sender, EventArgs e)
        {
            LocalStorage.CreateWorkers();
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            foreach (Markets market in LocalStorage.marketss)
            {
                if (market != null)
                {
                    foreach (Workers work in market.workersss)
                    {
                        if (work != null && work.Status == MarketStatus.Manager)
                        {
                            if (work.Name == textBox1.Text && work.PassWord == textBox2.Text)
                            {
                                LocalStorage.GoMarket = market;
                                Manager mng = new Manager();
                                mng.ShowDialog();
                            }
                        }
                       
                    }
                }             
            }
                if (textBox1.Text == "Admin" && textBox2.Text == "123")
                {
                    Adminstrator admin = new Adminstrator();
                    admin.ShowDialog();
                    
                }
        }
    }
}
