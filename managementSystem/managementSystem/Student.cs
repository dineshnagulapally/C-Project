using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace managementSystem
{
    internal class Student
    {
        DBconnect connect = new DBconnect();

        public bool insertStudent(string firstName, string lastName, DateTime dateOfBirth, string phone, string gender)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `student`(`firstName`,`lastName`,`dateOfBirth`,`phone`,`gender`) VALUES" +
                "(@firstName, @lastName,@dateOfBirth,@phone,@gender)",connect.getconnection);

            command.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = firstName;
            command.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = lastName;
            command.Parameters.Add("@dateOfBirth", MySqlDbType.Date).Value = dateOfBirth;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@gender", MySqlDbType.String).Value = gender;

            connect.OpenConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseConnect();
                return true;
            }
            else
            {
                connect.CloseConnect();
                return false;
            }

        }

        //update the student in table

        public bool updateStudent(int Id,string firstName, string lastName, DateTime dateOfBirth, string phone, string gender)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `student` SET firstName=@firstName, "+
                "lastName=@lastName,dateOfBirth=@dateOfBirth,phone=@phone,gender=@gender WHERE studentId=@Id", connect.getconnection);
            
            command.Parameters.Add("@Id", MySqlDbType.Int32).Value = Id;
            command.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = firstName;
            command.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = lastName;
            command.Parameters.Add("@dateOfBirth", MySqlDbType.Date).Value = dateOfBirth;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@gender", MySqlDbType.String).Value = gender;

            connect.OpenConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseConnect();
                return true;
            }
            else
            {
                connect.CloseConnect();
                return false;
            }

        }

        public bool deleteStudent(int studentId)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("DELETE FROM STUDENT WHERE studentId=@Id", connect.getconnection);
                command.Parameters.AddWithValue("@Id", studentId);
                connect.OpenConnect();
                if (command.ExecuteNonQuery() == 1)
                {
                    connect.CloseConnect();
                    return true;
                }
                else
                {
                    connect.CloseConnect();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
        } 

        public DataTable getStudents()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM STUDENT", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
