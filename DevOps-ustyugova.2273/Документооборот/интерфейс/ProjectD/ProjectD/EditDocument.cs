using System;
using System.Windows.Forms;

namespace ProjectD
{
    public partial class EditDocument : Form
    {
        public EditDocument()
        {
            InitializeComponent();
        }

        protected internal int  idNumberDepartment;
        protected internal string NameND;

        protected internal int idDocumentStatus;
        protected internal string Status;

        protected internal int idTypeDocument;
        protected internal string Type;

        protected internal int idInitiator;
        protected internal int idPersonelNumberIni;

        protected internal int idCoordinator;
        protected internal int idPersonelNumberCoo;

        protected internal int idExecutor;
        protected internal int idPersonelNumberExe;

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker3.Checked && dateTimePicker2.Value > dateTimePicker3.Value)
            {
                MessageBox.Show("Дата начала не может быть больше даты окончания");
                return;
            }

            NameND = dbDocumentDataSet.NumderDepartment[numderDepartmentBindingSource.Position].Name;
            Status = dbDocumentDataSet.DocumentStatus[documentStatusBindingSource.Position].Status;
            Type = dbDocumentDataSet.TypeDocument[typeDocumentBindingSource.Position].Type;
            idPersonelNumberIni = dbDocumentDataSet.Initiator[initiatorBindingSource.Position].idPersonelNumber;
            idPersonelNumberCoo = dbDocumentDataSet.Coordinator[coordinatorBindingSource.Position].idPersonelNumber;
            idPersonelNumberExe = dbDocumentDataSet.Executor[executorBindingSource.Position].idPersonelNumber;

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void EditDocument_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDocumentDataSet.Executor". При необходимости она может быть перемещена или удалена.
            this.executorTableAdapter.Fill(this.dbDocumentDataSet.Executor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDocumentDataSet.Coordinator". При необходимости она может быть перемещена или удалена.
            this.coordinatorTableAdapter.Fill(this.dbDocumentDataSet.Coordinator);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDocumentDataSet.Initiator". При необходимости она может быть перемещена или удалена.
            this.initiatorTableAdapter.Fill(this.dbDocumentDataSet.Initiator);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDocumentDataSet.TypeDocument". При необходимости она может быть перемещена или удалена.
            this.typeDocumentTableAdapter.Fill(this.dbDocumentDataSet.TypeDocument);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDocumentDataSet.DocumentStatus". При необходимости она может быть перемещена или удалена.
            this.documentStatusTableAdapter.Fill(this.dbDocumentDataSet.DocumentStatus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDocumentDataSet.NumderDepartment". При необходимости она может быть перемещена или удалена.
            this.numderDepartmentTableAdapter.Fill(this.dbDocumentDataSet.NumderDepartment);

        }
    }
}
