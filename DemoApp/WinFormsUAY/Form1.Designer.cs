namespace WinFormsUAY
{
    partial class FirstName
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            LastName = new Label();
            firstNameText = new TextBox();
            lastNameText = new TextBox();
            combineName = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 64);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name";
          
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Location = new Point(91, 126);
            LastName.Name = "LastName";
            LastName.Size = new Size(79, 20);
            LastName.TabIndex = 1;
            LastName.Text = "Last Name";
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(314, 67);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(249, 27);
            firstNameText.TabIndex = 2;
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(314, 126);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(249, 27);
            lastNameText.TabIndex = 3;
            // 
            // combineName
            // 
            combineName.Location = new Point(181, 231);
            combineName.Name = "combineName";
            combineName.Size = new Size(289, 74);
            combineName.TabIndex = 4;
            combineName.Text = "Combine Name";
            combineName.Click += new EventHandler(combineName_Click);
            combineName.UseVisualStyleBackColor = true;
            // 
            // FirstName
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(combineName);
            Controls.Add(lastNameText);
            Controls.Add(firstNameText);
            Controls.Add(LastName);
            Controls.Add(label1);
            Name = "FirstName";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LastName;
        private TextBox firstNameText;
        private TextBox lastNameText;
        private Button combineName;
    }
}