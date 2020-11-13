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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        private void набор_категорийBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.набор_категорийBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void Category_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Тип_сооружения". При необходимости она может быть перемещена или удалена.
            this.тип_сооруженияTableAdapter.Fill(this.bDDataSet.Тип_сооружения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Тип_покрытия". При необходимости она может быть перемещена или удалена.
            this.тип_покрытияTableAdapter.Fill(this.bDDataSet.Тип_покрытия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Набор_категорий". При необходимости она может быть перемещена или удалена.
            this.набор_категорийTableAdapter.Fill(this.bDDataSet.Набор_категорий);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (набор_категорийDataGridView.RowCount > 1)
            {
                набор_категорийBindingSource.RemoveCurrent();
                this.Validate();
                this.набор_категорийBindingSource.EndEdit();
            }
            else
            {
                string message = "Нечего удаляяяяяяяять";
                DialogResult result = MessageBox.Show(message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            набор_категорийBindingSource.AddNew();
            набор_категорийDataGridView.CurrentRow.Cells[1].Value = textBox1.Text.ToString();
            набор_категорийDataGridView.CurrentRow.Cells[2].Value = textBox2.Text.ToString();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.набор_категорийBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);
            набор_категорийBindingSource.MoveLast();
            //studentDataGridView.Visible = true;
            набор_категорийDataGridView.Invalidate();
        }

    }
}
