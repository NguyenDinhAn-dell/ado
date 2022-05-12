
namespace ado1
{
    partial class login
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
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(82, 102);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(55, 13);
            this.l1.TabIndex = 0;
            this.l1.Text = "Username";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(84, 143);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(53, 13);
            this.l2.TabIndex = 1;
            this.l2.Text = "Password";
            this.l2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(165, 99);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(173, 20);
            this.txt1.TabIndex = 2;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(165, 136);
            this.txt2.Name = "txt2";
            this.txt2.PasswordChar = '*';
            this.txt2.Size = new System.Drawing.Size(173, 20);
            this.txt2.TabIndex = 3;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(131, 182);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(58, 23);
            this.btnok.TabIndex = 4;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(247, 182);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(58, 23);
            this.btnc.TabIndex = 5;
            this.btnc.Text = "Cancel\r\n";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 358);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnc;
    }
}

