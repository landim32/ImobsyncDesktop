using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Xml;
using System.Threading;
using System.Net;

namespace ImobsyncDesktop
{

    public partial class CepForm : Form
    {
        internal class LogradouroInfo
        {
            public string Value { get; set; }
            public string Text { get; set; }
        }

        public CepForm()
        {
            InitializeComponent();
        }

        public string Cep
        {
            get
            {
                return CepText.Text;
            }
            set
            {
                CepText.Text = value;
            }
        }

        public string Uf {
            get {
                return UfText.Text;
            }
            set {
                UfText.Text = value;
            }
        }

        public string Cidade {
            get {
                return CidadeText.Text;
            }
            set {
                CidadeText.Text = value;
            }
        }

        public string Bairro
        {
            get
            {
                return BairroText.Text;
            }
            set
            {
                BairroText.Text = value;
            }
        }

        public string Logradouro
        {
            get
            {
                return LogradouroText.Text;
            }
            set
            {
                LogradouroText.Text = value;
            }
        }

        private void atualizarCidade()
        {
            if (string.IsNullOrEmpty(UfText.Text))
                return;
            if (string.IsNullOrEmpty(CidadeText.Text))
                return;
            if (CidadeText.Text.Length < 2)
                return;
            Thread thread = new Thread(() =>
            {
                String url = "http://www.imobsync-dev.com.br/desktop.php?ac=cidade";
                url += "&uf=" + HttpUtility.UrlEncode(UfText.Text);
                url += "&p=" + HttpUtility.UrlEncode(CidadeText.Text);
                Uri uri = new Uri(url);
                WebClient cidade = new WebClient();
                cidade.DownloadProgressChanged += new DownloadProgressChangedEventHandler(cidade_DownloadProgressChanged);
                cidade.DownloadStringCompleted += new DownloadStringCompletedEventHandler(cidade_DownloadStringCompleted);
                cidade.DownloadStringAsync(uri);
            });
            thread.Start();
        }

        void cidade_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                CidadeListBox.Items.Clear();
                XmlDocument xml = new XmlDocument();
                xml.LoadXml(e.Result);
                XmlNodeList cidades = xml.SelectNodes("//cidades/cidade");
                foreach (XmlNode cidade in cidades)
                {
                    byte[] bytes = Encoding.Default.GetBytes(cidade.InnerText);
                    CidadeListBox.Items.Add(Encoding.UTF8.GetString(bytes));
                }
                if (CidadeListBox.Items.Count == 1)
                {
                    CidadeListBox.SelectedIndex = 0;
                    if (!string.IsNullOrEmpty(BairroText.Text)) {
                        atualizarBairro();
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }

        void cidade_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void atualizarBairro()
        {
            if (string.IsNullOrEmpty(UfText.Text))
                return;
            if (CidadeListBox.SelectedIndex < 0)
                return;
            if (string.IsNullOrEmpty(BairroText.Text))
                return;
            if (BairroText.Text.Length < 2)
                return;
            Thread thread = new Thread(() =>
            {
                String url = "http://www.imobsync-dev.com.br/desktop.php?ac=bairro";
                url += "&uf=" + HttpUtility.UrlEncode(UfText.Text);
                url += "&cidade=" + HttpUtility.UrlEncode(CidadeListBox.SelectedItem.ToString());
                url += "&p=" + HttpUtility.UrlEncode(BairroText.Text);
                Uri uri = new Uri(url);
                WebClient bairro = new WebClient();
                bairro.DownloadProgressChanged += new DownloadProgressChangedEventHandler(bairro_DownloadProgressChanged);
                bairro.DownloadStringCompleted += new DownloadStringCompletedEventHandler(bairro_DownloadStringCompleted);
                bairro.DownloadStringAsync(uri);
            });
            thread.Start();
        }

        void bairro_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                BairroListBox.Items.Clear();
                XmlDocument xml = new XmlDocument();
                xml.LoadXml(e.Result);
                XmlNodeList bairros = xml.SelectNodes("//bairros/bairro");
                foreach (XmlNode bairro in bairros)
                {
                    byte[] bytes = Encoding.Default.GetBytes(bairro.InnerText);
                    BairroListBox.Items.Add(Encoding.UTF8.GetString(bytes));
                }
                if (BairroListBox.Items.Count == 1)
                {
                    BairroListBox.SelectedIndex = 0;
                    if (!string.IsNullOrEmpty(LogradouroText.Text))
                    {
                        atualizarLogradouro();
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }

        void bairro_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void atualizarLogradouro()
        {
            if (string.IsNullOrEmpty(UfText.Text))
                return;
            if (CidadeListBox.SelectedIndex < 0)
                return;
            if (BairroListBox.SelectedIndex < 0)
                return;
            if (string.IsNullOrEmpty(LogradouroText.Text))
                return;
            if (LogradouroText.Text.Length < 1)
                return;
            Thread thread = new Thread(() =>
            {
                String url = "http://www.imobsync-dev.com.br/desktop.php?ac=logradouro";
                url += "&uf=" + HttpUtility.UrlEncode(UfText.Text);
                url += "&cidade=" + HttpUtility.UrlEncode(CidadeListBox.SelectedItem.ToString());
                url += "&bairro=" + HttpUtility.UrlEncode(BairroListBox.SelectedItem.ToString());
                url += "&p=" + HttpUtility.UrlEncode(LogradouroText.Text);
                Uri uri = new Uri(url);
                WebClient logradouro = new WebClient();
                logradouro.DownloadProgressChanged += new DownloadProgressChangedEventHandler(logradouro_DownloadProgressChanged);
                logradouro.DownloadStringCompleted += new DownloadStringCompletedEventHandler(logradouro_DownloadStringCompleted);
                logradouro.DownloadStringAsync(uri);
            });
            thread.Start();
        }

        void logradouro_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                List<LogradouroInfo> data = new List<LogradouroInfo>();

                LogradouroListBox.DataSource = null;
                LogradouroListBox.Items.Clear();
                XmlDocument xml = new XmlDocument();
                xml.LoadXml(e.Result);
                XmlNodeList logradouros = xml.SelectNodes("//logradouros/logradouro");
                foreach (XmlNode logradouro in logradouros)
                {
                    byte[] bytes = null;
                    string cep = null;
                    string endereco = null;
                    foreach (XmlNode node in logradouro.ChildNodes)
                    {
                        switch (node.Name)
                        {
                            case "endereco":
                                bytes = Encoding.Default.GetBytes(node.InnerText);
                                endereco = Encoding.UTF8.GetString(bytes);
                                break;
                            case "cep":
                                bytes = Encoding.Default.GetBytes(node.InnerText);
                                cep = Encoding.UTF8.GetString(bytes);
                                break;
                        }
                    }
                    data.Add(new LogradouroInfo() { Value = cep, Text = endereco });
                    //LogradouroListBox.Items.Add(new ListBoxItem);
                }
                LogradouroListBox.DisplayMember = "Text";
                LogradouroListBox.DataSource = data;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }

        void logradouro_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void CidadeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (CidadeListBox.SelectedIndex >= 0)
            //    CidadeText.Text = CidadeListBox.SelectedItem.ToString();
        }

        private void CidadeText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                CidadeListBox.Focus();
            else if (e.KeyCode == Keys.Enter)
                atualizarCidade();
        }

        private void BairroText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                BairroListBox.Focus();
            else if (e.KeyCode == Keys.Enter)
                atualizarBairro();
        }

        private void LogradouroText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                LogradouroListBox.Focus();
            else if (e.KeyCode == Keys.Enter)
                atualizarLogradouro();
        }

        private void BairroListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (BairroListBox.SelectedIndex >= 0)
            //    BairroText.Text = BairroListBox.SelectedItem.ToString();
        }

        private void CepForm_Load(object sender, EventArgs e)
        {
            CidadeText.Focus();
            atualizarCidade();
        }

        private void LogradouroText_TextChanged(object sender, EventArgs e)
        {
        }

        private void LogradouroListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LogradouroListBox.SelectedIndex >= 0)
                CepText.Text = ((LogradouroInfo) LogradouroListBox.SelectedItem).Value;
        }

        private void AlterarCepButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
