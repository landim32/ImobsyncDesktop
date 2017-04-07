namespace ImobsyncDesktop
{
    partial class formNavegador
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
            this.BrowserTabs = new System.Windows.Forms.TabControl();
            this.TopoPanel = new System.Windows.Forms.Panel();
            this.ListaImovelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlterarConta = new System.Windows.Forms.Button();
            this.OlxSenhaText = new System.Windows.Forms.TextBox();
            this.OlxUsuarioText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NomeText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTrocarConta = new System.Windows.Forms.Button();
            this.ImovelStatusLabel = new System.Windows.Forms.Label();
            this.NovoCadastroButton = new System.Windows.Forms.Button();
            this.TopoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BrowserTabs
            // 
            this.BrowserTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowserTabs.Location = new System.Drawing.Point(0, 75);
            this.BrowserTabs.Name = "BrowserTabs";
            this.BrowserTabs.SelectedIndex = 0;
            this.BrowserTabs.Size = new System.Drawing.Size(958, 492);
            this.BrowserTabs.TabIndex = 90;
            // 
            // TopoPanel
            // 
            this.TopoPanel.Controls.Add(this.NovoCadastroButton);
            this.TopoPanel.Controls.Add(this.ListaImovelButton);
            this.TopoPanel.Controls.Add(this.label3);
            this.TopoPanel.Controls.Add(this.EmailText);
            this.TopoPanel.Controls.Add(this.label2);
            this.TopoPanel.Controls.Add(this.btnAlterarConta);
            this.TopoPanel.Controls.Add(this.OlxSenhaText);
            this.TopoPanel.Controls.Add(this.OlxUsuarioText);
            this.TopoPanel.Controls.Add(this.label4);
            this.TopoPanel.Controls.Add(this.NomeText);
            this.TopoPanel.Controls.Add(this.label1);
            this.TopoPanel.Controls.Add(this.btnTrocarConta);
            this.TopoPanel.Controls.Add(this.ImovelStatusLabel);
            this.TopoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopoPanel.Location = new System.Drawing.Point(0, 0);
            this.TopoPanel.Name = "TopoPanel";
            this.TopoPanel.Size = new System.Drawing.Size(958, 55);
            this.TopoPanel.TabIndex = 91;
            // 
            // ListaImovelButton
            // 
            this.ListaImovelButton.Enabled = false;
            this.ListaImovelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaImovelButton.Location = new System.Drawing.Point(317, 26);
            this.ListaImovelButton.Name = "ListaImovelButton";
            this.ListaImovelButton.Size = new System.Drawing.Size(88, 21);
            this.ListaImovelButton.TabIndex = 113;
            this.ListaImovelButton.Text = "Listar Imóveis";
            this.ListaImovelButton.UseVisualStyleBackColor = true;
            this.ListaImovelButton.Click += new System.EventHandler(this.ListaImovelButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(597, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 112;
            this.label3.Text = "Senha:";
            // 
            // EmailText
            // 
            this.EmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailText.Location = new System.Drawing.Point(48, 26);
            this.EmailText.Name = "EmailText";
            this.EmailText.ReadOnly = true;
            this.EmailText.Size = new System.Drawing.Size(263, 19);
            this.EmailText.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 110;
            this.label2.Text = "Email:";
            // 
            // btnAlterarConta
            // 
            this.btnAlterarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarConta.Location = new System.Drawing.Point(812, 2);
            this.btnAlterarConta.Name = "btnAlterarConta";
            this.btnAlterarConta.Size = new System.Drawing.Size(56, 21);
            this.btnAlterarConta.TabIndex = 109;
            this.btnAlterarConta.Text = "Alterar";
            this.btnAlterarConta.UseVisualStyleBackColor = true;
            this.btnAlterarConta.Click += new System.EventHandler(this.btnAlterarConta_Click);
            // 
            // OlxSenhaText
            // 
            this.OlxSenhaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OlxSenhaText.Location = new System.Drawing.Point(648, 3);
            this.OlxSenhaText.Name = "OlxSenhaText";
            this.OlxSenhaText.Size = new System.Drawing.Size(154, 19);
            this.OlxSenhaText.TabIndex = 108;
            // 
            // OlxUsuarioText
            // 
            this.OlxUsuarioText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OlxUsuarioText.Location = new System.Drawing.Point(428, 3);
            this.OlxUsuarioText.Name = "OlxUsuarioText";
            this.OlxUsuarioText.Size = new System.Drawing.Size(154, 19);
            this.OlxUsuarioText.TabIndex = 106;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(377, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 105;
            this.label4.Text = "Usuário:";
            // 
            // NomeText
            // 
            this.NomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeText.Location = new System.Drawing.Point(48, 3);
            this.NomeText.Name = "NomeText";
            this.NomeText.ReadOnly = true;
            this.NomeText.Size = new System.Drawing.Size(263, 19);
            this.NomeText.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 103;
            this.label1.Text = "Conta:";
            // 
            // btnTrocarConta
            // 
            this.btnTrocarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrocarConta.Location = new System.Drawing.Point(316, 2);
            this.btnTrocarConta.Name = "btnTrocarConta";
            this.btnTrocarConta.Size = new System.Drawing.Size(55, 21);
            this.btnTrocarConta.TabIndex = 102;
            this.btnTrocarConta.Text = "Mudar";
            this.btnTrocarConta.UseVisualStyleBackColor = true;
            this.btnTrocarConta.Click += new System.EventHandler(this.btnTrocarConta_Click);
            // 
            // ImovelStatusLabel
            // 
            this.ImovelStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImovelStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ImovelStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImovelStatusLabel.Location = new System.Drawing.Point(555, 29);
            this.ImovelStatusLabel.Name = "ImovelStatusLabel";
            this.ImovelStatusLabel.Size = new System.Drawing.Size(396, 20);
            this.ImovelStatusLabel.TabIndex = 81;
            this.ImovelStatusLabel.Text = "Status do Imóvel";
            // 
            // NovoCadastroButton
            // 
            this.NovoCadastroButton.Enabled = false;
            this.NovoCadastroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovoCadastroButton.Location = new System.Drawing.Point(405, 26);
            this.NovoCadastroButton.Name = "NovoCadastroButton";
            this.NovoCadastroButton.Size = new System.Drawing.Size(88, 21);
            this.NovoCadastroButton.TabIndex = 114;
            this.NovoCadastroButton.Text = "Novo Cadastro";
            this.NovoCadastroButton.UseVisualStyleBackColor = true;
            this.NovoCadastroButton.Click += new System.EventHandler(this.NovoCadastroButton_Click);
            // 
            // formNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 565);
            this.Controls.Add(this.TopoPanel);
            this.Controls.Add(this.BrowserTabs);
            this.Name = "formNavegador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imobsync Crawler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TopoPanel.ResumeLayout(false);
            this.TopoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl BrowserTabs;
        private System.Windows.Forms.Panel TopoPanel;
        private System.Windows.Forms.Label ImovelStatusLabel;
        private NavegadorUC navegadorUC1;
        private System.Windows.Forms.Button btnAlterarConta;
        private System.Windows.Forms.TextBox OlxSenhaText;
        private System.Windows.Forms.TextBox OlxUsuarioText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NomeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTrocarConta;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ListaImovelButton;
        private System.Windows.Forms.Button NovoCadastroButton;


    }
}

