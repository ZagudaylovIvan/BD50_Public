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
    public partial class Trenirovka : Form
    {
        public Trenirovka()
        {
            InitializeComponent();
        }

        private void тренировкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тренировкаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void Trenirovka_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Набор_категорий". При необходимости она может быть перемещена или удалена.
            this.набор_категорийTableAdapter.Fill(this.bDDataSet.Набор_категорий);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Вид_спорта". При необходимости она может быть перемещена или удалена.
            this.вид_спортаTableAdapter.Fill(this.bDDataSet.Вид_спорта);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.bDDataSet.Группа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Тренер". При необходимости она может быть перемещена или удалена.
            this.тренерTableAdapter.Fill(this.bDDataSet.Тренер);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Набор_категорий". При необходимости она может быть перемещена или удалена.
            this.набор_категорийTableAdapter.Fill(this.bDDataSet.Набор_категорий);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Тренировка". При необходимости она может быть перемещена или удалена.
            this.тренировкаTableAdapter.Fill(this.bDDataSet.Тренировка);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (тренировкаDataGridView.RowCount > 1)
            {
                тренировкаBindingSource.RemoveCurrent();
                this.Validate();
                this.тренировкаBindingSource.EndEdit();
            }
            else
            {
                string message = "Нечего удаляяяяяяяять";
                DialogResult result = MessageBox.Show(message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            тренировкаBindingSource.AddNew();
            тренировкаDataGridView.CurrentRow.Cells[1].Value = textBox2.Text.ToString();
            тренировкаDataGridView.CurrentRow.Cells[2].Value = textBox3.Text.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тренировкаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);
            тренировкаBindingSource.MoveLast();
            //studentDataGridView.Visible = true;
            тренировкаDataGridView.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            тренировкаBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            тренировкаBindingSource.MoveNext();
        }
    }
}
