namespace ImobsyncDesktop
{
    partial class ImovelForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.ImovelGrid = new System.Windows.Forms.DataGridView();
            this.Cadastrado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdImovel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ImovelGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(705, 364);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 30);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Selecionar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ImovelGrid
            // 
            this.ImovelGrid.AllowUserToAddRows = false;
            this.ImovelGrid.AllowUserToDeleteRows = false;
            this.ImovelGrid.AllowUserToResizeRows = false;
            this.ImovelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ImovelGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImovelGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cadastrado,
            this.Titulo,
            this.Tipo,
            this.Uf,
            this.Cidade,
            this.Bairro,
            this.IdImovel});
            this.ImovelGrid.Location = new System.Drawing.Point(12, 12);
            this.ImovelGrid.MultiSelect = false;
            this.ImovelGrid.Name = "ImovelGrid";
            this.ImovelGrid.ReadOnly = true;
            this.ImovelGrid.RowTemplate.Height = 24;
            this.ImovelGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ImovelGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ImovelGrid.Size = new System.Drawing.Size(778, 346);
            this.ImovelGrid.TabIndex = 3;
            this.ImovelGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ImovelGrid_CellDoubleClick);
            // 
            // Cadastrado
            // 
            this.Cadastrado.DataPropertyName = "Cadastrado";
            this.Cadastrado.FalseValue = "";
            this.Cadastrado.HeaderText = "Cadastrado";
            this.Cadastrado.Name = "Cadastrado";
            this.Cadastrado.ReadOnly = true;
            this.Cadastrado.Width = 50;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Título";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 230;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 130;
            // 
            // Uf
            // 
            this.Uf.DataPropertyName = "Uf";
            this.Uf.HeaderText = "Uf";
            this.Uf.Name = "Uf";
            this.Uf.ReadOnly = true;
            this.Uf.Width = 40;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "Cidade";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            this.Cidade.Width = 130;
            // 
            // Bairro
            // 
            this.Bairro.DataPropertyName = "Bairro";
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            this.Bairro.Width = 130;
            // 
            // IdImovel
            // 
            this.IdImovel.DataPropertyName = "IdImovel";
            this.IdImovel.HeaderText = "Id";
            this.IdImovel.Name = "IdImovel";
            this.IdImovel.ReadOnly = true;
            this.IdImovel.Visible = false;
            this.IdImovel.Width = 80;
            // 
            // ImovelForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 406);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.ImovelGrid);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImovelForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Imóveis";
            this.Load += new System.EventHandler(this.ImovelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImovelGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView ImovelGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Cadastrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdImovel;
    }
}