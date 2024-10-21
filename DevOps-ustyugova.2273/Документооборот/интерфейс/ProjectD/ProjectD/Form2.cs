
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        bool DataChanged;

       
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDocumentDataSet.Document". При необходимости она может быть перемещена или удалена.
            this.documentTableAdapter.Fill(this.dbDocumentDataSet.Document);
            


            DataChanged = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }

        private void exit1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm regP = new LoginForm();
            regP.Show();


        }
        private void update_Click(object sender, EventArgs e)
        {

            //try
            //{
            //   documentTableAdapter.Adapter.Update(dbDocumentDataSet.Document);
            //  dbDocumentDataSet.Document.AcceptChanges();

            //  DataChanged = false;
            // }
            // catch (Exception ex)
            // {
            //    MessageBox.Show("Ошибка при записи в базу данных\n" + ex.Message);
            //}
            MessageBox.Show("Именения сохранены");
        }

    private void button1_Click(object sender, EventArgs e)
        {
            
            documentBindingSource.Filter = documentBindingSource.Filter = " Name LIKE'" + textBox1.Text + "%'";

            

        }

        private void add_Click(object sender, EventArgs e)
        {
            NewDocument newDocument = new NewDocument();
            if (newDocument.ShowDialog() != DialogResult.OK)
                return;

            dbDocumentDataSet.DocumentRow row = (dbDocumentDataSet.DocumentRow)dbDocumentDataSet.Document.NewRow();
            
            row.DataRegistration = DateTime.Parse(newDocument.dateTimePicker1.Value.ToShortDateString());
            row.DataStart = DateTime.Parse(newDocument.dateTimePicker2.Value.ToShortDateString());

            if (newDocument.dateTimePicker3.Checked)
                row.DataEnd = DateTime.Parse(newDocument.dateTimePicker2.Value.ToShortDateString());
            if (newDocument.dateTimePicker4.Checked)
                row.DataEdited = DateTime.Parse(newDocument.dateTimePicker3.Value.ToShortDateString());

            row.RegistrationNumber = newDocument.textBox1.Text;
            row.Name = newDocument.textBox2.Text;
            row.Desription = newDocument.textBox3.Text;

            row.idNumderDepartment = (int)newDocument.dataGridView1["idNumderDepartmentDataGridViewTextBoxColumn", newDocument.dataGridView1.CurrentRow.Index].Value;
            row.idDocumentStatus = (int)newDocument.dataGridView3["idDocumentStatusDataGridViewTextBoxColumn", newDocument.dataGridView3.CurrentRow.Index].Value;
            row.idTypeDocument = (int)newDocument.dataGridView5["idTypeDocumentDataGridViewTextBoxColumn", newDocument.dataGridView5.CurrentRow.Index].Value;
            row.idCoordinator = (int)newDocument.dataGridView2["idCoordinatorDataGridViewTextBoxColumn", newDocument.dataGridView2.CurrentRow.Index].Value;
            row.idExecutor = (int)newDocument.dataGridView4["idExecutorDataGridViewTextBoxColumn", newDocument.dataGridView4.CurrentRow.Index].Value;
            row.idinitiator = (int)newDocument.dataGridView6["idinitiatorDataGridViewTextBoxColumn", newDocument.dataGridView6.CurrentRow.Index].Value;

            dbDocumentDataSet.Document.Rows.Add(row);

            dataGridView1["NumDep", dataGridView1.RowCount - 1].Value = newDocument.dataGridView1["nameDataGridViewTextBoxColumn", newDocument.dataGridView1.CurrentRow.Index].Value;
            dataGridView1["Status", dataGridView1.RowCount - 1].Value = newDocument.dataGridView3["statusDataGridViewTextBoxColumn", newDocument.dataGridView3.CurrentRow.Index].Value;
            dataGridView1["Type", dataGridView1.RowCount - 1].Value = newDocument.dataGridView5["typeDataGridViewTextBoxColumn", newDocument.dataGridView5.CurrentRow.Index].Value;
            dataGridView1["idPersonelNumberCoo", dataGridView1.RowCount - 1].Value = (int)newDocument.dataGridView2["idPersonelNumberDataGridViewTextBoxColumn", newDocument.dataGridView2.CurrentRow.Index].Value;
            dataGridView1["idPersonelNumberExe", dataGridView1.RowCount - 1].Value = (int)newDocument.dataGridView4["idPersonelNumberDataGridViewTextBoxColumn1", newDocument.dataGridView4.CurrentRow.Index].Value;
            dataGridView1["idPersonelNumberIni", dataGridView1.RowCount - 1].Value = (int)newDocument.dataGridView6["idPersonelNumberDataGridViewTextBoxColumn2", newDocument.dataGridView6.CurrentRow.Index].Value;

            documentBindingSource.Position = documentBindingSource.Count - 1;
            DataChanged = true;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            int id = (int)dataGridView1["dataGridViewTextBoxColumn1", dataGridView1.CurrentRow.Index].Value;
            dbDocumentDataSet.Document.FindByidDocument(id).Delete();
            DataChanged = true;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            int ind = dataGridView1.CurrentRow.Index;

            EditDocument editDocument = new EditDocument();
            editDocument.dateTimePicker1.Value = (DateTime)dataGridView1["dataGridViewTextBoxColumn5", ind].Value;
            editDocument.dateTimePicker2.Value = (DateTime)dataGridView1["dataGridViewTextBoxColumn6", ind].Value;
            
            if (dataGridView1["dataGridViewTextBoxColumn7", ind].Value  != DBNull.Value)
                editDocument.dateTimePicker3.Value = (DateTime)dataGridView1["dataGridViewTextBoxColumn7", ind].Value;
            else
                editDocument.dateTimePicker3.Checked = false;

            if (dataGridView1["dataGridViewTextBoxColumn8", ind].Value != DBNull.Value)
                editDocument.dateTimePicker4.Value = (DateTime)dataGridView1["dataGridViewTextBoxColumn8", ind].Value;
            else
                editDocument.dateTimePicker4.Checked = false;


            editDocument.textBox1.Text = (string)dataGridView1["dataGridViewTextBoxColumn3", ind].Value;
            editDocument.textBox2.Text = (string)dataGridView1["dataGridViewTextBoxColumn4", ind].Value;
            editDocument.textBox3.Text = (string)dataGridView1["desriptionDataGridViewTextBoxColumn", ind].Value;

            editDocument.idNumberDepartment = (int)dataGridView1["dataGridViewTextBoxColumn2", ind].Value;
            editDocument.idDocumentStatus = (int)dataGridView1["dataGridViewTextBoxColumn9", ind].Value;
            editDocument.idTypeDocument = (int)dataGridView1["dataGridViewTextBoxColumn10", ind].Value;
            editDocument.idInitiator = (int)dataGridView1["idinitiator", ind].Value;
            editDocument.idCoordinator = (int)dataGridView1["idCoordinator", ind].Value;
            editDocument.idExecutor = (int)dataGridView1["idExecutor", ind].Value;

            if (editDocument.ShowDialog() != DialogResult.OK)
                return;

            dataGridView1["dataGridViewTextBoxColumn5", ind].Value = editDocument.dateTimePicker1.Value;
            dataGridView1["dataGridViewTextBoxColumn6", ind].Value = editDocument.dateTimePicker2.Value;
            dataGridView1["dataGridViewTextBoxColumn8", ind].Value = editDocument.dateTimePicker4.Value;

            if (editDocument.dateTimePicker3.Checked)
                dataGridView1["dataGridViewTextBoxColumn7", ind].Value = editDocument.dateTimePicker3.Value;
            else
                dataGridView1["dataGridViewTextBoxColumn7", ind].Value = DBNull.Value;

            dataGridView1["dataGridViewTextBoxColumn3", ind].Value = editDocument.textBox1.Text;
            dataGridView1["dataGridViewTextBoxColumn4", ind].Value = editDocument.textBox2.Text;
            dataGridView1["desriptionDataGridViewTextBoxColumn", ind].Value = editDocument.textBox3.Text;

            dataGridView1["dataGridViewTextBoxColumn2", ind].Value = editDocument.comboBox1.SelectedValue;
            dataGridView1["NumDep", ind].Value = editDocument.NameND;

            dataGridView1["dataGridViewTextBoxColumn9", ind].Value = editDocument.comboBox2.SelectedValue;
            dataGridView1["Status", ind].Value = editDocument.Status;

            dataGridView1["dataGridViewTextBoxColumn10", ind].Value = editDocument.comboBox3.SelectedValue;
            dataGridView1["Type", ind].Value = editDocument.Type;

            dataGridView1["idinitiator", ind].Value = editDocument.comboBox4.SelectedValue;
            dataGridView1["idPersonelNumberIni", ind].Value = editDocument.idPersonelNumberIni;

            dataGridView1["idCoordinator", ind].Value = editDocument.comboBox5.SelectedValue;
            dataGridView1["idPersonelNumberCoo", ind].Value = editDocument.idPersonelNumberCoo;

            dataGridView1["idExecutor", ind].Value = editDocument.comboBox6.SelectedValue;
            dataGridView1["idPersonelNumberExe", ind].Value = editDocument.idPersonelNumberExe;

            DataChanged = true;

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!DataChanged)
                return;
            DialogResult dr = MessageBox.Show("Сохранить данные?", "", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.No)
                return;
            if (dr == DialogResult.Cancel)
                e.Cancel = true;
            add.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            documentBindingSource.Filter = documentBindingSource.Filter= " NumDep LIKE'" + textBox2.Text + "%'";
        }
    }
}

