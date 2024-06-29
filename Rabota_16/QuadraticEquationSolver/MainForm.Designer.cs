namespace QuadraticEquationSolver
{
    partial class MainForm
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
            this.coeffALabel = new System.Windows.Forms.Label();
            this.coeffBLabel = new System.Windows.Forms.Label();
            this.coeffCLabel = new System.Windows.Forms.Label();
            this.coeffATextBox = new System.Windows.Forms.TextBox();
            this.coeffBTextBox = new System.Windows.Forms.TextBox();
            this.coeffCTextBox = new System.Windows.Forms.TextBox();
            this.solveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.equationsListBox = new System.Windows.Forms.ListBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.discriminantLabel = new System.Windows.Forms.Label();
            this.root1Label = new System.Windows.Forms.Label();
            this.root2Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // coeffALabel
            // 
            this.coeffALabel.AutoSize = true;
            this.coeffALabel.Location = new System.Drawing.Point(12, 15);
            this.coeffALabel.Name = "coeffALabel";
            this.coeffALabel.Size = new System.Drawing.Size(57, 13);
            this.coeffALabel.TabIndex = 0;
            this.coeffALabel.Text = "Коэфф. a:";
            // 
            // coeffBLabel
            // 
            this.coeffBLabel.AutoSize = true;
            this.coeffBLabel.Location = new System.Drawing.Point(12, 41);
            this.coeffBLabel.Name = "coeffBLabel";
            this.coeffBLabel.Size = new System.Drawing.Size(57, 13);
            this.coeffBLabel.TabIndex = 1;
            this.coeffBLabel.Text = "Коэфф. b:";
            // 
            // coeffCLabel
            // 
            this.coeffCLabel.AutoSize = true;
            this.coeffCLabel.Location = new System.Drawing.Point(12, 67);
            this.coeffCLabel.Name = "coeffCLabel";
            this.coeffCLabel.Size = new System.Drawing.Size(57, 13);
            this.coeffCLabel.TabIndex = 2;
            this.coeffCLabel.Text = "Коэфф. c:";
            // 
            // coeffATextBox
            // 
            this.coeffATextBox.Location = new System.Drawing.Point(91, 12);
            this.coeffATextBox.Name = "coeffATextBox";
            this.coeffATextBox.Size = new System.Drawing.Size(100, 20);
            this.coeffATextBox.TabIndex = 3;
            // 
            // coeffBTextBox
            // 
            this.coeffBTextBox.Location = new System.Drawing.Point(91, 38);
            this.coeffBTextBox.Name = "coeffBTextBox";
            this.coeffBTextBox.Size = new System.Drawing.Size(100, 20);
            this.coeffBTextBox.TabIndex = 4;
            // 
            // coeffCTextBox
            // 
            this.coeffCTextBox.Location = new System.Drawing.Point(91, 64);
            this.coeffCTextBox.Name = "coeffCTextBox";
            this.coeffCTextBox.Size = new System.Drawing.Size(100, 20);
            this.coeffCTextBox.TabIndex = 5;
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(15, 105);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(75, 23);
            this.solveButton.TabIndex = 6;
            this.solveButton.Text = "Решить";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(116, 105);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // equationsListBox
            // 
            this.equationsListBox.FormattingEnabled = true;
            this.equationsListBox.Location = new System.Drawing.Point(310, 12);
            this.equationsListBox.Name = "equationsListBox";
            this.equationsListBox.Size = new System.Drawing.Size(226, 290);
            this.equationsListBox.TabIndex = 8;
            this.equationsListBox.SelectedIndexChanged += new System.EventHandler(this.equationsListBox_SelectedIndexChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusLabel.Location = new System.Drawing.Point(17, 156);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(91, 13);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.Text = "                            ";
            // 
            // discriminantLabel
            // 
            this.discriminantLabel.AutoSize = true;
            this.discriminantLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.discriminantLabel.Location = new System.Drawing.Point(133, 185);
            this.discriminantLabel.Name = "discriminantLabel";
            this.discriminantLabel.Size = new System.Drawing.Size(58, 13);
            this.discriminantLabel.TabIndex = 10;
            this.discriminantLabel.Text = "                 ";
            // 
            // root1Label
            // 
            this.root1Label.AutoSize = true;
            this.root1Label.BackColor = System.Drawing.SystemColors.ControlLight;
            this.root1Label.Location = new System.Drawing.Point(133, 217);
            this.root1Label.Name = "root1Label";
            this.root1Label.Size = new System.Drawing.Size(73, 13);
            this.root1Label.TabIndex = 11;
            this.root1Label.Text = "                      ";
            // 
            // root2Label
            // 
            this.root2Label.AutoSize = true;
            this.root2Label.BackColor = System.Drawing.SystemColors.ControlLight;
            this.root2Label.Location = new System.Drawing.Point(133, 250);
            this.root2Label.Name = "root2Label";
            this.root2Label.Size = new System.Drawing.Size(52, 13);
            this.root2Label.TabIndex = 12;
            this.root2Label.Text = "               ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Дискриминант:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Корень 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Корень 2:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 321);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.root2Label);
            this.Controls.Add(this.root1Label);
            this.Controls.Add(this.discriminantLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.equationsListBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.coeffCTextBox);
            this.Controls.Add(this.coeffBTextBox);
            this.Controls.Add(this.coeffATextBox);
            this.Controls.Add(this.coeffCLabel);
            this.Controls.Add(this.coeffBLabel);
            this.Controls.Add(this.coeffALabel);
            this.Name = "MainForm";
            this.Text = "Решение квадратных уравнений";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label coeffALabel;
        private System.Windows.Forms.Label coeffBLabel;
        private System.Windows.Forms.Label coeffCLabel;
        private System.Windows.Forms.TextBox coeffATextBox;
        private System.Windows.Forms.TextBox coeffBTextBox;
        private System.Windows.Forms.TextBox coeffCTextBox;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListBox equationsListBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label discriminantLabel;
        private System.Windows.Forms.Label root1Label;
        private System.Windows.Forms.Label root2Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
