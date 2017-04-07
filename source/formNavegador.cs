using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using System.Xml;
using System.Threading;
using System.IO;
using Newtonsoft.Json;

namespace ImobsyncDesktop
{
    public partial class formNavegador : Form
    {
        private ContaDTO _Conta;
        private IList<ImovelDTO> _Imoveis = null;
        private int _Index = -1;

        public formNavegador()
        {
            InitializeComponent();
            //downloadBar.Visible = false;
        }

        private void atualizarConta() { 
            if (_Conta == null)
                return;
            NomeText.Text = _Conta.Nome;
            //Telefone1Text.Text = _Conta.Telefone1;
            EmailText.Text = _Conta.Email1;
            if (string.IsNullOrEmpty(_Conta.OlxUsuario))
                OlxUsuarioText.Text = _Conta.Slug + "@imobsync.com.br";
            else
                OlxUsuarioText.Text = _Conta.OlxUsuario;
            OlxSenhaText.Text = _Conta.OlxSenha;
        }

        private void downloadImoveis() {
            ImovelStatusLabel.Text = "Baixando XML dos imóveis...";
            Thread thread = new Thread(() => {
                String url = "http://www.imobsync-dev.com.br/desktop.php?ac=imovel&id_conta=" + _Conta.IdConta;
                WebClient client = new WebClient();
                //client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadDataCompleted += new DownloadDataCompletedEventHandler(client_DownloadDataCompleted);
                client.DownloadDataAsync(new Uri(url));
            });
            thread.Start();
        }

        private void client_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                ImovelStatusLabel.Text = "Imóveis baixados com sucesso!";
                _Imoveis = carregarImoveis(e.Result);
                _Index = 0;
                //Carregar o Browser com uma Imóvel
                if (_Index >= 0 && _Index < _Imoveis.Count())
                {
                    AdicionarAba(_Imoveis[_Index]);
                    ListaImovelButton.Enabled = true;
                    NovoCadastroButton.Enabled = true;
                }
                else
                {
                    ListaImovelButton.Enabled = false;
                    NovoCadastroButton.Enabled = false;
                }
                ImovelStatusLabel.Text = _Imoveis.Count().ToString() + " imóveis";
            });
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            /*
            this.BeginInvoke((MethodInvoker)delegate
            {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                ImovelStatusLabel.Text = "Downloaded " + e.BytesReceived + " of " + e.TotalBytesToReceive;
                imovelBar.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
             */
        }

        public IList<ImovelDTO> carregarImoveis(byte[] buffer) {
            IList<ImovelDTO> imoveis = new List<ImovelDTO>();
            try
            {
                MemoryStream stream = new MemoryStream(buffer);
                XmlDocument xml = new XmlDocument();
                xml.Load(stream);
                XmlNodeList userNodes = xml.SelectNodes("//imoveis/imovel");
                ImovelDTO imovel = null;
                foreach (XmlNode nodeImovel in userNodes) {
                    imovel = new ImovelDTO();
                    foreach (XmlNode node in nodeImovel.ChildNodes)
                    {
                        switch (node.Name) { 
                            case "id_imovel":
                                imovel.IdImovel = Convert.ToInt32(node.InnerText);
                                break;
                            case "slug":
                                imovel.Slug = node.InnerText;
                                break;
                            case "codigo":
                                imovel.Codigo = node.InnerText;
                                break;
                            case "negocio":
                                imovel.Negocio = node.InnerText;
                                break;
                            case "titulo":
                                imovel.Titulo = node.InnerText;
                                break;
                            case "tipo":
                                imovel.Tipo = node.InnerText;
                                break;
                            case "cep":
                                imovel.Cep = node.InnerText;
                                break;
                            case "uf":
                                imovel.Uf = node.InnerText;
                                break;
                            case "cidade":
                                imovel.Cidade = node.InnerText;
                                break;
                            case "bairro":
                                imovel.Bairro = node.InnerText;
                                break;
                            case "endereco":
                                imovel.Endereco = node.InnerText;
                                break;
                            case "complemento":
                                imovel.Complemento = node.InnerText;
                                break;
                            case "quartos":
                                imovel.Quartos = Convert.ToInt32(node.InnerText);
                                break;
                            case "suites":
                                imovel.Suites = Convert.ToInt32(node.InnerText);
                                break;
                            case "banheiros":
                                imovel.Banheiros = Convert.ToInt32(node.InnerText);
                                break;
                            case "garagens":
                                imovel.Garagens = Convert.ToInt32(node.InnerText);
                                break;
                            case "area_util":
                                imovel.AreaUtil = Convert.ToDouble(node.InnerText);
                                break;
                            case "preco":
                                imovel.Preco = Convert.ToDouble(node.InnerText);
                                break;
                            case "descricao":
                                imovel.Descricao = node.InnerText;
                                break;
                            case "olx_situacao":
                                imovel.OlxSituacao = (node.InnerText == "1");
                                break;
                            case "fotos":
                                foreach (XmlNode nodeFoto in node.ChildNodes)
                                    imovel.Fotos.Add(nodeFoto.InnerText);
                                break;
                        }
                    }
                    imoveis.Add(imovel);
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString());
            }
            return imoveis;
        }

        private void btnTrocarConta_Click(object sender, EventArgs e)
        {
            formConta fconta = new formConta();
            if (fconta.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                _Conta = fconta.pegarConta();
                BrowserTabs.TabPages.Clear();
                atualizarConta();
                //_Imoveis = carregarImoveis();
                downloadImoveis();
            }
        }

        private void btnAlterarConta_Click(object sender, EventArgs e)
        {
            if (_Conta == null)
                return;
            using (WebClient client = new WebClient())
            {

                byte[] response =
                client.UploadValues("http://www.imobsync-dev.com.br/desktop.php?ac=alterar-conta", 
                new NameValueCollection()
                {
                    { "id_conta", _Conta.IdConta.ToString() },
                    { "olx_usuario", OlxUsuarioText.Text },
                    { "olx_senha", OlxSenhaText.Text }
                });
                string result = System.Text.Encoding.UTF8.GetString(response);
                MessageBox.Show(result);
            }
        }

        private void AdicionarAba(ImovelDTO imovel, bool doLogin = true) { 
            TabPage tab = new TabPage("OLX(" + imovel.IdImovel.ToString() + ")");
            NavegadorUC navegador = new NavegadorUC();
            navegador.Dock = DockStyle.Fill;
            tab.Controls.Add(navegador);
            BrowserTabs.TabPages.Add(tab);
            BrowserTabs.SelectTab(tab);
            navegador.Usuario = OlxUsuarioText.Text;
            navegador.Senha = OlxSenhaText.Text;
            navegador.Imovel = imovel;
            if (doLogin)
                navegador.abrirLoginOlx();
            else
                navegador.abrirInserirOlx();
        }

        private void ListaImovelButton_Click(object sender, EventArgs e)
        {
            ImovelForm fImovel = new ImovelForm();
            fImovel.Imoveis = _Imoveis;
            if (fImovel.ShowDialog() == DialogResult.OK) {
                ImovelDTO imovel = fImovel.Imovel;
                if (imovel != null)
                    AdicionarAba(fImovel.Imovel);
            }
        }

        private void NovoCadastroButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            bool encontrado = false;
            foreach (ImovelDTO imovel in _Imoveis) {
                if (!imovel.Cadastrado) {
                    encontrado = true;
                    AdicionarAba(imovel, false);
                    i++;
                    if (i >= 10)
                        break;
                }
            }
            if (!encontrado)
                MessageBox.Show("Nenhum imóvel encontrado para cadastro!");
        }

        /*
        private void AnteriorButton_Click(object sender, EventArgs e)
        {
            _Index--;
            if (_Index < 0)
                _Index = 0;
            carregarImovel();
        }

        private void ProximoButton_Click(object sender, EventArgs e)
        {
            _Index++;
            if (_Index >= _Imoveis.Count)
                _Index = _Imoveis.Count - 1;
            carregarImovel();
        }
         */
    }
}
