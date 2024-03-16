namespace ATMSimulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.racebutton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.raceBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.accountPanel = new System.Windows.Forms.Panel();
            this.registerButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pinSetBox = new System.Windows.Forms.TextBox();
            this.accSetBox = new System.Windows.Forms.TextBox();
            this.accountLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.accountPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // racebutton
            // 
            this.racebutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.racebutton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.racebutton.ForeColor = System.Drawing.Color.White;
            this.racebutton.Location = new System.Drawing.Point(95, 173);
            this.racebutton.Name = "racebutton";
            this.racebutton.Size = new System.Drawing.Size(259, 53);
            this.racebutton.TabIndex = 1;
            this.racebutton.Text = "Run Race Condition";
            this.racebutton.UseVisualStyleBackColor = false;
            this.racebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(480, 173);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(259, 53);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // raceBox
            // 
            this.raceBox.AutoSize = true;
            this.raceBox.BackColor = System.Drawing.Color.Transparent;
            this.raceBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceBox.ForeColor = System.Drawing.SystemColors.Control;
            this.raceBox.Location = new System.Drawing.Point(300, 401);
            this.raceBox.Name = "raceBox";
            this.raceBox.Size = new System.Drawing.Size(241, 23);
            this.raceBox.TabIndex = 3;
            this.raceBox.Text = "Application with Race Condition";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(277, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bank of Dundee";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(282, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "Open an Account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // accountPanel
            // 
            this.accountPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("accountPanel.BackgroundImage")));
            this.accountPanel.Controls.Add(this.button2);
            this.accountPanel.Controls.Add(this.registerButton);
            this.accountPanel.Controls.Add(this.label4);
            this.accountPanel.Controls.Add(this.label3);
            this.accountPanel.Controls.Add(this.pinSetBox);
            this.accountPanel.Controls.Add(this.accSetBox);
            this.accountPanel.Controls.Add(this.accountLabel);
            this.accountPanel.Location = new System.Drawing.Point(65, 86);
            this.accountPanel.Name = "accountPanel";
            this.accountPanel.Size = new System.Drawing.Size(674, 338);
            this.accountPanel.TabIndex = 6;
            this.accountPanel.Visible = false;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(239, 302);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(163, 23);
            this.registerButton.TabIndex = 12;
            this.registerButton.Text = "Complete Registeration";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(36, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Set Pin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(36, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Account Number (Auto)";
            // 
            // pinSetBox
            // 
            this.pinSetBox.Location = new System.Drawing.Point(230, 189);
            this.pinSetBox.Name = "pinSetBox";
            this.pinSetBox.Size = new System.Drawing.Size(211, 20);
            this.pinSetBox.TabIndex = 9;
            // 
            // accSetBox
            // 
            this.accSetBox.Enabled = false;
            this.accSetBox.Location = new System.Drawing.Point(230, 142);
            this.accSetBox.Name = "accSetBox";
            this.accSetBox.Size = new System.Drawing.Size(211, 20);
            this.accSetBox.TabIndex = 8;
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.BackColor = System.Drawing.Color.Transparent;
            this.accountLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLabel.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.accountLabel.Location = new System.Drawing.Point(136, 47);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(398, 37);
            this.accountLabel.TabIndex = 7;
            this.accountLabel.Text = "Open an Account with us";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(12, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.accountPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.raceBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.racebutton);
            this.Location = new System.Drawing.Point(20, 30);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bank of Dundee";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.accountPanel.ResumeLayout(false);
            this.accountPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button racebutton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label raceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel accountPanel;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.TextBox accSetBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pinSetBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button button2;
    }
}

