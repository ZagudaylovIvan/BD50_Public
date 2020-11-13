namespace Klientochka
{
    partial class Sorevnovanie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sorevnovanie));
            this.bDDataSet = new Klientochka.BDDataSet();
            this.соревнованияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.соревнованияTableAdapter = new Klientochka.BDDataSetTableAdapters.СоревнованияTableAdapter();
            this.tableAdapterManager = new Klientochka.BDDataSetTableAdapters.TableAdapterManager();
            this.соревнованияBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.соревнованияBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.видСпортаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.спортсменBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.организаторBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.спортивныйКлубBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.наборКатегорийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.спортсменTableAdapter = new Klientochka.BDDataSetTableAdapters.СпортсменTableAdapter();
            this.организаторTableAdapter = new Klientochka.BDDataSetTableAdapters.ОрганизаторTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.спортивный_клубTableAdapter = new Klientochka.BDDataSetTableAdapters.Спортивный_клубTableAdapter();
            this.набор_категорийTableAdapter = new Klientochka.BDDataSetTableAdapters.Набор_категорийTableAdapter();
            this.вид_спортаTableAdapter = new Klientochka.BDDataSetTableAdapters.Вид_спортаTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.iDSorevnovanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видСпортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.спортсменDataGridView = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.организаторDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.спортивныйКлубDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.спортивноеСооружениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.соревнованияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.соревнованияBindingNavigator)).BeginInit();
            this.соревнованияBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видСпортаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.спортсменBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.организаторBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.спортивныйКлубBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.наборКатегорийBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // соревнованияBindingSource
            // 
            this.соревнованияBindingSource.DataMember = "Соревнования";
            this.соревнованияBindingSource.DataSource = this.bDDataSet;
            // 
            // соревнованияTableAdapter
            // 
            this.соревнованияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Klientochka.BDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Вид_спортаTableAdapter = null;
            this.tableAdapterManager.ГруппаTableAdapter = null;
            this.tableAdapterManager.Набор_категорийTableAdapter = null;
            this.tableAdapterManager.НаградаTableAdapter = null;
            this.tableAdapterManager.НаграждениеTableAdapter = null;
            this.tableAdapterManager.Назначение_в_группуTableAdapter = null;
            this.tableAdapterManager.ОрганизаторTableAdapter = null;
            this.tableAdapterManager.СоревнованияTableAdapter = this.соревнованияTableAdapter;
            this.tableAdapterManager.Спортивный_клубTableAdapter = null;
            this.tableAdapterManager.СпортсменTableAdapter = null;
            this.tableAdapterManager.Тип_покрытияTableAdapter = null;
            this.tableAdapterManager.Тип_сооруженияTableAdapter = null;
            this.tableAdapterManager.ТренерTableAdapter = null;
            this.tableAdapterManager.ТренировкаTableAdapter = null;
            // 
            // соревнованияBindingNavigator
            // 
            this.соревнованияBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.соревнованияBindingNavigator.BindingSource = this.соревнованияBindingSource;
            this.соревнованияBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.соревнованияBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.соревнованияBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.соревнованияBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.соревнованияBindingNavigatorSaveItem});
            this.соревнованияBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.соревнованияBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.соревнованияBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.соревнованияBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.соревнованияBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.соревнованияBindingNavigator.Name = "соревнованияBindingNavigator";
            this.соревнованияBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.соревнованияBindingNavigator.Size = new System.Drawing.Size(1495, 27);
            this.соревнованияBindingNavigator.TabIndex = 0;
            this.соревнованияBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // соревнованияBindingNavigatorSaveItem
            // 
            this.соревнованияBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.соревнованияBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("соревнованияBindingNavigatorSaveItem.Image")));
            this.соревнованияBindingNavigatorSaveItem.Name = "соревнованияBindingNavigatorSaveItem";
            this.соревнованияBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.соревнованияBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.соревнованияBindingNavigatorSaveItem.Click += new System.EventHandler(this.соревнованияBindingNavigatorSaveItem_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(1356, 395);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 50);
            this.button5.TabIndex = 51;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(1356, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 50);
            this.button4.TabIndex = 50;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1356, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 50);
            this.button3.TabIndex = 49;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1271, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 68);
            this.button2.TabIndex = 48;
            this.button2.Text = "↓";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1271, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 68);
            this.button1.TabIndex = 47;
            this.button1.Text = "↑";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.соревнованияBindingSource, "Название", true));
            this.textBox1.Location = new System.Drawing.Point(1365, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 52;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Pink;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSorevnovanieDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.времяDataGridViewTextBoxColumn,
            this.видСпортаDataGridViewTextBoxColumn,
            this.спортсменDataGridView,
            this.организаторDataGridViewTextBoxColumn,
            this.спортивныйКлубDataGridViewTextBoxColumn,
            this.спортивноеСооружениеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.соревнованияBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1253, 415);
            this.dataGridView1.TabIndex = 53;
            // 
            // видСпортаBindingSource
            // 
            this.видСпортаBindingSource.DataMember = "Вид спорта";
            this.видСпортаBindingSource.DataSource = this.bDDataSet;
            // 
            // спортсменBindingSource
            // 
            this.спортсменBindingSource.DataMember = "Спортсмен";
            this.спортсменBindingSource.DataSource = this.bDDataSet;
            // 
            // организаторBindingSource
            // 
            this.организаторBindingSource.DataMember = "Организатор";
            this.организаторBindingSource.DataSource = this.bDDataSet;
            // 
            // спортивныйКлубBindingSource
            // 
            this.спортивныйКлубBindingSource.DataMember = "Спортивный клуб";
            this.спортивныйКлубBindingSource.DataSource = this.bDDataSet;
            // 
            // наборКатегорийBindingSource
            // 
            this.наборКатегорийBindingSource.DataMember = "Набор категорий";
            this.наборКатегорийBindingSource.DataSource = this.bDDataSet;
            // 
            // спортсменTableAdapter
            // 
            this.спортсменTableAdapter.ClearBeforeFill = true;
            // 
            // организаторTableAdapter
            // 
            this.организаторTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.соревнованияBindingSource, "Дата", true));
            this.textBox2.Location = new System.Drawing.Point(1365, 207);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 54;
            // 
            // спортивный_клубTableAdapter
            // 
            this.спортивный_клубTableAdapter.ClearBeforeFill = true;
            // 
            // набор_категорийTableAdapter
            // 
            this.набор_категорийTableAdapter.ClearBeforeFill = true;
            // 
            // вид_спортаTableAdapter
            // 
            this.вид_спортаTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1381, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1392, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Дата:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1392, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 58;
            this.label3.Text = "Время:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.соревнованияBindingSource, "Время", true));
            this.textBox3.Location = new System.Drawing.Point(1365, 252);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 59;
            // 
            // iDSorevnovanieDataGridViewTextBoxColumn
            // 
            this.iDSorevnovanieDataGridViewTextBoxColumn.DataPropertyName = "ID_Sorevnovanie";
            this.iDSorevnovanieDataGridViewTextBoxColumn.HeaderText = "ID_Sorevnovanie";
            this.iDSorevnovanieDataGridViewTextBoxColumn.Name = "iDSorevnovanieDataGridViewTextBoxColumn";
            this.iDSorevnovanieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // времяDataGridViewTextBoxColumn
            // 
            this.времяDataGridViewTextBoxColumn.DataPropertyName = "Время";
            this.времяDataGridViewTextBoxColumn.HeaderText = "Время";
            this.времяDataGridViewTextBoxColumn.Name = "времяDataGridViewTextBoxColumn";
            // 
            // видСпортаDataGridViewTextBoxColumn
            // 
            this.видСпортаDataGridViewTextBoxColumn.DataPropertyName = "Вид спорта";
            this.видСпортаDataGridViewTextBoxColumn.DataSource = this.видСпортаBindingSource;
            this.видСпортаDataGridViewTextBoxColumn.DisplayMember = "Наименование";
            this.видСпортаDataGridViewTextBoxColumn.HeaderText = "Вид спорта";
            this.видСпортаDataGridViewTextBoxColumn.Name = "видСпортаDataGridViewTextBoxColumn";
            this.видСпортаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.видСпортаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.видСпортаDataGridViewTextBoxColumn.ValueMember = "ID_Sport";
            // 
            // спортсменDataGridView
            // 
            this.спортсменDataGridView.DataPropertyName = "Спортсмен";
            this.спортсменDataGridView.DataSource = this.спортсменBindingSource;
            this.спортсменDataGridView.DisplayMember = "ФИО";
            this.спортсменDataGridView.HeaderText = "Спортсмен";
            this.спортсменDataGridView.Name = "спортсменDataGridView";
            this.спортсменDataGridView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.спортсменDataGridView.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.спортсменDataGridView.ValueMember = "ID_Sportsmen";
            // 
            // организаторDataGridViewTextBoxColumn
            // 
            this.организаторDataGridViewTextBoxColumn.DataPropertyName = "Организатор";
            this.организаторDataGridViewTextBoxColumn.DataSource = this.организаторBindingSource;
            this.организаторDataGridViewTextBoxColumn.DisplayMember = "ФИО";
            this.организаторDataGridViewTextBoxColumn.HeaderText = "Организатор";
            this.организаторDataGridViewTextBoxColumn.Name = "организаторDataGridViewTextBoxColumn";
            this.организаторDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.организаторDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.организаторDataGridViewTextBoxColumn.ValueMember = "ID_Organizator";
            // 
            // спортивныйКлубDataGridViewTextBoxColumn
            // 
            this.спортивныйКлубDataGridViewTextBoxColumn.DataPropertyName = "Спортивный клуб";
            this.спортивныйКлубDataGridViewTextBoxColumn.DataSource = this.спортивныйКлубBindingSource;
            this.спортивныйКлубDataGridViewTextBoxColumn.DisplayMember = "Название";
            this.спортивныйКлубDataGridViewTextBoxColumn.HeaderText = "Спортивный клуб";
            this.спортивныйКлубDataGridViewTextBoxColumn.Name = "спортивныйКлубDataGridViewTextBoxColumn";
            this.спортивныйКлубDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.спортивныйКлубDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.спортивныйКлубDataGridViewTextBoxColumn.ValueMember = "ID_Club";
            // 
            // спортивноеСооружениеDataGridViewTextBoxColumn
            // 
            this.спортивноеСооружениеDataGridViewTextBoxColumn.DataPropertyName = "Спортивное сооружение";
            this.спортивноеСооружениеDataGridViewTextBoxColumn.DataSource = this.наборКатегорийBindingSource;
            this.спортивноеСооружениеDataGridViewTextBoxColumn.DisplayMember = "Наименование";
            this.спортивноеСооружениеDataGridViewTextBoxColumn.HeaderText = "Спортивное сооружение";
            this.спортивноеСооружениеDataGridViewTextBoxColumn.Name = "спортивноеСооружениеDataGridViewTextBoxColumn";
            this.спортивноеСооружениеDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.спортивноеСооружениеDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.спортивноеСооружениеDataGridViewTextBoxColumn.ValueMember = "ID_Category";
            // 
            // Sorevnovanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.соревнованияBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1513, 497);
            this.MinimumSize = new System.Drawing.Size(1513, 497);
            this.Name = "Sorevnovanie";
            this.Text = "Соревнование";
            this.Load += new System.EventHandler(this.Sorevnovanie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.соревнованияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.соревнованияBindingNavigator)).EndInit();
            this.соревнованияBindingNavigator.ResumeLayout(false);
            this.соревнованияBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видСпортаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.спортсменBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.организаторBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.спортивныйКлубBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.наборКатегорийBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource соревнованияBindingSource;
        private BDDataSetTableAdapters.СоревнованияTableAdapter соревнованияTableAdapter;
        private BDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator соревнованияBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton соревнованияBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource спортсменBindingSource;
        private BDDataSetTableAdapters.СпортсменTableAdapter спортсменTableAdapter;
        private System.Windows.Forms.BindingSource организаторBindingSource;
        private BDDataSetTableAdapters.ОрганизаторTableAdapter организаторTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource спортивныйКлубBindingSource;
        private BDDataSetTableAdapters.Спортивный_клубTableAdapter спортивный_клубTableAdapter;
        private System.Windows.Forms.BindingSource наборКатегорийBindingSource;
        private BDDataSetTableAdapters.Набор_категорийTableAdapter набор_категорийTableAdapter;
        private System.Windows.Forms.BindingSource видСпортаBindingSource;
        private BDDataSetTableAdapters.Вид_спортаTableAdapter вид_спортаTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSorevnovanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn видСпортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn спортсменDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn организаторDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn спортивныйКлубDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn спортивноеСооружениеDataGridViewTextBoxColumn;
    }
}