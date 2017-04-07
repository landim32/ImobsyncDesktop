namespace ImobsyncDesktop
{
    partial class CepForm
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
            this.UfText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CidadeText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BairroText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LogradouroText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CepText = new System.Windows.Forms.TextBox();
            this.AlterarCepButton = new System.Windows.Forms.Button();
            this.CidadeListBox = new System.Windows.Forms.ListBox();
            this.BairroListBox = new System.Windows.Forms.ListBox();
            this.LogradouroListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // UfText
            // 
            this.UfText.AcceptsReturn = true;
            this.UfText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.UfText.Location = new System.Drawing.Point(61, 12);
            this.UfText.Margin = new System.Windows.Forms.Padding(2);
            this.UfText.Name = "UfText";
            this.UfText.Size = new System.Drawing.Size(40, 21);
            this.UfText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "UF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cidade:";
            // 
            // CidadeText
            // 
            this.CidadeText.AcceptsReturn = true;
            this.CidadeText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CidadeText.Location = new System.Drawing.Point(61, 37);
            this.CidadeText.Margin = new System.Windows.Forms.Padding(2);
            this.CidadeText.Name = "CidadeText";
            this.CidadeText.Size = new System.Drawing.Size(208, 21);
            this.CidadeText.TabIndex = 2;
            this.CidadeText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CidadeText_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bairro:";
            // 
            // BairroText
            // 
            this.BairroText.AcceptsReturn = true;
            this.BairroText.Location = new System.Drawing.Point(61, 162);
            this.BairroText.Margin = new System.Windows.Forms.Padding(2);
            this.BairroText.Name = "BairroText";
            this.BairroText.Size = new System.Drawing.Size(208, 21);
            this.BairroText.TabIndex = 4;
            this.BairroText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BairroText_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Logradouro:";
            // 
            // LogradouroText
            // 
            this.LogradouroText.AcceptsReturn = true;
            this.LogradouroText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LogradouroText.Location = new System.Drawing.Point(354, 38);
            this.LogradouroText.Margin = new System.Windows.Forms.Padding(2);
            this.LogradouroText.Name = "LogradouroText";
            this.LogradouroText.Size = new System.Drawing.Size(219, 21);
            this.LogradouroText.TabIndex = 6;
            this.LogradouroText.TextChanged += new System.EventHandler(this.LogradouroText_TextChanged);
            this.LogradouroText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LogradouroText_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "CEP:";
            // 
            // CepText
            // 
            this.CepText.AcceptsReturn = true;
            this.CepText.Location = new System.Drawing.Point(354, 13);
            this.CepText.Margin = new System.Windows.Forms.Padding(2);
            this.CepText.Name = "CepText";
            this.CepText.ReadOnly = true;
            this.CepText.Size = new System.Drawing.Size(107, 21);
            this.CepText.TabIndex = 9;
            this.CepText.TabStop = false;
            // 
            // AlterarCepButton
            // 
            this.AlterarCepButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AlterarCepButton.Location = new System.Drawing.Point(480, 292);
            this.AlterarCepButton.Margin = new System.Windows.Forms.Padding(2);
            this.AlterarCepButton.Name = "AlterarCepButton";
            this.AlterarCepButton.Size = new System.Drawing.Size(93, 30);
            this.AlterarCepButton.TabIndex = 8;
            this.AlterarCepButton.Text = "Alterar CEP";
            this.AlterarCepButton.UseVisualStyleBackColor = true;
            this.AlterarCepButton.Click += new System.EventHandler(this.AlterarCepButton_Click);
            // 
            // CidadeListBox
            // 
            this.CidadeListBox.FormattingEnabled = true;
            this.CidadeListBox.ItemHeight = 15;
            this.CidadeListBox.Location = new System.Drawing.Point(61, 63);
            this.CidadeListBox.Name = "CidadeListBox";
            this.CidadeListBox.Size = new System.Drawing.Size(208, 94);
            this.CidadeListBox.TabIndex = 3;
            this.CidadeListBox.SelectedIndexChanged += new System.EventHandler(this.CidadeListBox_SelectedIndexChanged);
            // 
            // BairroListBox
            // 
            this.BairroListBox.FormattingEnabled = true;
            this.BairroListBox.ItemHeight = 15;
            this.BairroListBox.Location = new System.Drawing.Point(61, 188);
            this.BairroListBox.Name = "BairroListBox";
            this.BairroListBox.Size = new System.Drawing.Size(208, 94);
            this.BairroListBox.TabIndex = 5;
            this.BairroListBox.SelectedIndexChanged += new System.EventHandler(this.BairroListBox_SelectedIndexChanged);
            // 
            // LogradouroListBox
            // 
            this.LogradouroListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LogradouroListBox.FormattingEnabled = true;
            this.LogradouroListBox.ItemHeight = 15;
            this.LogradouroListBox.Location = new System.Drawing.Point(354, 63);
            this.LogradouroListBox.Name = "LogradouroListBox";
            this.LogradouroListBox.Size = new System.Drawing.Size(219, 214);
            this.LogradouroListBox.TabIndex = 7;
            this.LogradouroListBox.SelectedIndexChanged += new System.EventHandler(this.LogradouroListBox_SelectedIndexChanged);
            // 
            // CepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 333);
            this.Controls.Add(this.LogradouroListBox);
            this.Controls.Add(this.BairroListBox);
            this.Controls.Add(this.CidadeListBox);
            this.Controls.Add(this.AlterarCepButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CepText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LogradouroText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BairroText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CidadeText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UfText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CepForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Busca por CEP";
            this.Load += new System.EventHandler(this.CepForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UfText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CidadeText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BairroText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LogradouroText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CepText;
        private System.Windows.Forms.Button AlterarCepButton;
        private System.Windows.Forms.ListBox CidadeListBox;
        private System.Windows.Forms.ListBox BairroListBox;
        private System.Windows.Forms.ListBox LogradouroListBox;
    }
}