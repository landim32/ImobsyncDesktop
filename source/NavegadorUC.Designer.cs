namespace ImobsyncDesktop
{
    partial class NavegadorUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StatusLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.downloadBar = new System.Windows.Forms.ProgressBar();
            this.FullContainer = new System.Windows.Forms.SplitContainer();
            this.oBrowser = new WebKit.WebKitBrowser();
            this.TopoPanel = new System.Windows.Forms.Panel();
            this.FotoDownloadButton = new System.Windows.Forms.Button();
            this.GoBtn = new System.Windows.Forms.Button();
            this.edtUrl = new System.Windows.Forms.TextBox();
            this.fotoBar = new System.Windows.Forms.ProgressBar();
            this.fotosBar = new System.Windows.Forms.ProgressBar();
            this.DownloadFotoLabel = new System.Windows.Forms.Label();
            this.InserirButton = new System.Windows.Forms.Button();
            this.LogarButton = new System.Windows.Forms.Button();
            this.OlxInserirButton = new System.Windows.Forms.Button();
            this.OlxLoginButton = new System.Windows.Forms.Button();
            this.OlxSituacaoCheckBox = new System.Windows.Forms.CheckBox();
            this.CepButton = new System.Windows.Forms.Button();
            this.FotoDirButton = new System.Windows.Forms.Button();
            this.FotoDirText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FecharButton = new System.Windows.Forms.Button();
            this.NegocioText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ImovelGravarButton = new System.Windows.Forms.Button();
            this.ComplementoText = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.EnderecoText = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.DescricaoText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PrecoText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CEPText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AreaUtilText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GaragensText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BanheirosText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuitesText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.QuartosText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BairroText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CidadeText = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.UfText = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TipoText = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TituloText = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.CodigoText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FullContainer)).BeginInit();
            this.FullContainer.Panel1.SuspendLayout();
            this.FullContainer.Panel2.SuspendLayout();
            this.FullContainer.SuspendLayout();
            this.TopoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusLabel.Location = new System.Drawing.Point(3, 6);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(466, 20);
            this.StatusLabel.TabIndex = 6;
            this.StatusLabel.Text = "...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.downloadBar);
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 561);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 32);
            this.panel1.TabIndex = 3;
            // 
            // downloadBar
            // 
            this.downloadBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadBar.Location = new System.Drawing.Point(475, 4);
            this.downloadBar.Name = "downloadBar";
            this.downloadBar.Size = new System.Drawing.Size(168, 23);
            this.downloadBar.TabIndex = 7;
            // 
            // FullContainer
            // 
            this.FullContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FullContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.FullContainer.Location = new System.Drawing.Point(0, 0);
            this.FullContainer.Name = "FullContainer";
            // 
            // FullContainer.Panel1
            // 
            this.FullContainer.Panel1.Controls.Add(this.oBrowser);
            this.FullContainer.Panel1.Controls.Add(this.TopoPanel);
            this.FullContainer.Panel1.Controls.Add(this.panel1);
            // 
            // FullContainer.Panel2
            // 
            this.FullContainer.Panel2.Controls.Add(this.CodigoText);
            this.FullContainer.Panel2.Controls.Add(this.label3);
            this.FullContainer.Panel2.Controls.Add(this.OlxSituacaoCheckBox);
            this.FullContainer.Panel2.Controls.Add(this.CepButton);
            this.FullContainer.Panel2.Controls.Add(this.FotoDirButton);
            this.FullContainer.Panel2.Controls.Add(this.FotoDirText);
            this.FullContainer.Panel2.Controls.Add(this.label2);
            this.FullContainer.Panel2.Controls.Add(this.FecharButton);
            this.FullContainer.Panel2.Controls.Add(this.NegocioText);
            this.FullContainer.Panel2.Controls.Add(this.label1);
            this.FullContainer.Panel2.Controls.Add(this.ImovelGravarButton);
            this.FullContainer.Panel2.Controls.Add(this.ComplementoText);
            this.FullContainer.Panel2.Controls.Add(this.label20);
            this.FullContainer.Panel2.Controls.Add(this.EnderecoText);
            this.FullContainer.Panel2.Controls.Add(this.label19);
            this.FullContainer.Panel2.Controls.Add(this.DescricaoText);
            this.FullContainer.Panel2.Controls.Add(this.label13);
            this.FullContainer.Panel2.Controls.Add(this.PrecoText);
            this.FullContainer.Panel2.Controls.Add(this.label12);
            this.FullContainer.Panel2.Controls.Add(this.CEPText);
            this.FullContainer.Panel2.Controls.Add(this.label11);
            this.FullContainer.Panel2.Controls.Add(this.AreaUtilText);
            this.FullContainer.Panel2.Controls.Add(this.label10);
            this.FullContainer.Panel2.Controls.Add(this.GaragensText);
            this.FullContainer.Panel2.Controls.Add(this.label9);
            this.FullContainer.Panel2.Controls.Add(this.BanheirosText);
            this.FullContainer.Panel2.Controls.Add(this.label8);
            this.FullContainer.Panel2.Controls.Add(this.SuitesText);
            this.FullContainer.Panel2.Controls.Add(this.label7);
            this.FullContainer.Panel2.Controls.Add(this.QuartosText);
            this.FullContainer.Panel2.Controls.Add(this.label6);
            this.FullContainer.Panel2.Controls.Add(this.BairroText);
            this.FullContainer.Panel2.Controls.Add(this.label14);
            this.FullContainer.Panel2.Controls.Add(this.CidadeText);
            this.FullContainer.Panel2.Controls.Add(this.label15);
            this.FullContainer.Panel2.Controls.Add(this.UfText);
            this.FullContainer.Panel2.Controls.Add(this.label16);
            this.FullContainer.Panel2.Controls.Add(this.TipoText);
            this.FullContainer.Panel2.Controls.Add(this.label17);
            this.FullContainer.Panel2.Controls.Add(this.TituloText);
            this.FullContainer.Panel2.Controls.Add(this.label18);
            this.FullContainer.Panel2MinSize = 300;
            this.FullContainer.Size = new System.Drawing.Size(959, 593);
            this.FullContainer.SplitterDistance = 648;
            this.FullContainer.TabIndex = 6;
            // 
            // oBrowser
            // 
            this.oBrowser.AllowDrop = true;
            this.oBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.oBrowser.BackColor = System.Drawing.Color.White;
            this.oBrowser.Location = new System.Drawing.Point(6, 59);
            this.oBrowser.Name = "oBrowser";
            this.oBrowser.Password = null;
            this.oBrowser.PrivateBrowsing = false;
            this.oBrowser.Size = new System.Drawing.Size(637, 500);
            this.oBrowser.TabIndex = 93;
            this.oBrowser.Url = null;
            this.oBrowser.Username = null;
            this.oBrowser.DocumentTitleChanged += new System.EventHandler(this.oBrowser_DocumentTitleChanged);
            this.oBrowser.StatusTextChanged += new WebKit.StatusTextChanged(this.oBrowser_StatusTextChanged);
            this.oBrowser.ProgressChanged += new WebKit.ProgressChangedEventHandler(this.oBrowser_ProgressChanged);
            this.oBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.oBrowser_DocumentCompleted);
            this.oBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.oBrowser_Navigated);
            this.oBrowser.MouseDidMoveOverElement += new WebKit.MouseDidMoveOverElementEventHandler(this.oBrowser_MouseDidMoveOverElement);
            this.oBrowser.PopupCreated += new WebKit.NewWindowCreatedEventHandler(this.oBrowser_PopupCreated);
            // 
            // TopoPanel
            // 
            this.TopoPanel.Controls.Add(this.FotoDownloadButton);
            this.TopoPanel.Controls.Add(this.GoBtn);
            this.TopoPanel.Controls.Add(this.edtUrl);
            this.TopoPanel.Controls.Add(this.fotoBar);
            this.TopoPanel.Controls.Add(this.fotosBar);
            this.TopoPanel.Controls.Add(this.DownloadFotoLabel);
            this.TopoPanel.Controls.Add(this.InserirButton);
            this.TopoPanel.Controls.Add(this.LogarButton);
            this.TopoPanel.Controls.Add(this.OlxInserirButton);
            this.TopoPanel.Controls.Add(this.OlxLoginButton);
            this.TopoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopoPanel.Location = new System.Drawing.Point(0, 0);
            this.TopoPanel.Name = "TopoPanel";
            this.TopoPanel.Size = new System.Drawing.Size(648, 60);
            this.TopoPanel.TabIndex = 92;
            // 
            // FotoDownloadButton
            // 
            this.FotoDownloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FotoDownloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FotoDownloadButton.Location = new System.Drawing.Point(298, 30);
            this.FotoDownloadButton.Name = "FotoDownloadButton";
            this.FotoDownloadButton.Size = new System.Drawing.Size(87, 23);
            this.FotoDownloadButton.TabIndex = 103;
            this.FotoDownloadButton.Text = "Baixar Fotos";
            this.FotoDownloadButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FotoDownloadButton.UseVisualStyleBackColor = true;
            this.FotoDownloadButton.Click += new System.EventHandler(this.FotoDownloadButton_Click);
            // 
            // GoBtn
            // 
            this.GoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBtn.Location = new System.Drawing.Point(350, 4);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(35, 23);
            this.GoBtn.TabIndex = 102;
            this.GoBtn.Text = "go";
            this.GoBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GoBtn.UseVisualStyleBackColor = true;
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // edtUrl
            // 
            this.edtUrl.AcceptsReturn = true;
            this.edtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.edtUrl.Location = new System.Drawing.Point(6, 3);
            this.edtUrl.Name = "edtUrl";
            this.edtUrl.Size = new System.Drawing.Size(337, 22);
            this.edtUrl.TabIndex = 101;
            this.edtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edtUrl_KeyDown);
            // 
            // fotoBar
            // 
            this.fotoBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fotoBar.Location = new System.Drawing.Point(391, 38);
            this.fotoBar.Name = "fotoBar";
            this.fotoBar.Size = new System.Drawing.Size(248, 15);
            this.fotoBar.TabIndex = 100;
            // 
            // fotosBar
            // 
            this.fotosBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fotosBar.Location = new System.Drawing.Point(391, 19);
            this.fotosBar.Name = "fotosBar";
            this.fotosBar.Size = new System.Drawing.Size(248, 15);
            this.fotosBar.TabIndex = 99;
            // 
            // DownloadFotoLabel
            // 
            this.DownloadFotoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadFotoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadFotoLabel.Location = new System.Drawing.Point(388, 1);
            this.DownloadFotoLabel.Name = "DownloadFotoLabel";
            this.DownloadFotoLabel.Size = new System.Drawing.Size(251, 17);
            this.DownloadFotoLabel.TabIndex = 98;
            this.DownloadFotoLabel.Text = "Download de Fotos";
            // 
            // InserirButton
            // 
            this.InserirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InserirButton.Location = new System.Drawing.Point(203, 30);
            this.InserirButton.Name = "InserirButton";
            this.InserirButton.Size = new System.Drawing.Size(68, 25);
            this.InserirButton.TabIndex = 97;
            this.InserirButton.Text = "Preencher";
            this.InserirButton.UseVisualStyleBackColor = true;
            this.InserirButton.Click += new System.EventHandler(this.InserirButton_Click);
            // 
            // LogarButton
            // 
            this.LogarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogarButton.Location = new System.Drawing.Point(149, 30);
            this.LogarButton.Name = "LogarButton";
            this.LogarButton.Size = new System.Drawing.Size(54, 25);
            this.LogarButton.TabIndex = 96;
            this.LogarButton.Text = "Logar";
            this.LogarButton.UseVisualStyleBackColor = true;
            // 
            // OlxInserirButton
            // 
            this.OlxInserirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OlxInserirButton.Location = new System.Drawing.Point(69, 30);
            this.OlxInserirButton.Name = "OlxInserirButton";
            this.OlxInserirButton.Size = new System.Drawing.Size(70, 25);
            this.OlxInserirButton.TabIndex = 92;
            this.OlxInserirButton.Text = "OLX Inserir";
            this.OlxInserirButton.UseVisualStyleBackColor = true;
            this.OlxInserirButton.Click += new System.EventHandler(this.OlxInserirButton_Click);
            // 
            // OlxLoginButton
            // 
            this.OlxLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OlxLoginButton.Location = new System.Drawing.Point(4, 30);
            this.OlxLoginButton.Name = "OlxLoginButton";
            this.OlxLoginButton.Size = new System.Drawing.Size(65, 25);
            this.OlxLoginButton.TabIndex = 91;
            this.OlxLoginButton.Text = "OLX Login";
            this.OlxLoginButton.UseVisualStyleBackColor = true;
            this.OlxLoginButton.Click += new System.EventHandler(this.OlxLoginButton_Click);
            // 
            // OlxSituacaoCheckBox
            // 
            this.OlxSituacaoCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OlxSituacaoCheckBox.AutoSize = true;
            this.OlxSituacaoCheckBox.Location = new System.Drawing.Point(166, 561);
            this.OlxSituacaoCheckBox.Name = "OlxSituacaoCheckBox";
            this.OlxSituacaoCheckBox.Size = new System.Drawing.Size(133, 21);
            this.OlxSituacaoCheckBox.TabIndex = 100;
            this.OlxSituacaoCheckBox.Text = "Publicar no OLX";
            this.OlxSituacaoCheckBox.UseVisualStyleBackColor = true;
            // 
            // CepButton
            // 
            this.CepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CepButton.Location = new System.Drawing.Point(123, 402);
            this.CepButton.Name = "CepButton";
            this.CepButton.Size = new System.Drawing.Size(29, 21);
            this.CepButton.TabIndex = 99;
            this.CepButton.Text = "...";
            this.CepButton.UseVisualStyleBackColor = true;
            this.CepButton.Click += new System.EventHandler(this.CepButton_Click);
            // 
            // FotoDirButton
            // 
            this.FotoDirButton.Enabled = false;
            this.FotoDirButton.Location = new System.Drawing.Point(270, 39);
            this.FotoDirButton.Name = "FotoDirButton";
            this.FotoDirButton.Size = new System.Drawing.Size(29, 23);
            this.FotoDirButton.TabIndex = 98;
            this.FotoDirButton.Text = "...";
            this.FotoDirButton.UseVisualStyleBackColor = true;
            this.FotoDirButton.Click += new System.EventHandler(this.FotoDirButton_Click);
            // 
            // FotoDirText
            // 
            this.FotoDirText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FotoDirText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FotoDirText.Location = new System.Drawing.Point(6, 38);
            this.FotoDirText.Name = "FotoDirText";
            this.FotoDirText.ReadOnly = true;
            this.FotoDirText.Size = new System.Drawing.Size(258, 21);
            this.FotoDirText.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 96;
            this.label2.Text = "Diretório das Fotos:";
            // 
            // FecharButton
            // 
            this.FecharButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FecharButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FecharButton.Location = new System.Drawing.Point(239, 6);
            this.FecharButton.Name = "FecharButton";
            this.FecharButton.Size = new System.Drawing.Size(60, 26);
            this.FecharButton.TabIndex = 95;
            this.FecharButton.Text = "Fechar";
            this.FecharButton.UseVisualStyleBackColor = true;
            this.FecharButton.Click += new System.EventHandler(this.FecharButton_Click);
            // 
            // NegocioText
            // 
            this.NegocioText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NegocioText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NegocioText.Location = new System.Drawing.Point(6, 80);
            this.NegocioText.Name = "NegocioText";
            this.NegocioText.ReadOnly = true;
            this.NegocioText.Size = new System.Drawing.Size(137, 21);
            this.NegocioText.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 93;
            this.label1.Text = "Negôcio:";
            // 
            // ImovelGravarButton
            // 
            this.ImovelGravarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImovelGravarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImovelGravarButton.Location = new System.Drawing.Point(176, 6);
            this.ImovelGravarButton.Name = "ImovelGravarButton";
            this.ImovelGravarButton.Size = new System.Drawing.Size(60, 26);
            this.ImovelGravarButton.TabIndex = 92;
            this.ImovelGravarButton.Text = "Gravar";
            this.ImovelGravarButton.UseVisualStyleBackColor = true;
            this.ImovelGravarButton.Click += new System.EventHandler(this.ImovelGravarButton_Click);
            // 
            // ComplementoText
            // 
            this.ComplementoText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ComplementoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComplementoText.Location = new System.Drawing.Point(6, 317);
            this.ComplementoText.Name = "ComplementoText";
            this.ComplementoText.Size = new System.Drawing.Size(293, 21);
            this.ComplementoText.TabIndex = 89;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 299);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 15);
            this.label20.TabIndex = 88;
            this.label20.Text = "Complemento:";
            // 
            // EnderecoText
            // 
            this.EnderecoText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.EnderecoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnderecoText.Location = new System.Drawing.Point(6, 278);
            this.EnderecoText.Name = "EnderecoText";
            this.EnderecoText.Size = new System.Drawing.Size(293, 21);
            this.EnderecoText.TabIndex = 87;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 260);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 15);
            this.label19.TabIndex = 86;
            this.label19.Text = "Endereço:";
            // 
            // DescricaoText
            // 
            this.DescricaoText.AcceptsReturn = true;
            this.DescricaoText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DescricaoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescricaoText.Location = new System.Drawing.Point(6, 442);
            this.DescricaoText.Multiline = true;
            this.DescricaoText.Name = "DescricaoText";
            this.DescricaoText.ReadOnly = true;
            this.DescricaoText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DescricaoText.Size = new System.Drawing.Size(293, 117);
            this.DescricaoText.TabIndex = 85;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 424);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 15);
            this.label13.TabIndex = 84;
            this.label13.Text = "Descrição:";
            // 
            // PrecoText
            // 
            this.PrecoText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PrecoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecoText.Location = new System.Drawing.Point(160, 401);
            this.PrecoText.Name = "PrecoText";
            this.PrecoText.ReadOnly = true;
            this.PrecoText.Size = new System.Drawing.Size(140, 21);
            this.PrecoText.TabIndex = 83;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(157, 384);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 15);
            this.label12.TabIndex = 82;
            this.label12.Text = "Preço:";
            // 
            // CEPText
            // 
            this.CEPText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEPText.Location = new System.Drawing.Point(6, 401);
            this.CEPText.Name = "CEPText";
            this.CEPText.Size = new System.Drawing.Size(109, 21);
            this.CEPText.TabIndex = 81;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 15);
            this.label11.TabIndex = 80;
            this.label11.Text = "CEP:";
            // 
            // AreaUtilText
            // 
            this.AreaUtilText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AreaUtilText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaUtilText.Location = new System.Drawing.Point(197, 360);
            this.AreaUtilText.Name = "AreaUtilText";
            this.AreaUtilText.ReadOnly = true;
            this.AreaUtilText.Size = new System.Drawing.Size(102, 21);
            this.AreaUtilText.TabIndex = 79;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(197, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 15);
            this.label10.TabIndex = 78;
            this.label10.Text = "Área:";
            // 
            // GaragensText
            // 
            this.GaragensText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GaragensText.Location = new System.Drawing.Point(149, 360);
            this.GaragensText.Name = "GaragensText";
            this.GaragensText.ReadOnly = true;
            this.GaragensText.Size = new System.Drawing.Size(42, 21);
            this.GaragensText.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(149, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 15);
            this.label9.TabIndex = 76;
            this.label9.Text = "Grg:";
            // 
            // BanheirosText
            // 
            this.BanheirosText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BanheirosText.Location = new System.Drawing.Point(101, 360);
            this.BanheirosText.Name = "BanheirosText";
            this.BanheirosText.ReadOnly = true;
            this.BanheirosText.Size = new System.Drawing.Size(42, 21);
            this.BanheirosText.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(101, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 15);
            this.label8.TabIndex = 74;
            this.label8.Text = "Bhr:";
            // 
            // SuitesText
            // 
            this.SuitesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuitesText.Location = new System.Drawing.Point(53, 360);
            this.SuitesText.Name = "SuitesText";
            this.SuitesText.ReadOnly = true;
            this.SuitesText.Size = new System.Drawing.Size(42, 21);
            this.SuitesText.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 15);
            this.label7.TabIndex = 72;
            this.label7.Text = "Sts:";
            // 
            // QuartosText
            // 
            this.QuartosText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuartosText.Location = new System.Drawing.Point(7, 360);
            this.QuartosText.Name = "QuartosText";
            this.QuartosText.ReadOnly = true;
            this.QuartosText.Size = new System.Drawing.Size(40, 21);
            this.QuartosText.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 70;
            this.label6.Text = "Qts:";
            // 
            // BairroText
            // 
            this.BairroText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BairroText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BairroText.Location = new System.Drawing.Point(6, 239);
            this.BairroText.Name = "BairroText";
            this.BairroText.Size = new System.Drawing.Size(293, 21);
            this.BairroText.TabIndex = 69;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 222);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 15);
            this.label14.TabIndex = 68;
            this.label14.Text = "Bairro:";
            // 
            // CidadeText
            // 
            this.CidadeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CidadeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CidadeText.Location = new System.Drawing.Point(38, 199);
            this.CidadeText.Name = "CidadeText";
            this.CidadeText.Size = new System.Drawing.Size(261, 21);
            this.CidadeText.TabIndex = 67;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(38, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 15);
            this.label15.TabIndex = 66;
            this.label15.Text = "Cidade:";
            // 
            // UfText
            // 
            this.UfText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UfText.Location = new System.Drawing.Point(6, 199);
            this.UfText.Name = "UfText";
            this.UfText.Size = new System.Drawing.Size(28, 21);
            this.UfText.TabIndex = 65;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 183);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 15);
            this.label16.TabIndex = 64;
            this.label16.Text = "Uf:";
            // 
            // TipoText
            // 
            this.TipoText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TipoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoText.Location = new System.Drawing.Point(6, 119);
            this.TipoText.Name = "TipoText";
            this.TipoText.ReadOnly = true;
            this.TipoText.Size = new System.Drawing.Size(293, 21);
            this.TipoText.TabIndex = 63;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 101);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 15);
            this.label17.TabIndex = 62;
            this.label17.Text = "Tipo:";
            // 
            // TituloText
            // 
            this.TituloText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TituloText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloText.Location = new System.Drawing.Point(6, 159);
            this.TituloText.Name = "TituloText";
            this.TituloText.ReadOnly = true;
            this.TituloText.Size = new System.Drawing.Size(293, 21);
            this.TituloText.TabIndex = 61;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 141);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 15);
            this.label18.TabIndex = 60;
            this.label18.Text = "Título:";
            // 
            // CodigoText
            // 
            this.CodigoText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CodigoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoText.Location = new System.Drawing.Point(160, 80);
            this.CodigoText.Name = "CodigoText";
            this.CodigoText.ReadOnly = true;
            this.CodigoText.Size = new System.Drawing.Size(137, 21);
            this.CodigoText.TabIndex = 102;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 101;
            this.label3.Text = "Código:";
            // 
            // NavegadorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FullContainer);
            this.Name = "NavegadorUC";
            this.Size = new System.Drawing.Size(959, 593);
            this.panel1.ResumeLayout(false);
            this.FullContainer.Panel1.ResumeLayout(false);
            this.FullContainer.Panel2.ResumeLayout(false);
            this.FullContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FullContainer)).EndInit();
            this.FullContainer.ResumeLayout(false);
            this.TopoPanel.ResumeLayout(false);
            this.TopoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar downloadBar;
        private System.Windows.Forms.SplitContainer FullContainer;
        private System.Windows.Forms.TextBox ComplementoText;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox EnderecoText;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox DescricaoText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PrecoText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CEPText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox AreaUtilText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox GaragensText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BanheirosText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SuitesText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox QuartosText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox CidadeText;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox UfText;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TipoText;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TituloText;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button ImovelGravarButton;
        private System.Windows.Forms.TextBox NegocioText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BairroText;
        private System.Windows.Forms.Panel TopoPanel;
        private System.Windows.Forms.Button OlxInserirButton;
        private System.Windows.Forms.Button OlxLoginButton;
        private System.Windows.Forms.Button InserirButton;
        private System.Windows.Forms.Button LogarButton;
        private System.Windows.Forms.Button FecharButton;
        private System.Windows.Forms.ProgressBar fotosBar;
        private System.Windows.Forms.Label DownloadFotoLabel;
        private System.Windows.Forms.TextBox FotoDirText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FotoDirButton;
        private System.Windows.Forms.ProgressBar fotoBar;
        private System.Windows.Forms.TextBox edtUrl;
        private System.Windows.Forms.Button GoBtn;
        private WebKit.WebKitBrowser oBrowser;
        private System.Windows.Forms.Button CepButton;
        private System.Windows.Forms.Button FotoDownloadButton;
        private System.Windows.Forms.CheckBox OlxSituacaoCheckBox;
        private System.Windows.Forms.TextBox CodigoText;
        private System.Windows.Forms.Label label3;

    }
}
