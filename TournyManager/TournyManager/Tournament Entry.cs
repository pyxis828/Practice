using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournyManager
{
    public partial class Tournament_Entry : Form
    {
        public Tournament_Entry()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            this.antesCheckbox.AutoSize = true;
            this.antesCheckbox.Size = new System.Drawing.Size(15, 21);
            this.antesCheckbox.TabIndex = 7;
            this.antesCheckbox.CheckedChanged += new System.EventHandler(this.antesCheckbox_CheckedChanged);
        }

        private void antesCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            antesEntry.Enabled = antesCheckbox.Checked;
        }

        private void currentGameCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            gameEntry.Enabled = currentGameCheckbox.Checked;
        }

        private void antesEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void smallBlindEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bigBlindEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void timeEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void addLevelButton_Click(object sender, EventArgs e)
        {            
            string[] splitLevel = this.levelLabel.Text.Split(' ');
            int levelNum = int.Parse(splitLevel[1]);
            int timesCalled = ++levelNum;
            Label levelLabel = new Label();
            levelLabel.Text = "Level " + timesCalled.ToString();
            this.Controls.Add(levelLabel);
            flowLayoutPanel1.Controls.Add(levelLabel);
            CheckBox antesCheckbox = new CheckBox();
            this.Controls.Add(antesCheckbox);
            this.antesCheckbox.Location = new System.Drawing.Point(76, 62);
            flowLayoutPanel1.Controls.Add(antesCheckbox);             
            
            TextBox antesEntry = new TextBox();
            this.Controls.Add(antesEntry);
            flowLayoutPanel1.Controls.Add(antesEntry);            
            this.antesEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.antesEntry.Enabled = false;            
            this.antesEntry.Location = new System.Drawing.Point(97, 62);
            this.antesEntry.MaxLength = 9;
            this.antesEntry.Name = "antesEntry";
            this.antesEntry.Size = new System.Drawing.Size(100, 27);
            this.antesEntry.TabIndex = 8;
            this.antesEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.antesEntry_KeyPress);
            TextBox smallBlindEntry = new TextBox();
            this.Controls.Add(smallBlindEntry);
            flowLayoutPanel1.Controls.Add(smallBlindEntry);
        }

        private void levelLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timeColumn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameColumn_Click(object sender, EventArgs e)
        {

        }
    }
}
