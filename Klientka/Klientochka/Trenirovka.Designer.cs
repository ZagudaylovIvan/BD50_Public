namespace Klientochka
{
    partial class Trenirovka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trenirovka));
            this.bDDataSet = new Klientochka.BDDataSet();
            this.тренировкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тренировкаTableAdapter = new Klientochka.BDDataSetTableAdapters.ТренировкаTableAdapter();
            this.tableAdapterManager = new Klientochka.BDDataSetTableAdapters.TableAdapterManager();
            this.тренировкаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.тренировкаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.тренировкаDataGridView = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.тренерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тренерTableAdapter = new Klientochka.BDDataSetTableAdapters.ТренерTableAdapter();
            this.группаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группаTableAdapter = new Klientochka.BDDataSetTableAdapters.ГруппаTableAdapter();
            this.видСпортаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вид_спортаTableAdapter = new Klientochka.BDDataSetTableAdapters.Вид_спортаTableAdapter();
            this.наборКатегорийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.набор_категорийTableAdapter = new Klientochka.BDDataSetTableAdapters.Набор_категорийTableAdapter();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тренировкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тренировкаBindingNavigator)).BeginInit();
            this.тренировкаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.тренировкаDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тренерBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видСпортаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.наборКатегорийBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // тренировкаBindingSource
            // 
            this.тренировкаBindingSource.DataMember = "Тренировка";
            this.тренировкаBindingSource.DataSource = this.bDDataSet;
            // 
            // тренировкаTableAdapter
            // 
            this.тренировкаTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.СоревнованияTableAdapter = null;
            this.tableAdapterManager.Спортивный_клубTableAdapter = null;
            this.tableAdapterManager.СпортсменTableAdapter = null;
            this.tableAdapterManager.Тип_покрытияTableAdapter = null;
            this.tableAdapterManager.Тип_сооруженияTableAdapter = null;
            this.tableAdapterManager.ТренерTableAdapter = null;
            this.tableAdapterManager.ТренировкаTableAdapter = this.тренировкаTableAdapter;
            // 
            // тренировкаBindingNavigator
            // 
            this.тренировкаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.тренировкаBindingNavigator.BindingSource = this.тренировкаBindingSource;
            this.тренировкаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.тренировкаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.тренировкаBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.тренировкаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.тренировкаBindingNavigatorSaveItem});
            this.тренировкаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.тренировкаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.тренировкаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.тренировкаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.тренировкаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.тренировкаBindingNavigator.Name = "тренировкаBindingNavigator";
            this.тренировкаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.тренировкаBindingNavigator.Size = new System.Drawing.Size(1208, 27);
            this.тренировкаBindingNavigator.TabIndex = 0;
            this.тренировкаBindingNavigator.Text = "bindingNavigator1";
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
            // тренировкаBindingNavigatorSaveItem
            // 
            this.тренировкаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.тренировкаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("тренировкаBindingNavigatorSaveItem.Image")));
            this.тренировкаBindingNavigatorSaveItem.Name = "тренировкаBindingNavigatorSaveItem";
            this.тренировкаBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.тренировкаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.тренировкаBindingNavigatorSaveItem.Click += new System.EventHandler(this.тренировкаBindingNavigatorSaveItem_Click);
            // 
            // тренировкаDataGridView
            // 
            this.тренировкаDataGridView.AutoGenerateColumns = false;
            this.тренировкаDataGridView.BackgroundColor = System.Drawing.Color.Pink;
            this.тренировкаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.тренировкаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.тренировкаDataGridView.DataSource = this.тренировкаBindingSource;
            this.тренировкаDataGridView.Location = new System.Drawing.Point(12, 30);
            this.тренировкаDataGridView.Name = "тренировкаDataGridView";
            this.тренировкаDataGridView.RowTemplate.Height = 24;
            this.тренировкаDataGridView.Size = new System.Drawing.Size(975, 414);
            this.тренировкаDataGridView.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(1077, 390);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 50);
            this.button5.TabIndex = 21;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(1077, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 50);
            this.button4.TabIndex = 20;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1077, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 50);
            this.button3.TabIndex = 19;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(992, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 68);
            this.button2.TabIndex = 18;
            this.button2.Text = "↓";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(992, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 68);
            this.button1.TabIndex = 17;
            this.button1.Text = "↑";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // тренерBindingSource
            // 
            this.тренерBindingSource.DataMember = "Тренер";
            this.тренерBindingSource.DataSource = this.bDDataSet;
            // 
            // тренерTableAdapter
            // 
            this.тренерTableAdapter.ClearBeforeFill = true;
            // 
            // группаBindingSource
            // 
            this.группаBindingSource.DataMember = "Группа";
            this.группаBindingSource.DataSource = this.bDDataSet;
            // 
            // группаTableAdapter
            // 
            this.группаTableAdapter.ClearBeforeFill = true;
            // 
            // видСпортаBindingSource
            // 
            this.видСпортаBindingSource.DataMember = "Вид спорта";
            this.видСпортаBindingSource.DataSource = this.bDDataSet;
            // 
            // вид_спортаTableAdapter
            // 
            this.вид_спортаTableAdapter.ClearBeforeFill = true;
            // 
            // наборКатегорийBindingSource
            // 
            this.наборКатегорийBindingSource.DataMember = "Набор категорий";
            this.наборКатегорийBindingSource.DataSource = this.bDDataSet;
            // 
            // набор_категорийTableAdapter
            // 
            this.набор_категорийTableAdapter.ClearBeforeFill = true;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тренировкаBindingSource, "Время", true));
            this.textBox3.Location = new System.Drawing.Point(1086, 197);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1113, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 62;
            this.label3.Text = "Время:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1113, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Дата:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тренировкаBindingSource, "Дата", true));
            this.textBox2.Location = new System.Drawing.Point(1086, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_trenirovka";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_trenirovka";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Время";
            this.dataGridViewTextBoxColumn3.HeaderText = "Время";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Вид спорта";
            this.dataGridViewTextBoxColumn4.DataSource = this.видСпортаBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Наименование";
            this.dataGridViewTextBoxColumn4.HeaderText = "Вид спорта";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "ID_Sport";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Группа";
            this.dataGridViewTextBoxColumn5.DataSource = this.группаBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "Наименование";
            this.dataGridViewTextBoxColumn5.HeaderText = "Группа";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "ID_Group";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Тренер";
            this.dataGridViewTextBoxColumn6.DataSource = this.тренерBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "ФИО";
            this.dataGridViewTextBoxColumn6.HeaderText = "Тренер";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "ID_Trener";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn7.DataSource = this.наборКатегорийBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "Наименование";
            this.dataGridViewTextBoxColumn7.HeaderText = "Наименование спортивного сооружения";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "ID_Category";
            // 
            // Trenirovka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.тренировкаDataGridView);
            this.Controls.Add(this.тренировкаBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1226, 497);
            this.MinimumSize = new System.Drawing.Size(1226, 497);
            this.Name = "Trenirovka";
            this.Text = "Тренировка";
            this.Load += new System.EventHandler(this.Trenirovka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тренировкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тренировкаBindingNavigator)).EndInit();
            this.тренировкаBindingNavigator.ResumeLayout(false);
            this.тренировкаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.тренировкаDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тренерBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видСпортаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.наборКатегорийBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource тренировкаBindingSource;
        private BDDataSetTableAdapters.ТренировкаTableAdapter тренировкаTableAdapter;
        private BDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator тренировкаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton тренировкаBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView тренировкаDataGridView;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource тренерBindingSource;
        private BDDataSetTableAdapters.ТренерTableAdapter тренерTableAdapter;
        private System.Windows.Forms.BindingSource группаBindingSource;
        private BDDataSetTableAdapters.ГруппаTableAdapter группаTableAdapter;
        private System.Windows.Forms.BindingSource видСпортаBindingSource;
        private BDDataSetTableAdapters.Вид_спортаTableAdapter вид_спортаTableAdapter;
        private System.Windows.Forms.BindingSource наборКатегорийBindingSource;
        private BDDataSetTableAdapters.Набор_категорийTableAdapter набор_категорийTableAdapter;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
    }
}