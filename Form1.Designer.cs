namespace Simple_calculator
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
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.lbloperator = new System.Windows.Forms.Label();
            this.btnplus = new System.Windows.Forms.Button();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnmines = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(38, 46);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(100, 22);
            this.txtn1.TabIndex = 0;
            // 
            // lbloperator
            // 
            this.lbloperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloperator.Location = new System.Drawing.Point(138, 47);
            this.lbloperator.Name = "lbloperator";
            this.lbloperator.Size = new System.Drawing.Size(82, 21);
            this.lbloperator.TabIndex = 1;
            this.lbloperator.Text = "Operator";
            this.lbloperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(38, 102);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(138, 29);
            this.btnplus.TabIndex = 2;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            this.btnplus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnall_mouseDown);
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(221, 46);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(100, 22);
            this.txtn2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Result:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter numbers:";
            // 
            // lblresult
            // 
            this.lblresult.BackColor = System.Drawing.Color.LightGreen;
            this.lblresult.Location = new System.Drawing.Point(41, 218);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(77, 29);
            this.lblresult.TabIndex = 1;
            this.lblresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnmines
            // 
            this.btnmines.Location = new System.Drawing.Point(183, 102);
            this.btnmines.Name = "btnmines";
            this.btnmines.Size = new System.Drawing.Size(138, 29);
            this.btnmines.TabIndex = 3;
            this.btnmines.Text = "-";
            this.btnmines.UseVisualStyleBackColor = true;
            this.btnmines.Click += new System.EventHandler(this.btnmines_Click);
            this.btnmines.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnall_mouseDown);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(183, 137);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(138, 29);
            this.btnMultiply.TabIndex = 5;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            this.btnMultiply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnall_mouseDown);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(38, 137);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(138, 29);
            this.btndiv.TabIndex = 4;
            this.btndiv.Text = "÷";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            this.btndiv.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnall_mouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 279);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnmines);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbloperator);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Name = "Form1";
            this.Text = "calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.Label lbloperator;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btnmines;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btndiv;
    }
}

