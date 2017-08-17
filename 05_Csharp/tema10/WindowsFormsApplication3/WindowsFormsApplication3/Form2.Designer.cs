namespace WindowsFormsApplication3
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblPriceHour = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtPriceH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(174, 86);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(9, 9);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(121, 13);
            this.lblHours.TabIndex = 1;
            this.lblHours.Text = "HORAS TRABAJADAS:";
            // 
            // lblPriceHour
            // 
            this.lblPriceHour.AutoSize = true;
            this.lblPriceHour.Location = new System.Drawing.Point(46, 42);
            this.lblPriceHour.Name = "lblPriceHour";
            this.lblPriceHour.Size = new System.Drawing.Size(84, 13);
            this.lblPriceHour.TabIndex = 2;
            this.lblPriceHour.Text = "PRECIO HORA:";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(149, 6);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 20);
            this.txtHours.TabIndex = 3;
            // 
            // txtPriceH
            // 
            this.txtPriceH.Location = new System.Drawing.Point(149, 39);
            this.txtPriceH.Name = "txtPriceH";
            this.txtPriceH.Size = new System.Drawing.Size(100, 20);
            this.txtPriceH.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 126);
            this.Controls.Add(this.txtPriceH);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.lblPriceHour);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.btnAccept);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblPriceHour;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtPriceH;
    }
}