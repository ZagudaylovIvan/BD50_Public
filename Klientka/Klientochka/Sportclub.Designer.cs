﻿namespace Klientochka
{
    partial class Sportclub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sportclub));
            this.bDDataSet = new Klientochka.BDDataSet();
            this.спортивный_клубBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.спортивный_клубTableAdapter = new Klientochka.BDDataSetTableAdapters.Спортивный_клубTableAdapter();
            this.tableAdapterManager = new Klientochka.BDDataSetTableAdapters.TableAdapterManager();
            this.спортивный_клубBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.спортивный_клубBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.спортивный_клубDataGridView = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.спортивный_клубBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.спортивный_клубBindingNavigator)).BeginInit();
            this.спортивный_клубBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.спортивный_клубDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // спортивный_клубBindingSource
            // 
            this.спортивный_клубBindingSource.DataMember = "Спортивный клуб";
            this.спортивный_клубBindingSource.DataSource = this.bDDataSet;
            // 
            // спортивный_клубTableAdapter
            // 
            this.спортивный_клубTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Спортивный_клубTableAdapter = this.спортивный_клубTableAdapter;
            this.tableAdapterManager.СпортсменTableAdapter = null;
            this.tableAdapterManager.Тип_покрытияTableAdapter = null;
            this.tableAdapterManager.Тип_сооруженияTableAdapter = null;
            this.tableAdapterManager.ТренерTableAdapter = null;
            this.tableAdapterManager.ТренировкаTableAdapter = null;
            // 
            // спортивный_клубBindingNavigator
            // 
            this.спортивный_клубBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.спортивный_клубBindingNavigator.BindingSource = this.спортивный_клубBindingSource;
            this.спортивный_клубBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.спортивный_клубBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.спортивный_клубBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.спортивный_клубBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.спортивный_клубBindingNavigatorSaveItem});
            this.спортивный_клубBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.спортивный_клубBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.спортивный_клубBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.спортивный_клубBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.спортивный_клубBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.спортивный_клубBindingNavigator.Name = "спортивный_клубBindingNavigator";
            this.спортивный_клубBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.спортивный_клубBindingNavigator.Size = new System.Drawing.Size(697, 27);
            this.спортивный_клубBindingNavigator.TabIndex = 0;
            this.спортивный_клубBindingNavigator.Text = "bindingNavigator1";
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
            // спортивный_клубBindingNavigatorSaveItem
            // 
            this.спортивный_клубBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.спортивный_клубBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("спортивный_клубBindingNavigatorSaveItem.Image")));
            this.спортивный_клубBindingNavigatorSaveItem.Name = "спортивный_клубBindingNavigatorSaveItem";
            this.спортивный_клубBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.спортивный_клубBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.спортивный_клубBindingNavigatorSaveItem.Click += new System.EventHandler(this.спортивный_клубBindingNavigatorSaveItem_Click);
            // 
            // спортивный_клубDataGridView
            // 
            this.спортивный_клубDataGridView.AutoGenerateColumns = false;
            this.спортивный_клубDataGridView.BackgroundColor = System.Drawing.Color.Pink;
            this.спортивный_клубDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.спортивный_клубDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.спортивный_клубDataGridView.DataSource = this.спортивный_клубBindingSource;
            this.спортивный_клубDataGridView.Location = new System.Drawing.Point(12, 30);
            this.спортивный_клубDataGridView.Name = "спортивный_клубDataGridView";
            this.спортивный_клубDataGridView.RowTemplate.Height = 24;
            this.спортивный_клубDataGridView.Size = new System.Drawing.Size(454, 413);
            this.спортивный_клубDataGridView.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(560, 390);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 50);
            this.button5.TabIndex = 36;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(560, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 50);
            this.button4.TabIndex = 35;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(560, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 50);
            this.button3.TabIndex = 34;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(475, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 68);
            this.button2.TabIndex = 33;
            this.button2.Text = "↓";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(475, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 68);
            this.button1.TabIndex = 32;
            this.button1.Text = "↑";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Адрес:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Название:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.спортивный_клубBindingSource, "Адрес", true));
            this.textBox2.Location = new System.Drawing.Point(575, 208);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 59;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.спортивный_клубBindingSource, "Название", true));
            this.textBox1.Location = new System.Drawing.Point(575, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 58;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Club";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Club";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn3.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Sportclub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.спортивный_клубDataGridView);
            this.Controls.Add(this.спортивный_клубBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(715, 497);
            this.MinimumSize = new System.Drawing.Size(715, 497);
            this.Name = "Sportclub";
            this.Text = "Спортивный клуб";
            this.Load += new System.EventHandler(this.Sportclub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.спортивный_клубBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.спортивный_клубBindingNavigator)).EndInit();
            this.спортивный_клубBindingNavigator.ResumeLayout(false);
            this.спортивный_клубBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.спортивный_клубDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource спортивный_клубBindingSource;
        private BDDataSetTableAdapters.Спортивный_клубTableAdapter спортивный_клубTableAdapter;
        private BDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator спортивный_клубBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton спортивный_клубBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView спортивный_клубDataGridView;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}