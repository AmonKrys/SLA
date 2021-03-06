﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLA
{
    public partial class frm_Cliente : Form
    {

        FuncGeral obj_FuncGeral = new FuncGeral();
        Cliente Cliente_Principal = new Cliente();

        public frm_Cliente()
        {
            InitializeComponent();
            PopulaLista();
            obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaTela(this, false);
        }

        /**********************************************************************************
        * NOME:            PopulaLista
        * PROCEDIMENTO:    Preenche o ListBox com os dados que estão na TB_Cliente
        * DT CRIAÇÃO:      22/11/2019
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amon && Guilherme
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaLista()
        {
            // Instância do objeto ClienteBD
            ClienteBD obj_ClienteBD = new ClienteBD();

            // Instância do objeto Lista
            List<Cliente> Lista = new List<Cliente>();

            // Limpando o ListBox
            lbox_Clientes.Items.Clear();

            Lista = obj_ClienteBD.FindAllCliente();

            if (Lista != null)
            {
                for (int i = 0; i <= Lista.Count - 1; i++)
                {
                    lbox_Clientes.Items.Add(Lista[i].COD_CLIENTE.ToString() + "-" + Lista[i].NOME_CLIENTE);
                }
            }
        }

        private void lbox_Clientes_Click(object sender, EventArgs e)
        {
            if (lbox_Clientes.SelectedIndex != -1)
            {
                ClienteBD obj_ClienteBD = new ClienteBD();

                string sLinha = lbox_Clientes.Items[lbox_Clientes.SelectedIndex].ToString();

                int ipos = 0;

                for (int t = 0; t <= sLinha.Length; t++)
                {
                    if (sLinha.Substring(t, 1) == "-")
                    {
                        ipos = t;
                        break;
                    }
                }

                Cliente_Principal.COD_CLIENTE = Convert.ToInt16(sLinha.Substring(0, ipos));

                Cliente_Principal = obj_ClienteBD.FindByCodCliente(Cliente_Principal);

                PopulaTela(Cliente_Principal);

                obj_FuncGeral.StatusBtn(this, 2);

            }
        }

        /**********************************************************************************
        * NOME:            PopulaTela
        * PROCEDIMENTO:    Preenche a tela com os dados do Objeto Principal
        * DT CRIAÇÃO:      22/11/2019
        * DT ALTERAÇÃO:    -
        * PARAMETRO:       
        * ESCRITA POR:    Amon && Guilherme
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaTela(Cliente aobj_Cliente)
        {
            if (aobj_Cliente.COD_CLIENTE != -1)
            {
                tbox_Cod_Cliente.Text = aobj_Cliente.COD_CLIENTE.ToString();
                tbox_Nm_Cliente.Text = aobj_Cliente.NOME_CLIENTE;
                tbox_Email_Cliente.Text = aobj_Cliente.EMAIL_CLIENTE;
                tbox_Tel_Cliente.Text = aobj_Cliente.TEL_CLIENTE;
                tbox_End_Cliente.Text = aobj_Cliente.END_CLIENTE;
                tbox_Bai_Cliente.Text = aobj_Cliente.BAI_CLIENTE;
                tbox_Cid_Cliente.Text = aobj_Cliente.CID_CLIENTE;
                tbox_Uf_Cliente.Text = aobj_Cliente.UF_CLIENTE;
                tbox_Cep_Cliente.Text = aobj_Cliente.CEP_CLIENTE;


                
            }
        }

        /**********************************************************************************
        * NOME:            PopulaObjeto
        * PROCEDIMENTO:    Preenche o objeto com os dados da  tela 
        * DT CRIAÇÃO:      22/11/2019
        * DT ALTERAÇÃO:    -
        * PARAMETRO:       
        * ESCRITA POR:     Amon && Guilherme
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private Cliente PopulaObjeto()
        {
            Cliente aobj_Cliente = new Cliente();

            if (tbox_Cod_Cliente.Text != "")
            {
                aobj_Cliente.COD_CLIENTE = Convert.ToInt16(tbox_Cod_Cliente.Text);
            }

            aobj_Cliente.NOME_CLIENTE = tbox_Nm_Cliente.Text;
            aobj_Cliente.EMAIL_CLIENTE = tbox_Email_Cliente.Text;
            aobj_Cliente.TEL_CLIENTE = tbox_Tel_Cliente.Text;
            aobj_Cliente.END_CLIENTE = tbox_End_Cliente.Text;
            aobj_Cliente.BAI_CLIENTE = tbox_Bai_Cliente.Text;
            aobj_Cliente.CID_CLIENTE = tbox_Cid_Cliente.Text;
            aobj_Cliente.UF_CLIENTE = tbox_Uf_Cliente.Text;
            aobj_Cliente.CEP_CLIENTE = tbox_Cep_Cliente.Text;


            return aobj_Cliente;
        }


        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            ClienteBD obj_ClienteBD = new ClienteBD();

            Cliente_Principal = PopulaObjeto();

            if (Cliente_Principal.COD_CLIENTE != -1)
            {
                obj_ClienteBD.Alterar(Cliente_Principal);
                MessageBox.Show("Cliente alterada com sucesso. ", "Alteração da Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Cliente_Principal.COD_CLIENTE = obj_ClienteBD.Incluir(Cliente_Principal);
                MessageBox.Show("Cliente Incluida com sucesso. ", "Inclusão da Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulaTela(Cliente_Principal);
            }

            obj_FuncGeral.StatusBtn(this, 2);
            obj_FuncGeral.HabilitaTela(this, false);
            PopulaLista();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            obj_FuncGeral.LimpaTela(this);
            obj_FuncGeral.StatusBtn(this, 3);
            tbox_Nm_Cliente.Focus();

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);

            if (Cliente_Principal.COD_CLIENTE != -1)
            {
                PopulaTela(Cliente_Principal);
                obj_FuncGeral.StatusBtn(this, 2);
            }
            else
            {
                obj_FuncGeral.StatusBtn(this, 1);
            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            obj_FuncGeral.StatusBtn(this, 3);
            tbox_Nm_Cliente.Focus();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            ClienteBD obj_ClienteBD = new ClienteBD();
            DialogResult varResp = MessageBox.Show("Confirma a Exclusão?", "Exclusão da Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (varResp == DialogResult.Yes)
            {
                if (obj_ClienteBD.Excluir(Cliente_Principal))
                {
                    MessageBox.Show("Cliente excluida com sucesso. ", "Exclusão da Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 1);
                PopulaLista();
            }
        }

        private void pnl_Botoes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbox_Clientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbox_Cod_Cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Locacao obj_frm_Locacao = new frm_Locacao();
            obj_frm_Locacao.ShowDialog();
        }
    }
}
