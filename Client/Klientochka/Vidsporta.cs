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
    public partial class Vidsporta : Form
    {
        public Vidsporta()
        {
            InitializeComponent();
        }

        private void вид_спортаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.вид_спортаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void Vidsporta_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Вид_спорта". При необходимости она может быть перемещена или удалена.
            this.вид_спортаTableAdapter.Fill(this.bDDataSet.Вид_спорта);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (вид_спортаDataGridView.RowCount > 1)
            {
                вид_спортаBindingSource.RemoveCurrent();
                this.Validate();
                this.вид_спортаBindingSource.EndEdit();
            }
            else
            {
                string message = "Нечего удаляяяяяяяять";
                DialogResult result = MessageBox.Show(message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            вид_спортаBindingSource.AddNew();
            вид_спортаDataGridView.CurrentRow.Cells[1].Value = textBox1.Text.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.вид_спортаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);
            вид_спортаBindingSource.MoveLast();
            //studentDataGridView.Visible = true;
            вид_спортаDataGridView.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            вид_спортаBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            вид_спортаBindingSource.MoveNext();
        }
    }
}
