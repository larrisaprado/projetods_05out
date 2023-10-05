namespace Frm1
{
    partial class FormReceber
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cd_conta_Label;
            System.Windows.Forms.Label ds_contaLabel;
            System.Windows.Forms.Label dt_emissaoLabel;
            System.Windows.Forms.Label vl_contaLabel;
            System.Windows.Forms.Label dt_vencimentoLabel;
            System.Windows.Forms.Label dt_pagamentoLabel;
            System.Windows.Forms.Label vl_pagoLabel;
            System.Windows.Forms.Label cd_clienteLabel;
            this.database1DataSet = new Frm1.Database1DataSet();
            this.tb_contasreceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_contasreceberTableAdapter = new Frm1.Database1DataSetTableAdapters.tb_contasreceberTableAdapter();
            this.cd_conta_TextBox = new System.Windows.Forms.TextBox();
            this.ds_contaTextBox = new System.Windows.Forms.TextBox();
            this.dt_emissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vl_contaTextBox = new System.Windows.Forms.TextBox();
            this.dt_vencimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dt_pagamentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vl_pagoTextBox = new System.Windows.Forms.TextBox();
            this.cd_clienteTextBox = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnPequisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            cd_conta_Label = new System.Windows.Forms.Label();
            ds_contaLabel = new System.Windows.Forms.Label();
            dt_emissaoLabel = new System.Windows.Forms.Label();
            vl_contaLabel = new System.Windows.Forms.Label();
            dt_vencimentoLabel = new System.Windows.Forms.Label();
            dt_pagamentoLabel = new System.Windows.Forms.Label();
            vl_pagoLabel = new System.Windows.Forms.Label();
            cd_clienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contasreceberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_conta_Label
            // 
            cd_conta_Label.AutoSize = true;
            cd_conta_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_conta_Label.Location = new System.Drawing.Point(46, 68);
            cd_conta_Label.Name = "cd_conta_Label";
            cd_conta_Label.Size = new System.Drawing.Size(89, 20);
            cd_conta_Label.TabIndex = 1;
            cd_conta_Label.Text = "Cód Conta:";
            // 
            // ds_contaLabel
            // 
            ds_contaLabel.AutoSize = true;
            ds_contaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_contaLabel.Location = new System.Drawing.Point(46, 109);
            ds_contaLabel.Name = "ds_contaLabel";
            ds_contaLabel.Size = new System.Drawing.Size(56, 20);
            ds_contaLabel.TabIndex = 3;
            ds_contaLabel.Text = "Conta:";
            // 
            // dt_emissaoLabel
            // 
            dt_emissaoLabel.AutoSize = true;
            dt_emissaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dt_emissaoLabel.Location = new System.Drawing.Point(46, 150);
            dt_emissaoLabel.Name = "dt_emissaoLabel";
            dt_emissaoLabel.Size = new System.Drawing.Size(135, 20);
            dt_emissaoLabel.TabIndex = 5;
            dt_emissaoLabel.Text = "Data da Emissao:";
            // 
            // vl_contaLabel
            // 
            vl_contaLabel.AutoSize = true;
            vl_contaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vl_contaLabel.Location = new System.Drawing.Point(46, 191);
            vl_contaLabel.Name = "vl_contaLabel";
            vl_contaLabel.Size = new System.Drawing.Size(101, 20);
            vl_contaLabel.TabIndex = 7;
            vl_contaLabel.Text = "Núm.  Conta:";
            // 
            // dt_vencimentoLabel
            // 
            dt_vencimentoLabel.AutoSize = true;
            dt_vencimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dt_vencimentoLabel.Location = new System.Drawing.Point(473, 68);
            dt_vencimentoLabel.Name = "dt_vencimentoLabel";
            dt_vencimentoLabel.Size = new System.Drawing.Size(155, 20);
            dt_vencimentoLabel.TabIndex = 9;
            dt_vencimentoLabel.Text = "Data de Vencimento";
            // 
            // dt_pagamentoLabel
            // 
            dt_pagamentoLabel.AutoSize = true;
            dt_pagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dt_pagamentoLabel.Location = new System.Drawing.Point(473, 109);
            dt_pagamentoLabel.Name = "dt_pagamentoLabel";
            dt_pagamentoLabel.Size = new System.Drawing.Size(156, 20);
            dt_pagamentoLabel.TabIndex = 11;
            dt_pagamentoLabel.Text = "Data de Pagamento:";
            // 
            // vl_pagoLabel
            // 
            vl_pagoLabel.AutoSize = true;
            vl_pagoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vl_pagoLabel.Location = new System.Drawing.Point(473, 150);
            vl_pagoLabel.Name = "vl_pagoLabel";
            vl_pagoLabel.Size = new System.Drawing.Size(74, 20);
            vl_pagoLabel.TabIndex = 13;
            vl_pagoLabel.Text = "VL Pago:";
            // 
            // cd_clienteLabel
            // 
            cd_clienteLabel.AutoSize = true;
            cd_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_clienteLabel.Location = new System.Drawing.Point(473, 191);
            cd_clienteLabel.Name = "cd_clienteLabel";
            cd_clienteLabel.Size = new System.Drawing.Size(95, 20);
            cd_clienteLabel.TabIndex = 15;
            cd_clienteLabel.Text = "Cód Cliente:";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_contasreceberBindingSource
            // 
            this.tb_contasreceberBindingSource.DataMember = "tb_contasreceber";
            this.tb_contasreceberBindingSource.DataSource = this.database1DataSet;
            // 
            // tb_contasreceberTableAdapter
            // 
            this.tb_contasreceberTableAdapter.ClearBeforeFill = true;
            // 
            // cd_conta_TextBox
            // 
            this.cd_conta_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contasreceberBindingSource, "cd_conta ", true));
            this.cd_conta_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_conta_TextBox.Location = new System.Drawing.Point(225, 65);
            this.cd_conta_TextBox.Name = "cd_conta_TextBox";
            this.cd_conta_TextBox.Size = new System.Drawing.Size(200, 26);
            this.cd_conta_TextBox.TabIndex = 2;
            this.cd_conta_TextBox.TextChanged += new System.EventHandler(this.Cd_conta_TextBox_TextChanged);
            this.cd_conta_TextBox.Leave += new System.EventHandler(this.Cd_conta_TextBox_Leave);
            // 
            // ds_contaTextBox
            // 
            this.ds_contaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contasreceberBindingSource, "ds_conta", true));
            this.ds_contaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ds_contaTextBox.Location = new System.Drawing.Point(225, 106);
            this.ds_contaTextBox.Name = "ds_contaTextBox";
            this.ds_contaTextBox.Size = new System.Drawing.Size(200, 26);
            this.ds_contaTextBox.TabIndex = 4;
            this.ds_contaTextBox.TabIndexChanged += new System.EventHandler(this.Ds_contaTextBox_TabIndexChanged);
            this.ds_contaTextBox.Leave += new System.EventHandler(this.Ds_contaTextBox_Leave);
            // 
            // dt_emissaoDateTimePicker
            // 
            this.dt_emissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_contasreceberBindingSource, "dt_emissao", true));
            this.dt_emissaoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_emissaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_emissaoDateTimePicker.Location = new System.Drawing.Point(225, 147);
            this.dt_emissaoDateTimePicker.Name = "dt_emissaoDateTimePicker";
            this.dt_emissaoDateTimePicker.Size = new System.Drawing.Size(119, 26);
            this.dt_emissaoDateTimePicker.TabIndex = 6;
            // 
            // vl_contaTextBox
            // 
            this.vl_contaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contasreceberBindingSource, "vl_conta", true));
            this.vl_contaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vl_contaTextBox.Location = new System.Drawing.Point(225, 188);
            this.vl_contaTextBox.Name = "vl_contaTextBox";
            this.vl_contaTextBox.Size = new System.Drawing.Size(200, 26);
            this.vl_contaTextBox.TabIndex = 8;
            this.vl_contaTextBox.TextChanged += new System.EventHandler(this.Vl_contaTextBox_TextChanged);
            this.vl_contaTextBox.Leave += new System.EventHandler(this.Vl_contaTextBox_Leave);
            // 
            // dt_vencimentoDateTimePicker
            // 
            this.dt_vencimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_contasreceberBindingSource, "dt_vencimento", true));
            this.dt_vencimentoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_vencimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_vencimentoDateTimePicker.Location = new System.Drawing.Point(652, 65);
            this.dt_vencimentoDateTimePicker.Name = "dt_vencimentoDateTimePicker";
            this.dt_vencimentoDateTimePicker.Size = new System.Drawing.Size(139, 26);
            this.dt_vencimentoDateTimePicker.TabIndex = 10;
            // 
            // dt_pagamentoDateTimePicker
            // 
            this.dt_pagamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_contasreceberBindingSource, "dt_pagamento", true));
            this.dt_pagamentoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_pagamentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_pagamentoDateTimePicker.Location = new System.Drawing.Point(652, 106);
            this.dt_pagamentoDateTimePicker.Name = "dt_pagamentoDateTimePicker";
            this.dt_pagamentoDateTimePicker.Size = new System.Drawing.Size(139, 26);
            this.dt_pagamentoDateTimePicker.TabIndex = 12;
            // 
            // vl_pagoTextBox
            // 
            this.vl_pagoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contasreceberBindingSource, "vl_pago", true));
            this.vl_pagoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vl_pagoTextBox.Location = new System.Drawing.Point(652, 147);
            this.vl_pagoTextBox.Name = "vl_pagoTextBox";
            this.vl_pagoTextBox.Size = new System.Drawing.Size(200, 26);
            this.vl_pagoTextBox.TabIndex = 14;
            this.vl_pagoTextBox.TextChanged += new System.EventHandler(this.Vl_pagoTextBox_TextChanged);
            this.vl_pagoTextBox.Leave += new System.EventHandler(this.Vl_pagoTextBox_Leave);
            // 
            // cd_clienteTextBox
            // 
            this.cd_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contasreceberBindingSource, "cd_cliente", true));
            this.cd_clienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_clienteTextBox.Location = new System.Drawing.Point(652, 188);
            this.cd_clienteTextBox.Name = "cd_clienteTextBox";
            this.cd_clienteTextBox.Size = new System.Drawing.Size(200, 26);
            this.cd_clienteTextBox.TabIndex = 16;
            this.cd_clienteTextBox.TextChanged += new System.EventHandler(this.Cd_clienteTextBox_TextChanged);
            this.cd_clienteTextBox.Leave += new System.EventHandler(this.Cd_clienteTextBox_Leave);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(580, 363);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 39);
            this.btnSair.TabIndex = 60;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(449, 366);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(97, 39);
            this.btnImprimir.TabIndex = 59;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnPequisar
            // 
            this.btnPequisar.AutoSize = true;
            this.btnPequisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPequisar.Location = new System.Drawing.Point(316, 366);
            this.btnPequisar.Name = "btnPequisar";
            this.btnPequisar.Size = new System.Drawing.Size(99, 39);
            this.btnPequisar.TabIndex = 58;
            this.btnPequisar.Text = "Pesquisar";
            this.btnPequisar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(183, 366);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 39);
            this.btnCancelar.TabIndex = 57;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(50, 366);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(99, 39);
            this.btnSalvar.TabIndex = 56;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(578, 318);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(97, 39);
            this.btnExcluir.TabIndex = 55;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(446, 318);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(97, 39);
            this.btnAlterar.TabIndex = 54;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(314, 318);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(97, 39);
            this.btnNovo.TabIndex = 53;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.AutoSize = true;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(182, 318);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(97, 39);
            this.btnProximo.TabIndex = 52;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.AutoSize = true;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(50, 318);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(97, 39);
            this.btnAnterior.TabIndex = 51;
            this.btnAnterior.Text = "Avançar";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // FormReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnPequisar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(cd_conta_Label);
            this.Controls.Add(this.cd_conta_TextBox);
            this.Controls.Add(ds_contaLabel);
            this.Controls.Add(this.ds_contaTextBox);
            this.Controls.Add(dt_emissaoLabel);
            this.Controls.Add(this.dt_emissaoDateTimePicker);
            this.Controls.Add(vl_contaLabel);
            this.Controls.Add(this.vl_contaTextBox);
            this.Controls.Add(dt_vencimentoLabel);
            this.Controls.Add(this.dt_vencimentoDateTimePicker);
            this.Controls.Add(dt_pagamentoLabel);
            this.Controls.Add(this.dt_pagamentoDateTimePicker);
            this.Controls.Add(vl_pagoLabel);
            this.Controls.Add(this.vl_pagoTextBox);
            this.Controls.Add(cd_clienteLabel);
            this.Controls.Add(this.cd_clienteTextBox);
            this.Name = "FormReceber";
            this.Text = "FormReceber";
            this.Load += new System.EventHandler(this.FormReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contasreceberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tb_contasreceberBindingSource;
        private Database1DataSetTableAdapters.tb_contasreceberTableAdapter tb_contasreceberTableAdapter;
        private System.Windows.Forms.TextBox cd_conta_TextBox;
        private System.Windows.Forms.TextBox ds_contaTextBox;
        private System.Windows.Forms.DateTimePicker dt_emissaoDateTimePicker;
        private System.Windows.Forms.TextBox vl_contaTextBox;
        private System.Windows.Forms.DateTimePicker dt_vencimentoDateTimePicker;
        private System.Windows.Forms.DateTimePicker dt_pagamentoDateTimePicker;
        private System.Windows.Forms.TextBox vl_pagoTextBox;
        private System.Windows.Forms.TextBox cd_clienteTextBox;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPequisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
    }
}