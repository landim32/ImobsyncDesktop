using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Collections.Specialized;
using System.Globalization;

namespace ImobsyncDesktop
{
    public enum TipoPaginaEnum
    {
        Nenhum,
        OLXLogin,
        OLXInserir
    }

    public partial class NavegadorUC : UserControl
    {
        private const string FOTO_DIR = @"d:\imobsync-desktop";
        private TipoPaginaEnum _TipoPagina = TipoPaginaEnum.Nenhum;

        public NavegadorUC()
        {
            InitializeComponent();
            FotoDirButton.Enabled = false;
        }

        private string _Usuario;
        private string _Senha;
        private ImovelDTO _Imovel;

        public string Usuario {
            get {
                return _Usuario;
            }
            set {
                _Usuario = value;
            }
        }

        public string Senha {
            get {
                return _Senha;
            }
            set {
                _Senha = value;
            }
        }

        public ImovelDTO Imovel
        {
            get
            {
                return _Imovel;
            }
            set
            {
                _Imovel = value;
                carregarImovel();
            }
        }

        private string formatarCep(string cep) {
            string texto = "";
            foreach (Char c in cep.ToCharArray())
                if (Char.IsNumber(c))
                    texto += c;
            if (texto.Length == 8)
                return texto.Substring(0, 5) + '-' + texto.Substring(5, 3);
            else
                return cep;
        }

        private bool IsAllUpper(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]) && !Char.IsUpper(input[i]))
                    return false;
            }
            return true;
        }

        private void carregarImovel()
        {
            if (_Imovel != null)
            {
                FotoDirButton.Enabled = false;
                TituloText.Text = _Imovel.Titulo;
                if (string.Compare(_Imovel.Negocio, "Venda", true) == 0)
                    NegocioText.Font = new Font(NegocioText.Font, FontStyle.Regular);
                else
                    NegocioText.Font = new Font(NegocioText.Font, FontStyle.Bold);
                if (string.Compare(_Imovel.Tipo, "Apartamento", true) == 0)
                    TipoText.Font = new Font(TipoText.Font, FontStyle.Regular);
                else
                    TipoText.Font = new Font(TipoText.Font, FontStyle.Bold);
                CodigoText.Text = _Imovel.Codigo;
                NegocioText.Text = _Imovel.Negocio;
                TipoText.Text = _Imovel.Tipo;
                CEPText.Text = _Imovel.Cep;
                UfText.Text = _Imovel.Uf;
                CidadeText.Text = _Imovel.Cidade;
                BairroText.Text = _Imovel.Bairro;
                EnderecoText.Text = _Imovel.Endereco;
                ComplementoText.Text = _Imovel.Complemento;
                QuartosText.Text = _Imovel.Quartos.ToString();
                SuitesText.Text = _Imovel.Suites.ToString();
                BanheirosText.Text = _Imovel.Banheiros.ToString();
                GaragensText.Text = _Imovel.Garagens.ToString();
                AreaUtilText.Text = _Imovel.AreaUtil.ToString();
                PrecoText.Text = _Imovel.Preco.ToString();
                DescricaoText.Text = _Imovel.Descricao.ToString();
                OlxSituacaoCheckBox.Checked = _Imovel.OlxSituacao;
                downloadFotos();
            }
        }

        private void downloadFotos() {
            if (_Imovel != null && _Imovel.Fotos != null) {
                if (_Imovel.Fotos.Count() > 0)
                {
                    fotosBar.Value = 0;
                    if (_Imovel.Fotos.Count() >= 6)
                        fotosBar.Maximum = 6;
                    else
                        fotosBar.Maximum = _Imovel.Fotos.Count();
                    DownloadFotoLabel.Visible = true;
                    DownloadFotoLabel.Text = "Iniciando Download de Fotos...";
                    //foreach (string fotoUrl in _Imovel.Fotos)
                    //{
                    downloadFoto(Imovel.IdImovel, _Imovel.Fotos[0]);
                    //}
                }
                else
                {
                    DownloadFotoLabel.Visible = true;
                    DownloadFotoLabel.Text = "Não possui Fotos!";
                }
            }
        }

        private string gerarDirImovel(int IdImovel) {
            if (!Directory.Exists(FOTO_DIR))
                Directory.CreateDirectory(FOTO_DIR);
            string path = Path.Combine(FOTO_DIR, IdImovel.ToString());
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            return path;
        }

        private void downloadFoto(int IdImovel, string url)
        {
            //ImovelStatusLabel.Text = "Baixando XML dos imóveis...";
            Thread thread = new Thread(() =>
            {
                Uri uri = new Uri(url);
                string arquivo = Path.Combine(gerarDirImovel(IdImovel), Path.GetFileName(uri.LocalPath));
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(uri, arquivo);
            });
            thread.Start();
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                fotosBar.Value = fotosBar.Value + 1;
                if (fotosBar.Value < fotosBar.Maximum)
                {
                    DownloadFotoLabel.Text = fotosBar.Value.ToString() + " de " + fotosBar.Maximum.ToString() + " fotos baixadas.";
                    if (fotosBar.Value < _Imovel.Fotos.Count)
                        downloadFoto(_Imovel.IdImovel, _Imovel.Fotos[fotosBar.Value]);
                }
                else
                {
                    DownloadFotoLabel.Text = fotosBar.Value.ToString() + " fotos baixadas com sucesso!";
                    FotoDirText.Text = gerarDirImovel(_Imovel.IdImovel);
                    Directory.SetCurrentDirectory(FotoDirText.Text);
                    Environment.CurrentDirectory = FotoDirText.Text;
                    Clipboard.SetText(FotoDirText.Text);
                    FotoDirButton.Enabled = true;
                    fotosBar.Value = 0;
                    fotoBar.Value = 0;
                }
            });
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                DownloadFotoLabel.Text = "Baixado " + e.BytesReceived + " de " + e.TotalBytesToReceive;
                fotoBar.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }

        public void abrirLoginOlx() {
            _TipoPagina = TipoPaginaEnum.OLXLogin;
            oBrowser.Stop();
            edtUrl.Text = "https://www3.olx.com.br/account/form_login";
            oBrowser.Navigate(edtUrl.Text);
        }

        public void abrirInserirOlx() {
            _TipoPagina = TipoPaginaEnum.OLXInserir;
            oBrowser.Stop();
            //cBrowser.Stop();
            edtUrl.Text = "http://www2.olx.com.br/ai";
            //cBrowser.Source = new Uri("http://www2.olx.com.br/ai");
            oBrowser.Navigate(edtUrl.Text);
        }

        private void doLoginOlx()
        {
            StringBuilder js = new StringBuilder();
            js.AppendLine("if (document.getElementById('login_email'))");
            js.AppendLine("document.getElementById('login_email').value = '" + _Usuario + "';");
            js.AppendLine("if (document.getElementById('login_password'))");
            js.AppendLine("document.getElementById('login_password').value = '" + _Senha + "';");
            oBrowser.StringByEvaluatingJavaScriptFromString(js.ToString());
            //cBrowser.ExecuteJavascript(js.ToString());
            //browser.StringByEvaluatingJavaScriptFromString(js.ToString());
            _TipoPagina = TipoPaginaEnum.Nenhum;
        }

        private void doOlxInserir(ImovelDTO imovel, bool Automatico = true)
        {
            Thread thread = new Thread(() =>
            {
                if (Automatico)
                {
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        string idTipo = "1000";
                        StringBuilder js = new StringBuilder();
                        js.AppendLine("if (document.getElementById('" + idTipo + "')) {");
                        js.AppendLine("   var cn = document.getElementById('" + idTipo + "').className;");
                        js.AppendLine("   if (!(cn == 'item item-has-children selected' || cn == 'item item-has-children active'))");
                        js.AppendLine("       document.getElementById('" + idTipo + "').click();");
                        js.AppendLine("}");
                        oBrowser.StringByEvaluatingJavaScriptFromString(js.ToString());
                    });
                    Thread.Sleep(3000);

                    //js.Clear();

                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        string idTipo = null;
                        StringBuilder js = new StringBuilder();
                        if (string.Compare(_Imovel.Tipo, "Apartamento", true) == 0)
                            idTipo = "1020";
                        else if (string.Compare(_Imovel.Tipo, "Casa", true) == 0)
                            idTipo = "1040";

                        if (idTipo != null)
                        {
                            js.AppendLine("if (document.getElementById('" + idTipo + "')) {");
                            js.AppendLine("   var cn = document.getElementById('" + idTipo + "').className;");
                            js.AppendLine("   if (!(cn == 'item item-has-children selected' || cn == 'item item-has-children active'))");
                            js.AppendLine("       document.getElementById('" + idTipo + "').click();");
                            js.AppendLine("}");
                            oBrowser.StringByEvaluatingJavaScriptFromString(js.ToString());
                        }
                    });
                    Thread.Sleep(7000);

                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        string idTipo = "1";
                        StringBuilder js = new StringBuilder();
                        js.AppendLine("if (document.getElementById('" + idTipo + "')) {");
                        js.AppendLine("   var cn = document.getElementById('" + idTipo + "').className;");
                        js.AppendLine("   if (!(cn == 'item item-has-children selected' || cn == 'item item-has-children active'))");
                        js.AppendLine("       document.getElementById('" + idTipo + "').click();");
                        js.AppendLine("}");
                        oBrowser.StringByEvaluatingJavaScriptFromString(js.ToString());
                    });
                    Thread.Sleep(3000);
                }

                this.BeginInvoke((MethodInvoker)delegate
                {
                    StringBuilder js = new StringBuilder();
                    if (imovel.Quartos > 0)
                    {
                        js.AppendLine("if (document.getElementById('rooms'))");
                        switch (imovel.Quartos)
                        {
                            case 1:
                                js.AppendLine("document.getElementById('rooms').selectedIndex = 1;");
                                break;
                            case 2:
                                js.AppendLine("document.getElementById('rooms').selectedIndex = 2;");
                                break;
                            case 3:
                                js.AppendLine("document.getElementById('rooms').selectedIndex = 3;");
                                break;
                            case 4:
                                js.AppendLine("document.getElementById('rooms').selectedIndex = 4;");
                                break;
                            default:
                                js.AppendLine("document.getElementById('rooms').selectedIndex = 5;");
                                break;
                        }
                    }
                    //if (!string.IsNullOrEmpty(GaragensText.Text))
                    //    js.AppendLine("document.getElementById('garage_spaces').value = '" + GaragensText.Text + "';");
                    //if (!string.IsNullOrEmpty(PrecoText.Text))
                    //    js.AppendLine("document.getElementById('price').value = '" + PrecoText.Text + "';");
                    if (!string.IsNullOrEmpty(imovel.Titulo))
                    {
                        string titulo = imovel.Titulo;
                        if (IsAllUpper(titulo)) {
                            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                            TextInfo textInfo = cultureInfo.TextInfo;
                            titulo = textInfo.ToTitleCase(titulo.ToLower());
                        }
                        if (!string.IsNullOrEmpty(imovel.Codigo))
                            titulo = titulo + " - " + imovel.Codigo;
                        js.AppendLine("if (document.getElementById('subject'))");
                        js.AppendLine("document.getElementById('subject').value = " + JsonConvert.SerializeObject(titulo) + ";");
                    }
                    if (imovel.AreaUtil > 0)
                    {
                        js.AppendLine("if (document.getElementById('size'))");
                        js.AppendLine("document.getElementById('size').value = '" + imovel.AreaUtil.ToString() + "';");
                    }
                    if (imovel.Preco > 0)
                    {
                        js.AppendLine("if (document.getElementById('price'))");
                        js.AppendLine("document.getElementById('price').value = '" + imovel.Preco.ToString() + "';");
                    }
                    /*
                    if (!string.IsNullOrEmpty(EnderecoText.Text))
                    {
                        js.AppendLine("if (document.getElementById('address'))");
                        js.AppendLine("document.getElementById('address').value = '" + EnderecoText.Text + "';");
                    }
                    */
                    if (imovel.Garagens > 0)
                    {
                        js.AppendLine("if (document.getElementById('garage_spaces'))");
                        js.AppendLine("document.getElementById('garage_spaces').value = '" + imovel.Garagens.ToString() + "';");
                    }

                    if (!string.IsNullOrEmpty(CEPText.Text))
                    {
                        js.AppendLine("if (document.getElementById('zipcode'))");
                        js.AppendLine("document.getElementById('zipcode').value = '" + formatarCep(CEPText.Text) + "';");
                        js.AppendLine("document.getElementById('zipcode').focus();");
                        js.AppendLine("document.getElementById('zipcode').blur();");
                    }
                    oBrowser.StringByEvaluatingJavaScriptFromString(js.ToString());
                }); 

                if (!string.IsNullOrEmpty(DescricaoText.Text))
                {
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        StringBuilder js = new StringBuilder();
                        js.AppendLine("if (document.getElementById('body'))");
                        js.Append("document.getElementById('body').value = " + JsonConvert.SerializeObject(DescricaoText.Text) + ";");
                        oBrowser.StringByEvaluatingJavaScriptFromString(js.ToString());
                    });
                }
                _TipoPagina = TipoPaginaEnum.Nenhum;
            });
            thread.Start();
        }

        private void OlxLoginButton_Click(object sender, EventArgs e)
        {
            abrirLoginOlx();
        }

        private void OlxInserirButton_Click(object sender, EventArgs e)
        {
            abrirInserirOlx();
        }

        private void LogarButton_Click(object sender, EventArgs e)
        {
            doLoginOlx();
        }

        private void InserirButton_Click(object sender, EventArgs e)
        {
            doOlxInserir(_Imovel, false);
        }

        private void FecharButton_Click(object sender, EventArgs e)
        {
            TabPage tab = (TabPage)this.Parent;
            TabControl tabControl = (TabControl)tab.Parent;
            tabControl.TabPages.Remove(tab);
        }

        private void FotoDirButton_Click(object sender, EventArgs e)
        {
            Process.Start(FotoDirText.Text);
        }

        private void gBrowser_Navigating(object sender) //, Skybound.Gecko.GeckoNavigatingEventArgs e)
        {
            //edtUrl.Text = e.Url.ToString();
            //edtUrl.Text = e.Uri.ToString();
            //edtUrl.Text = e.Uri.ToString();
            downloadBar.Visible = true;
            /*
            downloadBar.Visible = true;
            downloadBar.Minimum = 0;
            downloadBar.Maximum = 50;
            downloadBar.Step = 3;
            for (int i = 0; i <= 50; i += 5)
            {
                downloadBar.Value = i;
                System.Threading.Thread.Sleep(38);
            }
            labelStatus.Text = "Carregando...";
             */
        }

        private void gBrowser_Navigated(object sender)//, Skybound.Gecko.GeckoNavigatedEventArgs e)
        {
            downloadBar.Visible = false;
            //edtUrl.Text = e.Uri.ToString();
            //if (!gBrowser.IsBusy && e.Uri != null)
            //    edtUrl.Text = e.Uri.ToString();
        }

        private void gBrowser_DocumentCompleted(object sender, EventArgs e)
        {
            downloadBar.Value = 0;
        }

        /*
        private void Awesomium_Windows_Forms_WebControl_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            ParentForm.Text = e.Title;
        }
         */

        private void Awesomium_Windows_Forms_WebControl_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            StatusLabel.Text = e.PropertyName;
        }

        /*
        private void Awesomium_Windows_Forms_WebControl_LoadingFrameComplete(object sender, FrameEventArgs e)
        {

            //if (!cBrowser.IsLoading) {
                if (_TipoPagina == TipoPaginaEnum.OLXLogin)
                {
                    doLoginOlx();
                }
                else if (_TipoPagina == TipoPaginaEnum.OLXInserir)
                {
                    doOlxInserir(_Imovel);
                }
            //}
        }
         */

        private void edtUrl_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void oBrowser_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.ParentForm.Text = oBrowser.DocumentTitle;
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            oBrowser.Navigate(edtUrl.Text);
        }

        private void oBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            edtUrl.Text = e.Url.ToString();
        }

        private void oBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (!oBrowser.IsBusy)
            {
                if (_TipoPagina == TipoPaginaEnum.OLXLogin)
                {
                    doLoginOlx();
                }
                else if (_TipoPagina == TipoPaginaEnum.OLXInserir)
                {
                    doOlxInserir(_Imovel);
                }
            }
        }

        private void oBrowser_ProgressChanged(object sender, WebKit.ProgressChangesEventArgs e)
        {
            downloadBar.Maximum = Convert.ToInt32(e.MaxProgress);
            downloadBar.Value = Convert.ToInt32(e.Percent / 100);
        }

        private void oBrowser_StatusTextChanged(object sender, WebKit.WebKitBrowserStatusChangedEventArgs e)
        {
            StatusLabel.Text = e.StatusText;
        }

        private void oBrowser_PopupCreated(object sender, WebKit.NewWindowCreatedEventArgs e)
        {

        }

        private void oBrowser_MouseDidMoveOverElement(object sender, WebKit.MouseDidMoveOverElementEventArgs e)
        {
        }

        private void ImovelGravarButton_Click(object sender, EventArgs e)
        {
            if (_Imovel == null)
                return;
            _Imovel.Cep = CEPText.Text;
            _Imovel.Uf = UfText.Text;
            _Imovel.Cidade = CidadeText.Text;
            _Imovel.Bairro = BairroText.Text;
            _Imovel.Endereco = EnderecoText.Text;
            _Imovel.Complemento = ComplementoText.Text;
            _Imovel.OlxSituacao = OlxSituacaoCheckBox.Checked;
            using (WebClient client = new WebClient())
            {

                byte[] response =
                client.UploadValues("http://www.imobsync-dev.com.br/desktop.php?ac=alterar-imovel",
                new NameValueCollection()
                {
                    { "id_imovel", _Imovel.IdImovel.ToString() },
                    { "cep", _Imovel.Cep },
                    { "uf", _Imovel.Uf },
                    { "cidade", _Imovel.Cidade },
                    { "bairro", _Imovel.Bairro },
                    { "endereco", _Imovel.Endereco },
                    { "complemento", _Imovel.Complemento },
                    { "olx_situacao", _Imovel.OlxSituacao ? "1" : "0" }
                });
                string result = System.Text.Encoding.UTF8.GetString(response);
                MessageBox.Show(result);
                _Imovel.Cadastrado = true;
            }
            FecharButton_Click(FecharButton, new EventArgs());
        }

        private void CepButton_Click(object sender, EventArgs e)
        {
            CepForm fCep = new CepForm();
            fCep.Uf = UfText.Text;
            fCep.Cidade = CidadeText.Text;
            fCep.Bairro = BairroText.Text;
            fCep.Logradouro = EnderecoText.Text;
            if (fCep.ShowDialog() == DialogResult.OK) {
                CEPText.Text = fCep.Cep;
                if (!string.IsNullOrEmpty(CEPText.Text))
                {
                    StringBuilder js = new StringBuilder();
                    js.AppendLine("if (document.getElementById('zipcode'))");
                    js.AppendLine("document.getElementById('zipcode').value = '" + formatarCep(CEPText.Text) + "';");
                    js.AppendLine("document.getElementById('zipcode').focus();");
                    js.AppendLine("document.getElementById('zipcode').blur();");
                    oBrowser.StringByEvaluatingJavaScriptFromString(js.ToString());
                }
            }
        }

        private void FotoDownloadButton_Click(object sender, EventArgs e)
        {
            downloadFotos();
        }
    }
}
