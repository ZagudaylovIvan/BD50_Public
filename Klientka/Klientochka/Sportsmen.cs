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
    public partial class Sportsmen : Form
    {
        public Sportsmen()
        {
            InitializeComponent();
        }

        private void спортсменBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.спортсменBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void Sportsmen_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Спортсмен". При необходимости она может быть перемещена или удалена.
            this.спортсменTableAdapter.Fill(this.bDDataSet.Спортсмен);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (спортсменDataGridView.RowCount > 1)
            {
                спортсменBindingSource.RemoveCurrent();
                this.Validate();
                this.спортсменBindingSource.EndEdit();
            }
            else
            {
                string message = "Нечего удаляяяяяяяять";
                DialogResult result = MessageBox.Show(message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            спортсменBindingSource.AddNew();
            спортсменDataGridView.CurrentRow.Cells[1].Value = textBox1.Text.ToString();
            спортсменDataGridView.CurrentRow.Cells[2].Value = textBox2.Text.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.спортсменBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);
            спортсменBindingSource.MoveLast();
            //studentDataGridView.Visible = true;
            спортсменDataGridView.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            спортсменBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            спортсменBindingSource.MoveNext();
        }


    }
}
