
namespace VPNMonitor
{
	partial class SettingsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.functionPanel = new System.Windows.Forms.Panel();
			this.fillListBtn = new System.Windows.Forms.Button();
			this.balloonTipTimeoutLabel = new System.Windows.Forms.Label();
			this.balloonTipTimeoutEdit = new System.Windows.Forms.NumericUpDown();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.okBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			this.functionPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.balloonTipTimeoutEdit)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			resources.ApplyResources(this.dataGridView, "dataGridView");
			this.dataGridView.AllowUserToOrderColumns = true;
			this.dataGridView.AutoGenerateColumns = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName});
			this.dataGridView.DataSource = this.bindingSource;
			this.dataGridView.Name = "dataGridView";
			// 
			// colId
			// 
			this.colId.DataPropertyName = "Id";
			resources.ApplyResources(this.colId, "colId");
			this.colId.Name = "colId";
			// 
			// colName
			// 
			this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colName.DataPropertyName = "Name";
			resources.ApplyResources(this.colName, "colName");
			this.colName.Name = "colName";
			// 
			// functionPanel
			// 
			resources.ApplyResources(this.functionPanel, "functionPanel");
			this.functionPanel.Controls.Add(this.fillListBtn);
			this.functionPanel.Controls.Add(this.balloonTipTimeoutLabel);
			this.functionPanel.Controls.Add(this.balloonTipTimeoutEdit);
			this.functionPanel.Controls.Add(this.cancelBtn);
			this.functionPanel.Controls.Add(this.okBtn);
			this.functionPanel.Name = "functionPanel";
			// 
			// fillListBtn
			// 
			resources.ApplyResources(this.fillListBtn, "fillListBtn");
			this.fillListBtn.Name = "fillListBtn";
			this.fillListBtn.UseVisualStyleBackColor = true;
			this.fillListBtn.Click += new System.EventHandler(this.fillListBtn_Click);
			// 
			// balloonTipTimeoutLabel
			// 
			resources.ApplyResources(this.balloonTipTimeoutLabel, "balloonTipTimeoutLabel");
			this.balloonTipTimeoutLabel.Name = "balloonTipTimeoutLabel";
			// 
			// balloonTipTimeoutEdit
			// 
			resources.ApplyResources(this.balloonTipTimeoutEdit, "balloonTipTimeoutEdit");
			this.balloonTipTimeoutEdit.Name = "balloonTipTimeoutEdit";
			// 
			// cancelBtn
			// 
			resources.ApplyResources(this.cancelBtn, "cancelBtn");
			this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.UseVisualStyleBackColor = true;
			// 
			// okBtn
			// 
			resources.ApplyResources(this.okBtn, "okBtn");
			this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okBtn.Name = "okBtn";
			this.okBtn.UseVisualStyleBackColor = true;
			// 
			// SettingsForm
			// 
			this.AcceptButton = this.okBtn;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelBtn;
			this.ControlBox = false;
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.functionPanel);
			this.Name = "SettingsForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
			this.functionPanel.ResumeLayout(false);
			this.functionPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.balloonTipTimeoutEdit)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Panel functionPanel;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.Button okBtn;
		private System.Windows.Forms.BindingSource bindingSource;
		private System.Windows.Forms.Label balloonTipTimeoutLabel;
		private System.Windows.Forms.NumericUpDown balloonTipTimeoutEdit;
		private System.Windows.Forms.Button fillListBtn;
		private System.Windows.Forms.DataGridViewTextBoxColumn colId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
	}
}