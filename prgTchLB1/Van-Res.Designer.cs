namespace prgTchLB1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вызодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsVanuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservesCustToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sql11156565DataSet = new prgTchLB1.sql11156565DataSet();
            this.vanuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vanuesTableAdapter = new prgTchLB1.sql11156565DataSetTableAdapters.VanuesTableAdapter();
            this.tableAdapterManager = new prgTchLB1.sql11156565DataSetTableAdapters.TableAdapterManager();
            this.reserveTableAdapter = new prgTchLB1.sql11156565DataSetTableAdapters.ReserveTableAdapter();
            this.vanuesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vanuesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vanuesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reserveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reserveDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sql11156565DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanuesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanuesBindingNavigator)).BeginInit();
            this.vanuesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vanuesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вызодToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // вызодToolStripMenuItem
            // 
            this.вызодToolStripMenuItem.Name = "вызодToolStripMenuItem";
            this.вызодToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.вызодToolStripMenuItem.Text = "Выход";
            this.вызодToolStripMenuItem.Click += new System.EventHandler(this.вызодToolStripMenuItem_Click);
            // 
            // переходToolStripMenuItem
            // 
            this.переходToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventsVanuesToolStripMenuItem,
            this.reservesCustToolStripMenuItem});
            this.переходToolStripMenuItem.Name = "переходToolStripMenuItem";
            this.переходToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.переходToolStripMenuItem.Text = "Переход";
            // 
            // eventsVanuesToolStripMenuItem
            // 
            this.eventsVanuesToolStripMenuItem.Name = "eventsVanuesToolStripMenuItem";
            this.eventsVanuesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eventsVanuesToolStripMenuItem.Text = "Events-Vanues";
            this.eventsVanuesToolStripMenuItem.ToolTipText = "Таблица \"Событие-Арена\"";
            this.eventsVanuesToolStripMenuItem.Click += new System.EventHandler(this.eventsVanuesToolStripMenuItem_Click);
            // 
            // reservesCustToolStripMenuItem
            // 
            this.reservesCustToolStripMenuItem.Name = "reservesCustToolStripMenuItem";
            this.reservesCustToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reservesCustToolStripMenuItem.Text = "Reserves-Cust";
            this.reservesCustToolStripMenuItem.ToolTipText = "Таблица \"Покупатели-Резервы\"";
            this.reservesCustToolStripMenuItem.Click += new System.EventHandler(this.reservesCustToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.переходToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(716, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyDown);
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
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // помощьToolStripMenuItem1
            // 
            this.помощьToolStripMenuItem1.Name = "помощьToolStripMenuItem1";
            this.помощьToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.помощьToolStripMenuItem1.Text = "Помощь";
            this.помощьToolStripMenuItem1.Click += new System.EventHandler(this.помощьToolStripMenuItem1_Click);
            // 
            // sql11156565DataSet
            // 
            this.sql11156565DataSet.DataSetName = "sql11156565DataSet";
            this.sql11156565DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vanuesBindingSource
            // 
            this.vanuesBindingSource.DataMember = "Vanues";
            this.vanuesBindingSource.DataSource = this.sql11156565DataSet;
            // 
            // vanuesTableAdapter
            // 
            this.vanuesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EventsTableAdapter = null;
            this.tableAdapterManager.ReserveTableAdapter = this.reserveTableAdapter;
            this.tableAdapterManager.UpdateOrder = prgTchLB1.sql11156565DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VanuesTableAdapter = this.vanuesTableAdapter;
            // 
            // reserveTableAdapter
            // 
            this.reserveTableAdapter.ClearBeforeFill = true;
            // 
            // vanuesBindingNavigator
            // 
            this.vanuesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vanuesBindingNavigator.BindingSource = this.vanuesBindingSource;
            this.vanuesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vanuesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vanuesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vanuesBindingNavigatorSaveItem});
            this.vanuesBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.vanuesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vanuesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vanuesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vanuesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vanuesBindingNavigator.Name = "vanuesBindingNavigator";
            this.vanuesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vanuesBindingNavigator.Size = new System.Drawing.Size(716, 25);
            this.vanuesBindingNavigator.TabIndex = 1;
            this.vanuesBindingNavigator.Text = "bindingNavigator1";
            this.vanuesBindingNavigator.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Navig_KeyDown);
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
            // vanuesBindingNavigatorSaveItem
            // 
            this.vanuesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vanuesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vanuesBindingNavigatorSaveItem.Image")));
            this.vanuesBindingNavigatorSaveItem.Name = "vanuesBindingNavigatorSaveItem";
            this.vanuesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vanuesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.vanuesBindingNavigatorSaveItem.Click += new System.EventHandler(this.vanuesBindingNavigatorSaveItem_Click);
            // 
            // vanuesDataGridView
            // 
            this.vanuesDataGridView.AutoGenerateColumns = false;
            this.vanuesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vanuesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn4});
            this.vanuesDataGridView.DataSource = this.vanuesBindingSource;
            this.vanuesDataGridView.Location = new System.Drawing.Point(12, 52);
            this.vanuesDataGridView.Name = "vanuesDataGridView";
            this.vanuesDataGridView.RowTemplate.Height = 80;
            this.vanuesDataGridView.Size = new System.Drawing.Size(684, 298);
            this.vanuesDataGridView.TabIndex = 2;
            this.vanuesDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.parentTB_KeyDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idVanues";
            this.dataGridViewTextBoxColumn1.HeaderText = "Идентификатор";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name_Arena";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название арены";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "City_Arena";
            this.dataGridViewTextBoxColumn3.HeaderText = "Город ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Photo_Arena";
            this.dataGridViewImageColumn1.HeaderText = "Фото";
            this.dataGridViewImageColumn1.MinimumWidth = 200;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Events_idEvents";
            this.dataGridViewTextBoxColumn4.HeaderText = "Идентификатор события";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // reserveBindingSource
            // 
            this.reserveBindingSource.DataMember = "fk_Reserve_Vanues1";
            this.reserveBindingSource.DataSource = this.vanuesBindingSource;
            // 
            // reserveDataGridView
            // 
            this.reserveDataGridView.AutoGenerateColumns = false;
            this.reserveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reserveDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.reserveDataGridView.DataSource = this.reserveBindingSource;
            this.reserveDataGridView.Location = new System.Drawing.Point(12, 356);
            this.reserveDataGridView.Name = "reserveDataGridView";
            this.reserveDataGridView.Size = new System.Drawing.Size(684, 231);
            this.reserveDataGridView.TabIndex = 3;
            this.reserveDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Child_KeyDown);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "idReserve";
            this.dataGridViewTextBoxColumn5.HeaderText = "Идентификатор резерва";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn6.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Count";
            this.dataGridViewTextBoxColumn7.HeaderText = "Кол-во билетов";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Customer_idCust";
            this.dataGridViewTextBoxColumn8.HeaderText = "Идентификатор клиента";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Vanues_idVanues";
            this.dataGridViewTextBoxColumn9.HeaderText = "Идентификатор строения";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Vanues_Events_idEvents";
            this.dataGridViewTextBoxColumn10.HeaderText = "Идентификатор события";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(716, 599);
            this.Controls.Add(this.reserveDataGridView);
            this.Controls.Add(this.vanuesDataGridView);
            this.Controls.Add(this.vanuesBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sql11156565DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanuesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanuesBindingNavigator)).EndInit();
            this.vanuesBindingNavigator.ResumeLayout(false);
            this.vanuesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vanuesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вызодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsVanuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservesCustToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private sql11156565DataSet sql11156565DataSet;
        private System.Windows.Forms.BindingSource vanuesBindingSource;
        private sql11156565DataSetTableAdapters.VanuesTableAdapter vanuesTableAdapter;
        private sql11156565DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vanuesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vanuesBindingNavigatorSaveItem;
        private sql11156565DataSetTableAdapters.ReserveTableAdapter reserveTableAdapter;
        private System.Windows.Forms.DataGridView vanuesDataGridView;
        private System.Windows.Forms.BindingSource reserveBindingSource;
        private System.Windows.Forms.DataGridView reserveDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem1;
    }
}