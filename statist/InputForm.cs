using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statist
{
    public partial class InputForm : Form
    {
        public string ResultText { get; private set; }

        public InputForm()
        {
            InitializeComponent();
            InitializeVisual();

            this.AcceptButton = Ok;
            this.CancelButton = Cancel;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            ResultText = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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

            Ok.FlatAppearance.BorderSize = 0;
            Cancel.FlatAppearance.BorderSize = 0;

            textBox1.BackColor = color;
        }
    }
}
