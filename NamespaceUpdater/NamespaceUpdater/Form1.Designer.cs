namespace NamespaceUpdater
{
    partial class Form1
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
            directoryTextBox = new TextBox();
            label2 = new Label();
            prefixTextBox = new TextBox();
            executeButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "Ścieżka do solucji:";
            // 
            // directoryTextBox
            // 
            directoryTextBox.Location = new Point(147, 6);
            directoryTextBox.Name = "directoryTextBox";
            directoryTextBox.Size = new Size(125, 27);
            directoryTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 43);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 2;
            label2.Text = "Prefix firmy:";
            // 
            // prefixTextBox
            // 
            prefixTextBox.Location = new Point(147, 40);
            prefixTextBox.Name = "prefixTextBox";
            prefixTextBox.Size = new Size(125, 27);
            prefixTextBox.TabIndex = 3;
            // 
            // executeButton
            // 
            executeButton.Location = new Point(12, 82);
            executeButton.Name = "executeButton";
            executeButton.Size = new Size(94, 29);
            executeButton.TabIndex = 4;
            executeButton.Text = "Wykonaj";
            executeButton.UseVisualStyleBackColor = true;
            executeButton.Click += executeButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 122);
            Controls.Add(executeButton);
            Controls.Add(prefixTextBox);
            Controls.Add(label2);
            Controls.Add(directoryTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox directoryTextBox;
        private Label label2;
        private TextBox prefixTextBox;
        private Button executeButton;
    }
}
