using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace easyERP.View
{
    public partial class subgrupoPrdForm : Form
    {
        public subgrupoPrdForm()
        {
            InitializeComponent();
        }

        private void newBt_Click(object sender, EventArgs e)
        {
            op = 0;
            control(0);
        }

        Model.DB db = new Model.DB();
        Model.SubgrupoProduto obj = new Model.SubgrupoProduto();
        int op = 99;


            
        private void subgrupoPrdForm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'easyCaixaDataSet1.View_subgrupo'. Você pode movê-la ou removê-la conforme necessário.
            this.view_subgrupoTableAdapter.Fill(this.easyCaixaDataSet1.View_subgrupo);
            // TODO: esta linha de código carrega dados na tabela 'easyCaixaDataSet.View_subgrupo'. Você pode movê-la ou removê-la conforme necessário.
       

            // TODO: esta linha de código carrega dados na tabela 'easyCaixaDataSet3.GrupoProduto'. Você pode movê-la ou removê-la conforme necessário.







        }


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
                    var lst = db.GrupoProduto.Select(c=> new {c.id, c.descGrupo }).ToList();
                    comboBox1.DataSource = lst.Select(c => c.descGrupo).ToList();
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

                        obj = new Model.SubgrupoProduto();
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
                            obj = new Model.SubgrupoProduto();
                            obj.codSubgrupo = codTXT.Text;
                            obj.descSubgrupo = descTxt.Text;
                            obj.nvc1 = obsTxt.Text;

                            var subg = db.GrupoProduto.Where(c => c.descGrupo == comboBox1.Text).FirstOrDefault();


                            obj.grupoProduto = subg.id;

                            db.SubgrupoProduto.Add(obj);
                            db.SaveChanges();
                            GridView.Refresh();
                            this.view_subgrupoTableAdapter.Fill(this.easyCaixaDataSet1.View_subgrupo);

                            op = 99;
                            editBt.Enabled = true;
                            removeBt.Enabled = true;
                            newBt.Enabled = true;
                            EditGrpBox.Enabled = false;


                            obj = new Model.SubgrupoProduto();

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
                            obj = db.SubgrupoProduto.Where(c => c.id == cid).FirstOrDefault();
                            obj.codSubgrupo = codTXT.Text;
                            obj.descSubgrupo = descTxt.Text;
                            obj.nvc1 = obsTxt.Text;




                            db.SaveChanges();

                            GridView.DataSource = db.SubgrupoProduto.Select(c => new { c.id, c.codSubgrupo, c.descSubgrupo, c.nvc1 }).ToList();
                            op = 99;
                            editBt.Enabled = true;
                            removeBt.Enabled = true;
                            newBt.Enabled = true;
                            EditGrpBox.Enabled = false;
                            GridView.Enabled = true;


                            obj = new Model.SubgrupoProduto();

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
                        obj = db.SubgrupoProduto.Where(c => c.id == sid).FirstOrDefault();
                        db.SubgrupoProduto.Remove(obj);
                        db.SaveChanges();
                         GridView.DataSource = db.SubgrupoProduto.Select(c => new { c.id, c.codSubgrupo, c.descSubgrupo, c.nvc1 }).ToList();

                        obj = new Model.SubgrupoProduto();

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

        private void EditGrpBox_Enter(object sender, EventArgs e)
        {

        }

        private void viewsubgrupoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
         
        }
    }
}
