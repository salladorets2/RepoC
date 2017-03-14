namespace prgTchLB1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.eventsTableAdapter = new prgTchLB1.sql11156565DataSetTableAdapters.EventsTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вызодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vanuesReservCustToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservesCustToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sql11156565DataSet = new prgTchLB1.sql11156565DataSet();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new prgTchLB1.sql11156565DataSetTableAdapters.TableAdapterManager();
            this.vanuesTableAdapter = new prgTchLB1.sql11156565DataSetTableAdapters.VanuesTableAdapter();
            this.eventsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.eventsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eventsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vanuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vanuesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sql11156565DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingNavigator)).BeginInit();
            this.eventsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanuesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanuesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // eventsTableAdapter
            // 
            this.eventsTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.переходToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyDown);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вызодToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.ToolTipText = "Управление программой.";
            // 
            // вызодToolStripMenuItem
            // 
            this.вызодToolStripMenuItem.Name = "вызодToolStripMenuItem";
            this.вызодToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.вызодToolStripMenuItem.Text = "Выход";
            this.вызодToolStripMenuItem.Click += new System.EventHandler(this.вызодToolStripMenuItem_Click);
            // 
            // переходToolStripMenuItem
            // 
            this.переходToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vanuesReservCustToolStripMenuItem,
            this.reservesCustToolStripMenuItem});
            this.переходToolStripMenuItem.Name = "переходToolStripMenuItem";
            this.переходToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.переходToolStripMenuItem.Text = "Переход";
            this.переходToolStripMenuItem.ToolTipText = "Совершить переход к другой таблице.";
            // 
            // vanuesReservCustToolStripMenuItem
            // 
            this.vanuesReservCustToolStripMenuItem.Name = "vanuesReservCustToolStripMenuItem";
            this.vanuesReservCustToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.vanuesReservCustToolStripMenuItem.Text = "Vanues-Reserves";
            this.vanuesReservCustToolStripMenuItem.ToolTipText = "Таблица \"Арена-Резервы\"";
            this.vanuesReservCustToolStripMenuItem.Click += new System.EventHandler(this.vanuesReservCustToolStripMenuItem_Click);
            // 
            // reservesCustToolStripMenuItem
            // 
            this.reservesCustToolStripMenuItem.Name = "reservesCustToolStripMenuItem";
            this.reservesCustToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.reservesCustToolStripMenuItem.Text = "Reserves-Cust";
            this.reservesCustToolStripMenuItem.ToolTipText = "Таблица \"Покупатели-Резервы\"";
            this.reservesCustToolStripMenuItem.Click += new System.EventHandler(this.reservesCustToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.помощьToolStripMenuItem1});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem1
            // 
            this.помощьToolStripMenuItem1.Name = "помощьToolStripMenuItem1";
            this.помощьToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.помощьToolStripMenuItem1.Text = "Помощь";
            this.помощьToolStripMenuItem1.Click += new System.EventHandler(this.помощьToolStripMenuItem1_Click);
            // 
            // sql11156565DataSet
            // 
            this.sql11156565DataSet.DataSetName = "sql11156565DataSet";
            this.sql11156565DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "Events";
            this.eventsBindingSource.DataSource = this.sql11156565DataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EventsTableAdapter = this.eventsTableAdapter;
            this.tableAdapterManager.ReserveTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prgTchLB1.sql11156565DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VanuesTableAdapter = this.vanuesTableAdapter;
            // 
            // vanuesTableAdapter
            // 
            this.vanuesTableAdapter.ClearBeforeFill = true;
            // 
            // eventsBindingNavigator
            // 
            this.eventsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eventsBindingNavigator.BindingSource = this.eventsBindingSource;
            this.eventsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eventsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eventsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eventsBindingNavigatorSaveItem});
            this.eventsBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.eventsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eventsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eventsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eventsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eventsBindingNavigator.Name = "eventsBindingNavigator";
            this.eventsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eventsBindingNavigator.Size = new System.Drawing.Size(957, 25);
            this.eventsBindingNavigator.TabIndex = 4;
            this.eventsBindingNavigator.Text = "bindingNavigator1";
            this.eventsBindingNavigator.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Navig_KeyDown);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            this.bindingNavigatorPositionItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Navig_KeyDown);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // eventsBindingNavigatorSaveItem
            // 
            this.eventsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eventsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eventsBindingNavigatorSaveItem.Image")));
            this.eventsBindingNavigatorSaveItem.Name = "eventsBindingNavigatorSaveItem";
            this.eventsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.eventsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.eventsBindingNavigatorSaveItem.Click += new System.EventHandler(this.eventsBindingNavigatorSaveItem_Click);
            // 
            // eventsDataGridView
            // 
            this.eventsDataGridView.AutoGenerateColumns = false;
            this.eventsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.eventsDataGridView.DataSource = this.eventsBindingSource;
            this.eventsDataGridView.Location = new System.Drawing.Point(12, 52);
            this.eventsDataGridView.Name = "eventsDataGridView";
            this.eventsDataGridView.Size = new System.Drawing.Size(259, 369);
            this.eventsDataGridView.TabIndex = 4;
            this.eventsDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.parentTB_KeyDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idEvents";
            this.dataGridViewTextBoxColumn1.HeaderText = "Идентификатор события";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name_Sport";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название вида спорта";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // vanuesBindingSource
            // 
            this.vanuesBindingSource.DataMember = "fk_Vanues_Events1";
            this.vanuesBindingSource.DataSource = this.eventsBindingSource;
            // 
            // vanuesDataGridView
            // 
            this.vanuesDataGridView.AutoGenerateColumns = false;
            this.vanuesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vanuesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn6});
            this.vanuesDataGridView.DataSource = this.vanuesBindingSource;
            this.vanuesDataGridView.Location = new System.Drawing.Point(277, 52);
            this.vanuesDataGridView.Name = "vanuesDataGridView";
            this.vanuesDataGridView.RowTemplate.Height = 80;
            this.vanuesDataGridView.Size = new System.Drawing.Size(668, 369);
            this.vanuesDataGridView.TabIndex = 4;
            this.vanuesDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Child_KeyDown);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idVanues";
            this.dataGridViewTextBoxColumn3.HeaderText = "Идентификатор строения";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name_Arena";
            this.dataGridViewTextBoxColumn4.HeaderText = "Название арены";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "City_Arena";
            this.dataGridViewTextBoxColumn5.HeaderText = "Город";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Photo_Arena";
            this.dataGridViewImageColumn1.HeaderText = "Фото арены";
            this.dataGridViewImageColumn1.MinimumWidth = 200;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Events_idEvents";
            this.dataGridViewTextBoxColumn6.HeaderText = "Идентификатор события";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(957, 433);
            this.Controls.Add(this.vanuesDataGridView);
            this.Controls.Add(this.eventsDataGridView);
            this.Controls.Add(this.eventsBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sql11156565DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingNavigator)).EndInit();
            this.eventsBindingNavigator.ResumeLayout(false);
            this.eventsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanuesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanuesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private sql11156565DataSetTableAdapters.EventsTableAdapter eventsTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вызодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vanuesReservCustToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservesCustToolStripMenuItem;
        private sql11156565DataSet sql11156565DataSet;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private sql11156565DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eventsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton eventsBindingNavigatorSaveItem;
        private sql11156565DataSetTableAdapters.VanuesTableAdapter vanuesTableAdapter;
        private System.Windows.Forms.DataGridView eventsDataGridView;
        private System.Windows.Forms.BindingSource vanuesBindingSource;
        private System.Windows.Forms.DataGridView vanuesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem1;
    }
}

