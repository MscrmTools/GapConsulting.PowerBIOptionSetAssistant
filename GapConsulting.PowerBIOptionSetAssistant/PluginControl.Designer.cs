namespace GapConsulting.PowerBIOptionSetAssistant
{
    partial class PluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginControl));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCloseThisTab = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLoadEntities = new System.Windows.Forms.ToolStripButton();
            this.tsbCreateRecords = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteEntity = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvEntities = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvOptionSets = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.llSelectNoOptionSet = new System.Windows.Forms.LinkLabel();
            this.llSelectAllOptionSet = new System.Windows.Forms.LinkLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCloseThisTab,
            this.toolStripSeparator2,
            this.tsbLoadEntities,
            this.tsbCreateRecords,
            this.tsbDeleteEntity});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1917, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbCloseThisTab
            // 
            this.tsbCloseThisTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCloseThisTab.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tsbCloseThisTab.Image = ((System.Drawing.Image)(resources.GetObject("tsbCloseThisTab.Image")));
            this.tsbCloseThisTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCloseThisTab.Name = "tsbCloseThisTab";
            this.tsbCloseThisTab.Size = new System.Drawing.Size(28, 29);
            this.tsbCloseThisTab.Text = "Close this tab";
            this.tsbCloseThisTab.Click += new System.EventHandler(this.tsbCloseThisTab_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // tsbLoadEntities
            // 
            this.tsbLoadEntities.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoadEntities.Image")));
            this.tsbLoadEntities.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadEntities.Name = "tsbLoadEntities";
            this.tsbLoadEntities.Size = new System.Drawing.Size(140, 29);
            this.tsbLoadEntities.Text = "Load Entities";
            this.tsbLoadEntities.Click += new System.EventHandler(this.tsbLoadEntities_Click);
            // 
            // tsbCreateRecords
            // 
            this.tsbCreateRecords.Enabled = false;
            this.tsbCreateRecords.Image = ((System.Drawing.Image)(resources.GetObject("tsbCreateRecords.Image")));
            this.tsbCreateRecords.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCreateRecords.Name = "tsbCreateRecords";
            this.tsbCreateRecords.Size = new System.Drawing.Size(345, 29);
            this.tsbCreateRecords.Text = "Create records for selected option sets";
            this.tsbCreateRecords.Click += new System.EventHandler(this.tsbCreateRecords_Click);
            // 
            // tsbDeleteEntity
            // 
            this.tsbDeleteEntity.Enabled = false;
            this.tsbDeleteEntity.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteEntity.Image")));
            this.tsbDeleteEntity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteEntity.Name = "tsbDeleteEntity";
            this.tsbDeleteEntity.Size = new System.Drawing.Size(334, 29);
            this.tsbDeleteEntity.Text = "Delete PowerBi Option-set Xref Entity";
            this.tsbDeleteEntity.ToolTipText = "Delete PowerBi Option-set Xref Entity from the connect organization";
            this.tsbDeleteEntity.Click += new System.EventHandler(this.tsbDeleteEntity_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 32);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvEntities);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvOptionSets);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1917, 1199);
            this.splitContainer1.SplitterDistance = 639;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // lvEntities
            // 
            this.lvEntities.CheckBoxes = true;
            this.lvEntities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEntities.Location = new System.Drawing.Point(0, 40);
            this.lvEntities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvEntities.Name = "lvEntities";
            this.lvEntities.Size = new System.Drawing.Size(639, 1159);
            this.lvEntities.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvEntities.TabIndex = 3;
            this.lvEntities.UseCompatibleStateImageBehavior = false;
            this.lvEntities.View = System.Windows.Forms.View.Details;
            this.lvEntities.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Listview_ColumnClick);
            this.lvEntities.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvEntities_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Display name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Logical name";
            this.columnHeader2.Width = 200;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 40);
            this.panel1.TabIndex = 2;
            // 
            // lvOptionSets
            // 
            this.lvOptionSets.CheckBoxes = true;
            this.lvOptionSets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvOptionSets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvOptionSets.Location = new System.Drawing.Point(0, 40);
            this.lvOptionSets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvOptionSets.Name = "lvOptionSets";
            this.lvOptionSets.Size = new System.Drawing.Size(1272, 1159);
            this.lvOptionSets.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvOptionSets.TabIndex = 5;
            this.lvOptionSets.UseCompatibleStateImageBehavior = false;
            this.lvOptionSets.View = System.Windows.Forms.View.Details;
            this.lvOptionSets.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Listview_ColumnClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Display name";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Logical name";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Entity";
            this.columnHeader5.Width = 200;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.llSelectNoOptionSet);
            this.panel2.Controls.Add(this.llSelectAllOptionSet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1272, 40);
            this.panel2.TabIndex = 4;
            // 
            // llSelectNoOptionSet
            // 
            this.llSelectNoOptionSet.AutoSize = true;
            this.llSelectNoOptionSet.Location = new System.Drawing.Point(92, 6);
            this.llSelectNoOptionSet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llSelectNoOptionSet.Name = "llSelectNoOptionSet";
            this.llSelectNoOptionSet.Size = new System.Drawing.Size(94, 20);
            this.llSelectNoOptionSet.TabIndex = 1;
            this.llSelectNoOptionSet.TabStop = true;
            this.llSelectNoOptionSet.Text = "Select none";
            this.llSelectNoOptionSet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSelectNoOptionSet_LinkClicked);
            // 
            // llSelectAllOptionSet
            // 
            this.llSelectAllOptionSet.AutoSize = true;
            this.llSelectAllOptionSet.Location = new System.Drawing.Point(6, 6);
            this.llSelectAllOptionSet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llSelectAllOptionSet.Name = "llSelectAllOptionSet";
            this.llSelectAllOptionSet.Size = new System.Drawing.Size(73, 20);
            this.llSelectAllOptionSet.TabIndex = 0;
            this.llSelectAllOptionSet.TabStop = true;
            this.llSelectAllOptionSet.Text = "Select all";
            this.llSelectAllOptionSet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSelectAllOptionSet_LinkClicked);
            // 
            // PluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PluginControl";
            this.Size = new System.Drawing.Size(1917, 1231);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbLoadEntities;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton tsbCreateRecords;
        private System.Windows.Forms.ToolStripButton tsbDeleteEntity;
        private System.Windows.Forms.ListView lvEntities;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvOptionSets;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel llSelectNoOptionSet;
        private System.Windows.Forms.LinkLabel llSelectAllOptionSet;
        private System.Windows.Forms.ToolStripButton tsbCloseThisTab;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}
