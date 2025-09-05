namespace statist
{
    partial class RoomSettings
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
            PriorityBox = new ComboBox();
            Ok = new Button();
            Cancel = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // PriorityBox
            // 
            PriorityBox.BackColor = SystemColors.GrayText;
            PriorityBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PriorityBox.FlatStyle = FlatStyle.Flat;
            PriorityBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            PriorityBox.ForeColor = SystemColors.Control;
            PriorityBox.FormattingEnabled = true;
            PriorityBox.Items.AddRange(new object[] { "Обязательно", "Рекомендуется", "По желанию" });
            PriorityBox.Location = new Point(12, 47);
            PriorityBox.Name = "PriorityBox";
            PriorityBox.Size = new Size(160, 23);
            PriorityBox.TabIndex = 0;
            PriorityBox.SelectedIndexChanged += PriorityBox_SelectedIndexChanged;
            // 
            // Ok
            // 
            Ok.AccessibleName = "";
            Ok.BackColor = SystemColors.Highlight;
            Ok.FlatStyle = FlatStyle.Flat;
            Ok.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Ok.ForeColor = SystemColors.Control;
            Ok.Location = new Point(184, 47);
            Ok.Name = "Ok";
            Ok.Size = new Size(75, 23);
            Ok.TabIndex = 1;
            Ok.Text = "Ok";
            Ok.UseVisualStyleBackColor = false;
            Ok.Click += Ok_Click;
            // 
            // Cancel
            // 
            Cancel.AccessibleName = "";
            Cancel.BackColor = SystemColors.Highlight;
            Cancel.FlatStyle = FlatStyle.Flat;
            Cancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Cancel.ForeColor = SystemColors.Control;
            Cancel.Location = new Point(271, 47);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 23);
            Cancel.TabIndex = 2;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += Cancel_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox1.ForeColor = SystemColors.Control;
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 22);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // RoomSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(358, 82);
            Controls.Add(textBox1);
            Controls.Add(Cancel);
            Controls.Add(Ok);
            Controls.Add(PriorityBox);
            Name = "RoomSettings";
            Text = "Параметры комнаты";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox PriorityBox;
        private Button Ok;
        private Button Cancel;
        private TextBox textBox1;
    }
}