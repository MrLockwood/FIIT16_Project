namespace BugTracer
{
    partial class Login
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(13, 54);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(315, 20);
            this.NameBox.TabIndex = 0;
            this.NameBox.Text = "Name";
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(13, 92);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(315, 20);
            this.PassBox.TabIndex = 1;
            this.PassBox.Text = "Password";
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(13, 134);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(75, 23);
            this.Enter.TabIndex = 2;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.NameBox);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Label label1;
    }
}