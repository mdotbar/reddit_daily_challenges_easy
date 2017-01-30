using System;
using System.Windows.Forms;

//Rules :

//"Create a calculator application that has use in your life.
//For extra credit, make the calculator have multiple functions."

namespace _2_easy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Variables
        float temp, result;
        int operation;

        //Chiffres
        private void btn_0_Click(object sender, EventArgs e)
        {
            tb_output.Text = tb_output.Text + 0;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            tb_output.Text = tb_output.Text + 1;    
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            tb_output.Text = tb_output.Text + 2;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            tb_output.Text = tb_output.Text + 3;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            tb_output.Text = tb_output.Text + 4;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            tb_output.Text = tb_output.Text + 5;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            tb_output.Text = tb_output.Text + 6;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            tb_output.Text = tb_output.Text + 7;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            tb_output.Text = tb_output.Text + 8;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            tb_output.Text = tb_output.Text + 9;
        }

        //Décimale
        private void btn_dot_Click(object sender, EventArgs e)
        {
            if (!tb_output.Text.Contains(","))
            {
                tb_output.Text = tb_output.Text + ",";
            }
        }

        //Opérations
        private void btn_add_Click(object sender, EventArgs e)
        {
            temp = float.Parse(tb_output.Text);
            tb_output.Clear();
            tb_output.Focus();
            operation = 1;
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            temp = float.Parse(tb_output.Text);
            tb_output.Clear();
            tb_output.Focus();
            operation = 2;
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            temp = float.Parse(tb_output.Text);
            tb_output.Clear();
            tb_output.Focus();
            operation = 3;
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            temp = float.Parse(tb_output.Text);
            tb_output.Clear();
            tb_output.Focus();
            operation = 4;
        }

        //Clear
        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_output.Clear();
            result = 0;
            temp = 0;
            operation = 0;
        }

        //Résultat
        private void btn_rslt_Click(object sender, EventArgs e)
        {
            if (tb_output.Text != "")
            {
                switch (operation)
                {
                    case 1:
                        result = temp + float.Parse(tb_output.Text);
                        tb_output.Text = result.ToString();
                        break;
                    case 2:
                        result = temp - float.Parse(tb_output.Text);
                        tb_output.Text = result.ToString();
                        break;
                    case 3:
                        result = temp * float.Parse(tb_output.Text);
                        tb_output.Text = result.ToString();
                        break;
                    case 4:
                        result = temp / float.Parse(tb_output.Text);
                        tb_output.Text = result.ToString();
                        break;
                }
            }

            temp = 0;
        }
    }
}
