namespace Activity_7
{
    partial class activity7
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.numOfTermsLabel = new System.Windows.Forms.Label();
            this.usersNumTerms = new System.Windows.Forms.TextBox();
            this.userTotalLabel = new System.Windows.Forms.Label();
            this.userTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculateButton.Location = new System.Drawing.Point(35, 108);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(118, 53);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // numOfTermsLabel
            // 
            this.numOfTermsLabel.AutoSize = true;
            this.numOfTermsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfTermsLabel.Location = new System.Drawing.Point(30, 52);
            this.numOfTermsLabel.Name = "numOfTermsLabel";
            this.numOfTermsLabel.Size = new System.Drawing.Size(149, 22);
            this.numOfTermsLabel.TabIndex = 1;
            this.numOfTermsLabel.Text = "Enter # of Terms:";
            this.numOfTermsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // usersNumTerms
            // 
            this.usersNumTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersNumTerms.Location = new System.Drawing.Point(209, 54);
            this.usersNumTerms.Name = "usersNumTerms";
            this.usersNumTerms.Size = new System.Drawing.Size(100, 23);
            this.usersNumTerms.TabIndex = 2;
            // 
            // userTotalLabel
            // 
            this.userTotalLabel.AutoSize = true;
            this.userTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTotalLabel.Location = new System.Drawing.Point(32, 203);
            this.userTotalLabel.Name = "userTotalLabel";
            this.userTotalLabel.Size = new System.Drawing.Size(0, 20);
            this.userTotalLabel.TabIndex = 3;
            // 
            // userTotal
            // 
            this.userTotal.AutoSize = true;
            this.userTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTotal.Location = new System.Drawing.Point(32, 234);
            this.userTotal.Name = "userTotal";
            this.userTotal.Size = new System.Drawing.Size(0, 20);
            this.userTotal.TabIndex = 4;
            this.userTotal.Click += new System.EventHandler(this.userTotal_Click);
            // 
            // activity7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(448, 285);
            this.Controls.Add(this.userTotal);
            this.Controls.Add(this.userTotalLabel);
            this.Controls.Add(this.usersNumTerms);
            this.Controls.Add(this.numOfTermsLabel);
            this.Controls.Add(this.calculateButton);
            this.Name = "activity7";
            this.Text = "Approximate PI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label numOfTermsLabel;
        private System.Windows.Forms.TextBox usersNumTerms;
        private System.Windows.Forms.Label userTotalLabel;
        private System.Windows.Forms.Label userTotal;
    }
}

