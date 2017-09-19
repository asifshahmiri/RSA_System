using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Random random = new Random(DateTime.Now.Millisecond);

        private void btnpq_Click(object sender, EventArgs e)
        {
            BigInteger p = GenerateLargePrime(50);
            BigInteger q = GenerateLargePrime(50);
            txtp.Text = p.ToString();
            txtq.Text = q.ToString();
            btnnphi.Enabled = true;
            btnpq.Enabled = false;

        }

        private BigInteger SQUARE_AND_MULTIPLY(BigInteger m,BigInteger exp,BigInteger n)
        {
            BigInteger z = 1;
            string binaryExp = ToBinary(exp);
            for (int i = 0; i < binaryExp.Length; i++)
            {
                z = BigInteger.ModPow(z, 2, n);

                if(binaryExp[i]=='1')
                {
                    z = (z * m) % n;
                }
            }
            return z;
        }

        private void btnnphi_Click(object sender, EventArgs e)
        {
            try
            {
                BigInteger p = BigInteger.Parse(txtp.Text);
                BigInteger q = BigInteger.Parse(txtq.Text);
                txtn.Text = (p * q).ToString();
                txtphi.Text = ((p - 1) * (q - 1)).ToString();
                btned.Enabled = true;
                btnnphi.Enabled = false;

            }
            catch (Exception)
            {
                
                
            }
           
        }

        private void btned_Click(object sender, EventArgs e)
        {
            try
            {
                BigInteger PHI = BigInteger.Parse(txtphi.Text);
                txte.Text = getEV(PHI).ToString();
                BigInteger ev = BigInteger.Parse(txte.Text);
                txtd.Text = getD(ev,PHI).ToString();
                BigInteger d = BigInteger.Parse(txtd.Text);
                BigInteger n = BigInteger.Parse(txtn.Text);
                txtpbk.Text = "(" + ev + "," + n + ")";
                txtprk.Text = "(" + d + "," + n + ")";
                btncheck.Enabled = true;
                btned.Enabled = false;
            }
            catch (Exception)
            {
                
             
            }
            
        }

        static BigInteger getD(BigInteger e, BigInteger PHI)
        {
            BigInteger[] u;
            BigInteger[] v;
            BigInteger q, temp1, temp2, temp3;

            u = new BigInteger[] { 0, 0, 0 };
            v = new BigInteger[] { 0, 0, 0 };

            u[0] = 1; u[1] = 0; u[2] = PHI;
            v[0] = 0; v[1] = 1; v[2] = e;

            while (v[2] != 0)
            {
                q = ((BigInteger)u[2] / v[2]);
                temp1 = u[0] - q * v[0];
                temp2 = u[1] - q * v[1];
                temp3 = u[2] - q * v[2];
                u[0] = v[0];
                u[1] = v[1];
                u[2] = v[2];
                v[0] = temp1;
                v[1] = temp2;
                v[2] = temp3;
            }
            if (u[1] < 0)
                return (u[1] + PHI);
            else 
                return (u[1]); 
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            try
            {
                BigInteger PHI = BigInteger.Parse(txtphi.Text);
                BigInteger ev = BigInteger.Parse(txte.Text);
                BigInteger d = BigInteger.Parse(txtd.Text);
                BigInteger mod = (ev * d) % PHI;
                txtmod.Text = mod.ToString();
                btncheck.Enabled = false;
                bttnende.Enabled = true;
            }
            catch (Exception)
            {
                
               
            }
            
        }

        private void bttnende_Click(object sender, EventArgs e)
        {
            try
            {
                BigInteger n = BigInteger.Parse(txtn.Text);
                BigInteger ev = BigInteger.Parse(txte.Text);
                BigInteger ms = BigInteger.Parse(txtmsg.Text);
                BigInteger encode = SQUARE_AND_MULTIPLY(ms, ev, n);
                txten.Text = encode.ToString();
                bttnende.Enabled = false;
                button2.Enabled = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show("You Entered Invalid Debit Card Number\n"+ex.Message);
                txtmsg.Text = "";
            }
               
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            txtp.Text = txtq.Text = txtn.Text = txtphi.Text = txte.Text = txtd.Text
            = txtmod.Text = txtmsg.Text = txten.Text = txtde.Text = txtpbk.Text = txtprk.Text = "";
            button2.Enabled = bttnende.Enabled = btnnphi.Enabled = btncheck.Enabled = btned.Enabled = btndemo.Enabled = false;
            btnpq.Enabled = true;
        }


        private void btndemo_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(txte.Text, txtd.Text, txtn.Text, txtmsg.Text, txten.Text);
            frm.Show();
  
        }

       public BigInteger getEV(BigInteger phi)
       {
	        BigInteger great = 0;
	        BigInteger e = 2;

            while(great != 1)
            {   
                e = e + 1;
                great = BigInteger.GreatestCommonDivisor(e,phi) ;
            }
            
        return e;
       }


       public static string ToBinary(BigInteger Decimal)
       {
           BigInteger BinaryHolder;
           char[] BinaryArray;
           string BinaryResult = "";

           while (Decimal > 0)
           {
               BinaryHolder = Decimal % 2;
               BinaryResult += BinaryHolder;
               Decimal = Decimal / 2;
           }
           BinaryArray = BinaryResult.ToCharArray();
           Array.Reverse(BinaryArray);
           BinaryResult = new string(BinaryArray);

           return BinaryResult;
       }

       static BigInteger GenerateLargePrime(int length)
       {
           LargeRandomPrime primality = new LargeRandomPrime();
           string numbers = "";

           for (int i = 0; i < length; i++)
           {
               numbers += random.Next(0, 10);
           }

           BigInteger number = BigInteger.Parse(numbers);

           if (primality.IsPrimeMillerRabin(number))
           {
               return number;
           }
           else
           {
               return GenerateLargePrime(length);
           }
       }

       private void Form1_Load(object sender, EventArgs e)
       {
           button2.Enabled = bttnende.Enabled = btnnphi.Enabled = btncheck.Enabled = btned.Enabled = btndemo.Enabled = false;

       }

       private void button2_Click(object sender, EventArgs e)
       {
           BigInteger ct = BigInteger.Parse(txten.Text);
           BigInteger n = BigInteger.Parse(txtn.Text);
           BigInteger dv = BigInteger.Parse(txtd.Text);
           BigInteger encode = SQUARE_AND_MULTIPLY(ct, dv, n);
           txtde.Text = encode.ToString();
           btndemo.Enabled = true;

       }

       private void txtmod_TextChanged(object sender, EventArgs e)
       {

       }

       private void label1_Click(object sender, EventArgs e)
       {

       }

    }
}
