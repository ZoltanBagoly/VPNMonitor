
namespace VPNMonitor
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.notifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.separatorMenuItem = new System.Windows.Forms.ToolStripSeparator();
			this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colState = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.notifyMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// notifyIcon
			// 
			this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			resources.ApplyResources(this.notifyIcon, "notifyIcon");
			this.notifyIcon.ContextMenuStrip = this.notifyMenu;
			this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
			// 
			// notifyMenu
			// 
			resources.ApplyResources(this.notifyMenu, "notifyMenu");
			this.notifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMenuItem,
            this.exitMenuItem,
            this.separatorMenuItem,
            this.settingsMenuItem});
			this.notifyMenu.Name = "notifyMenu";
			// 
			// showMenuItem
			// 
			resources.ApplyResources(this.showMenuItem, "showMenuItem");
			this.showMenuItem.Name = "showMenuItem";
			this.showMenuItem.Click += new System.EventHandler(this.showMenuItem_Click);
			// 
			// exitMenuItem
			// 
			resources.ApplyResources(this.exitMenuItem, "exitMenuItem");
			this.exitMenuItem.Image = global::VPNMonitor.Properties.Resources.btn_exit;
			this.exitMenuItem.Name = "exitMenuItem";
			this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
			// 
			// separatorMenuItem
			// 
			resources.ApplyResources(this.separatorMenuItem, "separatorMenuItem");
			this.separatorMenuItem.Name = "separatorMenuItem";
			// 
			// settingsMenuItem
			// 
			resources.ApplyResources(this.settingsMenuItem, "settingsMenuItem");
			this.settingsMenuItem.Name = "settingsMenuItem";
			this.settingsMenuItem.Click += new System.EventHandler(this.settingsMenuItem_Click);
			// 
			// dataGridView
			// 
			resources.ApplyResources(this.dataGridView, "dataGridView");
			this.dataGridView.AllowUserToOrderColumns = true;
			this.dataGridView.AutoGenerateColumns = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colState,
            this.colId});
			this.dataGridView.DataSource = this.bindingSource;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersVisible = false;
			// 
			// colName
			// 
			this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colName.DataPropertyName = "Name";
			resources.ApplyResources(this.colName, "colName");
			this.colName.Name = "colName";
			this.colName.ReadOnly = true;
			// 
			// colState
			// 
			this.colState.DataPropertyName = "StateName";
			resources.ApplyResources(this.colState, "colState");
			this.colState.Name = "colState";
			this.colState.ReadOnly = true;
			// 
			// colId
			// 
			this.colId.DataPropertyName = "Id";
			resources.ApplyResources(this.colId, "colId");
			this.colId.Name = "colId";
			// 
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataGridView);
			this.Name = "MainForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.notifyMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip notifyMenu;
		private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.BindingSource bindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colState;
		private System.Windows.Forms.DataGridViewTextBoxColumn colId;
		private System.Windows.Forms.ToolStripSeparator separatorMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showMenuItem;
	}
}

