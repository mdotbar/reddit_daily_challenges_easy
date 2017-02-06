using System;
using System.Windows.Forms;

//Rules :

//"Write a program that can encrypt texts with an caracteresical caesar cipher. This cipher can ignore numbers, symbols, and whitespace.
//For extra credit, add a decrypt function to your program."

namespace _3_easy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string caracteres = "abcdefghijklmnopqrstuvwxyz0123456789 ";
        string output = "";

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tb_input.Text.Length; i++)
            {
                for (int j = 0; j < caracteres.Length; j++)
                {
                    if (tb_input.Text[i] == caracteres[j])
                    {
                        if (j + 3 > 37)
                        {
                            output += caracteres[(j + 3) - 37];
                        }
                        else
                        {
                            output += caracteres[j + 3];
                        }
                    }
                }
            }

            tb_output.Text = output;
            output = "";
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tb_input.Text.Length; i++)
            {
                for (int j = 0; j < caracteres.Length; j++)
                {
                    if (tb_input.Text[i] == caracteres[j])
                    {
                        if (j - 3 < 0)
                        {
                            output += caracteres[(j - 3) + 37];
                        }
                        else
                        {
                            output += caracteres[j - 3];
                        }
                    }
                }
            }

            tb_output.Text = output;
            output = "";
        }
    }
}
