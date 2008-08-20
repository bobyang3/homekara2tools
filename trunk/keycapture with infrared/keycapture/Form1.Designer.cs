namespace keycapture
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbl_Remote2BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_Remote2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.songDataSet = new keycapture.SongDataSet();
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
            this.tbl_Remote2BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_Remote2DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbl_Remote2TableAdapter = new keycapture.SongDataSetTableAdapters.Tbl_Remote2TableAdapter();
            this.axIRConnect1 = new AxInfrared.AxIRConnect();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Remote2BindingNavigator)).BeginInit();
            this.tbl_Remote2BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Remote2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Remote2DataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axIRConnect1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_Remote2BindingNavigator
            // 
            this.tbl_Remote2BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_Remote2BindingNavigator.BindingSource = this.tbl_Remote2BindingSource;
            this.tbl_Remote2BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_Remote2BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_Remote2BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbl_Remote2BindingNavigatorSaveItem});
            this.tbl_Remote2BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_Remote2BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_Remote2BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_Remote2BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_Remote2BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_Remote2BindingNavigator.Name = "tbl_Remote2BindingNavigator";
            this.tbl_Remote2BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_Remote2BindingNavigator.Size = new System.Drawing.Size(525, 25);
            this.tbl_Remote2BindingNavigator.TabIndex = 3;
            this.tbl_Remote2BindingNavigator.Text = "bindingNavigator1";
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
            // tbl_Remote2BindingSource
            // 
            this.tbl_Remote2BindingSource.DataMember = "Tbl_Remote2";
            this.tbl_Remote2BindingSource.DataSource = this.songDataSet;
            // 
            // songDataSet
            // 
            this.songDataSet.DataSetName = "SongDataSet";
            this.songDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // tbl_Remote2BindingNavigatorSaveItem
            // 
            this.tbl_Remote2BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_Remote2BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_Remote2BindingNavigatorSaveItem.Image")));
            this.tbl_Remote2BindingNavigatorSaveItem.Name = "tbl_Remote2BindingNavigatorSaveItem";
            this.tbl_Remote2BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbl_Remote2BindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_Remote2BindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_Remote2BindingNavigatorSaveItem_Click);
            // 
            // tbl_Remote2DataGridView
            // 
            this.tbl_Remote2DataGridView.AutoGenerateColumns = false;
            this.tbl_Remote2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tbl_Remote2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tbl_Remote2DataGridView.DataSource = this.tbl_Remote2BindingSource;
            this.tbl_Remote2DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Remote2DataGridView.Location = new System.Drawing.Point(0, 25);
            this.tbl_Remote2DataGridView.Name = "tbl_Remote2DataGridView";
            this.tbl_Remote2DataGridView.ReadOnly = true;
            this.tbl_Remote2DataGridView.Size = new System.Drawing.Size(525, 262);
            this.tbl_Remote2DataGridView.TabIndex = 3;
            this.tbl_Remote2DataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbl_Remote2DataGridView_KeyDown);
            this.tbl_Remote2DataGridView.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tbl_Remote2DataGridView_PreviewKeyDown);
            this.tbl_Remote2DataGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbl_Remote2DataGridView_KeyUp);
            this.tbl_Remote2DataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbl_Remote2DataGridView_KeyPress);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Remote_Intro";
            this.dataGridViewTextBoxColumn1.HeaderText = "Remote_Intro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 96;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Remote_KeyCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "Remote_KeyCode";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 118;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Remote_RemoteCode";
            this.dataGridViewTextBoxColumn3.HeaderText = "Remote_RemoteCode";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 137;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 265);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(525, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(316, 17);
            this.toolStripStatusLabel1.Text = "Please contact me if you see any bugs http://bobyang.no-ip.org";
            // 
            // tbl_Remote2TableAdapter
            // 
            this.tbl_Remote2TableAdapter.ClearBeforeFill = true;
            // 
            // axIRConnect1
            // 
            this.axIRConnect1.Enabled = true;
            this.axIRConnect1.Location = new System.Drawing.Point(402, 265);
            this.axIRConnect1.Name = "axIRConnect1";
            this.axIRConnect1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axIRConnect1.OcxState")));
            this.axIRConnect1.Size = new System.Drawing.Size(75, 23);
            this.axIRConnect1.TabIndex = 6;
            this.axIRConnect1.Error += new AxInfrared.@__IRConnect_ErrorEventHandler(this.axIRConnect1_Error);
            this.axIRConnect1.DataReceived += new AxInfrared.@__IRConnect_DataReceivedEventHandler(this.axIRConnect1_DataReceived);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "啟動紅外線";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(358, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "讀取紅外線訊息";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 287);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axIRConnect1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbl_Remote2DataGridView);
            this.Controls.Add(this.tbl_Remote2BindingNavigator);
            this.Name = "Form1";
            this.Text = "KeyLearning - put this to the same song.mbd folder";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Remote2BindingNavigator)).EndInit();
            this.tbl_Remote2BindingNavigator.ResumeLayout(false);
            this.tbl_Remote2BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Remote2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Remote2DataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axIRConnect1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SongDataSet songDataSet;
        private System.Windows.Forms.BindingSource tbl_Remote2BindingSource;
        private keycapture.SongDataSetTableAdapters.Tbl_Remote2TableAdapter tbl_Remote2TableAdapter;
        private System.Windows.Forms.BindingNavigator tbl_Remote2BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbl_Remote2BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tbl_Remote2DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private AxInfrared.AxIRConnect axIRConnect1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

