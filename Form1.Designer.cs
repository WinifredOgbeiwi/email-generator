namespace email_generator
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
            this.name = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.randomNo = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.randomNoTextBox = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.GroupBox();
            this.adminRadioButton = new System.Windows.Forms.RadioButton();
            this.studentRadioButton = new System.Windows.Forms.RadioButton();
            this.generateButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.header = new System.Windows.Forms.Label();
            this.position.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(184, 102);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(51, 20);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(184, 142);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(74, 20);
            this.surname.TabIndex = 1;
            this.surname.Text = "Surname";
            this.surname.Click += new System.EventHandler(this.surname_Click);
            // 
            // randomNo
            // 
            this.randomNo.AutoSize = true;
            this.randomNo.Location = new System.Drawing.Point(184, 184);
            this.randomNo.Name = "randomNo";
            this.randomNo.Size = new System.Drawing.Size(94, 20);
            this.randomNo.TabIndex = 2;
            this.randomNo.Text = "Random No";
            this.randomNo.Click += new System.EventHandler(this.randomNo_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Location = new System.Drawing.Point(303, 99);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(273, 26);
            this.nameTextBox.TabIndex = 3;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surnameTextBox.Location = new System.Drawing.Point(303, 139);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(273, 26);
            this.surnameTextBox.TabIndex = 4;
            // 
            // randomNoTextBox
            // 
            this.randomNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.randomNoTextBox.Location = new System.Drawing.Point(303, 180);
            this.randomNoTextBox.Name = "randomNoTextBox";
            this.randomNoTextBox.Size = new System.Drawing.Size(273, 26);
            this.randomNoTextBox.TabIndex = 5;
            // 
            // position
            // 
            this.position.Controls.Add(this.studentRadioButton);
            this.position.Controls.Add(this.adminRadioButton);
            this.position.Location = new System.Drawing.Point(188, 236);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(147, 100);
            this.position.TabIndex = 6;
            this.position.TabStop = false;
            this.position.Text = "Position";
            // 
            // adminRadioButton
            // 
            this.adminRadioButton.AutoSize = true;
            this.adminRadioButton.Location = new System.Drawing.Point(13, 28);
            this.adminRadioButton.Name = "adminRadioButton";
            this.adminRadioButton.Size = new System.Drawing.Size(79, 24);
            this.adminRadioButton.TabIndex = 7;
            this.adminRadioButton.TabStop = true;
            this.adminRadioButton.Text = "Admin";
            this.adminRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentRadioButton
            // 
            this.studentRadioButton.AutoSize = true;
            this.studentRadioButton.Location = new System.Drawing.Point(13, 66);
            this.studentRadioButton.Name = "studentRadioButton";
            this.studentRadioButton.Size = new System.Drawing.Size(91, 24);
            this.studentRadioButton.TabIndex = 8;
            this.studentRadioButton.TabStop = true;
            this.studentRadioButton.Text = "Student";
            this.studentRadioButton.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(357, 243);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(219, 93);
            this.generateButton.TabIndex = 7;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 372);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(388, 26);
            this.textBox1.TabIndex = 8;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(230, 18);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(325, 46);
            this.header.TabIndex = 9;
            this.header.Text = "Email Generator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.header);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.position);
            this.Controls.Add(this.randomNoTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.randomNo);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.position.ResumeLayout(false);
            this.position.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label randomNo;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox randomNoTextBox;
        private System.Windows.Forms.GroupBox position;
        private System.Windows.Forms.RadioButton adminRadioButton;
        private System.Windows.Forms.RadioButton studentRadioButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label header;
    }
}

