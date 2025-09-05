namespace statist
{
    partial class MainProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProgram));
            ListCategories = new ListBox();
            SaveButton = new Button();
            AddButton = new Button();
            RemoveButton = new Button();
            LoadButton = new Button();
            ResetButton = new Button();
            ListRooms = new ListBox();
            ListRequired = new ListBox();
            ListRecommend = new ListBox();
            ListOptional = new ListBox();
            RemoveRoomButton = new Button();
            AddRoomButton = new Button();
            AddRequired = new Button();
            RemoveRequired = new Button();
            AddRecommended = new Button();
            RemoveRecommended = new Button();
            AddOptional = new Button();
            RemoveOptional = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // ListCategories
            // 
            ListCategories.BorderStyle = BorderStyle.None;
            ListCategories.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ListCategories.ForeColor = SystemColors.Control;
            ListCategories.FormattingEnabled = true;
            ListCategories.Location = new Point(12, 56);
            ListCategories.Name = "ListCategories";
            ListCategories.Size = new Size(140, 525);
            ListCategories.TabIndex = 1;
            ListCategories.TabStop = false;
            ListCategories.UseTabStops = false;
            ListCategories.SelectedIndexChanged += ListCategories_SelectedIndexChanged;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = SystemColors.Highlight;
            SaveButton.Cursor = Cursors.Hand;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            SaveButton.ForeColor = SystemColors.Control;
            SaveButton.Location = new Point(12, 593);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(140, 32);
            SaveButton.TabIndex = 2;
            SaveButton.TabStop = false;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.Highlight;
            AddButton.BackgroundImageLayout = ImageLayout.None;
            AddButton.Cursor = Cursors.Hand;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Cascadia Mono", 9F, FontStyle.Bold);
            AddButton.ForeColor = SystemColors.Control;
            AddButton.Location = new Point(12, 33);
            AddButton.Name = "AddButton";
            AddButton.Padding = new Padding(4, 0, 0, 0);
            AddButton.Size = new Size(70, 23);
            AddButton.TabIndex = 3;
            AddButton.TabStop = false;
            AddButton.Text = "＋";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.BackColor = SystemColors.Highlight;
            RemoveButton.Cursor = Cursors.Hand;
            RemoveButton.FlatStyle = FlatStyle.Flat;
            RemoveButton.Font = new Font("Cascadia Mono", 9F, FontStyle.Bold);
            RemoveButton.ForeColor = SystemColors.Control;
            RemoveButton.Location = new Point(82, 33);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(70, 23);
            RemoveButton.TabIndex = 4;
            RemoveButton.TabStop = false;
            RemoveButton.Text = "—";
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // LoadButton
            // 
            LoadButton.BackColor = SystemColors.Highlight;
            LoadButton.Cursor = Cursors.Hand;
            LoadButton.FlatStyle = FlatStyle.Flat;
            LoadButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            LoadButton.ForeColor = SystemColors.Control;
            LoadButton.Location = new Point(164, 593);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(140, 32);
            LoadButton.TabIndex = 5;
            LoadButton.TabStop = false;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = false;
            LoadButton.Click += LoadButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.BackColor = SystemColors.Highlight;
            ResetButton.Cursor = Cursors.Hand;
            ResetButton.FlatStyle = FlatStyle.Flat;
            ResetButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            ResetButton.ForeColor = SystemColors.Control;
            ResetButton.Location = new Point(1100, 593);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(140, 32);
            ResetButton.TabIndex = 6;
            ResetButton.TabStop = false;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // ListRooms
            // 
            ListRooms.BorderStyle = BorderStyle.None;
            ListRooms.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ListRooms.ForeColor = SystemColors.Control;
            ListRooms.FormattingEnabled = true;
            ListRooms.Location = new Point(164, 56);
            ListRooms.Name = "ListRooms";
            ListRooms.Size = new Size(260, 525);
            ListRooms.TabIndex = 7;
            ListRooms.TabStop = false;
            ListRooms.UseTabStops = false;
            ListRooms.SelectedIndexChanged += ListRooms_SelectedIndexChanged;
            ListRooms.DoubleClick += ListRooms_DoubleClick;
            // 
            // ListRequired
            // 
            ListRequired.BorderStyle = BorderStyle.None;
            ListRequired.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ListRequired.ForeColor = SystemColors.Control;
            ListRequired.FormattingEnabled = true;
            ListRequired.Location = new Point(436, 56);
            ListRequired.Name = "ListRequired";
            ListRequired.Size = new Size(260, 525);
            ListRequired.TabIndex = 8;
            ListRequired.TabStop = false;
            ListRequired.UseTabStops = false;
            ListRequired.Click += ListRequired_SelectedIndexChanged;
            ListRequired.SelectedIndexChanged += ListRequired_SelectedIndexChanged;
            ListRequired.DoubleClick += ListRequired_DoubleClick;
            // 
            // ListRecommend
            // 
            ListRecommend.BorderStyle = BorderStyle.None;
            ListRecommend.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ListRecommend.ForeColor = SystemColors.Control;
            ListRecommend.FormattingEnabled = true;
            ListRecommend.Location = new Point(708, 56);
            ListRecommend.Name = "ListRecommend";
            ListRecommend.Size = new Size(260, 525);
            ListRecommend.TabIndex = 9;
            ListRecommend.TabStop = false;
            ListRecommend.UseTabStops = false;
            ListRecommend.Click += ListRecommend_SelectedIndexChanged;
            ListRecommend.SelectedIndexChanged += ListRecommend_SelectedIndexChanged;
            ListRecommend.DoubleClick += ListRecommended_DoubleClick;
            // 
            // ListOptional
            // 
            ListOptional.BorderStyle = BorderStyle.None;
            ListOptional.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ListOptional.ForeColor = SystemColors.Control;
            ListOptional.FormattingEnabled = true;
            ListOptional.Location = new Point(980, 56);
            ListOptional.Name = "ListOptional";
            ListOptional.Size = new Size(260, 525);
            ListOptional.TabIndex = 10;
            ListOptional.TabStop = false;
            ListOptional.UseTabStops = false;
            ListOptional.Click += ListOptional_SelectedIndexChanged;
            ListOptional.SelectedIndexChanged += ListOptional_SelectedIndexChanged;
            ListOptional.DoubleClick += ListOptional_DoubleClick;
            // 
            // RemoveRoomButton
            // 
            RemoveRoomButton.BackColor = SystemColors.Highlight;
            RemoveRoomButton.Cursor = Cursors.Hand;
            RemoveRoomButton.FlatStyle = FlatStyle.Flat;
            RemoveRoomButton.Font = new Font("Cascadia Mono", 9F, FontStyle.Bold);
            RemoveRoomButton.ForeColor = SystemColors.Control;
            RemoveRoomButton.Location = new Point(294, 33);
            RemoveRoomButton.Name = "RemoveRoomButton";
            RemoveRoomButton.Size = new Size(130, 23);
            RemoveRoomButton.TabIndex = 12;
            RemoveRoomButton.TabStop = false;
            RemoveRoomButton.Text = "—";
            RemoveRoomButton.UseVisualStyleBackColor = false;
            RemoveRoomButton.Click += RemoveRoomButton_Click;
            // 
            // AddRoomButton
            // 
            AddRoomButton.BackColor = SystemColors.Highlight;
            AddRoomButton.Cursor = Cursors.Hand;
            AddRoomButton.FlatStyle = FlatStyle.Flat;
            AddRoomButton.Font = new Font("Cascadia Mono", 9F, FontStyle.Bold);
            AddRoomButton.ForeColor = SystemColors.Control;
            AddRoomButton.Location = new Point(164, 33);
            AddRoomButton.Name = "AddRoomButton";
            AddRoomButton.Padding = new Padding(4, 0, 0, 0);
            AddRoomButton.Size = new Size(130, 23);
            AddRoomButton.TabIndex = 11;
            AddRoomButton.TabStop = false;
            AddRoomButton.Text = "＋";
            AddRoomButton.UseVisualStyleBackColor = false;
            AddRoomButton.Click += AddRoomButton_Click;
            // 
            // AddRequired
            // 
            AddRequired.BackColor = SystemColors.Highlight;
            AddRequired.Cursor = Cursors.Hand;
            AddRequired.FlatStyle = FlatStyle.Flat;
            AddRequired.Font = new Font("Cascadia Mono", 9F, FontStyle.Bold);
            AddRequired.ForeColor = SystemColors.Control;
            AddRequired.Location = new Point(436, 33);
            AddRequired.Name = "AddRequired";
            AddRequired.Padding = new Padding(4, 0, 0, 0);
            AddRequired.Size = new Size(130, 23);
            AddRequired.TabIndex = 13;
            AddRequired.TabStop = false;
            AddRequired.Text = "＋";
            AddRequired.UseVisualStyleBackColor = false;
            AddRequired.Click += AddRequired_Click;
            // 
            // RemoveRequired
            // 
            RemoveRequired.BackColor = SystemColors.Highlight;
            RemoveRequired.Cursor = Cursors.Hand;
            RemoveRequired.FlatStyle = FlatStyle.Flat;
            RemoveRequired.Font = new Font("Cascadia Mono", 9F, FontStyle.Bold);
            RemoveRequired.ForeColor = SystemColors.Control;
            RemoveRequired.Location = new Point(566, 33);
            RemoveRequired.Name = "RemoveRequired";
            RemoveRequired.Size = new Size(130, 23);
            RemoveRequired.TabIndex = 14;
            RemoveRequired.TabStop = false;
            RemoveRequired.Text = "—";
            RemoveRequired.UseVisualStyleBackColor = false;
            RemoveRequired.Click += RemoveRequired_Click;
            // 
            // AddRecommended
            // 
            AddRecommended.BackColor = SystemColors.Highlight;
            AddRecommended.Cursor = Cursors.Hand;
            AddRecommended.FlatStyle = FlatStyle.Flat;
            AddRecommended.Font = new Font("Cascadia Mono", 9F, FontStyle.Bold);
            AddRecommended.ForeColor = SystemColors.Control;
            AddRecommended.Location = new Point(708, 33);
            AddRecommended.Name = "AddRecommended";
            AddRecommended.Padding = new Padding(4, 0, 0, 0);
            AddRecommended.Size = new Size(130, 23);
            AddRecommended.TabIndex = 15;
            AddRecommended.TabStop = false;
            AddRecommended.Text = "＋";
            AddRecommended.UseVisualStyleBackColor = false;
            AddRecommended.Click += AddRecommended_Click;
            // 
            // RemoveRecommended
            // 
            RemoveRecommended.BackColor = SystemColors.Highlight;
            RemoveRecommended.Cursor = Cursors.Hand;
            RemoveRecommended.FlatStyle = FlatStyle.Flat;
            RemoveRecommended.Font = new Font("Cascadia Mono", 9F, FontStyle.Bold);
            RemoveRecommended.ForeColor = SystemColors.Control;
            RemoveRecommended.Location = new Point(838, 33);
            RemoveRecommended.Name = "RemoveRecommended";
            RemoveRecommended.Size = new Size(130, 23);
            RemoveRecommended.TabIndex = 16;
            RemoveRecommended.TabStop = false;
            RemoveRecommended.Text = "—";
            RemoveRecommended.UseVisualStyleBackColor = false;
            RemoveRecommended.Click += RemoveRecommended_Click;
            // 
            // AddOptional
            // 
            AddOptional.BackColor = SystemColors.Highlight;
            AddOptional.Cursor = Cursors.Hand;
            AddOptional.FlatStyle = FlatStyle.Flat;
            AddOptional.Font = new Font("Cascadia Mono", 9F, FontStyle.Bold);
            AddOptional.ForeColor = SystemColors.Control;
            AddOptional.Location = new Point(980, 33);
            AddOptional.Name = "AddOptional";
            AddOptional.Padding = new Padding(4, 0, 0, 0);
            AddOptional.Size = new Size(130, 23);
            AddOptional.TabIndex = 17;
            AddOptional.TabStop = false;
            AddOptional.Text = "＋";
            AddOptional.UseVisualStyleBackColor = false;
            AddOptional.Click += AddOptional_Click;
            // 
            // RemoveOptional
            // 
            RemoveOptional.BackColor = SystemColors.Highlight;
            RemoveOptional.Cursor = Cursors.Hand;
            RemoveOptional.FlatStyle = FlatStyle.Flat;
            RemoveOptional.Font = new Font("Cascadia Mono", 9F, FontStyle.Bold);
            RemoveOptional.ForeColor = SystemColors.Control;
            RemoveOptional.Location = new Point(1110, 33);
            RemoveOptional.Name = "RemoveOptional";
            RemoveOptional.Size = new Size(130, 23);
            RemoveOptional.TabIndex = 18;
            RemoveOptional.TabStop = false;
            RemoveOptional.Text = "—";
            RemoveOptional.UseVisualStyleBackColor = false;
            RemoveOptional.Click += RemoveOptional_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(38, 7);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 19;
            label1.Text = "Категории";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(256, 7);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 19;
            label2.Text = "Комнаты";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(807, 7);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 19;
            label3.Text = "Энтити";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainProgram
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1252, 637);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RemoveOptional);
            Controls.Add(AddOptional);
            Controls.Add(RemoveRecommended);
            Controls.Add(AddRecommended);
            Controls.Add(RemoveRequired);
            Controls.Add(AddRequired);
            Controls.Add(RemoveRoomButton);
            Controls.Add(AddRoomButton);
            Controls.Add(ListOptional);
            Controls.Add(ListRecommend);
            Controls.Add(ListRequired);
            Controls.Add(ListRooms);
            Controls.Add(ResetButton);
            Controls.Add(LoadButton);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Controls.Add(SaveButton);
            Controls.Add(ListCategories);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainProgram";
            Text = "Редактор статиста";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox ListCategories;
        private Button SaveButton;
        private Button AddButton;
        private Button RemoveButton;
        private Button LoadButton;
        private Button ResetButton;
        private ListBox ListRooms;
        private ListBox ListRequired;
        private ListBox ListRecommend;
        private ListBox ListOptional;
        private Button RemoveRoomButton;
        private Button AddRoomButton;
        private Button AddRequired;
        private Button RemoveRequired;
        private Button AddRecommended;
        private Button RemoveRecommended;
        private Button AddOptional;
        private Button RemoveOptional;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}