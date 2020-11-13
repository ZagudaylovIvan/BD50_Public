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
    public partial class Nagrazhdenie : Form
    {
        public Nagrazhdenie()
        {
            InitializeComponent();
        }
        private void награждениеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.награждениеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }
        private void Nagrazhdenie_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Награда". При необходимости она может быть перемещена или удалена.
            this.наградаTableAdapter.Fill(this.bDDataSet.Награда);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Соревнования". При необходимости она может быть перемещена или удалена.
            this.соревнованияTableAdapter.Fill(this.bDDataSet.Соревнования);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Спортсмен". При необходимости она может быть перемещена или удалена.
            this.спортсменTableAdapter.Fill(this.bDDataSet.Спортсмен);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Награждение". При необходимости она может быть перемещена или удалена.
            this.награждениеTableAdapter.Fill(this.bDDataSet.Награждение);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            награждениеBindingSource.MovePrevious();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            награждениеBindingSource.AddNew();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (награждениеDataGridView.RowCount > 1)
            {
                награждениеBindingSource.RemoveCurrent();
                this.Validate();
                this.награждениеBindingSource.EndEdit();
            }
            else
            {
                string message = "Нечего удаляяяяяяяять";
                DialogResult result = MessageBox.Show(message);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.награждениеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);
            награждениеBindingSource.MoveLast();
            //studentDataGridView.Visible = true;
            награждениеDataGridView.Invalidate();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            награждениеBindingSource.MoveNext();
        }
    }
}
