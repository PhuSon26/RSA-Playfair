namespace RSA_Playfair
{
    partial class Playfair
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            radiobtn_6 = new RadioButton();
            radiobtn_5 = new RadioButton();
            panel1 = new Panel();
            label2 = new Label();
            btn_encrypt = new Button();
            richTextBox20 = new RichTextBox();
            richTextBox25 = new RichTextBox();
            richTextBox24 = new RichTextBox();
            richTextBox19 = new RichTextBox();
            richTextBox15 = new RichTextBox();
            richTextBox14 = new RichTextBox();
            richTextBox23 = new RichTextBox();
            richTextBox18 = new RichTextBox();
            richTextBox13 = new RichTextBox();
            richTextBox10 = new RichTextBox();
            richTextBox9 = new RichTextBox();
            richTextBox8 = new RichTextBox();
            richTextBox22 = new RichTextBox();
            richTextBox17 = new RichTextBox();
            richTextBox12 = new RichTextBox();
            richTextBox7 = new RichTextBox();
            richTextBox21 = new RichTextBox();
            richTextBox16 = new RichTextBox();
            richTextBox11 = new RichTextBox();
            richTextBox6 = new RichTextBox();
            richTextBox5 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            rtb_key = new RichTextBox();
            rtb_output = new RichTextBox();
            rtb_input = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            btn_decrypt = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 7;
            label1.Text = "Playfair key";
            // 
            // radiobtn_6
            // 
            radiobtn_6.AutoSize = true;
            radiobtn_6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radiobtn_6.Location = new Point(763, 3);
            radiobtn_6.Name = "radiobtn_6";
            radiobtn_6.Size = new Size(127, 34);
            radiobtn_6.TabIndex = 6;
            radiobtn_6.TabStop = true;
            radiobtn_6.Text = "6x6 matrix";
            radiobtn_6.UseVisualStyleBackColor = true;
            // 
            // radiobtn_5
            // 
            radiobtn_5.AutoSize = true;
            radiobtn_5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radiobtn_5.Location = new Point(630, 3);
            radiobtn_5.Name = "radiobtn_5";
            radiobtn_5.Size = new Size(127, 34);
            radiobtn_5.TabIndex = 5;
            radiobtn_5.TabStop = true;
            radiobtn_5.Text = "5x5 matrix";
            radiobtn_5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(richTextBox20);
            panel1.Controls.Add(richTextBox25);
            panel1.Controls.Add(richTextBox24);
            panel1.Controls.Add(richTextBox19);
            panel1.Controls.Add(richTextBox15);
            panel1.Controls.Add(richTextBox14);
            panel1.Controls.Add(richTextBox23);
            panel1.Controls.Add(richTextBox18);
            panel1.Controls.Add(richTextBox13);
            panel1.Controls.Add(richTextBox10);
            panel1.Controls.Add(richTextBox9);
            panel1.Controls.Add(richTextBox8);
            panel1.Controls.Add(richTextBox22);
            panel1.Controls.Add(richTextBox17);
            panel1.Controls.Add(richTextBox12);
            panel1.Controls.Add(richTextBox7);
            panel1.Controls.Add(richTextBox21);
            panel1.Controls.Add(richTextBox16);
            panel1.Controls.Add(richTextBox11);
            panel1.Controls.Add(richTextBox6);
            panel1.Controls.Add(richTextBox5);
            panel1.Controls.Add(richTextBox4);
            panel1.Controls.Add(richTextBox3);
            panel1.Controls.Add(richTextBox2);
            panel1.Controls.Add(richTextBox1);
            panel1.Location = new Point(21, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 600);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 538);
            label2.Name = "label2";
            label2.Size = new Size(111, 30);
            label2.TabIndex = 8;
            label2.Text = "Key Matrix";
            // 
            // btn_encrypt
            // 
            btn_encrypt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_encrypt.Location = new Point(374, 691);
            btn_encrypt.Name = "btn_encrypt";
            btn_encrypt.Size = new Size(178, 47);
            btn_encrypt.TabIndex = 12;
            btn_encrypt.Text = "Encrypt";
            btn_encrypt.UseVisualStyleBackColor = true;
            btn_encrypt.Click += btn_encrypt_Click;
            // 
            // richTextBox20
            // 
            richTextBox20.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox20.Location = new Point(425, 293);
            richTextBox20.Name = "richTextBox20";
            richTextBox20.ReadOnly = true;
            richTextBox20.Size = new Size(50, 50);
            richTextBox20.TabIndex = 30;
            richTextBox20.Text = "";
            // 
            // richTextBox25
            // 
            richTextBox25.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox25.Location = new Point(425, 376);
            richTextBox25.Name = "richTextBox25";
            richTextBox25.ReadOnly = true;
            richTextBox25.Size = new Size(50, 50);
            richTextBox25.TabIndex = 29;
            richTextBox25.Text = "";
            // 
            // richTextBox24
            // 
            richTextBox24.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox24.Location = new Point(331, 376);
            richTextBox24.Name = "richTextBox24";
            richTextBox24.ReadOnly = true;
            richTextBox24.Size = new Size(50, 50);
            richTextBox24.TabIndex = 28;
            richTextBox24.Text = "";
            // 
            // richTextBox19
            // 
            richTextBox19.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox19.Location = new Point(331, 293);
            richTextBox19.Name = "richTextBox19";
            richTextBox19.ReadOnly = true;
            richTextBox19.Size = new Size(50, 50);
            richTextBox19.TabIndex = 27;
            richTextBox19.Text = "";
            // 
            // richTextBox15
            // 
            richTextBox15.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox15.Location = new Point(425, 206);
            richTextBox15.Name = "richTextBox15";
            richTextBox15.ReadOnly = true;
            richTextBox15.Size = new Size(50, 50);
            richTextBox15.TabIndex = 25;
            richTextBox15.Text = "";
            // 
            // richTextBox14
            // 
            richTextBox14.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox14.Location = new Point(331, 206);
            richTextBox14.Name = "richTextBox14";
            richTextBox14.ReadOnly = true;
            richTextBox14.Size = new Size(50, 50);
            richTextBox14.TabIndex = 24;
            richTextBox14.Text = "";
            // 
            // richTextBox23
            // 
            richTextBox23.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox23.Location = new Point(232, 376);
            richTextBox23.Name = "richTextBox23";
            richTextBox23.ReadOnly = true;
            richTextBox23.Size = new Size(50, 50);
            richTextBox23.TabIndex = 22;
            richTextBox23.Text = "";
            // 
            // richTextBox18
            // 
            richTextBox18.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox18.Location = new Point(232, 293);
            richTextBox18.Name = "richTextBox18";
            richTextBox18.ReadOnly = true;
            richTextBox18.Size = new Size(50, 50);
            richTextBox18.TabIndex = 21;
            richTextBox18.Text = "";
            // 
            // richTextBox13
            // 
            richTextBox13.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox13.Location = new Point(232, 206);
            richTextBox13.Name = "richTextBox13";
            richTextBox13.ReadOnly = true;
            richTextBox13.Size = new Size(50, 50);
            richTextBox13.TabIndex = 20;
            richTextBox13.Text = "";
            // 
            // richTextBox10
            // 
            richTextBox10.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox10.Location = new Point(425, 124);
            richTextBox10.Name = "richTextBox10";
            richTextBox10.ReadOnly = true;
            richTextBox10.Size = new Size(50, 50);
            richTextBox10.TabIndex = 18;
            richTextBox10.Text = "";
            // 
            // richTextBox9
            // 
            richTextBox9.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox9.Location = new Point(331, 124);
            richTextBox9.Name = "richTextBox9";
            richTextBox9.ReadOnly = true;
            richTextBox9.Size = new Size(50, 50);
            richTextBox9.TabIndex = 17;
            richTextBox9.Text = "";
            // 
            // richTextBox8
            // 
            richTextBox8.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox8.Location = new Point(232, 124);
            richTextBox8.Name = "richTextBox8";
            richTextBox8.ReadOnly = true;
            richTextBox8.Size = new Size(50, 50);
            richTextBox8.TabIndex = 16;
            richTextBox8.Text = "";
            // 
            // richTextBox22
            // 
            richTextBox22.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox22.Location = new Point(134, 376);
            richTextBox22.Name = "richTextBox22";
            richTextBox22.ReadOnly = true;
            richTextBox22.Size = new Size(50, 50);
            richTextBox22.TabIndex = 14;
            richTextBox22.Text = "";
            // 
            // richTextBox17
            // 
            richTextBox17.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox17.Location = new Point(134, 293);
            richTextBox17.Name = "richTextBox17";
            richTextBox17.ReadOnly = true;
            richTextBox17.Size = new Size(50, 50);
            richTextBox17.TabIndex = 13;
            richTextBox17.Text = "";
            // 
            // richTextBox12
            // 
            richTextBox12.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox12.Location = new Point(134, 206);
            richTextBox12.Name = "richTextBox12";
            richTextBox12.ReadOnly = true;
            richTextBox12.Size = new Size(50, 50);
            richTextBox12.TabIndex = 12;
            richTextBox12.Text = "";
            // 
            // richTextBox7
            // 
            richTextBox7.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox7.Location = new Point(134, 124);
            richTextBox7.Name = "richTextBox7";
            richTextBox7.ReadOnly = true;
            richTextBox7.Size = new Size(50, 50);
            richTextBox7.TabIndex = 11;
            richTextBox7.Text = "";
            // 
            // richTextBox21
            // 
            richTextBox21.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox21.Location = new Point(38, 376);
            richTextBox21.Name = "richTextBox21";
            richTextBox21.ReadOnly = true;
            richTextBox21.Size = new Size(50, 50);
            richTextBox21.TabIndex = 9;
            richTextBox21.Text = "";
            // 
            // richTextBox16
            // 
            richTextBox16.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox16.Location = new Point(38, 293);
            richTextBox16.Name = "richTextBox16";
            richTextBox16.ReadOnly = true;
            richTextBox16.Size = new Size(50, 50);
            richTextBox16.TabIndex = 8;
            richTextBox16.Text = "";
            // 
            // richTextBox11
            // 
            richTextBox11.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox11.Location = new Point(38, 206);
            richTextBox11.Name = "richTextBox11";
            richTextBox11.ReadOnly = true;
            richTextBox11.Size = new Size(50, 50);
            richTextBox11.TabIndex = 7;
            richTextBox11.Text = "";
            // 
            // richTextBox6
            // 
            richTextBox6.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox6.Location = new Point(38, 124);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.ReadOnly = true;
            richTextBox6.Size = new Size(50, 50);
            richTextBox6.TabIndex = 6;
            richTextBox6.Text = "";
            // 
            // richTextBox5
            // 
            richTextBox5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox5.Location = new Point(425, 33);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.ReadOnly = true;
            richTextBox5.Size = new Size(50, 50);
            richTextBox5.TabIndex = 4;
            richTextBox5.Text = "";
            // 
            // richTextBox4
            // 
            richTextBox4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox4.Location = new Point(331, 33);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.ReadOnly = true;
            richTextBox4.Size = new Size(50, 50);
            richTextBox4.TabIndex = 3;
            richTextBox4.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox3.Location = new Point(232, 33);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new Size(50, 50);
            richTextBox3.TabIndex = 2;
            richTextBox3.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox2.Location = new Point(134, 33);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(50, 50);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(38, 33);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(50, 50);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // rtb_key
            // 
            rtb_key.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtb_key.Location = new Point(21, 33);
            rtb_key.Name = "rtb_key";
            rtb_key.Size = new Size(600, 32);
            rtb_key.TabIndex = 3;
            rtb_key.Text = "";
            // 
            // rtb_output
            // 
            rtb_output.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtb_output.Location = new Point(630, 390);
            rtb_output.Name = "rtb_output";
            rtb_output.ReadOnly = true;
            rtb_output.Size = new Size(473, 281);
            rtb_output.TabIndex = 8;
            rtb_output.Text = "";
            // 
            // rtb_input
            // 
            rtb_input.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtb_input.Location = new Point(630, 71);
            rtb_input.Name = "rtb_input";
            rtb_input.Size = new Size(473, 280);
            rtb_input.TabIndex = 9;
            rtb_input.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(630, 354);
            label3.Name = "label3";
            label3.Size = new Size(79, 30);
            label3.TabIndex = 10;
            label3.Text = "Output";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(630, 40);
            label4.Name = "label4";
            label4.Size = new Size(62, 30);
            label4.TabIndex = 11;
            label4.Text = "Input";
            // 
            // btn_decrypt
            // 
            btn_decrypt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_decrypt.Location = new Point(596, 691);
            btn_decrypt.Name = "btn_decrypt";
            btn_decrypt.Size = new Size(178, 47);
            btn_decrypt.TabIndex = 25;
            btn_decrypt.Text = "Decrypt";
            btn_decrypt.UseVisualStyleBackColor = true;
            btn_decrypt.Click += btn_decrypt_Click;
            // 
            // Playfair
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_decrypt);
            Controls.Add(btn_encrypt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(rtb_input);
            Controls.Add(rtb_output);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(radiobtn_6);
            Controls.Add(rtb_key);
            Controls.Add(radiobtn_5);
            Name = "Playfair";
            Size = new Size(1103, 741);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private RichTextBox rtb_key;
        private RadioButton radiobtn_6;
        private RadioButton radiobtn_5;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox20;
        private RichTextBox richTextBox25;
        private RichTextBox richTextBox24;
        private RichTextBox richTextBox19;
        private RichTextBox richTextBox15;
        private RichTextBox richTextBox14;
        private RichTextBox richTextBox23;
        private RichTextBox richTextBox18;
        private RichTextBox richTextBox13;
        private RichTextBox richTextBox10;
        private RichTextBox richTextBox9;
        private RichTextBox richTextBox8;
        private RichTextBox richTextBox22;
        private RichTextBox richTextBox17;
        private RichTextBox richTextBox12;
        private RichTextBox richTextBox7;
        private RichTextBox richTextBox21;
        private RichTextBox richTextBox16;
        private RichTextBox richTextBox11;
        private RichTextBox richTextBox6;
        private RichTextBox richTextBox5;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        public RichTextBox rtb_output;
        public RichTextBox rtb_input;
        private Label label3;
        private Label label4;
        private Button btn_encrypt;
        private Button btn_decrypt;
    }
}
