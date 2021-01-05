
namespace Doctor
{
    partial class RegAs
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lLogin = new System.Windows.Forms.Button();
            this.lPat = new System.Windows.Forms.Button();
            this.lDoc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lLogin);
            this.groupBox1.Controls.Add(this.lPat);
            this.groupBox1.Controls.Add(this.lDoc);
            this.groupBox1.Location = new System.Drawing.Point(117, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(707, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 316);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "I have already a account";
            // 
            // lLogin
            // 
            this.lLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.lLogin.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLogin.ForeColor = System.Drawing.Color.White;
            this.lLogin.Location = new System.Drawing.Point(203, 340);
            this.lLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(301, 31);
            this.lLogin.TabIndex = 2;
            this.lLogin.Text = "Login";
            this.lLogin.UseVisualStyleBackColor = false;
            this.lLogin.Click += new System.EventHandler(this.lLogin_Click);
            // 
            // lPat
            // 
            this.lPat.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPat.Location = new System.Drawing.Point(367, 175);
            this.lPat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lPat.Name = "lPat";
            this.lPat.Size = new System.Drawing.Size(137, 40);
            this.lPat.TabIndex = 1;
            this.lPat.Text = "Patient";
            this.lPat.UseVisualStyleBackColor = true;
            this.lPat.Click += new System.EventHandler(this.lPat_Click);
            // 
            // lDoc
            // 
            this.lDoc.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDoc.Location = new System.Drawing.Point(203, 175);
            this.lDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lDoc.Name = "lDoc";
            this.lDoc.Size = new System.Drawing.Size(137, 40);
            this.lDoc.TabIndex = 0;
            this.lDoc.Text = "Doctor";
            this.lDoc.UseVisualStyleBackColor = true;
            this.lDoc.Click += new System.EventHandler(this.lDoc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(200, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Type Selection ";
            // 
            // RegAs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Doctor.Properties.Resources.blur_background_patient_waiting_see_doctor_hospital_abstract_background_7189_1097;
            this.ClientSize = new System.Drawing.Size(931, 535);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegAs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegAs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegAs_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button lPat;
        private System.Windows.Forms.Button lDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lLogin;
        private System.Windows.Forms.Label label2;
    }
}