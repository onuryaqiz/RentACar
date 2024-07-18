namespace RentACar
{
    partial class frmAracListesi
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
            this.dgv_AracListesi = new System.Windows.Forms.DataGridView();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakitTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ımageUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktifMiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.arabalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AracListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_AracListesi
            // 
            this.dgv_AracListesi.AutoGenerateColumns = false;
            this.dgv_AracListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AracListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plakaDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.aracTipiDataGridViewTextBoxColumn,
            this.vitesDataGridViewTextBoxColumn,
            this.yakitTipiDataGridViewTextBoxColumn,
            this.ımageUrlDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.ıDDataGridViewTextBoxColumn,
            this.updateDateDataGridViewTextBoxColumn,
            this.deletedDateDataGridViewTextBoxColumn,
            this.aktifMiDataGridViewCheckBoxColumn});
            this.dgv_AracListesi.DataSource = this.arabalarBindingSource;
            this.dgv_AracListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_AracListesi.Location = new System.Drawing.Point(0, 0);
            this.dgv_AracListesi.Name = "dgv_AracListesi";
            this.dgv_AracListesi.Size = new System.Drawing.Size(702, 260);
            this.dgv_AracListesi.TabIndex = 0;
            this.dgv_AracListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AracListesi_CellContentClick);
            this.dgv_AracListesi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_AracListesi_CellMouseClick);
            // 
            // plakaDataGridViewTextBoxColumn
            // 
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "Plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "Plaka";
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // aracTipiDataGridViewTextBoxColumn
            // 
            this.aracTipiDataGridViewTextBoxColumn.DataPropertyName = "AracTipi";
            this.aracTipiDataGridViewTextBoxColumn.HeaderText = "AracTipi";
            this.aracTipiDataGridViewTextBoxColumn.Name = "aracTipiDataGridViewTextBoxColumn";
            // 
            // vitesDataGridViewTextBoxColumn
            // 
            this.vitesDataGridViewTextBoxColumn.DataPropertyName = "Vites";
            this.vitesDataGridViewTextBoxColumn.HeaderText = "Vites";
            this.vitesDataGridViewTextBoxColumn.Name = "vitesDataGridViewTextBoxColumn";
            // 
            // yakitTipiDataGridViewTextBoxColumn
            // 
            this.yakitTipiDataGridViewTextBoxColumn.DataPropertyName = "YakitTipi";
            this.yakitTipiDataGridViewTextBoxColumn.HeaderText = "YakitTipi";
            this.yakitTipiDataGridViewTextBoxColumn.Name = "yakitTipiDataGridViewTextBoxColumn";
            // 
            // ımageUrlDataGridViewTextBoxColumn
            // 
            this.ımageUrlDataGridViewTextBoxColumn.DataPropertyName = "ImageUrl";
            this.ımageUrlDataGridViewTextBoxColumn.HeaderText = "ImageUrl";
            this.ımageUrlDataGridViewTextBoxColumn.Name = "ımageUrlDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            // 
            // updateDateDataGridViewTextBoxColumn
            // 
            this.updateDateDataGridViewTextBoxColumn.DataPropertyName = "UpdateDate";
            this.updateDateDataGridViewTextBoxColumn.HeaderText = "UpdateDate";
            this.updateDateDataGridViewTextBoxColumn.Name = "updateDateDataGridViewTextBoxColumn";
            // 
            // deletedDateDataGridViewTextBoxColumn
            // 
            this.deletedDateDataGridViewTextBoxColumn.DataPropertyName = "DeletedDate";
            this.deletedDateDataGridViewTextBoxColumn.HeaderText = "DeletedDate";
            this.deletedDateDataGridViewTextBoxColumn.Name = "deletedDateDataGridViewTextBoxColumn";
            // 
            // aktifMiDataGridViewCheckBoxColumn
            // 
            this.aktifMiDataGridViewCheckBoxColumn.DataPropertyName = "AktifMi";
            this.aktifMiDataGridViewCheckBoxColumn.HeaderText = "AktifMi";
            this.aktifMiDataGridViewCheckBoxColumn.Name = "aktifMiDataGridViewCheckBoxColumn";
            // 
            // arabalarBindingSource
            // 
            this.arabalarBindingSource.DataSource = typeof(RentACar.ORM.Entity.Arabalar);
            // 
            // frmAracListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 260);
            this.Controls.Add(this.dgv_AracListesi);
            this.Name = "frmAracListesi";
            this.Text = "frmAracListesi";
            this.Load += new System.EventHandler(this.frmAracListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AracListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_AracListesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakitTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ımageUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktifMiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource arabalarBindingSource;
    }
}