using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConfeitaria
{
    public partial class frm_Usuario : Form
    {

        FuncGeral obj_FuncGeral = new FuncGeral();
        Usuario Usuario_Principal = new Usuario();

        public frm_Usuario()
        {
            InitializeComponent();
            PopulaLista();
            obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaTela(this, false);
        }

        /**********************************************************************************
        * NOME:            PopulaLista
        * PROCEDIMENTO:    Preenche o ListBox com os dados que estão na TB_Usuario
        * DT CRIAÇÃO:     19/02/2020
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    Jhonatan de Oliveira
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaLista()
        {
            // Instância do objeto UsuarioBD
            UsuarioBD obj_UsuarioBD = new UsuarioBD();

            // Instância do objeto Lista
            List<Usuario> Lista = new List<Usuario>();

            // Limpando o ListBox
            lbox_Usuarios.Items.Clear();

            Lista = obj_UsuarioBD.FindAllUsuario();

            if (Lista != null)
            {
                for (int i = 0; i <= Lista.Count - 1; i++)
                {
                    lbox_Usuarios.Items.Add(Lista[i].COD_USUARIO.ToString() + "-" + Lista[i].LOG_USUARIO + "-" + Convert.ToString(Convert.ToInt16(Lista[i].LEV_USUARIO) + 1));
                }
            }
        }

        private void lbox_Usuarios_Click(object sender, EventArgs e)
        {
            if (lbox_Usuarios.SelectedIndex != -1)
            {
                UsuarioBD obj_UsuarioBD = new UsuarioBD();

                string sLinha = lbox_Usuarios.Items[lbox_Usuarios.SelectedIndex].ToString();

                int ipos = 0;

                for (int t = 0; t <= sLinha.Length; t++)
                {
                    if (sLinha.Substring(t, 1) == "-")
                    {
                        ipos = t;
                        break;
                    }
                }

                Usuario_Principal.COD_USUARIO = Convert.ToInt16(sLinha.Substring(0, ipos));

                Usuario_Principal = obj_UsuarioBD.FindByCodUsuario(Usuario_Principal);

                PopulaTela(Usuario_Principal);

                obj_FuncGeral.StatusBtn(this, 2);

            }
        }

        /**********************************************************************************
        * NOME:            PopulaTela
        * PROCEDIMENTO:    Preenche a tela com os dados do Objeto Principal
        * DT CRIAÇÃO:     19/02/2020
        * DT ALTERAÇÃO:    -
        * PARAMETRO:       
        * ESCRITA POR:    Jhonatan de Oliveira
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaTela(Usuario aobj_Usuario)
        {
            if (aobj_Usuario.COD_USUARIO != -1)
            {
                tbox_Cod_Usuario.Text = aobj_Usuario.COD_USUARIO.ToString();
                tbox_Log_Usuario.Text = aobj_Usuario.LOG_USUARIO;
                tbox_Pass_Usuario.Text = obj_FuncGeral.DesCriptografa(aobj_Usuario.PASS_USUARIO);
                cbox_Lev_Usuario.SelectedIndex = aobj_Usuario.LEV_USUARIO;
            }
        }


        /**********************************************************************************
        * NOME:            PopulaObjeto
        * PROCEDIMENTO:    Preenche o objeto com os dados da  tela 
        * DT CRIAÇÃO:     19/02/2020
        * DT ALTERAÇÃO:    -
        * PARAMETRO:       
        * ESCRITA POR:    Jhonatan de Oliveira
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private Usuario PopulaObjeto()
        {
            Usuario aobj_Usuario = new Usuario();

            if (tbox_Cod_Usuario.Text != "")
            {
                aobj_Usuario.COD_USUARIO = Convert.ToInt16(tbox_Cod_Usuario.Text);
            }

            aobj_Usuario.LOG_USUARIO = tbox_Log_Usuario.Text;
            aobj_Usuario.PASS_USUARIO = obj_FuncGeral.Criptografa(tbox_Pass_Usuario.Text);
            aobj_Usuario.LEV_USUARIO = cbox_Lev_Usuario.SelectedIndex;

            return aobj_Usuario;
        }


        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            UsuarioBD obj_UsuarioBD = new UsuarioBD();

            Usuario_Principal = PopulaObjeto();

            if (Usuario_Principal.COD_USUARIO != -1)
            {
                obj_UsuarioBD.Alterar(Usuario_Principal);
                MessageBox.Show("Usuario alterada com sucesso. ", "Alteração da Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Usuario_Principal.COD_USUARIO = obj_UsuarioBD.Incluir(Usuario_Principal);
                MessageBox.Show("Usuario Incluida com sucesso. ", "Inclusão da Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulaTela(Usuario_Principal);
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
            tbox_Log_Usuario.Focus();

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);

            if (Usuario_Principal.COD_USUARIO != -1)
            {
                PopulaTela(Usuario_Principal);
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
            tbox_Log_Usuario.Focus();

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            UsuarioBD obj_UsuarioBD = new UsuarioBD();
            DialogResult varResp = MessageBox.Show("Confirma a Exclusão?", "Exclusão da Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (varResp == DialogResult.Yes)
            {
                if (obj_UsuarioBD.Excluir(Usuario_Principal))
                {
                    MessageBox.Show("Usuario excluida com sucesso. ", "Exclusão da Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 1);
                PopulaLista();


            }

        }

        private void cbox_VizualizaPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_VizualizaPass.Checked)
            {
                tbox_Pass_Usuario.PasswordChar = '\0';
            }
            else
            {
                tbox_Pass_Usuario.PasswordChar = '*';
            }
        }

       
    }
}
