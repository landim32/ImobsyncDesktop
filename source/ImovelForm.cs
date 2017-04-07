using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImobsyncDesktop
{
    public partial class ImovelForm : Form
    {
        public ImovelForm()
        {
            InitializeComponent();
        }

        public ImovelDTO Imovel {
            get { 
                if (ImovelGrid.SelectedRows.Count > 0) {
                    return (ImovelDTO)ImovelGrid.SelectedRows[0].DataBoundItem;
                }
                return null;
            }
        }

        private IList<ImovelDTO> _Imoveis;

        public IList<ImovelDTO> Imoveis {
            get {
                return _Imoveis;
            }
            set {
                _Imoveis = value;
                atualizarImoveis();
            }
        }

        private void atualizarImoveis() {
            try
            {
                //DataSet ds = new DataSet();
                ImovelGrid.DataSource = _Imoveis;
                ImovelGrid.Columns["Slug"].Visible = false;
                ImovelGrid.Columns["Negocio"].Visible = false;
                ImovelGrid.Columns["Cep"].Visible = false;
                ImovelGrid.Columns["Endereco"].Visible = false;
                ImovelGrid.Columns["Complemento"].Visible = false;
                ImovelGrid.Columns["Quartos"].Visible = false;
                ImovelGrid.Columns["Suites"].Visible = false;
                ImovelGrid.Columns["Banheiros"].Visible = false;
                ImovelGrid.Columns["Garagens"].Visible = false;
                ImovelGrid.Columns["AreaUtil"].Visible = false;
                ImovelGrid.Columns["Preco"].Visible = false;
                ImovelGrid.Columns["Descricao"].Visible = false;
                if (ImovelGrid.Columns.Contains("Fotos"))
                    ImovelGrid.Columns["Fotos"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } 
        }

        private void ImovelForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void ImovelGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
