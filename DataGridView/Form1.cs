using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            refreshB.Enabled = false;
            addB.Enabled = false;
            deleteB.Enabled = false;
            deleteBySelect.Enabled = false;
            changeB.Enabled = false;
            colourB.Enabled = false;
            defaultColorB.Enabled = false;

        }

        InterfaceClass IClass = new InterfaceClass();

        private void createTableB_Click(object sender, EventArgs e)
        {
            if (IClass.CreateDataCheck(numberOfColumnsTB, tableDGV, addTableDGV))
            {
                createTableB.Enabled = false;
                refreshB.Enabled = true;
                addB.Enabled = true;
                deleteB.Enabled = true;
                deleteBySelect.Enabled = true;
                changeB.Enabled = true;
                colourB.Enabled = true;
                defaultColorB.Enabled = true;
                numberOfColumnsTB.Text = "";
            }
        }

        private void refreshB_Click(object sender, EventArgs e)
        {
            createTableB.Enabled = true;
            numberOfColumnsTB.Text = "";
            IClass.Refresh(tableDGV,addTableDGV);
            refreshB.Enabled = false;
            addB.Enabled = false;
            deleteB.Enabled = false;
            deleteBySelect.Enabled = false;
            changeB.Enabled = false;
            colourB.Enabled = false;
            defaultColorB.Enabled = false;
        }

        private void addB_Click(object sender, EventArgs e)
        {
            IClass.Add(tableDGV, addTableDGV);
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            IClass.DeleteDataCheck(deleteRowNumberTB, tableDGV);
            deleteRowNumberTB.Text = "";
        }

        private void deleteBySelect_Click(object sender, EventArgs e)
        {
            IClass.DeleteBySelection(tableDGV);
        }

        private void changeB_Click(object sender, EventArgs e)
        {
            IClass.ChangeInput(changeInputTB, tableDGV);
            changeInputTB.Text = "";
        }

        private void colourB_Click(object sender, EventArgs e)
        {
            IClass.PaintCell(tableDGV);
        }

        private void defaultColorB_Click(object sender, EventArgs e)
        {
            IClass.UnpaintCell(tableDGV);
        }
    }
}
