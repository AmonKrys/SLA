using System;
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
    public partial class frm_Locacao : Form
    {

        FuncGeral obj_FuncGeral = new FuncGeral();
        Locacao Locacao_Principal = new Locacao();

        public frm_Locacao()
        {
            InitializeComponent();
            PopulaLista();
            obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaTela(this, false);
        }

        /**********************************************************************************
        * NOME:            PopulaLista
        * PROCEDIMENTO:    Preenche o ListBox com os dados que estão na TB_Locacao
        * DT CRIAÇÃO:      22/11/2019
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Amon && Guilherme
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaLista()
        {
            // Instância do objeto LocacaoBD
            LocacaoBD obj_LocacaoBD = new LocacaoBD();

            // Instância do objeto Lista
            List<Locacao> Lista = new List<Locacao>();

            // Limpando o ListBox
            lbox_Locacoes.Items.Clear();

            Lista = obj_LocacaoBD.FindAllLocacao();

            if (Lista != null)
            {
                for (int i = 0; i <= Lista.Count - 1; i++)
                {
                    lbox_Locacoes.Items.Add(Lista[i].COD_LOCACAO.ToString() + "-" + Lista[i].INICIO_LOCACAO);
                }
            }
        }

        private void lbox_Locacoes_Click(object sender, EventArgs e)
        {
            if (lbox_Locacoes.SelectedIndex != -1)
            {
                LocacaoBD obj_LocacaoBD = new LocacaoBD();

                string sLinha = lbox_Locacoes.Items[lbox_Locacoes.SelectedIndex].ToString();

                int ipos = 0;

                for (int t = 0; t <= sLinha.Length; t++)
                {
                    if (sLinha.Substring(t, 1) == "-")
                    {
                        ipos = t;
                        break;
                    }
                }

                Locacao_Principal.COD_LOCACAO = Convert.ToInt16(sLinha.Substring(0, ipos));

                Locacao_Principal = obj_LocacaoBD.FindByCodLocacao(Locacao_Principal);

                PopulaTela(Locacao_Principal);

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
        private void PopulaTela(Locacao aobj_Locacao)
        {
            if (aobj_Locacao.COD_LOCACAO != -1)
            {
                tbox_Cod_Locacao.Text = aobj_Locacao.COD_LOCACAO.ToString();
                tbox_Inicio_Locacao.Text = aobj_Locacao.INICIO_LOCACAO;
                tbox_Fim_Locacao.Text = aobj_Locacao.FIM_LOCACAO;
                tbox_Obs_Locacao.Text = aobj_Locacao.OBS_LOCACAO;

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
        private Locacao PopulaObjeto()
        {
            Locacao aobj_Locacao = new Locacao();

            if (tbox_Cod_Locacao.Text != "")
            {
                aobj_Locacao.COD_LOCACAO = Convert.ToInt16(tbox_Cod_Locacao.Text);
            }

            aobj_Locacao.INICIO_LOCACAO = Convert.ToString(tbox_Inicio_Locacao.Text);
            aobj_Locacao.FIM_LOCACAO =  Convert.ToString(tbox_Fim_Locacao.Text);
            aobj_Locacao.OBS_LOCACAO = Convert.ToString(tbox_Obs_Locacao.Text);


            return aobj_Locacao;
        }


        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            LocacaoBD obj_LocacaoBD = new LocacaoBD();

            Locacao_Principal = PopulaObjeto();

            if (Locacao_Principal.COD_LOCACAO != -1)
            {
                obj_LocacaoBD.Alterar(Locacao_Principal);
                MessageBox.Show("Locação alterada com sucesso. ", "Alteração da Locação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Locacao_Principal.COD_LOCACAO = obj_LocacaoBD.Incluir(Locacao_Principal);
                MessageBox.Show("Locação Incluida com sucesso. ", "Inclusão da Locação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulaTela(Locacao_Principal);
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
            tbox_Inicio_Locacao.Focus();

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);

            if (Locacao_Principal.COD_LOCACAO != -1)
            {
                PopulaTela(Locacao_Principal);
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
            tbox_Inicio_Locacao.Focus();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            LocacaoBD obj_LocacaoBD = new LocacaoBD();
            DialogResult varResp = MessageBox.Show("Confirma a Exclusão?", "Exclusão da Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (varResp == DialogResult.Yes)
            {
                if (obj_LocacaoBD.Excluir(Locacao_Principal))
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

        private void tbox_Inicio_Locacao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbox_Inicio_Locacao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
