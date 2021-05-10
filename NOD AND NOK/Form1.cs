using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOD_AND_NOK
{
    public partial class NOD_AND_NOK : Form
    {
        long A, B, R;
        int  d = 0;
        long AB;
        private void button2_Click(object sender, EventArgs e)
        {  
            long m = Convert.ToInt64(textBox5.Text);
            dataGridView1.RowCount++;
            dataGridView1[0, d].Value = m;
           
            d++;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
            A = Math.Abs(Convert.ToInt64(dataGridView1[0, 0].Value));
            for (int i = 1; i < d; i++)
            {
                B = Math.Abs(Convert.ToInt64(dataGridView1[0, i].Value));
                while (B != 0)
                {
                    R = A % B;
                    A = B;
                    B = R;
                }

            }
            textBox3.Text = A.ToString();
            A = Math.Abs(Convert.ToInt64(dataGridView1[0, 0].Value));
            AB = A;
            for (int i = 1; i < d; i++)
            {
                B = Math.Abs(Convert.ToInt64(dataGridView1[0, i].Value));
                AB = AB * B;
                while (B != 0)
                {
                    R = A % B;
                    A = B;
                    B = R;
                }
                AB = AB / A;
                A = AB;
            }
            textBox4.Text = A.ToString();
        }

        public NOD_AND_NOK()
        {
            InitializeComponent();
        }

    }
}
