namespace RSA_Playfair
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rsa_btn = new Button();
            pf_btn = new Button();
            lb1 = new Label();
            lb2 = new Label();
            label14 = new Label();
            panel1 = new Panel();
            btn_generate = new Button();
            rtb_q = new RichTextBox();
            rtb_p = new RichTextBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btn_update = new Button();
            label7 = new Label();
            label8 = new Label();
            rtb_d = new RichTextBox();
            rtb_e = new RichTextBox();
            rtb_phi = new RichTextBox();
            rtb_modulus = new RichTextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            rtb_ciphertext = new RichTextBox();
            rtb_base = new RichTextBox();
            rtb_seg = new RichTextBox();
            rtb_plaintext = new RichTextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            btn_decrypt = new Button();
            btn_encrypt = new Button();
            pn_rsa = new Panel();
            panel4 = new Panel();
            pn_pf = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            pn_rsa.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // rsa_btn
            // 
            rsa_btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rsa_btn.Location = new Point(12, 44);
            rsa_btn.Name = "rsa_btn";
            rsa_btn.Size = new Size(127, 46);
            rsa_btn.TabIndex = 0;
            rsa_btn.Text = "RSA";
            rsa_btn.UseVisualStyleBackColor = true;
            rsa_btn.Click += rsa_btn_Click;
            // 
            // pf_btn
            // 
            pf_btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pf_btn.Location = new Point(145, 44);
            pf_btn.Name = "pf_btn";
            pf_btn.Size = new Size(127, 46);
            pf_btn.TabIndex = 1;
            pf_btn.Text = "Playfair";
            pf_btn.UseVisualStyleBackColor = true;
            pf_btn.Click += pf_btn_Click;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb1.Location = new Point(503, -3);
            lb1.Name = "lb1";
            lb1.Size = new Size(88, 47);
            lb1.TabIndex = 2;
            lb1.Text = "RSA";
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb2.Location = new Point(12, 9);
            lb2.Name = "lb2";
            lb2.Size = new Size(235, 32);
            lb2.TabIndex = 3;
            lb2.Text = "Choose encrypt type";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 0);
            label14.Name = "label14";
            label14.Size = new Size(356, 15);
            label14.TabIndex = 0;
            label14.Text = "RSA using the private and public key - or using only the public key";
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_generate);
            panel1.Controls.Add(rtb_q);
            panel1.Controls.Add(rtb_p);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(1101, 103);
            panel1.TabIndex = 5;
            // 
            // btn_generate
            // 
            btn_generate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_generate.Location = new Point(858, 18);
            btn_generate.Name = "btn_generate";
            btn_generate.Size = new Size(233, 70);
            btn_generate.TabIndex = 8;
            btn_generate.Text = "Generate Prime Number";
            btn_generate.UseVisualStyleBackColor = true;
            btn_generate.Click += btn_generate_Click;
            // 
            // rtb_q
            // 
            rtb_q.Location = new Point(173, 56);
            rtb_q.Name = "rtb_q";
            rtb_q.Size = new Size(669, 32);
            rtb_q.TabIndex = 3;
            rtb_q.Text = "";
            // 
            // rtb_p
            // 
            rtb_p.Location = new Point(173, 18);
            rtb_p.Name = "rtb_p";
            rtb_p.Size = new Size(669, 32);
            rtb_p.TabIndex = 2;
            rtb_p.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 57);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 1;
            label3.Text = "Prime number q";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 18);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 0;
            label2.Text = "Prime number p";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_update);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(rtb_d);
            panel2.Controls.Add(rtb_e);
            panel2.Controls.Add(rtb_phi);
            panel2.Controls.Add(rtb_modulus);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(0, 221);
            panel2.Name = "panel2";
            panel2.Size = new Size(1101, 176);
            panel2.TabIndex = 6;
            // 
            // btn_update
            // 
            btn_update.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_update.Location = new Point(858, 91);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(233, 70);
            btn_update.TabIndex = 9;
            btn_update.Text = "Update Parameters";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(858, 15);
            label7.Name = "label7";
            label7.Size = new Size(76, 25);
            label7.TabIndex = 9;
            label7.Text = "(Public)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(858, 59);
            label8.Name = "label8";
            label8.Size = new Size(76, 25);
            label8.TabIndex = 10;
            label8.Text = "(Secret)";
            // 
            // rtb_d
            // 
            rtb_d.Location = new Point(173, 129);
            rtb_d.Name = "rtb_d";
            rtb_d.Size = new Size(669, 32);
            rtb_d.TabIndex = 15;
            rtb_d.Text = "";
            // 
            // rtb_e
            // 
            rtb_e.Location = new Point(173, 90);
            rtb_e.Name = "rtb_e";
            rtb_e.Size = new Size(669, 32);
            rtb_e.TabIndex = 14;
            rtb_e.Text = "";
            // 
            // rtb_phi
            // 
            rtb_phi.Location = new Point(173, 52);
            rtb_phi.Name = "rtb_phi";
            rtb_phi.Size = new Size(669, 32);
            rtb_phi.TabIndex = 13;
            rtb_phi.Text = "";
            // 
            // rtb_modulus
            // 
            rtb_modulus.Location = new Point(173, 8);
            rtb_modulus.Name = "rtb_modulus";
            rtb_modulus.Size = new Size(669, 32);
            rtb_modulus.TabIndex = 9;
            rtb_modulus.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 9;
            label1.Text = "RSA modulus N";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 52);
            label4.Name = "label4";
            label4.Size = new Size(170, 25);
            label4.TabIndex = 10;
            label4.Text = "phi(N) = (p-1)(q-1)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 91);
            label5.Name = "label5";
            label5.Size = new Size(112, 25);
            label5.TabIndex = 11;
            label5.Text = "Public key e";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 129);
            label6.Name = "label6";
            label6.Size = new Size(119, 25);
            label6.TabIndex = 12;
            label6.Text = "Private key d";
            // 
            // panel3
            // 
            panel3.Controls.Add(radioButton2);
            panel3.Controls.Add(radioButton1);
            panel3.Controls.Add(rtb_ciphertext);
            panel3.Controls.Add(rtb_base);
            panel3.Controls.Add(rtb_seg);
            panel3.Controls.Add(rtb_plaintext);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(0, 403);
            panel3.Name = "panel3";
            panel3.Size = new Size(1101, 285);
            panel3.TabIndex = 6;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(242, 17);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(86, 25);
            radioButton2.TabIndex = 28;
            radioButton2.TabStop = true;
            radioButton2.Text = "Number";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(173, 17);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(54, 25);
            radioButton1.TabIndex = 27;
            radioButton1.TabStop = true;
            radioButton1.Text = "Text";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // rtb_ciphertext
            // 
            rtb_ciphertext.Location = new Point(8, 253);
            rtb_ciphertext.Name = "rtb_ciphertext";
            rtb_ciphertext.Size = new Size(1083, 32);
            rtb_ciphertext.TabIndex = 23;
            rtb_ciphertext.Text = "";
            // 
            // rtb_base
            // 
            rtb_base.Location = new Point(8, 190);
            rtb_base.Name = "rtb_base";
            rtb_base.Size = new Size(1083, 32);
            rtb_base.TabIndex = 22;
            rtb_base.Text = "";
            // 
            // rtb_seg
            // 
            rtb_seg.Location = new Point(8, 132);
            rtb_seg.Name = "rtb_seg";
            rtb_seg.Size = new Size(1083, 32);
            rtb_seg.TabIndex = 21;
            rtb_seg.Text = "";
            // 
            // rtb_plaintext
            // 
            rtb_plaintext.Location = new Point(8, 69);
            rtb_plaintext.Name = "rtb_plaintext";
            rtb_plaintext.Size = new Size(1083, 32);
            rtb_plaintext.TabIndex = 16;
            rtb_plaintext.Text = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(8, 225);
            label13.Name = "label13";
            label13.Size = new Size(99, 25);
            label13.TabIndex = 20;
            label13.Text = "Ciphertext";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(8, 162);
            label12.Name = "label12";
            label12.Size = new Size(289, 25);
            label12.TabIndex = 19;
            label12.Text = "Numbers input in base 10 format";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 104);
            label11.Name = "label11";
            label11.Size = new Size(752, 25);
            label11.TabIndex = 18;
            label11.Text = "The input will be seperated into segments of Size 1 (The symbol '#'  is used as seperator)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 41);
            label10.Name = "label10";
            label10.Size = new Size(85, 25);
            label10.TabIndex = 17;
            label10.Text = "Plaintext";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 16);
            label9.Name = "label9";
            label9.Size = new Size(79, 25);
            label9.TabIndex = 16;
            label9.Text = "Input as";
            // 
            // btn_decrypt
            // 
            btn_decrypt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_decrypt.Location = new Point(589, 790);
            btn_decrypt.Name = "btn_decrypt";
            btn_decrypt.Size = new Size(178, 47);
            btn_decrypt.TabIndex = 24;
            btn_decrypt.Text = "Decrypt";
            btn_decrypt.UseVisualStyleBackColor = true;
            // 
            // btn_encrypt
            // 
            btn_encrypt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_encrypt.Location = new Point(342, 790);
            btn_encrypt.Name = "btn_encrypt";
            btn_encrypt.Size = new Size(178, 47);
            btn_encrypt.TabIndex = 8;
            btn_encrypt.Text = "Encrypt";
            btn_encrypt.UseVisualStyleBackColor = true;
            // 
            // pn_rsa
            // 
            pn_rsa.Controls.Add(panel3);
            pn_rsa.Controls.Add(panel4);
            pn_rsa.Controls.Add(panel2);
            pn_rsa.Controls.Add(panel1);
            pn_rsa.Location = new Point(12, 96);
            pn_rsa.Name = "pn_rsa";
            pn_rsa.Size = new Size(1103, 688);
            pn_rsa.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Controls.Add(label14);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1103, 100);
            panel4.TabIndex = 1;
            // 
            // pn_pf
            // 
            pn_pf.Location = new Point(12, 96);
            pn_pf.Name = "pn_pf";
            pn_pf.Size = new Size(1101, 688);
            pn_pf.TabIndex = 8;
            pn_pf.Controls.Add(pf);
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 838);
            Controls.Add(lb2);
            Controls.Add(lb1);
            Controls.Add(btn_decrypt);
            Controls.Add(pf_btn);
            Controls.Add(btn_encrypt);
            Controls.Add(rsa_btn);
            Controls.Add(pn_rsa);
            Controls.Add(pn_pf);
            Name = "Main";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pn_rsa.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button rsa_btn;
        private Button pf_btn;
        private Label lb1;
        private Label lb2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel pn_rsa;
        private Button btn_generate;
        private RichTextBox rtb_q;
        private RichTextBox rtb_p;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private RichTextBox rtb_d;
        private RichTextBox rtb_e;
        private RichTextBox rtb_phi;
        private RichTextBox rtb_modulus;
        private Button btn_update;
        private Label label7;
        private Label label8;
        private Label label9;
        private RichTextBox rtb_ciphertext;
        private RichTextBox rtb_base;
        private RichTextBox rtb_seg;
        private RichTextBox rtb_plaintext;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label14;
        private Button btn_decrypt;
        private Button btn_encrypt;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel pn_pf;
        private Panel panel4;
    }
}
