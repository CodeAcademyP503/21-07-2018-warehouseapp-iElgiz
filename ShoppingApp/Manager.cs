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
    public partial class Manager : Form
    {
        public static TextBox[] txt = new TextBox[30];
    
        public Manager()
        {
            InitializeComponent();
        }


        private void CheckBtn_Click(object sender, EventArgs e)
        {
            foreach (Workers wr in LocalStorage.workerss)
            {
                if (wr != null)
                {
                    if (comboBox1.Text == wr.Name)
                    {
                        textBox1.Text = wr.Name;
                        textBox2.Text = wr.Surname;
                        textBox3.Text = wr.Mail;
                        textBox4.Text = Convert.ToString(wr.Status);
                        textBox5.Text = Convert.ToString(wr.WorkPlace);
                        textBox6.Text = Convert.ToString(wr.Wage);
                        textBox7.Text = Convert.ToString(wr.bonucetype);
                        textBox8.Text = Convert.ToString(wr.Total);
                        break;
                    }
                }
            }
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            foreach (Workers work in LocalStorage.GoMarket.workersss)
            {
                if (work != null && work.Status !=MarketStatus.Manager)
                {
                    comboBox1.Items.Add(work.Name);
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            foreach (Workers user in LocalStorage.workerss)
            {
                if (user != null)
                {
                    if (comboBox1.Text == user.Name)
                    {
                        user.Name = textBox1.Text;
                        user.Surname = textBox2.Text;
                        user.Mail = textBox3.Text;
                        user.Wage = Convert.ToInt32(textBox6.Text);
                        user.Total = Convert.ToInt32(textBox8.Text);
                    }
                }
            }
        }
    }
}
