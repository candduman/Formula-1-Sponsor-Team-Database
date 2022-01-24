using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Enrollment' table. You can move, or remove it, as needed.
            this.enrollmentTableAdapter.Fill(this.dataSet1.Enrollment);
            // TODO: This line of code loads data into the 'dataSet1.Sponsor' table. You can move, or remove it, as needed.
            this.sponsorTableAdapter.Fill(this.dataSet1.Sponsor);
            // TODO: This line of code loads data into the 'dataSet1.Team' table. You can move, or remove it, as needed.
            this.teamTableAdapter.Fill(this.dataSet1.Team);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.teamTableAdapter.Insert(textBox1.Text, textBox2.Text);
            this.teamTableAdapter.Fill(this.dataSet1.Team);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int IDX;
            int sel_ID=0;
            IDX = dataGridView1.CurrentRow.Index;
            int.TryParse(dataGridView1.Rows[IDX].Cells[0].Value.ToString(), out sel_ID);
            this.teamTableAdapter.team_delete(sel_ID);
            this.teamTableAdapter.Fill(this.dataSet1.Team);
            this.enrollmentTableAdapter.delete_withteam(sel_ID);
            this.enrollmentTableAdapter.Fill(this.dataSet1.Enrollment);

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int IDX;
            int sel_ID=0;
            IDX = dataGridView1.CurrentRow.Index;
            int.TryParse(dataGridView1.Rows[IDX].Cells[0].Value.ToString(), out sel_ID);
            this.teamTableAdapter.team_update(textBox1.Text, textBox2.Text, sel_ID, 5);
            this.teamTableAdapter.Fill(this.dataSet1.Team);
            this.enrollmentTableAdapter.Fill(this.dataSet1.Enrollment);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.sponsorTableAdapter.Insert(textBox3.Text, textBox4.Text);
            this.sponsorTableAdapter.Fill(this.dataSet1.Sponsor); 
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            int IDX;
            int sel_ID = 0;
            IDX = dataGridView2.CurrentRow.Index;
            int.TryParse(dataGridView2.Rows[IDX].Cells[0].Value.ToString(), out sel_ID);
            this.sponsorTableAdapter.sponsor_Delete(sel_ID);
            this.sponsorTableAdapter.Fill(this.dataSet1.Sponsor);
            this.enrollmentTableAdapter.delete_withsponsor(sel_ID);
            this.enrollmentTableAdapter.Fill(this.dataSet1.Enrollment);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int IDX;
            int sel_ID = 0;
            IDX = dataGridView2.CurrentRow.Index;
            int.TryParse(dataGridView2.Rows[IDX].Cells[0].Value.ToString(), out sel_ID);
            this.sponsorTableAdapter.sponsor_update(textBox3.Text, textBox4.Text, sel_ID, 5);
            this.sponsorTableAdapter.Fill(this.dataSet1.Sponsor);
            this.enrollmentTableAdapter.Fill(this.dataSet1.Enrollment);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            int x = (int)comboBox1.SelectedValue;
            int y = (int)comboBox2.SelectedValue;
            this.enrollmentTableAdapter.Insert(x, y, dateTimePicker1.Value);
            this.enrollmentTableAdapter.Fill(this.dataSet1.Enrollment);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            int IDX;
            int sel_ID = 0;
            IDX = dataGridView3.CurrentRow.Index;
            int.TryParse(dataGridView3.Rows[IDX].Cells[1].Value.ToString(), out sel_ID);
            this.enrollmentTableAdapter.enrollment_delete(sel_ID);
            this.enrollmentTableAdapter.Fill(this.dataSet1.Enrollment);       
         
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            int x = (int)comboBox1.SelectedValue;
            int y = (int)comboBox2.SelectedValue;
            int IDX;
            int sel_ID = 0;
            IDX = dataGridView3.CurrentRow.Index;
            int.TryParse(dataGridView3.Rows[IDX].Cells[1].Value.ToString(), out sel_ID);
            this.enrollmentTableAdapter.enrollment_update(x, y, dateTimePicker1.Value, sel_ID, 5);
            this.enrollmentTableAdapter.Fill(this.dataSet1.Enrollment);
        }
    }
}
