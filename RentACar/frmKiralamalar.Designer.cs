namespace RentACar
{
    partial class frmKiralamalar
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
            this.dgv_kiralamalistesi = new System.Windows.Forms.DataGridView();
            this.arabaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arabalarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticilerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiralamaSuresiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaTutariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktifMiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kiralamalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kiralamalistesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiralamalarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_kiralamalistesi
            // 
            this.dgv_kiralamalistesi.AutoGenerateColumns = false;
            this.dgv_kiralamalistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kiralamalistesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.arabaIDDataGridViewTextBoxColumn,
            this.yoneticiIdDataGridViewTextBoxColumn,
            this.arabalarDataGridViewTextBoxColumn,
            this.yoneticilerDataGridViewTextBoxColumn,
            this.alisTarihiDataGridViewTextBoxColumn,
            this.teslimTarihiDataGridViewTextBoxColumn,
            this.kiralamaSuresiDataGridViewTextBoxColumn,
            this.faturaTutariDataGridViewTextBoxColumn,
            this.ıDDataGridViewTextBoxColumn,
            this.updateDateDataGridViewTextBoxColumn,
            this.deletedDateDataGridViewTextBoxColumn,
            this.aktifMiDataGridViewCheckBoxColumn});
            this.dgv_kiralamalistesi.DataSource = this.kiralamalarBindingSource;
            this.dgv_kiralamalistesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_kiralamalistesi.Location = new System.Drawing.Point(0, 0);
            this.dgv_kiralamalistesi.Name = "dgv_kiralamalistesi";
            this.dgv_kiralamalistesi.Size = new System.Drawing.Size(965, 237);
            this.dgv_kiralamalistesi.TabIndex = 0;
            this.dgv_kiralamalistesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_kiralamalistesi_CellContentClick);
            // 
            // arabaIDDataGridViewTextBoxColumn
            // 
            this.arabaIDDataGridViewTextBoxColumn.DataPropertyName = "ArabaID";
            this.arabaIDDataGridViewTextBoxColumn.HeaderText = "ArabaID";
            this.arabaIDDataGridViewTextBoxColumn.Name = "arabaIDDataGridViewTextBoxColumn";
            // 
            // yoneticiIdDataGridViewTextBoxColumn
            // 
            this.yoneticiIdDataGridViewTextBoxColumn.DataPropertyName = "YoneticiId";
            this.yoneticiIdDataGridViewTextBoxColumn.HeaderText = "YoneticiId";
            this.yoneticiIdDataGridViewTextBoxColumn.Name = "yoneticiIdDataGridViewTextBoxColumn";
            // 
            // arabalarDataGridViewTextBoxColumn
            // 
            this.arabalarDataGridViewTextBoxColumn.DataPropertyName = "Arabalar";
            this.arabalarDataGridViewTextBoxColumn.HeaderText = "Arabalar";
            this.arabalarDataGridViewTextBoxColumn.Name = "arabalarDataGridViewTextBoxColumn";
            // 
            // yoneticilerDataGridViewTextBoxColumn
            // 
            this.yoneticilerDataGridViewTextBoxColumn.DataPropertyName = "Yoneticiler";
            this.yoneticilerDataGridViewTextBoxColumn.HeaderText = "Yoneticiler";
            this.yoneticilerDataGridViewTextBoxColumn.Name = "yoneticilerDataGridViewTextBoxColumn";
            // 
            // alisTarihiDataGridViewTextBoxColumn
            // 
            this.alisTarihiDataGridViewTextBoxColumn.DataPropertyName = "AlisTarihi";
            this.alisTarihiDataGridViewTextBoxColumn.HeaderText = "AlisTarihi";
            this.alisTarihiDataGridViewTextBoxColumn.Name = "alisTarihiDataGridViewTextBoxColumn";
            // 
            // teslimTarihiDataGridViewTextBoxColumn
            // 
            this.teslimTarihiDataGridViewTextBoxColumn.DataPropertyName = "TeslimTarihi";
            this.teslimTarihiDataGridViewTextBoxColumn.HeaderText = "TeslimTarihi";
            this.teslimTarihiDataGridViewTextBoxColumn.Name = "teslimTarihiDataGridViewTextBoxColumn";
            // 
            // kiralamaSuresiDataGridViewTextBoxColumn
            // 
            this.kiralamaSuresiDataGridViewTextBoxColumn.DataPropertyName = "KiralamaSuresi";
            this.kiralamaSuresiDataGridViewTextBoxColumn.HeaderText = "KiralamaSuresi";
            this.kiralamaSuresiDataGridViewTextBoxColumn.Name = "kiralamaSuresiDataGridViewTextBoxColumn";
            // 
            // faturaTutariDataGridViewTextBoxColumn
            // 
            this.faturaTutariDataGridViewTextBoxColumn.DataPropertyName = "FaturaTutari";
            this.faturaTutariDataGridViewTextBoxColumn.HeaderText = "FaturaTutari";
            this.faturaTutariDataGridViewTextBoxColumn.Name = "faturaTutariDataGridViewTextBoxColumn";
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
            // kiralamalarBindingSource
            // 
            this.kiralamalarBindingSource.DataSource = typeof(RentACar.ORM.Entity.Kiralamalar);
            // 
            // frmKiralamalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 237);
            this.Controls.Add(this.dgv_kiralamalistesi);
            this.Name = "frmKiralamalar";
            this.Text = "Kiralamalar";
            this.Load += new System.EventHandler(this.frmKiralamalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kiralamalistesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiralamalarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_kiralamalistesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn arabaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arabalarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticilerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslimTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiralamaSuresiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaTutariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktifMiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource kiralamalarBindingSource;
    }
}