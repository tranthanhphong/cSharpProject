namespace HUFLITplayer
{
    partial class Library
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label artistLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library));
            System.Windows.Forms.Label uRLLabel;
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.mediaInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mediaInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.dataDataSet2 = new HUFLITplayer.DataDataSet2();
            this.mediaInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mediaInfoTableAdapter1 = new HUFLITplayer.DataDataSet2TableAdapters.MediaInfoTableAdapter();
            this.tableAdapterManager1 = new HUFLITplayer.DataDataSet2TableAdapters.TableAdapterManager();
            this.iDSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.yearSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.artistTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mediaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet1 = new HUFLITplayer.DataDataSet1();
            this.mediaInfoTableAdapter = new HUFLITplayer.DataDataSet1TableAdapters.MediaInfoTableAdapter();
            this.tableAdapterManager = new HUFLITplayer.DataDataSet1TableAdapters.TableAdapterManager();
            this.uRLTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mediaInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            artistLabel = new System.Windows.Forms.Label();
            uRLLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mediaInfoBindingNavigator)).BeginInit();
            this.mediaInfoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRLTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaInfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(51, 97);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 11;
            iDLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(51, 123);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 13;
            nameLabel.Text = "Name:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(51, 149);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(32, 13);
            yearLabel.TabIndex = 15;
            yearLabel.Text = "Year:";
            // 
            // artistLabel
            // 
            artistLabel.AutoSize = true;
            artistLabel.Location = new System.Drawing.Point(51, 175);
            artistLabel.Name = "artistLabel";
            artistLabel.Size = new System.Drawing.Size(33, 13);
            artistLabel.TabIndex = 17;
            artistLabel.Text = "Artist:";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            // 
            // colYear
            // 
            this.colYear.FieldName = "Year";
            this.colYear.Name = "colYear";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Song list...";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // mediaInfoBindingNavigatorSaveItem
            // 
            this.mediaInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mediaInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mediaInfoBindingNavigatorSaveItem.Image")));
            this.mediaInfoBindingNavigatorSaveItem.Name = "mediaInfoBindingNavigatorSaveItem";
            this.mediaInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mediaInfoBindingNavigatorSaveItem.Text = "Save Data";
            this.mediaInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.mediaInfoBindingNavigatorSaveItem_Click);
            // 
            // mediaInfoBindingNavigator
            // 
            this.mediaInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mediaInfoBindingNavigator.BindingSource = this.mediaInfoBindingSource;
            this.mediaInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mediaInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mediaInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mediaInfoBindingNavigatorSaveItem});
            this.mediaInfoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mediaInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mediaInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mediaInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mediaInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mediaInfoBindingNavigator.Name = "mediaInfoBindingNavigator";
            this.mediaInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mediaInfoBindingNavigator.Size = new System.Drawing.Size(774, 25);
            this.mediaInfoBindingNavigator.TabIndex = 0;
            this.mediaInfoBindingNavigator.Text = "bindingNavigator1";
            this.mediaInfoBindingNavigator.RefreshItems += new System.EventHandler(this.mediaInfoBindingNavigator_RefreshItems);
            // 
            // dataDataSet2
            // 
            this.dataDataSet2.DataSetName = "DataDataSet2";
            this.dataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mediaInfoBindingSource1
            // 
            this.mediaInfoBindingSource1.DataMember = "MediaInfo";
            this.mediaInfoBindingSource1.DataSource = this.dataDataSet2;
            // 
            // mediaInfoTableAdapter1
            // 
            this.mediaInfoTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.MediaInfoTableAdapter = this.mediaInfoTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = HUFLITplayer.DataDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDSpinEdit
            // 
            this.iDSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mediaInfoBindingSource, "ID", true));
            this.iDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.iDSpinEdit.Location = new System.Drawing.Point(95, 94);
            this.iDSpinEdit.Name = "iDSpinEdit";
            this.iDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.iDSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.iDSpinEdit.TabIndex = 12;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mediaInfoBindingSource, "Name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(95, 120);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(100, 20);
            this.nameTextEdit.TabIndex = 14;
            // 
            // yearSpinEdit
            // 
            this.yearSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mediaInfoBindingSource, "Year", true));
            this.yearSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.yearSpinEdit.Location = new System.Drawing.Point(95, 146);
            this.yearSpinEdit.Name = "yearSpinEdit";
            this.yearSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.yearSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.yearSpinEdit.TabIndex = 16;
            // 
            // artistTextEdit
            // 
            this.artistTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mediaInfoBindingSource, "Artist", true));
            this.artistTextEdit.Location = new System.Drawing.Point(95, 172);
            this.artistTextEdit.Name = "artistTextEdit";
            this.artistTextEdit.Size = new System.Drawing.Size(100, 20);
            this.artistTextEdit.TabIndex = 18;
            // 
            // mediaInfoBindingSource
            // 
            this.mediaInfoBindingSource.DataMember = "MediaInfo";
            this.mediaInfoBindingSource.DataSource = this.dataDataSet1;
            // 
            // dataDataSet1
            // 
            this.dataDataSet1.DataSetName = "DataDataSet1";
            this.dataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mediaInfoTableAdapter
            // 
            this.mediaInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MediaInfoTableAdapter = this.mediaInfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = HUFLITplayer.DataDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // uRLLabel
            // 
            uRLLabel.AutoSize = true;
            uRLLabel.Location = new System.Drawing.Point(57, 201);
            uRLLabel.Name = "uRLLabel";
            uRLLabel.Size = new System.Drawing.Size(32, 13);
            uRLLabel.TabIndex = 18;
            uRLLabel.Text = "URL:";
            // 
            // uRLTextEdit
            // 
            this.uRLTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mediaInfoBindingSource, "URL", true));
            this.uRLTextEdit.Location = new System.Drawing.Point(95, 198);
            this.uRLTextEdit.Name = "uRLTextEdit";
            this.uRLTextEdit.Size = new System.Drawing.Size(100, 20);
            this.uRLTextEdit.TabIndex = 19;
            // 
            // mediaInfoDataGridView
            // 
            this.mediaInfoDataGridView.AutoGenerateColumns = false;
            this.mediaInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mediaInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.mediaInfoDataGridView.DataSource = this.mediaInfoBindingSource;
            this.mediaInfoDataGridView.Location = new System.Drawing.Point(201, 123);
            this.mediaInfoDataGridView.Name = "mediaInfoDataGridView";
            this.mediaInfoDataGridView.Size = new System.Drawing.Size(538, 220);
            this.mediaInfoDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn3.HeaderText = "Year";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Artist";
            this.dataGridViewTextBoxColumn4.HeaderText = "Artist";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "URL";
            this.dataGridViewTextBoxColumn5.HeaderText = "URL";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 508);
            this.Controls.Add(this.mediaInfoDataGridView);
            this.Controls.Add(uRLLabel);
            this.Controls.Add(this.uRLTextEdit);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDSpinEdit);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextEdit);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearSpinEdit);
            this.Controls.Add(artistLabel);
            this.Controls.Add(this.artistTextEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mediaInfoBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Library";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Manager";
            this.Load += new System.EventHandler(this.Library_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaInfoBindingNavigator)).EndInit();
            this.mediaInfoBindingNavigator.ResumeLayout(false);
            this.mediaInfoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRLTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaInfoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataDataSet1 dataDataSet1;
        private System.Windows.Forms.BindingSource mediaInfoBindingSource;
        private DataDataSet1TableAdapters.MediaInfoTableAdapter mediaInfoTableAdapter;
        private DataDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private System.Windows.Forms.Label label1;
        private DataDataSet2 dataDataSet2;
        private System.Windows.Forms.BindingSource mediaInfoBindingSource1;
        private DataDataSet2TableAdapters.MediaInfoTableAdapter mediaInfoTableAdapter1;
        private DataDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton mediaInfoBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator mediaInfoBindingNavigator;
        private DevExpress.XtraEditors.SpinEdit iDSpinEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.SpinEdit yearSpinEdit;
        private DevExpress.XtraEditors.TextEdit artistTextEdit;
        private DevExpress.XtraEditors.TextEdit uRLTextEdit;
        private System.Windows.Forms.DataGridView mediaInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}