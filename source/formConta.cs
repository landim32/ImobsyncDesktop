using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Web;

namespace ImobsyncDesktop
{
    public partial class formConta : Form
    {
        public formConta()
        {
            InitializeComponent();
        }

        public ContaDTO pegarConta() {
            if (dataGridView1.SelectedRows.Count > 0) {
                ContaDTO conta = new ContaDTO();
                if (dataGridView1.SelectedRows[0].Cells["id_conta"].Value != null)
                    conta.IdConta = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_conta"].Value);
                if (dataGridView1.SelectedRows[0].Cells["slug"].Value != null)
                    conta.Slug = dataGridView1.SelectedRows[0].Cells["slug"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["nome"].Value != null)
                    conta.Nome = dataGridView1.SelectedRows[0].Cells["nome"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["telefone1"].Value != null)
                    conta.Telefone1 = dataGridView1.SelectedRows[0].Cells["telefone1"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["telefone2"].Value != null)
                    conta.Telefone2 = dataGridView1.SelectedRows[0].Cells["telefone2"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["telefone3"].Value != null)
                    conta.Telefone3 = dataGridView1.SelectedRows[0].Cells["telefone3"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["telefone4"].Value != null)
                    conta.Telefone4 = dataGridView1.SelectedRows[0].Cells["telefone4"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["telefone5"].Value != null)
                    conta.Telefone5 = dataGridView1.SelectedRows[0].Cells["telefone5"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["telefone6"].Value != null)
                    conta.Telefone6 = dataGridView1.SelectedRows[0].Cells["telefone6"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["email1"].Value != null)
                    conta.Email1 = dataGridView1.SelectedRows[0].Cells["email1"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["email2"].Value != null)
                    conta.Email2 = dataGridView1.SelectedRows[0].Cells["email2"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["email3"].Value != null)
                    conta.Email3 = dataGridView1.SelectedRows[0].Cells["email3"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["email4"].Value != null)
                    conta.Email4 = dataGridView1.SelectedRows[0].Cells["email4"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["olx_usuario"].Value != null)
                    conta.OlxUsuario = dataGridView1.SelectedRows[0].Cells["olx_usuario"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["olx_senha"].Value != null)
                    conta.OlxSenha = dataGridView1.SelectedRows[0].Cells["olx_senha"].Value.ToString();
                return conta;
            }
            return null;
        }

        private void atualizarConta() { 
            try
            {
                String url = "http://www.imobsync-dev.com.br/desktop.php?ac=conta";
                if (!string.IsNullOrEmpty(PalavraChaveText.Text))
                    url += "&p=" + HttpUtility.UrlEncode(PalavraChaveText.Text);
                    //url += "&p=" + PalavraChaveText.Text;
                XmlReader xmlFile;
                xmlFile = XmlReader.Create(url, new XmlReaderSettings());
                DataSet ds = new DataSet();
                ds.ReadXml(xmlFile);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } 
        }

        private void formConta_Load(object sender, EventArgs e)
        {
            //atualizarConta();
            PalavraChaveText.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            atualizarConta();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
