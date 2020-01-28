using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Festival.desktop
{
    public partial class CantorFrm : Form
    {
        public CantorFrm()
        {
            InitializeComponent();
            bindingSourceCantor.DataSource = new Festival.or.Cantor();
            bindingSourceApresentacao.DataSource = new Festival.or.Apresentacao();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                // Montar objeto Cantor
                Festival.or.Cantor cantor= new Festival.or.Cantor();
                cantor = (Festival.or.Cantor)bindingSourceCantor.Current;
                // Montar objeto Apresentação
                Festival.or.Apresentacao apresentacao = new Festival.or.Apresentacao();
                apresentacao = (Festival.or.Apresentacao)bindingSourceApresentacao.Current;

                /* Gravar cantor no banco
                Festival.bo.CantorBo bo = new Festival.bo.CantorBo();
                bindingSourceCantor.EndEdit();
                bo.Inserir(cantor);
                MessageBox.Show("Inserido com sucesso");
                */
                // Gravar Apresentação no banco
                Festival.bo.ApresentacaoBo apresentacaoBo = new Festival.bo.ApresentacaoBo();
                bindingSourceApresentacao.EndEdit();
                apresentacao.fk_categoria = new or.Categoria()
                {
                    id_categoria = 1,
                    categoria = "sertanejo",
                    dia = DateTime.Now
                };
                apresentacao.fk_cantor = cantor;

                apresentacaoBo.Inserir(apresentacao);
                MessageBox.Show("Inserido com sucesso");



                // Limpar campos
                this.txtNome.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir ");
                throw new Exception("Erro ao inserir  " + ex);
            }
        }
    }
    
}
