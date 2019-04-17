using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace easyERP
{
    public partial class grupoPrdForm : Form
    {
        public grupoPrdForm()
        {
            InitializeComponent();
        }

        Model.DB db = new Model.DB();
        Model.GrupoProduto grpProduto = new Model.GrupoProduto();
        int op = 99;
        


        private void grupoPrdForm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'easyCaixaDataSet.GrupoProduto'. Você pode movê-la ou removê-la conforme necessário.
            this.grupoProdutoTableAdapter.Fill(this.easyCaixaDataSet.GrupoProduto);
            // TODO: esta linha de código carrega dados na tabela 'easyCaixaDataSet1.GrupoProduto'. Você pode movê-la ou removê-la conforme necessário.

            // TODO: esta linha de código carrega dados na tabela 'easyCaixaDataSet.GrupoProduto'. Você pode movê-la ou removê-la conforme necessário.


            //db.GrupoProduto.Select(c => new {c.id, c.codGrupo, c.descGrupo, c.nvc1 }).ToList();

        }


        public void control(int x)
        {
            switch (x)
            {

                //Incluir --------------------
                case 0:

                    cancelbt.Enabled = true;
                    savebt.Enabled = true;
                  
                    nprdGrpBox.Enabled = true;

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
                    grupoPrdGridView.Enabled = false;
                    nprdGrpBox.Enabled = true;
                    codTXT.Text = grupoPrdGridView.CurrentRow.Cells[1].Value.ToString();
                    descTxt.Text = grupoPrdGridView.CurrentRow.Cells[2].Value.ToString();
                    obsTxt.Text = grupoPrdGridView.CurrentRow.Cells[3].Value.ToString();
                    break;


                    //--------------------Cancelar
                case 2:
                    DialogResult confirm = MessageBox.Show("Deseja Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                    if (confirm.ToString().ToUpper() == "YES")
                    {

                        grpProduto = new Model.GrupoProduto();
                        codTXT.Text = "";
                        descTxt.Text = "";
                        obsTxt.Text = "";
                        nprdGrpBox.Enabled = false;
                        op = 99;
                        editBt.Enabled = true;
                        removeBt.Enabled = true;
                        newBt.Enabled = true;
                        nprdGrpBox.Enabled = false;
                        grupoPrdGridView.Enabled = true;
                        cancelbt.Enabled = false;
                        savebt.Enabled = false;
                    }

                    

                    break;

                    // Salvar

                case 3:
                    switch (op)
                    {



                        case 0:
                            grpProduto = new Model.GrupoProduto();
                            grpProduto.codGrupo = codTXT.Text;
                            grpProduto.descGrupo = descTxt.Text;
                            grpProduto.nvc1 = obsTxt.Text;
                            db.GrupoProduto.Add(grpProduto);
                            db.SaveChanges();
                            grupoPrdGridView.DataSource = db.GrupoProduto.Select(c => new { c.id, c.codGrupo, c.descGrupo, c.nvc1 }).ToList();
                            op = 99;
                            editBt.Enabled = true;
                            removeBt.Enabled = true;
                            newBt.Enabled = true;
                            nprdGrpBox.Enabled = false;


                            grpProduto = new Model.GrupoProduto();

                            codTXT.Text = "";
                            descTxt.Text = "";
                            obsTxt.Text = "";
                            nprdGrpBox.Enabled = false;
                            op = 99;
                            editBt.Enabled = true;
                            removeBt.Enabled = true;
                            newBt.Enabled = true;
                            nprdGrpBox.Enabled = false;


                            cancelbt.Enabled = false;
                            savebt.Enabled = false;
                            this.grupoProdutoTableAdapter.Fill(this.easyCaixaDataSet.GrupoProduto);

                            break;


                        case 1:
                            int cid = Convert.ToInt32(grupoPrdGridView.CurrentRow.Cells[0].Value);
                            grpProduto = db.GrupoProduto.Where(c => c.id == cid).FirstOrDefault();
                            grpProduto.codGrupo = codTXT.Text;
                            grpProduto.descGrupo = descTxt.Text;
                            grpProduto.nvc1 = obsTxt.Text;


                     

                            db.SaveChanges();

                            grupoPrdGridView.DataSource = db.GrupoProduto.Select(c => new { c.id, c.codGrupo, c.descGrupo, c.nvc1 }).ToList();
                            op = 99;
                            editBt.Enabled = true;
                            removeBt.Enabled = true;
                            newBt.Enabled = true;
                            nprdGrpBox.Enabled = false;
                            grupoPrdGridView.Enabled = true;


                            grpProduto = new Model.GrupoProduto();

                            codTXT.Text = "";
                            descTxt.Text = "";
                            obsTxt.Text = "";
                            nprdGrpBox.Enabled = false;
                            op = 99;
                            editBt.Enabled = true;
                            removeBt.Enabled = true;
                            newBt.Enabled = true;
                            nprdGrpBox.Enabled = false;

                            cancelbt.Enabled = false;
                            savebt.Enabled = false;
                            break;

                    }

                    break;


                case 5:

                    DialogResult con = MessageBox.Show("Deseja excluir registro?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                    if (con.ToString().ToUpper() == "YES")
                    {

                        int sid = Convert.ToInt32(grupoPrdGridView.CurrentRow.Cells[0].Value);
                        grpProduto = db.GrupoProduto.Where(c => c.id == sid).FirstOrDefault();
                        db.GrupoProduto.Remove(grpProduto);
                        db.SaveChanges();
                        grupoPrdGridView.DataSource = db.GrupoProduto.Select(c => new { c.id, c.codGrupo, c.descGrupo, c.nvc1 }).ToList();

                        grpProduto = new Model.GrupoProduto();

                        codTXT.Text = "";
                        descTxt.Text = "";
                        obsTxt.Text = "";
                        nprdGrpBox.Enabled = false;
                        op = 99;
                        editBt.Enabled = true;
                        removeBt.Enabled = true;
                        newBt.Enabled = true;
                        nprdGrpBox.Enabled = false;
                    }




                    break;

            }





        }








        private void toolStripButton14_Click(object sender, EventArgs e)

        {
            op = 1;
            control(1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)

        {
            op = 0;
            control(0);

        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            control(3);
        }

        private void removeBt_Click(object sender, EventArgs e)
        {
            control(5);


        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            
            control(2);
            
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void nprdGrpBox_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tipoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void grupoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

       

      

  

      
     
    }
