using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace easyERP.View.tipoEntrada
{
    public partial class tipoEntradaForm : Form
    {
        public tipoEntradaForm()
        {
            InitializeComponent();
        }
        Model.TipoEntrada obj = new Model.TipoEntrada();
        int op = 99;
        Model.DB db = new Model.DB();
        public void control(int x)
        {
            switch (x)
            {

                //Incluir --------------------
                case 0:

                    cancelbt.Enabled = true;
                    savebt.Enabled = true;

                    EditGrpBox.Enabled = true;

                    editBt.Enabled = false;
                    removeBt.Enabled = false;
                    newBt.Enabled = false;

                    codTXT.Text = "";
                    descTxt.Text = "";
                    obsTxt.Text = "";
               
                    break;
                //-------------

                // Editar --------------
                case 1:

                    cancelbt.Enabled = true;
                    removeBt.Enabled = false;
                    savebt.Enabled = true;
                    GridView.Enabled = false;
                    EditGrpBox.Enabled = true;
                    codTXT.Text = GridView.CurrentRow.Cells[1].Value.ToString();
                    descTxt.Text = GridView.CurrentRow.Cells[2].Value.ToString();
                    obsTxt.Text = GridView.CurrentRow.Cells[3].Value.ToString();
                    break;


                //--------------------Cancelar
                case 2:
                    DialogResult confirm = MessageBox.Show("Deseja Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                    if (confirm.ToString().ToUpper() == "YES")
                    {

                        obj = new Model.TipoEntrada();
                        codTXT.Text = "";
                        descTxt.Text = "";
                        obsTxt.Text = "";
                        EditGrpBox.Enabled = false;
                        op = 99;
                        editBt.Enabled = true;
                        removeBt.Enabled = true;
                        newBt.Enabled = true;
                        EditGrpBox.Enabled = false;
                        GridView.Enabled = true;
                        cancelbt.Enabled = false;
                        savebt.Enabled = false;
                    }



                    break;

                // Salvar

                case 3:
                    switch (op)
                    {



                        case 0:
                            obj = new Model.TipoEntrada();
                            obj.codEntrada =  codTXT.Text;
                            obj.descricaoEntrada= descTxt.Text;
                            obj.nvc1 = obsTxt.Text;






                            db.TipoEntrada.Add(obj);
                            db.SaveChanges();

                         this.tipoEntradaTableAdapter.Fill(this.tipoEntradaDataSet.TipoEntrada);

                            op = 99;
                            editBt.Enabled = true;
                            removeBt.Enabled = true;
                            newBt.Enabled = true;
                            EditGrpBox.Enabled = false;


                            obj = new Model.TipoEntrada();

                            codTXT.Text = "";
                            descTxt.Text = "";
                            obsTxt.Text = "";
                            EditGrpBox.Enabled = false;
                            op = 99;
                            editBt.Enabled = true;
                            removeBt.Enabled = true;
                            newBt.Enabled = true;
                            EditGrpBox.Enabled = false;


                            cancelbt.Enabled = false;
                            savebt.Enabled = false;

                            break;


                        case 1:
                            int cid = Convert.ToInt32(GridView.CurrentRow.Cells[0].Value);
                            obj = db.TipoEntrada.Where(c => c.id == cid).FirstOrDefault();
                            obj.codEntrada = codTXT.Text;
                            obj.descricaoEntrada = descTxt.Text;
                            obj.nvc1 = obsTxt.Text;




                            db.SaveChanges();

                            this.tipoEntradaTableAdapter.Fill(this.tipoEntradaDataSet.TipoEntrada);
                            op = 99;
                            editBt.Enabled = true;
                            removeBt.Enabled = true;
                            newBt.Enabled = true;
                            EditGrpBox.Enabled = false;
                            GridView.Enabled = true;


                            obj = new Model.TipoEntrada();

                            codTXT.Text = "";
                            descTxt.Text = "";
                            obsTxt.Text = "";
                            EditGrpBox.Enabled = false;
                            op = 99;
                            editBt.Enabled = true;
                            removeBt.Enabled = true;
                            newBt.Enabled = true;
                            EditGrpBox.Enabled = false;

                            cancelbt.Enabled = false;
                            savebt.Enabled = false;
                            break;

                    }

                    break;


                case 5:

                    DialogResult con = MessageBox.Show("Deseja excluir registro?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                    if (con.ToString().ToUpper() == "YES")
                    {

                        int sid = Convert.ToInt32(GridView.CurrentRow.Cells[0].Value);
                        obj = db.TipoEntrada.Where(c => c.id == sid).FirstOrDefault();
                        db.TipoEntrada.Remove(obj);
                        db.SaveChanges();
                       this.tipoEntradaTableAdapter.Fill(this.tipoEntradaDataSet.TipoEntrada);

                        obj = new Model.TipoEntrada();

                        codTXT.Text = "";
                        descTxt.Text = "";
                        obsTxt.Text = "";
                        EditGrpBox.Enabled = false;
                        op = 99;
                        editBt.Enabled = true;
                        removeBt.Enabled = true;
                        newBt.Enabled = true;
                        EditGrpBox.Enabled = false;
                    }




                    break;

            }





        }

        private void tipoEntradaForm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tipoEntradaDataSet.TipoEntrada'. Você pode movê-la ou removê-la conforme necessário.
            this.tipoEntradaTableAdapter.Fill(this.tipoEntradaDataSet.TipoEntrada);
            // TODO: esta linha de código carrega dados na tabela 'tipoEntradaDataSet.TipoEntrada'. Você pode movê-la ou removê-la conforme necessário.
            //this.tipoEntradaTableAdapter.Fill(this.tipoEntradaDataSet.TipoEntrada);
            // TODO: esta linha de código carrega dados na tabela 'easyCaixaDataSet.GrupoProduto'. Você pode movê-la ou removê-la conforme necessário.


        }

        private void newBt_Click(object sender, EventArgs e)
        {
            op = 0;
            control(0);
        }

        private void editBt_Click(object sender, EventArgs e)
        {
            op = 1;
            control(1);
        }

        private void cancelbt_Click(object sender, EventArgs e)
        {
            control(2);
        }

        private void savebt_Click(object sender, EventArgs e)
        {
            control(3);
        }

        private void removeBt_Click(object sender, EventArgs e)
        {
            control(5);
        }
    }
}
