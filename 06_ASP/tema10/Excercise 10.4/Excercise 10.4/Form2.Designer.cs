namespace Excercise_10._4
{
    partial class Form2
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
            this.txtWholeName = new System.Windows.Forms.TextBox();
            this.lblCncName = new System.Windows.Forms.Label();
            this.lblLivedDays = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtWholeName
            // 
            this.txtWholeName.Location = new System.Drawing.Point(132, 71);
            this.txtWholeName.Name = "txtWholeName";
            this.txtWholeName.Size = new System.Drawing.Size(139, 20);
            this.txtWholeName.TabIndex = 0;
            this.txtWholeName.BorderStyleChanged += new System.EventHandler(this.button1_Click);
            this.txtWholeName.Click += new System.EventHandler(this.txtWholeName_Click);
            // 
            // lblCncName
            // 
            this.lblCncName.AutoSize = true;
            this.lblCncName.Location = new System.Drawing.Point(12, 74);
            this.lblCncName.Name = "lblCncName";
            this.lblCncName.Size = new System.Drawing.Size(114, 13);
            this.lblCncName.TabIndex = 1;
            this.lblCncName.Text = "Nombre Concatenado:";
            // 
            // lblLivedDays
            // 
            this.lblLivedDays.AutoSize = true;
            this.lblLivedDays.Location = new System.Drawing.Point(12, 110);
            this.lblLivedDays.Name = "lblLivedDays";
            this.lblLivedDays.Size = new System.Drawing.Size(69, 13);
            this.lblLivedDays.TabIndex = 3;
            this.lblLivedDays.Text = "Días vividos:";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(132, 110);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 20);
            this.txtDays.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(132, 23);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(256, 23);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 200);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLivedDays);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.lblCncName);
            this.Controls.Add(this.txtWholeName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWholeName;
        private System.Windows.Forms.Label lblCncName;
        private System.Windows.Forms.Label lblLivedDays;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}