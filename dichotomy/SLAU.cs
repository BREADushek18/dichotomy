using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dichotomy
{
    public partial class SLAU : Form
    {
        DichotomyForm mainForm;
        public SLAU(DichotomyForm form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void вернутьсяНазадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void запуститьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBoxN_TextChanged(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(textBoxN.Text, out n))
            {
                if (n >= 2 && n <= 50)
                {
                    dataGridView1.ColumnCount = n + 1;
                    dataGridView1.RowCount = n;

                    for (int i = 0; i < n; i++)
                    {
                        dataGridView1.Columns[i].HeaderText = "X" + (i + 1);
                        dataGridView1.Rows[i].HeaderCell.Value = " " + (i + 1);
                    }
                    dataGridView1.Columns[n].HeaderText = "= Y";
                    
                }
                else
                {
                    MessageBox.Show("Число N должно быть от 2 до 50");
                }
            }
        }

        
    }
}
