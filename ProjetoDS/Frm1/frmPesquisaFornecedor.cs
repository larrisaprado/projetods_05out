using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm1
{
    public partial class frmPesquisaFornecedor : Form
    {
        private int codigo;
        public frmPesquisaFornecedor()
        {
            InitializeComponent();
        }
        public int getCodigo()
        {
            return codigo;
        }

        private void TbfornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbfornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FrmPesquisaFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.tbfornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tbfornecedorTableAdapter.Fill(this.database1DataSet.tbfornecedor);

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (lblNome.Text == "")
            {
                this.tbfornecedorTableAdapter.Fill(this.database1DataSet.tbfornecedor);
            }
            else
            {
                this.tbfornecedorTableAdapter.FillByNome(this.database1DataSet.tbfornecedor, "%" + lblNome.Text + "%");
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
