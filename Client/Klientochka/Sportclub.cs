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
    public partial class Sportclub : Form
    {
        public Sportclub()
        {
            InitializeComponent();
        }

        private void спортивный_клубBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.спортивный_клубBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void Sportclub_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Спортивный_клуб". При необходимости она может быть перемещена или удалена.
            this.спортивный_клубTableAdapter.Fill(this.bDDataSet.Спортивный_клуб);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (спортивный_клубDataGridView.RowCount > 1)
            {
                спортивный_клубBindingSource.RemoveCurrent();
                this.Validate();
                this.спортивный_клубBindingSource.EndEdit();
            }
            else
            {
                string message = "Нечего удаляяяяяяяять";
                DialogResult result = MessageBox.Show(message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            спортивный_клубBindingSource.AddNew();
            спортивный_клубDataGridView.CurrentRow.Cells[1].Value = textBox1.Text.ToString();
            спортивный_клубDataGridView.CurrentRow.Cells[2].Value = textBox2.Text.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.спортивный_клубBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);
            спортивный_клубBindingSource.MoveLast();
            //studentDataGridView.Visible = true;
            спортивный_клубDataGridView.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            спортивный_клубBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            спортивный_клубBindingSource.MoveNext();
        }
    }
}
