namespace UI
{
    partial class MainWindow
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLblImageDatabaseStatus = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripButtonDatabaseReload = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.panelMetropolitane = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelText = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanelBottom.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLblImageDatabaseStatus,
            this.toolStripLabel1,
            this.toolStripProgressBar,
            this.toolStripButtonDatabaseReload});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(716, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLblImageDatabaseStatus
            // 
            this.toolStripLblImageDatabaseStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLblImageDatabaseStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLblImageDatabaseStatus.Image = global::UI.Properties.Resources.database_disconnected;
            this.toolStripLblImageDatabaseStatus.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.toolStripLblImageDatabaseStatus.Name = "toolStripLblImageDatabaseStatus";
            this.toolStripLblImageDatabaseStatus.Size = new System.Drawing.Size(16, 22);
            this.toolStripLblImageDatabaseStatus.Text = "Database Status";
            this.toolStripLblImageDatabaseStatus.ToolTipText = "Database Status";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(109, 22);
            this.toolStripLabel1.Text = "Metropolitane";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar.Margin = new System.Windows.Forms.Padding(1, 2, 20, 1);
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(200, 22);
            // 
            // toolStripButtonDatabaseReload
            // 
            this.toolStripButtonDatabaseReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDatabaseReload.Image = global::UI.Properties.Resources.database_reload;
            this.toolStripButtonDatabaseReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDatabaseReload.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.toolStripButtonDatabaseReload.Name = "toolStripButtonDatabaseReload";
            this.toolStripButtonDatabaseReload.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDatabaseReload.Text = "Ricarica Metropolitane";
            this.toolStripButtonDatabaseReload.Click += new System.EventHandler(this.toolStripButtonDatabaseReload_Click);
            // 
            // tableLayoutPanelBottom
            // 
            this.tableLayoutPanelBottom.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanelBottom.ColumnCount = 1;
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBottom.Controls.Add(this.panelMetropolitane, 0, 2);
            this.tableLayoutPanelBottom.Controls.Add(this.toolStrip2, 0, 1);
            this.tableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBottom.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            this.tableLayoutPanelBottom.RowCount = 3;
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBottom.Size = new System.Drawing.Size(716, 462);
            this.tableLayoutPanelBottom.TabIndex = 1;
            // 
            // panelMetropolitane
            // 
            this.panelMetropolitane.AutoScroll = true;
            this.panelMetropolitane.BackColor = System.Drawing.Color.White;
            this.panelMetropolitane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMetropolitane.Location = new System.Drawing.Point(3, 35);
            this.panelMetropolitane.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelMetropolitane.Name = "panelMetropolitane";
            this.panelMetropolitane.Size = new System.Drawing.Size(710, 424);
            this.panelMetropolitane.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripLabelText,
            this.toolStripSeparator1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 10);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(716, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = global::UI.Properties.Resources.add;
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAdd.Text = "Aggiungi Metropolitana";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEdit.Image = global::UI.Properties.Resources.edit;
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEdit.Text = "Modifica";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripLabelText
            // 
            this.toolStripLabelText.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripLabelText.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.toolStripLabelText.Name = "toolStripLabelText";
            this.toolStripLabelText.Size = new System.Drawing.Size(240, 22);
            this.toolStripLabelText.Text = "Seleziona una metropolitana per modificarla";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 487);
            this.Controls.Add(this.tableLayoutPanelBottom);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "MainWindow";
            this.Text = "Underground Manager";
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanelBottom.ResumeLayout(false);
            this.tableLayoutPanelBottom.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLblImageDatabaseStatus;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripButton toolStripButtonDatabaseReload;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
        private System.Windows.Forms.Panel panelMetropolitane;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripLabel toolStripLabelText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}