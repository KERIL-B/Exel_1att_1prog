using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace DataGridViewProject
{
    class InterfaceClass
    {
        public Boolean CreateDataCheck(TextBox numberOfColumnsTB, DataGridView table, DataGridView addTable)
        {

            if (numberOfColumnsTB.Text != "")
            {
                try
                {
                    int n = Convert.ToInt32(numberOfColumnsTB.Text);
                    CreateTable(n, table, addTable);
                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Incorrect number of columns", "Error");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Enter number of columns", "Error");
                return false;
            }


        }

        public void Refresh(DataGridView table, DataGridView addTable)
        {
            addTable.ColumnCount = 0;
            table.ColumnCount = 0;
            table.RowCount = 0;
        }

        public void Add(DataGridView table, DataGridView addTable)
        {
            object cell = addTable[0, 0].Value;
            int n;
            try
            {
                n = Convert.ToInt32(cell);
            }
            catch (Exception)
            {
                n = 0;
            }
            addTable[0, 0].Value = n;

            table.RowCount++;

            for (int i = 0; i < table.ColumnCount; i++)
            {
                table[i, table.RowCount - 1].Value = addTable[i, 0].Value;
                addTable[i, 0].Value = null;
            }
        }

        public void DeleteDataCheck(TextBox deleteTB, DataGridView table)
        {
            if (deleteTB.Text != "")
            {
                try
                {
                    int n = Convert.ToInt32(deleteTB.Text);
                    if (table.RowCount < n)
                    {
                        MessageBox.Show("Row wasn't found", "Error");
                    }
                    else
                    {
                        DeleteRow(n, table);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong row number you want to delete", "Error");
                }
            }

        }

        public void DeleteBySelection(DataGridView table)
        {
            int n = table.CurrentRow.Index;
            DeleteRow(n + 1, table);
        }

        public void ChangeInput(TextBox newInputTB, DataGridView table)
        {
            string newInput = newInputTB.Text;
            
            try
            {
                if (table.CurrentCell.ColumnIndex == 0)
                {
                    table.CurrentCell.Value = 0;
                }
                else
                    table.CurrentCell.Value = newInput;
            }
            catch (Exception)
            {
                MessageBox.Show("No selected cell", "Error");
            }
        }

        public void PaintCell(DataGridView table)
        {
            Paint(Color.PaleTurquoise, table);

        }

        public void UnpaintCell(DataGridView table)
        {
            Paint(Color.White,table);
        }
        private void Paint(Color color1, DataGridView table)
        {
            try
            {
                table.CurrentCell.Style.BackColor = color1;
            }
            catch (Exception)
            {
                MessageBox.Show("No selected cell", "Error");
            }
        }

        private void DeleteRow(int n, DataGridView table)
        {
            for (int i = n - 1; i < table.RowCount - 1; i++)
            {
                for (int j = 0; j < table.ColumnCount; j++)
                {
                    table[j, i].Value = table[j, i + 1].Value;
                }
            }
            table.RowCount--;
        }

        private void CreateTable(int n, DataGridView table, DataGridView addTable)
        {
            table.ColumnCount = n;
            table.RowCount = 0;
            addTable.ColumnCount = n;
            addTable.RowCount = 1;
            table.Columns[0].HeaderCell.Value = "id";
            addTable.Columns[0].HeaderCell.Value = "id";
            if (n > 1)
            {
                for (int i = 1; i < n; i++)
                {
                    table.Columns[i].HeaderCell.Value = "Data #" + i;
                    addTable.Columns[i].HeaderCell.Value = "Data #" + i;
                }
            }
        }

    }


}
