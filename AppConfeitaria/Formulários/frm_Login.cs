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
    public partial class frm_Login : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        public frm_Login()
        {
            InitializeComponent();

        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            UsuarioBD obj_UsuarioBD = new UsuarioBD();
            Usuario obj_Usuario = new Usuario();

            obj_Usuario.LOG_USUARIO = tbox_Log_Usuario.Text;

            obj_Usuario = obj_UsuarioBD.FindByLogUsuario(obj_Usuario);

            if (obj_Usuario.LOG_USUARIO != "")
            {
                //login inválido caso vazio

                if (obj_FuncGeral.DesCriptografa(obj_Usuario.PASS_USUARIO) == tbox_Pass_Usuario.Text)
                {
                    frm_Principal obj_frm_Principal = new frm_Principal();
                    obj_frm_Principal.ShowDialog();
                    Close();

                }
                else
                {
                    MessageBox.Show("Senha digitada não encontrada. ", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbox_Pass_Usuario.Text = "";
                    tbox_Pass_Usuario.Focus();

                }
            }
            else
            {
                MessageBox.Show("Login digitado não encontrado. ", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbox_Log_Usuario.Text = "";
                tbox_Log_Usuario.Focus();
            }

        }

        private void frm_Login_Activated(object sender, EventArgs e)
        {
            tbox_Log_Usuario.Focus();
        }


    }
}

