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
            rtb_output = new RichTextBox();
            rtb_base = new RichTextBox();
            rtb_seg = new RichTextBox();
            rtb_input = new RichTextBox();
            lb_output = new Label();
            label12 = new Label();
            label11 = new Label();
            lb_input = new Label();

            btn_decrypt = new Button();
            btn_encrypt = new Button();
            pn_rsa = new Panel();
            btn_de = new Button();
            btn_en = new Button();
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
            rsa_btn.BackColor = Color.FromArgb(0, 205, 255);
            rsa_btn.Cursor = Cursors.Hand;
            rsa_btn.FlatAppearance.BorderColor = Color.FromArgb(150, 240, 255);
            rsa_btn.FlatAppearance.BorderSize = 2;
            rsa_btn.FlatStyle = FlatStyle.Flat;
            rsa_btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rsa_btn.ForeColor = Color.FromArgb(3, 18, 28);
            rsa_btn.Location = new Point(24, 67);
            rsa_btn.Margin = new Padding(3, 4, 3, 4);
            rsa_btn.Name = "rsa_btn";
            rsa_btn.Size = new Size(145, 58);
            rsa_btn.TabIndex = 0;
            rsa_btn.Text = "RSA";
            rsa_btn.UseVisualStyleBackColor = false;
            rsa_btn.Click += rsa_btn_Click;

            // 
            // pf_btn
            // 
            pf_btn.BackColor = Color.FromArgb(10, 27, 41);
            pf_btn.Cursor = Cursors.Hand;
            pf_btn.FlatAppearance.BorderColor = Color.FromArgb(90, 170, 190);
            pf_btn.FlatAppearance.BorderSize = 2;
            pf_btn.FlatStyle = FlatStyle.Flat;
            pf_btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pf_btn.ForeColor = Color.FromArgb(235, 250, 255);
            pf_btn.Location = new Point(185, 67);
            pf_btn.Margin = new Padding(3, 4, 3, 4);
            pf_btn.Name = "pf_btn";
            pf_btn.Size = new Size(145, 58);
            pf_btn.TabIndex = 1;
            pf_btn.Text = "Playfair";
            pf_btn.UseVisualStyleBackColor = false;
            pf_btn.Click += pf_btn_Click;

            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.BackColor = Color.Transparent;
            lb1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb1.ForeColor = Color.White;
            lb1.Location = new Point(585, 28);
            lb1.Name = "lb1";
            lb1.Size = new Size(114, 67);
            lb1.TabIndex = 2;
            lb1.Text = "RSA";

            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.BackColor = Color.FromArgb(6, 18, 28);
            lb2.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb2.ForeColor = Color.White;
            lb2.Location = new Point(24, 17);
            lb2.Name = "lb2";
            lb2.Padding = new Padding(8, 2, 8, 2);
            lb2.Size = new Size(323, 44);
            lb2.TabIndex = 3;
            lb2.Text = "Choose encrypt type";

            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(6, 18, 28);
            label14.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(225, 250, 255);
            label14.Location = new Point(17, 8);
            label14.Name = "label14";
            label14.Padding = new Padding(7, 2, 7, 2);
            label14.Size = new Size(547, 29);
            label14.TabIndex = 0;
            label14.Text = "RSA using the private and public key - or using only the public key";

            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = null;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(btn_generate);
            panel1.Controls.Add(rtb_q);
            panel1.Controls.Add(rtb_p);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 54);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1258, 130);
            panel1.TabIndex = 5;

            // 
            // btn_generate
            // 
            btn_generate.BackColor = Color.FromArgb(0, 205, 255);
            btn_generate.Cursor = Cursors.Hand;
            btn_generate.FlatAppearance.BorderColor = Color.FromArgb(180, 246, 255);
            btn_generate.FlatAppearance.BorderSize = 2;
            btn_generate.FlatStyle = FlatStyle.Flat;
            btn_generate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_generate.ForeColor = Color.FromArgb(2, 18, 28);
            btn_generate.Location = new Point(982, 27);
            btn_generate.Margin = new Padding(3, 4, 3, 4);
            btn_generate.Name = "btn_generate";
            btn_generate.Size = new Size(252, 76);
            btn_generate.TabIndex = 8;
            btn_generate.Text = "Generate Prime\r\nNumber";
            btn_generate.UseVisualStyleBackColor = false;
            btn_generate.Click += btn_generate_Click;

            // 
            // rtb_q
            // 
            rtb_q.BackColor = Color.FromArgb(245, 250, 255);
            rtb_q.BorderStyle = BorderStyle.FixedSingle;
            rtb_q.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtb_q.ForeColor = Color.FromArgb(5, 18, 28);
            rtb_q.Location = new Point(245, 75);
            rtb_q.Margin = new Padding(3, 4, 3, 4);
            rtb_q.Multiline = false;
            rtb_q.Name = "rtb_q";
            rtb_q.Size = new Size(720, 41);
            rtb_q.TabIndex = 3;
            rtb_q.Text = "";

            // 
            // rtb_p
            // 
            rtb_p.BackColor = Color.FromArgb(245, 250, 255);
            rtb_p.BorderStyle = BorderStyle.FixedSingle;
            rtb_p.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtb_p.ForeColor = Color.FromArgb(5, 18, 28);
            rtb_p.Location = new Point(245, 24);
            rtb_p.Margin = new Padding(3, 4, 3, 4);
            rtb_p.Multiline = false;
            rtb_p.Name = "rtb_p";
            rtb_p.Size = new Size(720, 41);
            rtb_p.TabIndex = 2;
            rtb_p.Text = "";

            // 
            // label3
            // 
            label3.AutoSize = false;
            label3.BackColor = Color.FromArgb(6, 18, 28);
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(17, 77);
            label3.Name = "label3";
            label3.Padding = new Padding(7, 0, 7, 0);
            label3.Size = new Size(205, 34);
            label3.TabIndex = 1;
            label3.Text = "Prime number q";

            // 
            // label2
            // 
            label2.AutoSize = false;
            label2.BackColor = Color.FromArgb(6, 18, 28);
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 26);
            label2.Name = "label2";
            label2.Padding = new Padding(7, 0, 7, 0);
            label2.Size = new Size(205, 34);
            label2.TabIndex = 0;
            label2.Text = "Prime number p";

            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = null;
            panel2.BackgroundImageLayout = ImageLayout.None;
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
            panel2.Location = new Point(0, 188);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1258, 236);
            panel2.TabIndex = 6;

            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(118, 92, 255);
            btn_update.Cursor = Cursors.Hand;
            btn_update.FlatAppearance.BorderColor = Color.FromArgb(210, 205, 255);
            btn_update.FlatAppearance.BorderSize = 2;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(982, 130);
            btn_update.Margin = new Padding(3, 4, 3, 4);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(252, 76);
            btn_update.TabIndex = 9;
            btn_update.Text = "Update Parameters";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;

            // 
            // label7
            // 
            label7.AutoSize = false;
            label7.BackColor = Color.FromArgb(6, 18, 28);
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(982, 29);
            label7.Name = "label7";
            label7.Padding = new Padding(7, 0, 7, 0);
            label7.Size = new Size(118, 34);
            label7.TabIndex = 9;
            label7.Text = "(Public)";

            // 
            // label8
            // 
            label8.AutoSize = false;
            label8.BackColor = Color.FromArgb(6, 18, 28);
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(982, 77);
            label8.Name = "label8";
            label8.Padding = new Padding(7, 0, 7, 0);
            label8.Size = new Size(118, 34);
            label8.TabIndex = 10;
            label8.Text = "(Secret)";

            // 
            // rtb_d
            // 
            rtb_d.BackColor = Color.FromArgb(245, 250, 255);
            rtb_d.BorderStyle = BorderStyle.FixedSingle;
            rtb_d.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtb_d.ForeColor = Color.FromArgb(5, 18, 28);
            rtb_d.Location = new Point(245, 173);
            rtb_d.Margin = new Padding(3, 4, 3, 4);
            rtb_d.Multiline = false;
            rtb_d.Name = "rtb_d";
            rtb_d.Size = new Size(720, 41);
            rtb_d.TabIndex = 15;
            rtb_d.Text = "";

            // 
            // rtb_e
            // 
            rtb_e.BackColor = Color.FromArgb(245, 250, 255);
            rtb_e.BorderStyle = BorderStyle.FixedSingle;
            rtb_e.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtb_e.ForeColor = Color.FromArgb(5, 18, 28);
            rtb_e.Location = new Point(245, 124);
            rtb_e.Margin = new Padding(3, 4, 3, 4);
            rtb_e.Multiline = false;
            rtb_e.Name = "rtb_e";
            rtb_e.Size = new Size(720, 41);
            rtb_e.TabIndex = 14;
            rtb_e.Text = "";

            // 
            // rtb_phi
            // 
            rtb_phi.BackColor = Color.FromArgb(245, 250, 255);
            rtb_phi.BorderStyle = BorderStyle.FixedSingle;
            rtb_phi.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtb_phi.ForeColor = Color.FromArgb(5, 18, 28);
            rtb_phi.Location = new Point(245, 75);
            rtb_phi.Margin = new Padding(3, 4, 3, 4);
            rtb_phi.Multiline = false;
            rtb_phi.Name = "rtb_phi";
            rtb_phi.Size = new Size(720, 41);
            rtb_phi.TabIndex = 13;
            rtb_phi.Text = "";

            // 
            // rtb_modulus
            // 
            rtb_modulus.BackColor = Color.FromArgb(245, 250, 255);
            rtb_modulus.BorderStyle = BorderStyle.FixedSingle;
            rtb_modulus.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtb_modulus.ForeColor = Color.FromArgb(5, 18, 28);
            rtb_modulus.Location = new Point(245, 26);
            rtb_modulus.Margin = new Padding(3, 4, 3, 4);
            rtb_modulus.Multiline = false;
            rtb_modulus.Name = "rtb_modulus";
            rtb_modulus.Size = new Size(720, 41);
            rtb_modulus.TabIndex = 9;
            rtb_modulus.Text = "";

            // 
            // label1
            // 
            label1.AutoSize = false;
            label1.BackColor = Color.FromArgb(6, 18, 28);
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 28);
            label1.Name = "label1";
            label1.Padding = new Padding(7, 0, 7, 0);
            label1.Size = new Size(205, 34);
            label1.TabIndex = 9;
            label1.Text = "RSA modulus N";

            // 
            // label4
            // 
            label4.AutoSize = false;
            label4.BackColor = Color.FromArgb(6, 18, 28);
            label4.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(17, 78);
            label4.Name = "label4";
            label4.Padding = new Padding(7, 0, 7, 0);
            label4.Size = new Size(220, 34);
            label4.TabIndex = 10;
            label4.Text = "phi(N) = (p-1)(q-1)";

            // 
            // label5
            // 
            label5.AutoSize = false;
            label5.BackColor = Color.FromArgb(6, 18, 28);
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(17, 126);
            label5.Name = "label5";
            label5.Padding = new Padding(7, 0, 7, 0);
            label5.Size = new Size(205, 34);
            label5.TabIndex = 11;
            label5.Text = "Public key e";

            // 
            // label6
            // 
            label6.AutoSize = false;
            label6.BackColor = Color.FromArgb(6, 18, 28);
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(17, 176);
            label6.Name = "label6";
            label6.Padding = new Padding(7, 0, 7, 0);
            label6.Size = new Size(205, 34);
            label6.TabIndex = 12;
            label6.Text = "Private key d";

            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = null;
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Controls.Add(rtb_output);
            panel3.Controls.Add(rtb_base);
            panel3.Controls.Add(rtb_seg);
            panel3.Controls.Add(rtb_input);
            panel3.Controls.Add(lb_output);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(lb_input);
            panel3.Location = new Point(3, 435);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1258, 350);
            panel3.TabIndex = 6;

            // 
            // rtb_output
            // 
            rtb_output.BackColor = Color.FromArgb(245, 250, 255);
            rtb_output.BorderStyle = BorderStyle.FixedSingle;
            rtb_output.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtb_output.ForeColor = Color.FromArgb(5, 18, 28);
            rtb_output.Location = new Point(28, 282);
            rtb_output.Margin = new Padding(3, 4, 3, 4);
            rtb_output.Multiline = false;
            rtb_output.Name = "rtb_output";
            rtb_output.Size = new Size(1212, 41);
            rtb_output.TabIndex = 23;
            rtb_output.Text = "";

            // 
            // rtb_base
            // 
            rtb_base.BackColor = Color.FromArgb(245, 250, 255);
            rtb_base.BorderStyle = BorderStyle.FixedSingle;
            rtb_base.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtb_base.ForeColor = Color.FromArgb(5, 18, 28);
            rtb_base.Location = new Point(28, 207);
            rtb_base.Margin = new Padding(3, 4, 3, 4);
            rtb_base.Multiline = false;
            rtb_base.Name = "rtb_base";
            rtb_base.Size = new Size(1212, 41);
            rtb_base.TabIndex = 22;
            rtb_base.Text = "";

            // 
            // rtb_seg
            // 
            rtb_seg.BackColor = Color.FromArgb(245, 250, 255);
            rtb_seg.BorderStyle = BorderStyle.FixedSingle;
            rtb_seg.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtb_seg.ForeColor = Color.FromArgb(5, 18, 28);
            rtb_seg.Location = new Point(28, 132);
            rtb_seg.Margin = new Padding(3, 4, 3, 4);
            rtb_seg.Multiline = false;
            rtb_seg.Name = "rtb_seg";
            rtb_seg.Size = new Size(1212, 41);
            rtb_seg.TabIndex = 21;
            rtb_seg.Text = "";

            // 
            // rtb_input
            // 
            rtb_input.BackColor = Color.FromArgb(245, 250, 255);
            rtb_input.BorderStyle = BorderStyle.FixedSingle;
            rtb_input.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtb_input.ForeColor = Color.FromArgb(5, 18, 28);
            rtb_input.Location = new Point(28, 57);
            rtb_input.Margin = new Padding(3, 4, 3, 4);
            rtb_input.Multiline = false;
            rtb_input.Name = "rtb_input";
            rtb_input.Size = new Size(1212, 41);
            rtb_input.TabIndex = 16;
            rtb_input.Text = "";

            // 
            // lb_output
            // 
            lb_output.AutoSize = true;
            lb_output.BackColor = Color.FromArgb(6, 18, 28);
            lb_output.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_output.ForeColor = Color.White;
            lb_output.Location = new Point(28, 246);
            lb_output.Name = "lb_output";
            lb_output.Padding = new Padding(7, 0, 7, 0);
            lb_output.Size = new Size(112, 32);
            lb_output.TabIndex = 20;
            lb_output.Text = "Output";

            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(6, 18, 28);
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(28, 171);
            label12.Name = "label12";
            label12.Padding = new Padding(7, 0, 7, 0);
            label12.Size = new Size(390, 32);
            label12.TabIndex = 19;
            label12.Text = "Numbers input in base 10 format";

            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(6, 18, 28);
            label11.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(28, 100);
            label11.Name = "label11";
            label11.Padding = new Padding(7, 0, 7, 0);
            label11.Size = new Size(911, 30);
            label11.TabIndex = 18;
            label11.Text = "The input will be seperated into segments of Size 7 (The symbol '#'  is used as seperator)";

            // 
            // lb_input
            // 
            lb_input.AutoSize = true;
            lb_input.BackColor = Color.FromArgb(6, 18, 28);
            lb_input.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_input.ForeColor = Color.White;
            lb_input.Location = new Point(28, 21);
            lb_input.Name = "lb_input";
            lb_input.Padding = new Padding(7, 0, 7, 0);
            lb_input.Size = new Size(92, 32);
            lb_input.TabIndex = 17;
            lb_input.Text = "Input";

            // 
            // btn_decrypt
            // 
            btn_decrypt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_decrypt.Location = new Point(673, 1053);
            btn_decrypt.Margin = new Padding(3, 4, 3, 4);
            btn_decrypt.Name = "btn_decrypt";
            btn_decrypt.Size = new Size(1, 1);
            btn_decrypt.TabIndex = 24;
            btn_decrypt.Text = "Decrypt";
            btn_decrypt.UseVisualStyleBackColor = true;
            btn_decrypt.Visible = false;

            // 
            // btn_encrypt
            // 
            btn_encrypt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_encrypt.Location = new Point(391, 1053);
            btn_encrypt.Margin = new Padding(3, 4, 3, 4);
            btn_encrypt.Name = "btn_encrypt";
            btn_encrypt.Size = new Size(1, 1);
            btn_encrypt.TabIndex = 8;
            btn_encrypt.Text = "Encrypt";
            btn_encrypt.UseVisualStyleBackColor = true;
            btn_encrypt.Visible = false;

            // 
            // pn_rsa
            // 
            pn_rsa.BackColor = Color.Transparent;
            pn_rsa.BackgroundImage = null;
            pn_rsa.BackgroundImageLayout = ImageLayout.None;
            pn_rsa.Controls.Add(btn_de);
            pn_rsa.Controls.Add(btn_en);
            pn_rsa.Controls.Add(panel4);
            pn_rsa.Controls.Add(panel2);
            pn_rsa.Controls.Add(panel1);
            pn_rsa.Controls.Add(panel3);
            pn_rsa.Location = new Point(14, 128);
            pn_rsa.Margin = new Padding(3, 4, 3, 4);
            pn_rsa.Name = "pn_rsa";
            pn_rsa.Size = new Size(1261, 917);
            pn_rsa.TabIndex = 7;

            // 
            // btn_de
            // 
            btn_de.BackColor = Color.FromArgb(118, 92, 255);
            btn_de.Cursor = Cursors.Hand;
            btn_de.FlatAppearance.BorderColor = Color.FromArgb(210, 205, 255);
            btn_de.FlatAppearance.BorderSize = 2;
            btn_de.FlatStyle = FlatStyle.Flat;
            btn_de.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_de.ForeColor = Color.White;
            btn_de.Location = new Point(760, 808);
            btn_de.Name = "btn_de";
            btn_de.Size = new Size(199, 70);
            btn_de.TabIndex = 9;
            btn_de.Text = "Decrypt";
            btn_de.UseVisualStyleBackColor = false;
            btn_de.Click += btn_de_Click;

            // 
            // btn_en
            // 
            btn_en.BackColor = Color.FromArgb(0, 205, 255);
            btn_en.Cursor = Cursors.Hand;
            btn_en.FlatAppearance.BorderColor = Color.FromArgb(180, 246, 255);
            btn_en.FlatAppearance.BorderSize = 2;
            btn_en.FlatStyle = FlatStyle.Flat;
            btn_en.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_en.ForeColor = Color.FromArgb(2, 18, 28);
            btn_en.Location = new Point(305, 808);
            btn_en.Name = "btn_en";
            btn_en.Size = new Size(199, 70);
            btn_en.TabIndex = 7;
            btn_en.Text = "Encrypt";
            btn_en.UseVisualStyleBackColor = false;
            btn_en.Click += btn_en_Click;

            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = null;
            panel4.Controls.Add(label14);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1261, 45);
            panel4.TabIndex = 1;

            // 
            // pn_pf
            // 
            pn_pf.BackColor = Color.Transparent;
            pn_pf.BackgroundImage = null;
            pn_pf.BackgroundImageLayout = ImageLayout.None;
            pn_pf.Location = new Point(14, 128);
            pn_pf.Margin = new Padding(3, 4, 3, 4);
            pn_pf.Name = "pn_pf";
            pn_pf.Size = new Size(1258, 917);
            pn_pf.TabIndex = 8;

            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.background_cyber;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1274, 1055);
            Controls.Add(lb2);
            Controls.Add(lb1);
            Controls.Add(btn_decrypt);
            Controls.Add(pf_btn);
            Controls.Add(btn_encrypt);
            Controls.Add(rsa_btn);
            Controls.Add(pn_rsa);
            Controls.Add(pn_pf);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main";
            Text = "Form1";

            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
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
        private RichTextBox rtb_output;
        private RichTextBox rtb_base;
        private RichTextBox rtb_seg;
        private RichTextBox rtb_input;
        private Label lb_output;
        private Label label12;
        private Label label11;
        private Label lb_input;
        private Label label14;
        private Button btn_decrypt;
        private Button btn_encrypt;
        private Panel pn_pf;
        private Panel panel4;
        private Button btn_en;
        private Button btn_de;
    }
}