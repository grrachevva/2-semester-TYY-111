namespace A_N_1
{
    partial class BlockingButtonsForm
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
            this.Upper = new System.Windows.Forms.Button();
            this.Lower = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Upper
            // 
            this.Upper.Location = new System.Drawing.Point(168, 82);
            this.Upper.Name = "Upper";
            this.Upper.Size = new System.Drawing.Size(232, 78);
            this.Upper.TabIndex = 0;
            this.Upper.Text = "Разблокировать нижнюю кнопку";
            this.Upper.UseVisualStyleBackColor = true;
            this.Upper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bottom1_MouseDown);
            // 
            // Lower
            // 
            this.Lower.Enabled = false;
            this.Lower.Location = new System.Drawing.Point(168, 204);
            this.Lower.Name = "Lower";
            this.Lower.Size = new System.Drawing.Size(232, 78);
            this.Lower.TabIndex = 1;
            this.Lower.Text = "Разблокировать верхнюю кнопку";
            this.Lower.UseVisualStyleBackColor = true;
            this.Lower.MouseDown += new System.Windows.Forms.MouseEventHandler(this.up2_MouseDown);
            // 
            // BlockingButtonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 424);
            this.Controls.Add(this.Lower);
            this.Controls.Add(this.Upper);
            this.Name = "BlockingButtonsForm";
            this.Text = "Blocking Buttons";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Upper;
        private System.Windows.Forms.Button Lower;
    }
}

