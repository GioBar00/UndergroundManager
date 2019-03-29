namespace UI
{
    partial class UndergroundEdit
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
            this.toolStripLabelMetropolitana = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxLinee = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiStazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elencoStazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiLineeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elencoLineeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnUndo = new System.Windows.Forms.ToolStripButton();
            this.btnRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripLblImageDatabaseStatus = new System.Windows.Forms.ToolStripLabel();
            this.btnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.btnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.btnZoomToFit = new System.Windows.Forms.ToolStripButton();
            this.btnConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelMetropolitana,
            this.toolStripSeparator1,
            this.btnUndo,
            this.btnRedo,
            this.toolStripLblImageDatabaseStatus,
            this.toolStripProgressBar,
            this.toolStripSeparator2,
            this.btnZoomIn,
            this.btnZoomOut,
            this.btnZoomToFit,
            this.toolStripSeparator3,
            this.toolStripComboBoxLinee,
            this.btnConnect});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(694, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelMetropolitana
            // 
            this.toolStripLabelMetropolitana.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.toolStripLabelMetropolitana.Name = "toolStripLabelMetropolitana";
            this.toolStripLabelMetropolitana.Size = new System.Drawing.Size(132, 22);
            this.toolStripLabelMetropolitana.Text = "Modifica Metropolitana";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar.Margin = new System.Windows.Forms.Padding(1, 2, 10, 1);
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(200, 22);
            this.toolStripProgressBar.Visible = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripComboBoxLinee
            // 
            this.toolStripComboBoxLinee.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripComboBoxLinee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxLinee.Name = "toolStripComboBoxLinee";
            this.toolStripComboBoxLinee.Size = new System.Drawing.Size(121, 25);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stazioniToolStripMenuItem,
            this.lineeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stazioniToolStripMenuItem
            // 
            this.stazioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiungiStazioniToolStripMenuItem,
            this.elencoStazioniToolStripMenuItem});
            this.stazioniToolStripMenuItem.Name = "stazioniToolStripMenuItem";
            this.stazioniToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.stazioniToolStripMenuItem.Text = "Stazioni";
            // 
            // aggiungiStazioniToolStripMenuItem
            // 
            this.aggiungiStazioniToolStripMenuItem.Name = "aggiungiStazioniToolStripMenuItem";
            this.aggiungiStazioniToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.aggiungiStazioniToolStripMenuItem.Text = "Aggiungi";
            // 
            // elencoStazioniToolStripMenuItem
            // 
            this.elencoStazioniToolStripMenuItem.Name = "elencoStazioniToolStripMenuItem";
            this.elencoStazioniToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.elencoStazioniToolStripMenuItem.Text = "Elenco";
            // 
            // lineeToolStripMenuItem
            // 
            this.lineeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiungiLineeToolStripMenuItem,
            this.elencoLineeToolStripMenuItem});
            this.lineeToolStripMenuItem.Name = "lineeToolStripMenuItem";
            this.lineeToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.lineeToolStripMenuItem.Text = "Linee";
            // 
            // aggiungiLineeToolStripMenuItem
            // 
            this.aggiungiLineeToolStripMenuItem.Name = "aggiungiLineeToolStripMenuItem";
            this.aggiungiLineeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.aggiungiLineeToolStripMenuItem.Text = "Aggiungi";
            // 
            // elencoLineeToolStripMenuItem
            // 
            this.elencoLineeToolStripMenuItem.Name = "elencoLineeToolStripMenuItem";
            this.elencoLineeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.elencoLineeToolStripMenuItem.Text = "Elenco";
            // 
            // panelContainer
            // 
            this.panelContainer.AutoScroll = true;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 49);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(694, 362);
            this.panelContainer.TabIndex = 2;
            // 
            // btnUndo
            // 
            this.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUndo.Image = global::UI.Properties.Resources.undo;
            this.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(23, 22);
            this.btnUndo.Text = "Undo";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRedo.Image = global::UI.Properties.Resources.redo;
            this.btnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRedo.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(23, 22);
            this.btnRedo.Text = "Redo";
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // toolStripLblImageDatabaseStatus
            // 
            this.toolStripLblImageDatabaseStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLblImageDatabaseStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLblImageDatabaseStatus.Image = global::UI.Properties.Resources.database_disconnected;
            this.toolStripLblImageDatabaseStatus.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.toolStripLblImageDatabaseStatus.Name = "toolStripLblImageDatabaseStatus";
            this.toolStripLblImageDatabaseStatus.Size = new System.Drawing.Size(16, 22);
            this.toolStripLblImageDatabaseStatus.Text = "toolStripLabel2";
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomIn.Image = global::UI.Properties.Resources.zoomIn;
            this.btnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(23, 22);
            this.btnZoomIn.Text = "Zoom In";
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomOut.Image = global::UI.Properties.Resources.zoomOut;
            this.btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(23, 22);
            this.btnZoomOut.Text = "Zoom Out";
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomToFit
            // 
            this.btnZoomToFit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomToFit.Image = global::UI.Properties.Resources.zoomToFit;
            this.btnZoomToFit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomToFit.Name = "btnZoomToFit";
            this.btnZoomToFit.Size = new System.Drawing.Size(23, 22);
            this.btnZoomToFit.Text = "Zoom To Fit";
            this.btnZoomToFit.Click += new System.EventHandler(this.btnZoomToFit_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConnect.Image = global::UI.Properties.Resources.draw;
            this.btnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(23, 22);
            this.btnConnect.Text = "Collega";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // UndergroundEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 411);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(710, 450);
            this.Name = "UndergroundEdit";
            this.Text = "Modifica Metropolitana";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelMetropolitana;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnUndo;
        private System.Windows.Forms.ToolStripButton btnRedo;
        private System.Windows.Forms.ToolStripLabel toolStripLblImageDatabaseStatus;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aggiungiStazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elencoStazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aggiungiLineeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elencoLineeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxLinee;
        private System.Windows.Forms.ToolStripButton btnConnect;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.ToolStripButton btnZoomIn;
        private System.Windows.Forms.ToolStripButton btnZoomOut;
        private System.Windows.Forms.ToolStripButton btnZoomToFit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}