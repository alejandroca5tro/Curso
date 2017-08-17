namespace WindowsFormsApplication1
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
            this.btnSaludar = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaludar
            // 
            this.btnSaludar.AccessibleDescription = "Botón Saludar";
            this.btnSaludar.Location = new System.Drawing.Point(91, 352);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(80, 35);
            this.btnSaludar.TabIndex = 0;
            this.btnSaludar.Text = "Saludar";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl1.Location = new System.Drawing.Point(10, 12);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(59, 15);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "1º Número";
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(91, 12);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(58, 20);
            this.txtBox1.TabIndex = 2;
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(91, 45);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(58, 20);
            this.txtBox2.TabIndex = 3;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl2.Location = new System.Drawing.Point(10, 45);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(59, 15);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "2º Número";
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleDescription = "Botón Saludar";
            this.btnAdd.Location = new System.Drawing.Point(91, 139);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 39);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Sumar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRes.Location = new System.Drawing.Point(91, 89);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(2, 15);
            this.lblRes.TabIndex = 6;
            this.lblRes.Visible = false;
            this.lblRes.Click += new System.EventHandler(this.lblRes_Click);
            // 
            // btnSub
            // 
            this.btnSub.AccessibleDescription = "Botón Saludar";
            this.btnSub.Location = new System.Drawing.Point(91, 205);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(80, 36);
            this.btnSub.TabIndex = 7;
            this.btnSub.Text = "Restar";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnReset
            // 
            this.btnReset.AccessibleDescription = "Botón Saludar";
            this.btnReset.Location = new System.Drawing.Point(91, 285);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 36);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 398);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnSaludar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnReset;
    }
}

