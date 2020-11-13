using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klientochka
{
    public partial class Nagrada : Form
    {
        public Nagrada()
        {
            InitializeComponent();
        }

        private void наградаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.наградаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void Nagrada_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Награда". При необходимости она может быть перемещена или удалена.
            this.наградаTableAdapter.Fill(this.bDDataSet.Награда);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (наградаDataGridView.RowCount > 1)
            {
                наградаBindingSource.RemoveCurrent();
                this.Validate();
                this.наградаBindingSource.EndEdit();
            }
            else
            {
                string message = "Нечего удаляяяяяяяять";
                DialogResult result = MessageBox.Show(message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            наградаBindingSource.AddNew();
            наградаDataGridView.CurrentRow.Cells[1].Value = textBox1.Text.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.наградаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);
            наградаBindingSource.MoveLast();
            //studentDataGridView.Visible = true;
            наградаDataGridView.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            наградаBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            наградаBindingSource.MoveNext();
        }
    }
}
