namespace listView_Demo
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
            this.demolistView = new System.Windows.Forms.ListView();
            this.listviewhdrLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.homefolderlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // demolistView
            // 
            this.demolistView.GridLines = true;
            this.demolistView.Location = new System.Drawing.Point(232, 87);
            this.demolistView.MultiSelect = false;
            this.demolistView.Name = "demolistView";
            this.demolistView.Size = new System.Drawing.Size(238, 184);
            this.demolistView.TabIndex = 0;
            this.demolistView.UseCompatibleStateImageBehavior = false;
            // 
            // listviewhdrLabel
            // 
            this.listviewhdrLabel.AutoSize = true;
            this.listviewhdrLabel.Location = new System.Drawing.Point(295, 61);
            this.listviewhdrLabel.Name = "listviewhdrLabel";
            this.listviewhdrLabel.Size = new System.Drawing.Size(77, 13);
            this.listviewhdrLabel.TabIndex = 1;
            this.listviewhdrLabel.Text = "ListView Demo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "display files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(36, 41);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 53);
            this.printButton.TabIndex = 3;
            this.printButton.Text = "Print Selection";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(36, 100);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(36, 167);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(39, 13);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Output";
            // 
            // homefolderlabel
            // 
            this.homefolderlabel.AutoSize = true;
            this.homefolderlabel.Location = new System.Drawing.Point(621, 194);
            this.homefolderlabel.Name = "homefolderlabel";
            this.homefolderlabel.Size = new System.Drawing.Size(67, 13);
            this.homefolderlabel.TabIndex = 6;
            this.homefolderlabel.Text = "Home Folder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.homefolderlabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listviewhdrLabel);
            this.Controls.Add(this.demolistView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView demolistView;
        private System.Windows.Forms.Label listviewhdrLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label homefolderlabel;
    }
}

