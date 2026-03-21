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
            rtb_p = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 0);
            label1.Name = "label1";
            label1.Size = new Size(306, 30);
            label1.TabIndex = 7;
            label1.Text = "Short version of the Playfair key";
            // 
            // radiobtn_6
            // 
            radiobtn_6.AutoSize = true;
            radiobtn_6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radiobtn_6.Location = new Point(673, 111);
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
            radiobtn_5.Location = new Point(673, 71);
            radiobtn_5.Name = "radiobtn_5";
            radiobtn_5.Size = new Size(127, 34);
            radiobtn_5.TabIndex = 5;
            radiobtn_5.TabStop = true;
            radiobtn_5.Text = "5x5 matrix";
            radiobtn_5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(21, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 600);
            panel1.TabIndex = 4;
            // 
            // rtb_p
            // 
            rtb_p.Location = new Point(21, 33);
            rtb_p.Name = "rtb_p";
            rtb_p.Size = new Size(885, 32);
            rtb_p.TabIndex = 3;
            rtb_p.Text = "";
            // 
            // Playfair
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(radiobtn_6);
            Controls.Add(label1);
            Controls.Add(radiobtn_5);
            Controls.Add(panel1);
            Controls.Add(rtb_p);
            Name = "Playfair";
            Size = new Size(1103, 692);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private RichTextBox rtb_p;
        private RadioButton radiobtn_6;
        private RadioButton radiobtn_5;
        private Label label1;
    }
}
