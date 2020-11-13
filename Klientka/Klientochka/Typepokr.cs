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
    public partial class Typepokr : Form
    {
        public Typepokr()
        {
            InitializeComponent();
        }

        private void тип_покрытияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тип_покрытияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void Typepokr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Тип_покрытия". При необходимости она может быть перемещена или удалена.
            this.тип_покрытияTableAdapter.Fill(this.bDDataSet.Тип_покрытия);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (тип_покрытияDataGridView.RowCount > 1)
            {
                тип_покрытияBindingSource.RemoveCurrent();
                this.Validate();
                this.тип_покрытияBindingSource.EndEdit();
            }
            else
            {
                string message = "Нечего удаляяяяяяяять";
                DialogResult result = MessageBox.Show(message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            тип_покрытияBindingSource.AddNew();
            тип_покрытияDataGridView.CurrentRow.Cells[1].Value = textBox1.Text.ToString();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тип_покрытияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);
            тип_покрытияBindingSource.MoveLast();
            //studentDataGridView.Visible = true;
            тип_покрытияDataGridView.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            тип_покрытияBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            тип_покрытияBindingSource.MoveNext();
        }
    }
}
