using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAssessment
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
            table1DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            facultyDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            staffDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void pnlStudent_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void table1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'staffDataSet.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.staffDataSet.staff);
            // TODO: This line of code loads data into the 'facultyDataSet.faculty' table. You can move, or remove it, as needed.
            this.facultyTableAdapter.Fill(this.facultyDataSet.faculty);
            // TODO: This line of code loads data into the 'finaldatabaseDataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.finaldatabaseDataSet.Table1);

        }

        private void pnlEmployee_Paint(object sender, PaintEventArgs e)
        {
            timer2.Start();
            lblTime2.Text = DateTime.Now.ToLongTimeString();
            lblDate2.Text = DateTime.Now.ToLongDateString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblTime2.Text = DateTime.Now.ToLongTimeString();
            timer2.Start();
        }

        private void lblDate3_Click(object sender, EventArgs e)
        {

        }

        private void pnlStaff_Paint(object sender, PaintEventArgs e)
        {
            timer3.Start();
            lblTime3.Text = DateTime.Now.ToLongTimeString();
            lblDate3.Text = DateTime.Now.ToLongDateString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lblTime3.Text = DateTime.Now.ToLongTimeString();
            timer3.Start();
        }

        private void btnStudentAddNew_Click(object sender, EventArgs e)
        {
            this.table1BindingSource.AddNew();
        }

        private void btnStudentSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table1BindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.finaldatabaseDataSet);
            this.table1TableAdapter.Update(this.finaldatabaseDataSet.Table1);
            MessageBox.Show("New Record Added");
        }

        private void btnStudentUpdate_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table1BindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.finaldatabaseDataSet);
            this.table1TableAdapter.Update(this.finaldatabaseDataSet.Table1);
            MessageBox.Show("Successfully Updated");
        }

        private void btnStudentLoadRecords_Click(object sender, EventArgs e)
        {
            this.table1TableAdapter.Fill(this.finaldatabaseDataSet.Table1);
        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            this.table1BindingSource.RemoveCurrent();
            this.table1TableAdapter.Update(this.finaldatabaseDataSet.Table1);
            MessageBox.Show("Successfully Deleted");
        }

        private void btnFacultyAddNew_Click(object sender, EventArgs e)
        {
            this.staffBindingSource.AddNew();
        }

        private void btnFacultySave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facultyBindingSource.EndEdit();
            //this.facultyTableAdapter.UpdateAll(this.facultyDataSet);
            this.facultyTableAdapter.Update(this.facultyDataSet.faculty);
            MessageBox.Show("New Record Added");
        }

        private void btnFacultyUpdate_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facultyBindingSource.EndEdit();
            //this.facultyTableAdapter.UpdateAll(this.facultyDataSet);
            this.facultyTableAdapter.Update(this.facultyDataSet.faculty);
            MessageBox.Show("New Record Updated");
        }

        private void btnFacultyLoadRecords_Click(object sender, EventArgs e)
        {
            this.facultyTableAdapter.Fill(this.facultyDataSet.faculty); 
        }

        private void btnFacultyDelete_Click(object sender, EventArgs e)
        {
            this.facultyBindingSource.RemoveCurrent();
            this.facultyTableAdapter.Update(this.facultyDataSet.faculty);
            MessageBox.Show("Successfully Deleted");
        }

        private void btnStaffAddNew_Click(object sender, EventArgs e)
        {
            this.staffBindingSource.AddNew();
        }

        private void btnStaffSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            //this.staffTableAdapter.UpdateAll(this.staffDataSet);
            this.staffTableAdapter.Update(this.staffDataSet.staff);
            MessageBox.Show("New Record Added");
        }

        private void btnStaffUpdate_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            //this.staffTableAdapter.UpdateAll(this.staffDataSet);
            this.staffTableAdapter.Update(this.staffDataSet.staff);
            MessageBox.Show("Successfully Updated");
        }

        private void btnStaffLoadRecords_Click(object sender, EventArgs e)
        {
            this.staffTableAdapter.Fill(this.staffDataSet.staff);
        }

        private void btnStaffDelete_Click(object sender, EventArgs e)
        {
            this.staffBindingSource.RemoveCurrent();
            this.staffTableAdapter.Update(this.staffDataSet.staff);
            MessageBox.Show("Successfully Deleted");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlOnButtonPosition.Height = btnHome.Height;
            pnlOnButtonPosition.Top = btnHome.Top;
            pnlHome.Visible = true;
            pnlStudent.Visible = false;
            pnlFaculty.Visible = false;
            pnlStaff.Visible = false;
            pnlSettings.Visible = false;
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            pnlOnButtonPosition.Height = btnStudent.Height;
            pnlOnButtonPosition.Top = btnStudent.Top;
            pnlHome.Visible = false;
            pnlStudent.Visible = true;
            pnlFaculty.Visible = false;
            pnlStaff.Visible = false;
            pnlSettings.Visible = false;
        }

        private void btnFaculty_Click(object sender, EventArgs e)
        {
            pnlOnButtonPosition.Height = btnFaculty.Height;
            pnlOnButtonPosition.Top = btnFaculty.Top;
            pnlHome.Visible = false;
            pnlStudent.Visible = false;
            pnlFaculty.Visible = true;
            pnlStaff.Visible = false;
            pnlSettings.Visible = false;
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            pnlOnButtonPosition.Height = btnStaff.Height;
            pnlOnButtonPosition.Top = btnStaff.Top;
            pnlHome.Visible = false;
            pnlStudent.Visible = false;
            pnlFaculty.Visible = false;
            pnlStaff.Visible = true;
            pnlSettings.Visible = false;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlOnButtonPosition.Height = btnSettings.Height;
            pnlOnButtonPosition.Top = btnSettings.Top;
            pnlHome.Visible = false;
            pnlStudent.Visible = false;
            pnlFaculty.Visible = false;
            pnlStaff.Visible = false;
            pnlSettings.Visible = true;
        }

        private void faculty_NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void facultyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
