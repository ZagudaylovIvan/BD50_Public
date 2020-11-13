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
    public partial class Naznachenie : Form
    {
        public Naznachenie()
        {
            InitializeComponent();
        }

        private void назначение_в_группуBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.назначение_в_группуBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void Naznachenie_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.bDDataSet.Группа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Спортсмен". При необходимости она может быть перемещена или удалена.
            this.спортсменTableAdapter.Fill(this.bDDataSet.Спортсмен);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Назначение_в_группу". При необходимости она может быть перемещена или удалена.
            this.назначение_в_группуTableAdapter.Fill(this.bDDataSet.Назначение_в_группу);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (назначение_в_группуDataGridView.RowCount > 1)
            {
                назначение_в_группуBindingSource.RemoveCurrent();
                this.Validate();
                this.назначение_в_группуBindingSource.EndEdit();
            }
            else
            {
                string message = "Нечего удаляяяяяяяять";
                DialogResult result = MessageBox.Show(message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            назначение_в_группуBindingSource.AddNew();
            назначение_в_группуDataGridView.CurrentRow.Cells[1].Value = textBox1.Text.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.назначение_в_группуBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);
            назначение_в_группуBindingSource.MoveLast();
            //studentDataGridView.Visible = true;
            назначение_в_группуDataGridView.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            назначение_в_группуBindingSource.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            назначение_в_группуBindingSource.MovePrevious();
        }
    }
}
