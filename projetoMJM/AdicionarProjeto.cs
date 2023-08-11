﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoMJM
{
    public partial class AdicionarProjeto : Form
    {
        DAO conectar;
        public AdicionarProjeto()
        {
            InitializeComponent();
            conectar = new DAO();
        }

        private void AdicionarProjeto_Load(object sender, EventArgs e)
        {

        }

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }//Nome

        private void tipo_TextChanged(object sender, EventArgs e)
        {

        }//Tipo
        private void descricao_TextChanged(object sender, EventArgs e)
        {

        }//Descrição

        private void orcamento_TextChanged(object sender, EventArgs e)
        {

        }//Orçamento

        private void status_TextChanged(object sender, EventArgs e)
        {

        }//Status

        private void adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string result = conectar.Inserir(Convert.ToInt32(codigo.Text),nome.Text, tipo.Text, descricao.Text,
                                 Convert.ToDouble(orcamento.Text), status.Text, integrante.Text, "projeto"); ; 
                MessageBox.Show(result);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro.Message);
            }//Fim do try catch

        }//Adicionar

        private void integrante_TextChanged(object sender, EventArgs e)
        {

        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
