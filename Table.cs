using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Test
{
    class Table
    {
        public DataGridView dataGridView1 = new DataGridView();
        public List<string> names = new List<string>();
        public void Function()
        {
            dataGridView1.Size = new Size(1240, 450);
            dataGridView1.Location = new Point(10, 10);

            DataGridViewTextBoxColumn column0 = new DataGridViewTextBoxColumn();
            column0.Name = "cardcode";
            column0.HeaderText = "CARDCODE";
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "startdate";
            column1.HeaderText = "STARTDATE";
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "finishdate";
            column2.HeaderText = "FINISHDATE";
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.Name = "lastname";
            column3.HeaderText = "LASTNAME";
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.Name = "firstname";
            column4.HeaderText = "FIRSTNAME";
            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.Name = "surname";
            column5.HeaderText = "SURNAME";
            DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn();
            column6.Name = "gender";
            column6.HeaderText = "GENDER";
            DataGridViewTextBoxColumn column7 = new DataGridViewTextBoxColumn();
            column7.Name = "birthday";
            column7.HeaderText = "BIRTHDAY";
            DataGridViewTextBoxColumn column8 = new DataGridViewTextBoxColumn();
            column8.Name = "phonehome";
            column8.HeaderText = "PHONEHOME";
            DataGridViewTextBoxColumn column9 = new DataGridViewTextBoxColumn();
            column9.Name = "phonemobil";
            column9.HeaderText = "PHONEMOBIL";
            DataGridViewTextBoxColumn column10 = new DataGridViewTextBoxColumn();
            column10.Name = "email";
            column10.HeaderText = "EMAIL";
            DataGridViewTextBoxColumn column11 = new DataGridViewTextBoxColumn();
            column11.Name = "city";
            column11.HeaderText = "CITY";
            DataGridViewTextBoxColumn column12 = new DataGridViewTextBoxColumn();
            column12.Name = "street";
            column12.HeaderText = "STREET";
            DataGridViewTextBoxColumn column13 = new DataGridViewTextBoxColumn();
            column13.Name = "house";
            column13.HeaderText = "HOUSE";
            DataGridViewTextBoxColumn column14 = new DataGridViewTextBoxColumn();
            column14.Name = "apartment";
            column14.HeaderText = "APARTMENT";
            dataGridView1.Columns.AddRange(column0, column1, column2, column3,
                column4, column5, column6, column7, column8, column9, column10,
                column11, column12, column13, column14);
        }

        public void DynamicTable(string _cardcode, string _startdate, string _finishdate,
            string _lastname, string _firstname, string _surname, string _gender, string _birthday,
            string _phonehome, string _phonemobil, string _email, string _city, string _street,
            string _house, string _apartment)
        {
            DataGridViewCell cardcode = new DataGridViewTextBoxCell();
            DataGridViewCell startdate = new DataGridViewTextBoxCell();
            DataGridViewCell finishdate = new DataGridViewTextBoxCell();
            DataGridViewCell lastname = new DataGridViewTextBoxCell();
            DataGridViewCell firstname = new DataGridViewTextBoxCell();
            DataGridViewCell surname = new DataGridViewTextBoxCell();
            DataGridViewCell gender = new DataGridViewTextBoxCell();
            DataGridViewCell birthday = new DataGridViewTextBoxCell();
            DataGridViewCell phonehome = new DataGridViewTextBoxCell();
            DataGridViewCell phonemobil = new DataGridViewTextBoxCell();
            DataGridViewCell email = new DataGridViewTextBoxCell();
            DataGridViewCell city = new DataGridViewTextBoxCell();
            DataGridViewCell street = new DataGridViewTextBoxCell();
            DataGridViewCell house = new DataGridViewTextBoxCell();
            DataGridViewCell apartment = new DataGridViewTextBoxCell();
            cardcode.Value = _cardcode;
            startdate.Value = _startdate;
            finishdate.Value = _finishdate;
            lastname.Value = _lastname;
            firstname.Value = _firstname;
            surname.Value = _surname;
            gender.Value = _gender;
            birthday.Value = _birthday;
            phonehome.Value = _phonehome;
            phonemobil.Value = _phonemobil;
            email.Value = _email;
            city.Value = _city;
            street.Value = _street;
            house.Value = _house;
            apartment.Value = _apartment;

            DataGridViewRow row = new DataGridViewRow();
            row.Cells.AddRange(cardcode, startdate, finishdate, lastname, firstname, surname, gender,
                birthday, phonehome, phonemobil, email, city, street, house, apartment);
            dataGridView1.Rows.Add(row);

            dataGridView1.Refresh();
        }

        public void ValueToList()
        {
            string desktoppath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "db.txt");
            StreamWriter writer = new StreamWriter(desktoppath);
            try
            {
                string sLine = "";

                for (int r = 0; r <= dataGridView1.Rows.Count - 1; r++)
                {
                    for (int c = 0; c <= dataGridView1.Columns.Count - 1; c++)
                    {
                        sLine = sLine + dataGridView1.Rows[r].Cells[c].Value;
                        if (c != dataGridView1.Columns.Count - 1)
                        {
                            sLine += ",";
                        } else
                        {
                            sLine += "\n";
                        }
                    }
                }
                writer.Write(sLine);
                sLine = "";
                writer.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                writer.Dispose();
            }
        }
    }
}
