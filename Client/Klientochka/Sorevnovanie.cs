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
    public partial class Sorevnovanie : Form
    {
        public Sorevnovanie()
        {
            InitializeComponent();
        }

        private void соревнованияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.соревнованияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void Sorevnovanie_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Вид_спорта". При необходимости она может быть перемещена или удалена.
            this.вид_спортаTableAdapter.Fill(this.bDDataSet.Вид_спорта);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Набор_категорий". При необходимости она может быть перемещена или удалена.
            this.набор_категорийTableAdapter.Fill(this.bDDataSet.Набор_категорий);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Спортивный_клуб". При необходимости она может быть перемещена или удалена.
            this.спортивный_клубTableAdapter.Fill(this.bDDataSet.Спортивный_клуб);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Организатор". При необходимости она может быть перемещена или удалена.
            this.организаторTableAdapter.Fill(this.bDDataSet.Организатор);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Спортсмен". При необходимости она может быть перемещена или удалена.
            this.спортсменTableAdapter.Fill(this.bDDataSet.Спортсмен);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Соревнования". При необходимости она может быть перемещена или удалена.
            this.соревнованияTableAdapter.Fill(this.bDDataSet.Соревнования);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (dataGridView1.RowCount > 1)
            {
                соревнованияBindingSource.RemoveCurrent();
                this.Validate();
                this.соревнованияBindingSource.EndEdit();
            }
            else {
                string message = "Нечего удаляяяяяяяять";
                DialogResult result = MessageBox.Show(message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            соревнованияBindingSource.AddNew();
            dataGridView1.CurrentRow.Cells[1].Value = textBox1.Text.ToString();
            dataGridView1.CurrentRow.Cells[2].Value = textBox2.Text.ToString();
            dataGridView1.CurrentRow.Cells[3].Value = textBox3.Text.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.соревнованияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);
            соревнованияBindingSource.MoveLast();
            dataGridView1.Visible = true;
            dataGridView1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            соревнованияBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            соревнованияBindingSource.MoveNext();
        }

        
    }
}
