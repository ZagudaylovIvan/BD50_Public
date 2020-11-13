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
    public partial class Group : Form
    {
        public Group()
        {
            InitializeComponent();
        }

        private void группаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.группаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void Group_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.bDDataSet.Группа);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (группаDataGridView.RowCount > 1)
            {
                группаBindingSource.RemoveCurrent();
                this.Validate();
                this.группаBindingSource.EndEdit();
            }
            else
            {
                string message = "Нечего удаляяяяяяяять";
                DialogResult result = MessageBox.Show(message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            группаBindingSource.AddNew();
            группаDataGridView.CurrentRow.Cells[1].Value = textBox1.Text.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.группаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);
            группаBindingSource.MoveLast();
            //studentDataGridView.Visible = true;
            группаDataGridView.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            группаBindingSource.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            группаBindingSource.MovePrevious();
        }

       
    }
    
}
