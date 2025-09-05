using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace statist
{
    public partial class RoomSettings : Form
    {
        public int SelectedPriority;
        public string RoomName;

        public RoomSettings()
        {
            InitializeComponent();
            InitializeVisual();

            this.AcceptButton = Ok;
            this.CancelButton = Cancel;

            PriorityBox.SelectedIndex = MainProgram.SelectedRoom.Priority - 1;
            RoomName = MainProgram.SelectedRoom.Name;
            textBox1.Text = RoomName;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void PriorityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPriority = PriorityBox.SelectedIndex + 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            RoomName = textBox1.Text;
        }

        private void InitializeVisual()
        {
            this.BackColor = ColorTranslator.FromHtml("#2b2b2b");
            this.StartPosition = FormStartPosition.CenterScreen;

            Color color = ColorTranslator.FromHtml("#333333");
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(1);
            this.Paint += (s, e) =>
            {
                using (Pen pen = new Pen(color, 1))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
                }
            };

            textBox1.BackColor = color;
            PriorityBox.BackColor = color;

            Ok.FlatAppearance.BorderSize = 0;
            Cancel.FlatAppearance.BorderSize = 0;
        }
    }
}
