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
    public partial class Typesooruzh : Form
    {
        public Typesooruzh()
        {
            InitializeComponent();
        }

        private void тип_сооруженияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тип_сооруженияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void Typesooruzh_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Тип_сооружения". При необходимости она может быть перемещена или удалена.
            this.тип_сооруженияTableAdapter.Fill(this.bDDataSet.Тип_сооружения);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (тип_сооруженияDataGridView.RowCount > 1)
            {
                тип_сооруженияBindingSource.RemoveCurrent();
                this.Validate();
                this.тип_сооруженияBindingSource.EndEdit();
            }
            else
            {
                string message = "Нечего удаляяяяяяяять";
                DialogResult result = MessageBox.Show(message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            тип_сооруженияBindingSource.AddNew();
            тип_сооруженияDataGridView.CurrentRow.Cells[1].Value = textBox1.Text.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тип_сооруженияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);
            тип_сооруженияBindingSource.MoveLast();
            //studentDataGridView.Visible = true;
            тип_сооруженияDataGridView.Invalidate();
        }
    }
}
