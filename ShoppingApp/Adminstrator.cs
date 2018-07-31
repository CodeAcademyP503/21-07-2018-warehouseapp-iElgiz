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
    public partial class Adminstrator : Form
    {
        public Adminstrator()
        {
            InitializeComponent();
            FillData();
        }


        
        public void FillData()
        {
            int index = 0;
         
            foreach (Markets mrk in LocalStorage.marketss)
            {
                if (mrk != null)
                {
                    foreach (Workers wrk in mrk.workersss)
                    {
                        if (wrk != null)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[index].Cells[0].Value = wrk.Name;
                            dataGridView1.Rows[index].Cells[1].Value = wrk.Surname;
                            dataGridView1.Rows[index].Cells[2].Value = wrk.Mail;
                            dataGridView1.Rows[index].Cells[3].Value = wrk.WorkPlace;
                            dataGridView1.Rows[index].Cells[4].Value = wrk.Wage;
                            dataGridView1.Rows[index].Cells[5].Value = wrk.Status;
                            dataGridView1.Rows[index].Cells[6].Value = mrk.Grade.gradeName;
                            dataGridView1.Rows[index].Cells[7].Value = wrk.bonucetype;
                            index++;
                        }
                    }
                }
            }
        }



        private void hesabla_Click(object sender, EventArgs e)
        {
            int t = 0;
            int l = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToString(dataGridView1.Rows[i].Cells[10].Value) == "True")
                {
                    foreach (Markets market in LocalStorage.marketss)
                    {
                        if (market != null)
                        {
                            foreach (Workers user in market.workersss)
                            {
                                if (user != null)
                                {
                                    if (user.Total != 0 && user.Name == Convert.ToString(dataGridView1.Rows[i].Cells[0].Value))
                                    {
                                        dataGridView1.Rows[i].Cells[8].Value = user.Total.ToString();
                                        
                                        if (Convert.ToString(market.Grade.gradeName) == "G01")
                                        {

                                            if ((t += Convert.ToInt32(user.Total))>100000)
                                            {
                                                for (int k = 0; k < dataGridView1.RowCount; k++)
                                                {
                                                    if (Convert.ToString(dataGridView1.Rows[k].Cells[6].Value) == "G01")
                                                    {
                                                        dataGridView1.Rows[k].Cells[9].Value = Convert.ToInt32(dataGridView1.Rows[k].Cells[4].Value) + 100;
                                                    }
                                                    
                                                }
                                                
                                            }
                                        }

                                        if (Convert.ToString(market.Grade.gradeName) == "G02")
                                        {

                                            if ((t += Convert.ToInt32(user.Total)) > 340000)
                                            {
                                                for (int k = 0; k < dataGridView1.RowCount; k++)
                                                {
                                                    if (Convert.ToString(dataGridView1.Rows[k].Cells[6].Value) == "G02")
                                                    {
                                                        dataGridView1.Rows[k].Cells[9].Value = Convert.ToInt32(dataGridView1.Rows[k].Cells[4].Value) +3400;
                                                    }

                                                }

                                            }
                                        }
                                        if (Convert.ToString(market.Grade.gradeName) == "G02M")
                                        {

                                            if ((t += Convert.ToInt32(user.Total)) > 340000)
                                            {
                                                for (int k = 0; k < dataGridView1.RowCount; k++)
                                                {
                                                    if (Convert.ToString(dataGridView1.Rows[k].Cells[6].Value) == "G02M")
                                                    {
                                                        dataGridView1.Rows[k].Cells[9].Value = Convert.ToInt32(dataGridView1.Rows[k].Cells[4].Value) + 500;
                                                    }

                                                }

                                            }
                                        }

                                        if (Convert.ToString(market.Grade.gradeName) == "G02NS")
                                        {

                                            if ((t += Convert.ToInt32(user.Total)) > 200000)
                                            {
                                                for (int k = 0; k < dataGridView1.RowCount; k++)
                                                {
                                                    if (Convert.ToString(dataGridView1.Rows[k].Cells[6].Value) == "G02NS")
                                                    {
                                                        dataGridView1.Rows[k].Cells[9].Value = Convert.ToInt32(dataGridView1.Rows[k].Cells[4].Value) + 200;
                                                    }

                                                }

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
