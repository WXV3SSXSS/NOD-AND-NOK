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
        int A, B, R;
        int d = 0;
        int AB = 1;
        private void button2_Click(object sender, EventArgs e)
        {  
            int m = Convert.ToInt32(textBox5.Text);
            dataGridView1.RowCount++;
            dataGridView1[0, d].Value = m;
            d++;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            A = Math.Abs(Convert.ToInt32(dataGridView1[0, 0].Value));
            AB = A * AB;
            for (int i = 1; i < d-1; i++)
            {
                B = Math.Abs(Convert.ToInt32(dataGridView1[0, i + 1].Value));
                AB = AB * B;
                while (B != 0)
                {
                    R = A % B;
                    A = B;
                    B = R;
                }

            }
            AB = AB * A;

            textBox3.Text = A.ToString();
            textBox4.Text = (AB / A).ToString();
        }

        public NOD_AND_NOK()
        {
            InitializeComponent();
        }

    }
}
