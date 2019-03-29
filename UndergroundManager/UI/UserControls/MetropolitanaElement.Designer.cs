namespace UI
{
    partial class MetropolitanaElement
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLastEdit = new System.Windows.Forms.Label();
            this.pictureBoxMetropolitana = new System.Windows.Forms.PictureBox();
            this.pictureBoxRoute = new System.Windows.Forms.PictureBox();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMetropolitana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoute)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.lblLastEdit, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxMetropolitana, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxRoute, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCreationDate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(455, 57);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            // 
            // lblLastEdit
            // 
            this.lblLastEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastEdit.Location = new System.Drawing.Point(277, 0);
            this.lblLastEdit.Name = "lblLastEdit";
            this.lblLastEdit.Size = new System.Drawing.Size(134, 57);
            this.lblLastEdit.TabIndex = 3;
            this.lblLastEdit.Text = "Data ultima modifica:\r\ndd/mm/yyyy \r\nalle hh:mm";
            this.lblLastEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLastEdit.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            // 
            // pictureBoxMetropolitana
            // 
            this.pictureBoxMetropolitana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMetropolitana.Image = global::UI.Properties.Resources.sign;
            this.pictureBoxMetropolitana.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxMetropolitana.Name = "pictureBoxMetropolitana";
            this.pictureBoxMetropolitana.Size = new System.Drawing.Size(44, 51);
            this.pictureBoxMetropolitana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMetropolitana.TabIndex = 0;
            this.pictureBoxMetropolitana.TabStop = false;
            this.pictureBoxMetropolitana.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            // 
            // pictureBoxRoute
            // 
            this.pictureBoxRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxRoute.Image = global::UI.Properties.Resources.route;
            this.pictureBoxRoute.Location = new System.Drawing.Point(417, 3);
            this.pictureBoxRoute.Name = "pictureBoxRoute";
            this.pictureBoxRoute.Size = new System.Drawing.Size(35, 51);
            this.pictureBoxRoute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRoute.TabIndex = 1;
            this.pictureBoxRoute.TabStop = false;
            this.pictureBoxRoute.Click += new System.EventHandler(this.pictureBoxRoute_Click);
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreationDate.Location = new System.Drawing.Point(163, 0);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(108, 57);
            this.lblCreationDate.TabIndex = 2;
            this.lblCreationDate.Text = "Data creazione:\r\ndd/mm/yyyy \r\nalle hh:mm";
            this.lblCreationDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCreationDate.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(53, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 57);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nome";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            // 
            // MetropolitanaElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MetropolitanaElement";
            this.Size = new System.Drawing.Size(455, 57);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMetropolitana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoute)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxMetropolitana;
        private System.Windows.Forms.Label lblLastEdit;
        private System.Windows.Forms.PictureBox pictureBoxRoute;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.Label lblName;
    }
}
