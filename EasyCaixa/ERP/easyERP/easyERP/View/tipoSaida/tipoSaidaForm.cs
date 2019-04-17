using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace easyERP.View.tipoSaida
{
    public partial class tipoSaidaForm : Form
    {
        public tipoSaidaForm()
        {
            InitializeComponent();
        }

        Model.tipoSaida obj = new Model.tipoSaida();
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

                        obj = new Model.tipoSaida();
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
                            obj = new Model.tipoSaida();
                            obj.codSaida = codTXT.Text;
                            obj.descSaida = descTxt.Text;
                            obj.nvc1 = obsTxt.Text;






                            db.tipoSaida.Add(obj);
                            db.SaveChanges();

                            this.tipoSaidaTableAdapter.Fill(this.tipoSaidaDataSet.tipoSaida);

                            op = 99;
                            editBt.Enabled = true;
                            removeBt.Enabled = true;
                            newBt.Enabled = true;
                            EditGrpBox.Enabled = false;


                            obj = new Model.tipoSaida();

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
                            obj = db.tipoSaida.Where(c => c._int == cid).FirstOrDefault();
                            obj.codSaida = codTXT.Text;
                            obj.descSaida = descTxt.Text;
                            obj.nvc1 = obsTxt.Text;




                            db.SaveChanges();

                            this.tipoSaidaTableAdapter.Fill(this.tipoSaidaDataSet.tipoSaida);
                            op = 99;
                            editBt.Enabled = true;
                            removeBt.Enabled = true;
                            newBt.Enabled = true;
                            EditGrpBox.Enabled = false;
                            GridView.Enabled = true;


                            obj = new Model.tipoSaida();

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
                        obj = db.tipoSaida.Where(c => c._int == sid).FirstOrDefault();
                        db.tipoSaida.Remove(obj);
                        db.SaveChanges();
                        this.tipoSaidaTableAdapter.Fill(this.tipoSaidaDataSet.tipoSaida);

                        obj = new Model.tipoSaida();

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
        private void tipoSaidaForm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tipoSaidaDataSet.tipoSaida'. Você pode movê-la ou removê-la conforme necessário.
            this.tipoSaidaTableAdapter.Fill(this.tipoSaidaDataSet.tipoSaida);

        }

      

    

       


      

        private void newBt_Click_1(object sender, EventArgs e)
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
