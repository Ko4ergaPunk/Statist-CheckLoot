namespace statist
{
    partial class EntityProperties
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
            MinBox = new TextBox();
            Ok = new Button();
            Cancel = new Button();
            MaxBox = new TextBox();
            BoxName = new TextBox();
            CheckBoxIsCategory = new CheckBox();
            BoxIncludedItems = new ComboBox();
            Add = new Button();
            Remove = new Button();
            SuspendLayout();
            // 
            // MinBox
            // 
            MinBox.BorderStyle = BorderStyle.None;
            MinBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            MinBox.ForeColor = SystemColors.Control;
            MinBox.Location = new Point(99, 47);
            MinBox.Name = "MinBox";
            MinBox.Size = new Size(75, 22);
            MinBox.TabIndex = 0;
            MinBox.TextChanged += MinBox_TextChanged;
            // 
            // Ok
            // 
            Ok.BackColor = SystemColors.Highlight;
            Ok.FlatStyle = FlatStyle.Flat;
            Ok.ForeColor = SystemColors.Control;
            Ok.Location = new Point(186, 47);
            Ok.Name = "Ok";
            Ok.Size = new Size(75, 23);
            Ok.TabIndex = 1;
            Ok.Text = "OK";
            Ok.UseVisualStyleBackColor = false;
            Ok.Click += Ok_Click;
            // 
            // Cancel
            // 
            Cancel.BackColor = SystemColors.Highlight;
            Cancel.FlatStyle = FlatStyle.Flat;
            Cancel.ForeColor = SystemColors.Control;
            Cancel.Location = new Point(271, 47);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 23);
            Cancel.TabIndex = 2;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += Cancel_Click;
            // 
            // MaxBox
            // 
            MaxBox.BorderStyle = BorderStyle.None;
            MaxBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            MaxBox.ForeColor = SystemColors.Control;
            MaxBox.Location = new Point(12, 47);
            MaxBox.Name = "MaxBox";
            MaxBox.Size = new Size(75, 22);
            MaxBox.TabIndex = 3;
            MaxBox.TextChanged += MaxBox_TextChanged;
            // 
            // BoxName
            // 
            BoxName.BorderStyle = BorderStyle.None;
            BoxName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            BoxName.ForeColor = SystemColors.Control;
            BoxName.Location = new Point(12, 12);
            BoxName.Name = "BoxName";
            BoxName.Size = new Size(334, 22);
            BoxName.TabIndex = 5;
            BoxName.TextChanged += BoxName_TextChanged;
            // 
            // CheckBoxIsCategory
            // 
            CheckBoxIsCategory.AutoSize = true;
            CheckBoxIsCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            CheckBoxIsCategory.ForeColor = SystemColors.Control;
            CheckBoxIsCategory.Location = new Point(12, 75);
            CheckBoxIsCategory.Name = "CheckBoxIsCategory";
            CheckBoxIsCategory.Size = new Size(190, 25);
            CheckBoxIsCategory.TabIndex = 6;
            CheckBoxIsCategory.Text = "Является категорией";
            CheckBoxIsCategory.UseVisualStyleBackColor = true;
            CheckBoxIsCategory.CheckedChanged += CheckBoxIsCategory_CheckedChanged;
            // 
            // BoxIncludedItems
            // 
            BoxIncludedItems.FlatStyle = FlatStyle.Flat;
            BoxIncludedItems.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            BoxIncludedItems.ForeColor = SystemColors.Control;
            BoxIncludedItems.FormattingEnabled = true;
            BoxIncludedItems.Location = new Point(12, 104);
            BoxIncludedItems.Name = "BoxIncludedItems";
            BoxIncludedItems.Size = new Size(276, 29);
            BoxIncludedItems.TabIndex = 7;
            BoxIncludedItems.SelectedIndexChanged += BoxIncludedItems_SelectedIndexChanged;
            // 
            // Add
            // 
            Add.BackColor = SystemColors.Highlight;
            Add.FlatStyle = FlatStyle.Flat;
            Add.Font = new Font("Cascadia Mono", 9F, FontStyle.Bold);
            Add.ForeColor = SystemColors.Control;
            Add.Location = new Point(288, 104);
            Add.Name = "Add";
            Add.Padding = new Padding(3, 2, 0, 0);
            Add.Size = new Size(29, 29);
            Add.TabIndex = 8;
            Add.Text = "＋";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Remove
            // 
            Remove.BackColor = SystemColors.Highlight;
            Remove.FlatStyle = FlatStyle.Flat;
            Remove.Font = new Font("Cascadia Mono", 9F, FontStyle.Bold);
            Remove.ForeColor = SystemColors.Control;
            Remove.Location = new Point(317, 104);
            Remove.Name = "Remove";
            Remove.Padding = new Padding(1, 0, 0, 0);
            Remove.Size = new Size(29, 29);
            Remove.TabIndex = 9;
            Remove.Text = "—";
            Remove.UseVisualStyleBackColor = false;
            Remove.Click += Remove_Click;
            // 
            // EntityProperties
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(358, 145);
            Controls.Add(Remove);
            Controls.Add(Add);
            Controls.Add(BoxIncludedItems);
            Controls.Add(CheckBoxIsCategory);
            Controls.Add(BoxName);
            Controls.Add(MaxBox);
            Controls.Add(Cancel);
            Controls.Add(Ok);
            Controls.Add(MinBox);
            Name = "EntityProperties";
            Text = "Параметры предмета";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MinBox;
        private Button Ok;
        private Button Cancel;
        private TextBox MaxBox;
        private TextBox BoxName;
        private CheckBox CheckBoxIsCategory;
        private ComboBox BoxIncludedItems;
        private Button Add;
        private Button Remove;
    }
}