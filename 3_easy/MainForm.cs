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

        byte temp;
        string output = "";

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tb_input.Text.Length; i++)
            {
                temp = (byte)tb_input.Text[i];  

                
                if ((int)temp + 3 > 255)
                {
                    temp = (byte)((int)temp - 252);
                }
                else
                {
                    temp = (byte)((int)temp + 3);
                }
                output += (char)temp;
            }

            tb_output.Text = output;
            output = "";
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tb_input.Text.Length; i++)
            {
                temp = (byte)tb_input.Text[i];


                if ((int)temp - 3 < 0)
                {
                    temp = (byte)((int)temp + 252);
                }
                else
                {
                    temp = (byte)((int)temp - 3);
                }
                output += (char)temp;
            }

            tb_output.Text = output;
            output = "";
        }
    }
}
