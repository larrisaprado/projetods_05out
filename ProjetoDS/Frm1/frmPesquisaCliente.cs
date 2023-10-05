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
    public partial class frmPesquisaCliente : Form
    {
        public frmPesquisaCliente()
        {
            InitializeComponent();
        }

        private void TbClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FrmPesquisaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.database1DataSet.tbCliente);

        }

        private void LblPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (lblNome.Text == "")
            {
                this.tbClienteTableAdapter.Fill(this.database1DataSet.tbCliente);
            }
            else
            {
                this.tbClienteTableAdapter.FillBy1Nome(this.database1DataSet.tbCliente, "%" + lblNome.Text + "%");
            }
        }
    }
}
