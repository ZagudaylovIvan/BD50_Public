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
    public partial class Trener : Form
    {
        public Trener()
        {
            InitializeComponent();
        }

        private void тренерBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тренерBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void Trener_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Тренер". При необходимости она может быть перемещена или удалена.
            this.тренерTableAdapter.Fill(this.bDDataSet.Тренер);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (тренерDataGridView.RowCount > 1)
            {
                тренерBindingSource.RemoveCurrent();
                this.Validate();
                this.тренерBindingSource.EndEdit();
            }
            else
            {
                string message = "Нечего удаляяяяяяяять";
                DialogResult result = MessageBox.Show(message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            тренерBindingSource.AddNew();
            тренерDataGridView.CurrentRow.Cells[1].Value = textBox1.Text.ToString();
            тренерDataGridView.CurrentRow.Cells[2].Value = textBox2.Text.ToString();
            тренерDataGridView.CurrentRow.Cells[3].Value = textBox3.Text.ToString();
            тренерDataGridView.CurrentRow.Cells[4].Value = textBox4.Text.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тренерBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);
            тренерBindingSource.MoveLast();
            //studentDataGridView.Visible = true;
            тренерDataGridView.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            тренерBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            тренерBindingSource.MoveNext();
        }
    }
}
