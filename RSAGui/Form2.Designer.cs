namespace RSAGui
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnpublickey = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblpublickey = new System.Windows.Forms.Label();
            this.btnenc = new System.Windows.Forms.Button();
            this.btnprivatekey = new System.Windows.Forms.Button();
            this.btndec = new System.Windows.Forms.Button();
            this.lblprivatekey = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEncryption = new System.Windows.Forms.Label();
            this.lblDecryption = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnpublickey
            // 
            this.btnpublickey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpublickey.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnpublickey.Location = new System.Drawing.Point(61, 32);
            this.btnpublickey.Name = "btnpublickey";
            this.btnpublickey.Size = new System.Drawing.Size(350, 248);
            this.btnpublickey.TabIndex = 0;
            this.btnpublickey.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblpublickey
            // 
            this.lblpublickey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblpublickey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpublickey.Location = new System.Drawing.Point(61, 32);
            this.lblpublickey.Name = "lblpublickey";
            this.lblpublickey.Size = new System.Drawing.Size(350, 248);
            this.lblpublickey.TabIndex = 1;
            this.lblpublickey.Text = "(e,n)";
            // 
            // btnenc
            // 
            this.btnenc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenc.Location = new System.Drawing.Point(36, 410);
            this.btnenc.Name = "btnenc";
            this.btnenc.Size = new System.Drawing.Size(326, 244);
            this.btnenc.TabIndex = 2;
            this.btnenc.UseVisualStyleBackColor = true;
            // 
            // btnprivatekey
            // 
            this.btnprivatekey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprivatekey.Location = new System.Drawing.Point(756, 54);
            this.btnprivatekey.Name = "btnprivatekey";
            this.btnprivatekey.Size = new System.Drawing.Size(252, 235);
            this.btnprivatekey.TabIndex = 4;
            this.btnprivatekey.UseVisualStyleBackColor = true;
            // 
            // btndec
            // 
            this.btndec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndec.Location = new System.Drawing.Point(710, 410);
            this.btndec.Name = "btndec";
            this.btndec.Size = new System.Drawing.Size(298, 244);
            this.btndec.TabIndex = 5;
            this.btndec.UseVisualStyleBackColor = true;
            this.btndec.Click += new System.EventHandler(this.btndec_Click);
            // 
            // lblprivatekey
            // 
            this.lblprivatekey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblprivatekey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprivatekey.Location = new System.Drawing.Point(752, 54);
            this.lblprivatekey.Name = "lblprivatekey";
            this.lblprivatekey.Size = new System.Drawing.Size(256, 248);
            this.lblprivatekey.TabIndex = 8;
            this.lblprivatekey.Text = "(d,n)";
            this.lblprivatekey.Click += new System.EventHandler(this.lblprivatekey_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(361, 434);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(354, 199);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Public Key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1072, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Private Key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(220, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "ENCRYPTION";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(706, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "DECRYPTION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(406, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Insecure Network OR Cloud";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblEncryption
            // 
            this.lblEncryption.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEncryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncryption.Location = new System.Drawing.Point(173, 447);
            this.lblEncryption.Name = "lblEncryption";
            this.lblEncryption.Size = new System.Drawing.Size(74, 171);
            this.lblEncryption.TabIndex = 15;
            // 
            // lblDecryption
            // 
            this.lblDecryption.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDecryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecryption.Location = new System.Drawing.Point(809, 447);
            this.lblDecryption.Name = "lblDecryption";
            this.lblDecryption.Size = new System.Drawing.Size(80, 171);
            this.lblDecryption.TabIndex = 17;
            this.lblDecryption.Visible = false;
            this.lblDecryption.Click += new System.EventHandler(this.lblDecryption_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 286);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 118);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1148, 286);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 118);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(809, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Private Key";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 666);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblprivatekey);
            this.Controls.Add(this.lblEncryption);
            this.Controls.Add(this.lblpublickey);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnpublickey);
            this.Controls.Add(this.btnenc);
            this.Controls.Add(this.btnprivatekey);
            this.Controls.Add(this.lblDecryption);
            this.Controls.Add(this.btndec);
            this.Controls.Add(this.button3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA PUBLIC KEY CRYPTOSYSTEM";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpublickey;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblpublickey;
        private System.Windows.Forms.Button btnenc;
        private System.Windows.Forms.Button btnprivatekey;
        private System.Windows.Forms.Button btndec;
        private System.Windows.Forms.Label lblprivatekey;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEncryption;
        private System.Windows.Forms.Label lblDecryption;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}