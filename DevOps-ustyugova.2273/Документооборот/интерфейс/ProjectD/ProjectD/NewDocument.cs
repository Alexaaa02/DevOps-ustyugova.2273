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
    public partial class NewDocument : Form
    {
        public NewDocument()
        {
            InitializeComponent();
        }

        private void NewDocument_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDocumentDataSet.Initiator". При необходимости она может быть перемещена или удалена.
            this.initiatorTableAdapter.Fill(this.dbDocumentDataSet.Initiator);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDocumentDataSet.Executor". При необходимости она может быть перемещена или удалена.
            this.executorTableAdapter.Fill(this.dbDocumentDataSet.Executor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDocumentDataSet.Coordinator". При необходимости она может быть перемещена или удалена.
            this.coordinatorTableAdapter.Fill(this.dbDocumentDataSet.Coordinator);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDocumentDataSet.Coordinator". При необходимости она может быть перемещена или удалена.
            this.coordinatorTableAdapter.Fill(this.dbDocumentDataSet.Coordinator);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDocumentDataSet.TypeDocument". При необходимости она может быть перемещена или удалена.
            this.typeDocumentTableAdapter.Fill(this.dbDocumentDataSet.TypeDocument);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDocumentDataSet.DocumentStatus". При необходимости она может быть перемещена или удалена.
            this.documentStatusTableAdapter.Fill(this.dbDocumentDataSet.DocumentStatus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDocumentDataSet.NumderDepartment". При необходимости она может быть перемещена или удалена.
            this.numderDepartmentTableAdapter.Fill(this.dbDocumentDataSet.NumderDepartment);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker2.Checked && dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Дата начала не может быть больше даты окончания");
                return;
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
