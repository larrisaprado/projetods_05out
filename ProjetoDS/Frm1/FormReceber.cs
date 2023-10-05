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
    public partial class FormReceber : Form
    {
        private void habilita()
        {
            cd_conta_TextBox.Enabled = false;
            ds_contaTextBox.Enabled = true;
            vl_contaTextBox.Enabled = true;
            vl_pagoTextBox.Enabled = true;
            cd_clienteTextBox.Enabled = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnPequisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;
            btnSair.Enabled = true;
        }
        private void Desabilita()
        {
            cd_conta_TextBox.Enabled = true;
            ds_contaTextBox.Enabled = false;
            vl_contaTextBox.Enabled = false;
            vl_pagoTextBox.Enabled = false;
            cd_clienteTextBox.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
            btnPequisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;
            btnSair.Enabled = false;
        }
        public FormReceber()
        {
            InitializeComponent();
        }

       
       

        private void FormReceber_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.tb_contasreceber'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_contasreceberTableAdapter.Fill(this.database1DataSet.tb_contasreceber);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            tb_contasreceberBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            tb_contasreceberBindingSource.MoveNext();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            habilita();
            tb_contasreceberBindingSource.AddNew();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            Validate();
            tb_contasreceberBindingSource.EndEdit();
            tb_contasreceberTableAdapter.Update(database1DataSet.tb_contasreceber);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
            tb_contasreceberBindingSource.CancelEdit();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            habilita();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            tb_contasreceberBindingSource.RemoveCurrent();
            tb_contasreceberTableAdapter.Adapter.Update(database1DataSet.tb_contasreceber);
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cd_conta_TextBox_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.White;
            ((TextBox)sender).BackColor = Color.Blue;
        }

        private void Cd_conta_TextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.Black;
            ((TextBox)sender).BackColor = Color.White;
        }

        private void Ds_contaTextBox_TabIndexChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.White;
            ((TextBox)sender).BackColor = Color.Blue;
        }

        private void Ds_contaTextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.Black;
            ((TextBox)sender).BackColor = Color.White;
        }

        private void Vl_contaTextBox_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.White;
            ((TextBox)sender).BackColor = Color.Blue;
        }

        private void Vl_contaTextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.Black;
            ((TextBox)sender).BackColor = Color.White;
        }

        private void Vl_pagoTextBox_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.White;
            ((TextBox)sender).BackColor = Color.Blue;
        }

        private void Vl_pagoTextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.Black;
            ((TextBox)sender).BackColor = Color.White;
        }

        private void Cd_clienteTextBox_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.White;
            ((TextBox)sender).BackColor = Color.Blue;
        }

        private void Cd_clienteTextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.Black;
            ((TextBox)sender).BackColor = Color.White;
        }
    }
}
