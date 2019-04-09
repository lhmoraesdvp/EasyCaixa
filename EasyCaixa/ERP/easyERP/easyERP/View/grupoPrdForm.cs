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
            // TODO: esta linha de código carrega dados na tabela 'easyCaixaDataSet1.GrupoProduto'. Você pode movê-la ou removê-la conforme necessário.

            // TODO: esta linha de código carrega dados na tabela 'easyCaixaDataSet.GrupoProduto'. Você pode movê-la ou removê-la conforme necessário.

            grupoPrdGridView.DataSource = db.GrupoProduto.Select(c => new {c.id, c.codGrupo, c.descGrupo, c.nvc1 }).ToList();

        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            cancelbt.Enabled = true;
            removeBt.Enabled = false;
            savebt.Enabled = true;
            grupoPrdGridView.Enabled = false;
            nprdGrpBox.Enabled = true;
            op = 1;
            codTXT.Text= grupoPrdGridView.CurrentRow.Cells[1].Value.ToString();
            descTxt.Text = grupoPrdGridView.CurrentRow.Cells[2].Value.ToString();
            obsTxt.Text= grupoPrdGridView.CurrentRow.Cells[3].Value.ToString();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)

        {
            cancelbt.Enabled = true;
            savebt.Enabled = true;
            op = 0;
            nprdGrpBox.Enabled = true;

            editBt.Enabled = false;
            removeBt.Enabled = false;
            newBt.Enabled = false;

            codTXT.Text = "";
            descTxt.Text = "";
            obsTxt.Text = "";

        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case 0:
                    grpProduto = new Model.GrupoProduto();
                    grpProduto.codGrupo = codTXT.Text;
                    grpProduto.descGrupo = descTxt.Text;
                    grpProduto.nvc1 = obsTxt.Text;
                    db.GrupoProduto.Add(grpProduto);
                    db.SaveChanges();
                    grupoPrdGridView.DataSource = db.GrupoProduto.Select(c => new {c.id, c.codGrupo, c.descGrupo, c.nvc1 }).ToList();
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


                    cancelbt.Enabled = false ;
                    savebt.Enabled = false;

                    break;


                case 1:
                    int cid= Convert.ToInt32(grupoPrdGridView.CurrentRow.Cells[0].Value);
                    grpProduto = db.GrupoProduto.Where(c => c.id == cid).FirstOrDefault();
                    grpProduto.codGrupo = codTXT.Text;
                    grpProduto.descGrupo = descTxt.Text;
                    grpProduto.nvc1 = obsTxt.Text;
                   

                   // db.GrupoProduto.Remove(grpProduto);
                   // db.SaveChanges();
                  //  db.GrupoProduto.Add(gp1);

                    db.SaveChanges();

                      grupoPrdGridView.DataSource = db.GrupoProduto.Select(c => new {c.id, c.codGrupo, c.descGrupo, c.nvc1 }).ToList();
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
        }

        private void removeBt_Click(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32 (grupoPrdGridView.CurrentRow.Cells[0].Value);
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

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            switch (op)
            {

                case 0:
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



                case 1:

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
                    break;


            }
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
    }

       

      

  

      
     
    }
