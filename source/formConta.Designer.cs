namespace ImobsyncDesktop
{
    partial class formConta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.PalavraChaveText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id_conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultima_alteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olx_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olx_senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_conta,
            this.nome,
            this.telefone1,
            this.email1,
            this.ultima_alteracao,
            this.Quantidade,
            this.olx_usuario,
            this.olx_senha,
            this.slug,
            this.telefone2,
            this.telefone3,
            this.telefone4,
            this.telefone5,
            this.telefone6,
            this.email2,
            this.email3,
            this.email4});
            this.dataGridView1.Location = new System.Drawing.Point(11, 41);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(868, 335);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(804, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 30);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(794, 382);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 30);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Selecionar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // PalavraChaveText
            // 
            this.PalavraChaveText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PalavraChaveText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PalavraChaveText.Location = new System.Drawing.Point(86, 9);
            this.PalavraChaveText.Name = "PalavraChaveText";
            this.PalavraChaveText.Size = new System.Drawing.Size(712, 27);
            this.PalavraChaveText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar:";
            // 
            // id_conta
            // 
            this.id_conta.DataPropertyName = "id_conta";
            this.id_conta.HeaderText = "ID";
            this.id_conta.Name = "id_conta";
            this.id_conta.ReadOnly = true;
            this.id_conta.Width = 80;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 250;
            // 
            // telefone1
            // 
            this.telefone1.DataPropertyName = "telefone1";
            this.telefone1.HeaderText = "Telefone";
            this.telefone1.Name = "telefone1";
            this.telefone1.ReadOnly = true;
            // 
            // email1
            // 
            this.email1.DataPropertyName = "email1";
            this.email1.HeaderText = "Email";
            this.email1.Name = "email1";
            this.email1.ReadOnly = true;
            this.email1.Width = 220;
            // 
            // ultima_alteracao
            // 
            this.ultima_alteracao.DataPropertyName = "ultima_alteracao";
            this.ultima_alteracao.HeaderText = "Última Alt.";
            this.ultima_alteracao.Name = "ultima_alteracao";
            this.ultima_alteracao.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "quantidade";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Quantidade.DefaultCellStyle = dataGridViewCellStyle1;
            this.Quantidade.HeaderText = "Quant.";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 50;
            // 
            // olx_usuario
            // 
            this.olx_usuario.DataPropertyName = "olx_usuario";
            this.olx_usuario.HeaderText = "Usuário OLX";
            this.olx_usuario.Name = "olx_usuario";
            this.olx_usuario.ReadOnly = true;
            this.olx_usuario.Visible = false;
            // 
            // olx_senha
            // 
            this.olx_senha.DataPropertyName = "olx_senha";
            this.olx_senha.HeaderText = "Senha OLX";
            this.olx_senha.Name = "olx_senha";
            this.olx_senha.ReadOnly = true;
            this.olx_senha.Visible = false;
            // 
            // slug
            // 
            this.slug.DataPropertyName = "slug";
            this.slug.HeaderText = "Slug";
            this.slug.Name = "slug";
            this.slug.ReadOnly = true;
            this.slug.Visible = false;
            // 
            // telefone2
            // 
            this.telefone2.DataPropertyName = "telefone2";
            this.telefone2.HeaderText = "Telefone(2)";
            this.telefone2.Name = "telefone2";
            this.telefone2.ReadOnly = true;
            this.telefone2.Visible = false;
            // 
            // telefone3
            // 
            this.telefone3.DataPropertyName = "telefone3";
            this.telefone3.HeaderText = "Telefone(3)";
            this.telefone3.Name = "telefone3";
            this.telefone3.ReadOnly = true;
            this.telefone3.Visible = false;
            // 
            // telefone4
            // 
            this.telefone4.DataPropertyName = "telefone4";
            this.telefone4.HeaderText = "Telefone(4)";
            this.telefone4.Name = "telefone4";
            this.telefone4.ReadOnly = true;
            this.telefone4.Visible = false;
            // 
            // telefone5
            // 
            this.telefone5.DataPropertyName = "telefone5";
            this.telefone5.HeaderText = "Telefone(5)";
            this.telefone5.Name = "telefone5";
            this.telefone5.ReadOnly = true;
            this.telefone5.Visible = false;
            // 
            // telefone6
            // 
            this.telefone6.DataPropertyName = "telefone6";
            this.telefone6.HeaderText = "Telefone(6)";
            this.telefone6.Name = "telefone6";
            this.telefone6.ReadOnly = true;
            this.telefone6.Visible = false;
            // 
            // email2
            // 
            this.email2.DataPropertyName = "email2";
            this.email2.HeaderText = "Email(2)";
            this.email2.Name = "email2";
            this.email2.ReadOnly = true;
            this.email2.Visible = false;
            // 
            // email3
            // 
            this.email3.DataPropertyName = "email3";
            this.email3.HeaderText = "Email(3)";
            this.email3.Name = "email3";
            this.email3.ReadOnly = true;
            this.email3.Visible = false;
            // 
            // email4
            // 
            this.email4.DataPropertyName = "email4";
            this.email4.HeaderText = "Email(4)";
            this.email4.Name = "email4";
            this.email4.ReadOnly = true;
            this.email4.Visible = false;
            // 
            // formConta
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PalavraChaveText);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formConta";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contas";
            this.Load += new System.EventHandler(this.formConta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox PalavraChaveText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn email1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultima_alteracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn olx_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn olx_senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn slug;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone3;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone4;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone5;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone6;
        private System.Windows.Forms.DataGridViewTextBoxColumn email2;
        private System.Windows.Forms.DataGridViewTextBoxColumn email3;
        private System.Windows.Forms.DataGridViewTextBoxColumn email4;
    }
}