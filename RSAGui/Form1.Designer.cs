namespace RSAGui
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtp = new System.Windows.Forms.TextBox();
            this.txtq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnpq = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtn = new System.Windows.Forms.TextBox();
            this.txtphi = new System.Windows.Forms.TextBox();
            this.btnnphi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txte = new System.Windows.Forms.TextBox();
            this.txtd = new System.Windows.Forms.TextBox();
            this.btned = new System.Windows.Forms.Button();
            this.txtmod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btncheck = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtpbk = new System.Windows.Forms.TextBox();
            this.txtprk = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtmsg = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtde = new System.Windows.Forms.TextBox();
            this.txten = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.bttnende = new System.Windows.Forms.Button();
            this.btndemo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Californian FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(68, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "RSA PUBLIC KEY CRYPTOSYSTEM by (TouchStarDev)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtp
            // 
            this.txtp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtp.Enabled = false;
            this.txtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtp.ForeColor = System.Drawing.Color.Black;
            this.txtp.Location = new System.Drawing.Point(36, 45);
            this.txtp.Multiline = true;
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(397, 73);
            this.txtp.TabIndex = 1;
            // 
            // txtq
            // 
            this.txtq.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtq.Enabled = false;
            this.txtq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtq.ForeColor = System.Drawing.Color.Black;
            this.txtq.Location = new System.Drawing.Point(483, 45);
            this.txtq.Multiline = true;
            this.txtq.Name = "txtq";
            this.txtq.Size = new System.Drawing.Size(434, 73);
            this.txtq.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "P =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(439, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = " Q =";
            // 
            // btnpq
            // 
            this.btnpq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpq.Location = new System.Drawing.Point(739, 124);
            this.btnpq.Name = "btnpq";
            this.btnpq.Size = new System.Drawing.Size(178, 32);
            this.btnpq.TabIndex = 5;
            this.btnpq.Text = "Generate P && Q";
            this.btnpq.UseVisualStyleBackColor = true;
            this.btnpq.Click += new System.EventHandler(this.btnpq_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "N=p*q ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(381, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "PHI=(p-1)(q-1)";
            // 
            // txtn
            // 
            this.txtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtn.Enabled = false;
            this.txtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtn.ForeColor = System.Drawing.Color.Black;
            this.txtn.Location = new System.Drawing.Point(75, 162);
            this.txtn.Multiline = true;
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(301, 67);
            this.txtn.TabIndex = 8;
            // 
            // txtphi
            // 
            this.txtphi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtphi.Enabled = false;
            this.txtphi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphi.ForeColor = System.Drawing.Color.Black;
            this.txtphi.Location = new System.Drawing.Point(483, 162);
            this.txtphi.Multiline = true;
            this.txtphi.Name = "txtphi";
            this.txtphi.Size = new System.Drawing.Size(434, 67);
            this.txtphi.TabIndex = 9;
            // 
            // btnnphi
            // 
            this.btnnphi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnphi.Location = new System.Drawing.Point(739, 235);
            this.btnnphi.Name = "btnnphi";
            this.btnnphi.Size = new System.Drawing.Size(178, 32);
            this.btnnphi.TabIndex = 10;
            this.btnnphi.Text = "Generate N && PHI";
            this.btnnphi.UseVisualStyleBackColor = true;
            this.btnnphi.Click += new System.EventHandler(this.btnnphi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(443, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "D = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "E =";
            // 
            // txte
            // 
            this.txte.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txte.Enabled = false;
            this.txte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txte.ForeColor = System.Drawing.Color.Black;
            this.txte.Location = new System.Drawing.Point(68, 273);
            this.txte.Multiline = true;
            this.txte.Name = "txte";
            this.txte.Size = new System.Drawing.Size(369, 54);
            this.txte.TabIndex = 13;
            // 
            // txtd
            // 
            this.txtd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtd.Enabled = false;
            this.txtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtd.ForeColor = System.Drawing.Color.Black;
            this.txtd.Location = new System.Drawing.Point(483, 273);
            this.txtd.Multiline = true;
            this.txtd.Name = "txtd";
            this.txtd.Size = new System.Drawing.Size(434, 59);
            this.txtd.TabIndex = 14;
            // 
            // btned
            // 
            this.btned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btned.Location = new System.Drawing.Point(739, 338);
            this.btned.Name = "btned";
            this.btned.Size = new System.Drawing.Size(178, 32);
            this.btned.TabIndex = 15;
            this.btned.Text = "Generate E && D";
            this.btned.UseVisualStyleBackColor = true;
            this.btned.Click += new System.EventHandler(this.btned_Click);
            // 
            // txtmod
            // 
            this.txtmod.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtmod.Enabled = false;
            this.txtmod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmod.ForeColor = System.Drawing.Color.Black;
            this.txtmod.Location = new System.Drawing.Point(140, 452);
            this.txtmod.Name = "txtmod";
            this.txtmod.Size = new System.Drawing.Size(408, 26);
            this.txtmod.TabIndex = 16;
            this.txtmod.TextChanged += new System.EventHandler(this.txtmod_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "(E*D) Mod PHI ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(553, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "This should be always= 1";
            // 
            // btncheck
            // 
            this.btncheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.Location = new System.Drawing.Point(739, 455);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(178, 32);
            this.btncheck.TabIndex = 19;
            this.btncheck.Text = "Check This";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Public Key =(E,N)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-2, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Private Key =(D,N)";
            // 
            // txtpbk
            // 
            this.txtpbk.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtpbk.Enabled = false;
            this.txtpbk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpbk.ForeColor = System.Drawing.Color.Black;
            this.txtpbk.Location = new System.Drawing.Point(140, 341);
            this.txtpbk.Multiline = true;
            this.txtpbk.Name = "txtpbk";
            this.txtpbk.Size = new System.Drawing.Size(585, 38);
            this.txtpbk.TabIndex = 22;
            // 
            // txtprk
            // 
            this.txtprk.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtprk.Enabled = false;
            this.txtprk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprk.ForeColor = System.Drawing.Color.Black;
            this.txtprk.Location = new System.Drawing.Point(140, 397);
            this.txtprk.Multiline = true;
            this.txtprk.Name = "txtprk";
            this.txtprk.Size = new System.Drawing.Size(777, 37);
            this.txtprk.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 494);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(196, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Enter Debit Card Number :";
            // 
            // txtmsg
            // 
            this.txtmsg.BackColor = System.Drawing.SystemColors.Window;
            this.txtmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmsg.ForeColor = System.Drawing.Color.Black;
            this.txtmsg.Location = new System.Drawing.Point(213, 494);
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.Size = new System.Drawing.Size(335, 26);
            this.txtmsg.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 567);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Cipher Text :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 634);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "Original Debit Card :";
            // 
            // txtde
            // 
            this.txtde.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtde.Enabled = false;
            this.txtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtde.ForeColor = System.Drawing.Color.Black;
            this.txtde.Location = new System.Drawing.Point(209, 634);
            this.txtde.Name = "txtde";
            this.txtde.Size = new System.Drawing.Size(339, 26);
            this.txtde.TabIndex = 28;
            // 
            // txten
            // 
            this.txten.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txten.Enabled = false;
            this.txten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txten.ForeColor = System.Drawing.Color.Black;
            this.txten.Location = new System.Drawing.Point(209, 564);
            this.txten.Name = "txten";
            this.txten.Size = new System.Drawing.Size(339, 26);
            this.txten.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(564, 570);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(195, 20);
            this.label15.TabIndex = 30;
            this.label15.Text = "Card# = (Cipher)^d mod N ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(564, 500);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(195, 20);
            this.label16.TabIndex = 31;
            this.label16.Text = "Cipher = (Card#)^e mod N ";
            // 
            // bttnende
            // 
            this.bttnende.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnende.Location = new System.Drawing.Point(349, 526);
            this.bttnende.Name = "bttnende";
            this.bttnende.Size = new System.Drawing.Size(170, 32);
            this.bttnende.TabIndex = 32;
            this.bttnende.Text = "Encrypt";
            this.bttnende.UseVisualStyleBackColor = true;
            this.bttnende.Click += new System.EventHandler(this.bttnende_Click);
            // 
            // btndemo
            // 
            this.btndemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndemo.Location = new System.Drawing.Point(746, 610);
            this.btndemo.Name = "btndemo";
            this.btndemo.Size = new System.Drawing.Size(171, 44);
            this.btndemo.TabIndex = 33;
            this.btndemo.Text = "Demo";
            this.btndemo.UseVisualStyleBackColor = true;
            this.btndemo.Click += new System.EventHandler(this.btndemo_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(787, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 34;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(349, 596);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 32);
            this.button2.TabIndex = 35;
            this.button2.Text = "Decrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 672);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btndemo);
            this.Controls.Add(this.bttnende);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txten);
            this.Controls.Add(this.txtde);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtmsg);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtprk);
            this.Controls.Add(this.txtpbk);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtmod);
            this.Controls.Add(this.btned);
            this.Controls.Add(this.txtd);
            this.Controls.Add(this.txte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnnphi);
            this.Controls.Add(this.txtphi);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnpq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtq);
            this.Controls.Add(this.txtp);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA PUBLIC KEY CRYPTOSYSTEM";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.TextBox txtq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnpq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.TextBox txtphi;
        private System.Windows.Forms.Button btnnphi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txte;
        private System.Windows.Forms.TextBox txtd;
        private System.Windows.Forms.Button btned;
        private System.Windows.Forms.TextBox txtmod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtpbk;
        private System.Windows.Forms.TextBox txtprk;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtmsg;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtde;
        private System.Windows.Forms.TextBox txten;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button bttnende;
        private System.Windows.Forms.Button btndemo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

