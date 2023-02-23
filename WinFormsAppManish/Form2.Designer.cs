namespace WinFormsAppManish
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter 1st Number";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(77, 77);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(368, 27);
            this.txtN1.TabIndex = 1;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(77, 156);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(368, 27);
            this.txtN2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter 2nd Number";
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(77, 204);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(94, 29);
            this.btnSum.TabIndex = 4;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(85, 297);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(18, 20);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "...";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtN1;
        private TextBox txtN2;
        private Label label2;
        private Button btnSum;
        private Label label3;
        private Label lblResult;
    }
}