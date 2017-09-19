using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAGui
{
    public partial class Form2 : Form
    {
        Form1 frm = new Form1();
        public Form2(string e,string d,string n,string m,string s)
        { 
            InitializeComponent();
            lblpublickey.Text = "(" + e + "," + n + ")";
            btnpublickey.Text = "(" + e + "," + n + ")";
            lblprivatekey.Text = "(" + d + "," + n + ")";
            btnprivatekey.Text = "(" + d + "," + n + ")";
            btnenc.Text = "*********Debit Card Number*********\n" + m;
            lblEncryption.Text = "**********************Cipher Text***********************\n" + s;
            lblDecryption.Text = "*********Debit Card Number*********\n" + m;
            btndec.Text = "Waiting for Authentication";

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblpublickey.Top < 405)
            {
                lblpublickey.Top++;
                lblEncryption.Visible = false;

            }
            else
            {
                lblpublickey.Visible = false;
                lblEncryption.Visible = true;
               /// timer1.Enabled = false;
            }
            if (lblpublickey.Top==405)
            {
                if (lblEncryption.Left < 910)
                {
                    timer1.Enabled = true;
                    lblEncryption.Left++;
                }
                else
                {
                    timer1.Enabled = false;
                }
            }
          
            if (lblEncryption.Left ==910)
            {
                if (lblprivatekey.Top < 405)
                {
                    timer1.Enabled = false;
                    lblprivatekey.Top++;
                    timer1.Enabled = true;

                }
                else
                {
                    lblprivatekey.Visible = false;
                    lblDecryption.Visible = false;
                    lblEncryption.Visible = false;
                    btndec.Text = btnenc.Text;
                } 
            }
            
        }

        private void btndec_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblprivatekey_Click(object sender, EventArgs e)
        {

        }

        private void lblDecryption_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
