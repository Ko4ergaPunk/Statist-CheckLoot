using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statist
{
    public partial class EntityProperties : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        private const int EM_SETCUEBANNER = 0x1501;

        public string EntityName;

        public List<string> EntitiesIncluded;
        public bool IncludeEntities;

        public int MaxValue;
        public int MinValue;

        public EntityProperties()
        {
            InitializeComponent();

            CheckBoxIsCategory.Checked = IncludeEntities;

            var entitiesIncluded = MainProgram.SelectedEntity.EntitiesIncluded;
            if (entitiesIncluded.Count > 0)
            {
                EntitiesIncluded = new List<string>(entitiesIncluded);
                BoxIncludedItems.Items.AddRange(EntitiesIncluded.ToArray());
            }
            else
                EntitiesIncluded = new List<string>();

            InitializeVisual();
            ChangeWindowSize();
            SetParams();
            RefreshList();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.AcceptButton = Ok;
            this.CancelButton = Cancel;

            SetPlaceholder(MaxBox, "Max...");
            SetPlaceholder(MinBox, "Min...");
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (MaxValue >= MinValue)
            {
                
                if (!IncludeEntities || EntitiesIncluded.Count > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MaxBox.BackColor = ColorTranslator.FromHtml("#333333");
                    MinBox.BackColor = ColorTranslator.FromHtml("#333333");
                    BoxIncludedItems.BackColor = Color.Red;
                }
            }
            else
            {
                MaxBox.BackColor = Color.Red;
                MinBox.BackColor = Color.Red;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private int ParseAndSet(TextBox box)
        {
            return int.TryParse(box.Text, out int result) ? result : 1;
        }

        private void CheckBoxIsCategory_CheckedChanged(object sender, EventArgs e)
        {
            IncludeEntities = CheckBoxIsCategory.Checked;
            ChangeWindowSize();
        }

        private void ChangeWindowSize()
        {
            if (CheckBoxIsCategory.Checked)
                this.Size = new Size(359, 144);
            else
                this.Size = new Size(359, 104);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string text = BoxIncludedItems.Text.Trim();
            if (!string.IsNullOrWhiteSpace(text))
            {
                if (!EntitiesIncluded.Contains(text))
                {
                    BoxIncludedItems.BackColor = ColorTranslator.FromHtml("#333333");
                    EntitiesIncluded.Add(text);
                    BoxIncludedItems.Items.Add(text);
                }

                BoxIncludedItems.Text = "";
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (BoxIncludedItems.SelectedIndex != -1)
            {
                string text = (string)BoxIncludedItems.SelectedItem;
                EntitiesIncluded.Remove(text);
                BoxIncludedItems.Items.Remove(text);
            }
        }

        private void RefreshList()
        {

        }

        #region [ Visual ]

        private void SetParams()
        {
            var selectedEntity = MainProgram.SelectedEntity;
            BoxName.Text = selectedEntity.Name;
            IncludeEntities = selectedEntity.IncludeEntities;
            CheckBoxIsCategory.Checked = IncludeEntities;
            MaxBox.Text = selectedEntity.Max.ToString();
            MinBox.Text = selectedEntity.Min.ToString();
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            SendMessage(textBox.Handle, EM_SETCUEBANNER, 0, placeholder);
        }

        private void MaxBox_TextChanged(object sender, EventArgs e)
        {
            MaxValue = ParseAndSet(MaxBox);
        }

        private void MinBox_TextChanged(object sender, EventArgs e)
        {
            MinValue = ParseAndSet(MinBox);
        }

        private void BoxName_TextChanged(object sender, EventArgs e)
        {
            EntityName = BoxName.Text;
        }

        private void InitializeVisual()
        {
            this.BackColor = ColorTranslator.FromHtml("#2b2b2b");

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
            Add.FlatAppearance.BorderSize = 0;
            Remove.FlatAppearance.BorderSize = 0;

            BoxName.BackColor = color;
            MaxBox.BackColor = color;
            MinBox.BackColor = color;
            BoxIncludedItems.BackColor = color;

            Remove.BackColor = ColorTranslator.FromHtml("#006bbd");
        }

        #endregion

        private void BoxIncludedItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
