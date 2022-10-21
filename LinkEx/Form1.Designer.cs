
namespace linqEx1
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
            this.btnCounties = new System.Windows.Forms.Button();
            this.lstCounties = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCounties
            // 
            this.btnCounties.Location = new System.Drawing.Point(58, 53);
            this.btnCounties.Name = "btnCounties";
            this.btnCounties.Size = new System.Drawing.Size(189, 60);
            this.btnCounties.TabIndex = 0;
            this.btnCounties.Text = "Get Counties";
            this.btnCounties.UseVisualStyleBackColor = true;
            this.btnCounties.Click += new System.EventHandler(this.btnCounties_Click);
            // 
            // lstCounties
            // 
            this.lstCounties.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCounties.FormattingEnabled = true;
            this.lstCounties.ItemHeight = 25;
            this.lstCounties.Location = new System.Drawing.Point(58, 162);
            this.lstCounties.Name = "lstCounties";
            this.lstCounties.Size = new System.Drawing.Size(246, 179);
            this.lstCounties.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstCounties);
            this.Controls.Add(this.btnCounties);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCounties;
        private System.Windows.Forms.ListBox lstCounties;
    }
}

