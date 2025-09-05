namespace statist
{
    partial class InputForm
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
            textBox1 = new TextBox();
            Ok = new Button();
            Cancel = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.ForeColor = SystemColors.Control;
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 22);
            textBox1.TabIndex = 0;
            // 
            // Ok
            // 
            Ok.BackColor = SystemColors.Highlight;
            Ok.FlatStyle = FlatStyle.Flat;
            Ok.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Ok.ForeColor = SystemColors.Control;
            Ok.Location = new Point(377, 12);
            Ok.Name = "Ok";
            Ok.Size = new Size(75, 23);
            Ok.TabIndex = 1;
            Ok.Text = "ОК";
            Ok.UseVisualStyleBackColor = false;
            Ok.Click += Ok_Click;
            // 
            // Cancel
            // 
            Cancel.BackColor = SystemColors.Highlight;
            Cancel.FlatStyle = FlatStyle.Flat;
            Cancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Cancel.ForeColor = SystemColors.Control;
            Cancel.Location = new Point(464, 12);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 23);
            Cancel.TabIndex = 1;
            Cancel.Text = "Отмена";
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += Cancel_Click;
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(551, 47);
            Controls.Add(Cancel);
            Controls.Add(Ok);
            Controls.Add(textBox1);
            Name = "InputForm";
            Text = "Добавить объект";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button Ok;
        private Button Cancel;
    }
}