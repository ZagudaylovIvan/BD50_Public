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
    public partial class Organizator : Form
    {
        public Organizator()
        {
            InitializeComponent();
        }

        private void организаторBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.организаторBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void Organizator_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Организатор". При необходимости она может быть перемещена или удалена.
            this.организаторTableAdapter.Fill(this.bDDataSet.Организатор);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (организаторDataGridView.RowCount > 1)
            {
                организаторBindingSource.RemoveCurrent();
                this.Validate();
                this.организаторBindingSource.EndEdit();
            }
            else
            {
                string message = "Нечего удаляяяяяяяять";
                DialogResult result = MessageBox.Show(message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            организаторBindingSource.AddNew();
            организаторDataGridView.CurrentRow.Cells[1].Value = textBox1.Text.ToString();
            организаторDataGridView.CurrentRow.Cells[2].Value = textBox2.Text.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.организаторBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);
            организаторBindingSource.MoveLast();
            //studentDataGridView.Visible = true;
            организаторDataGridView.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            организаторBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            организаторBindingSource.MoveNext();
        }
    }
}
