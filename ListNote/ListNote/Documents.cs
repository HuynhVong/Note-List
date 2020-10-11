using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListNote
{
    public partial class Documents : Form
    {

        public Documents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = ".pdf,.doc,.xls|*.pdf;*.doc;*.xls| All file (*.*)|*.*";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.dataGridView1.Rows.Add(ofd.FileName);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                string filepath = (string)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                System.Diagnostics.Process.Start(filepath);
            }
        }
        public void update()
        {
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Width = 300;
            dataGridView1.Columns[0].Name = "File";
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Open";
            btn.Name = "Open";
            btn.Text = "Click to open";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);
        }

        private void Documents_Load(object sender, EventArgs e)
        {
            update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }
    }
}
