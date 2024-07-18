using ShabatGuest.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace College.DAL.Repositries
{
    internal class StudentRepository
    {

        private readonly DBconnections DBconnections;

        public StudentRepository(DBconnections dBconnections)
        {
            DBconnections = dBconnections;
        }

        public int Finddebt(string Name, string password)
        {
            string query = @"select SUM(c.price) - SUM(p.amount) as Debt 
                            from Students s 
                            join Registrations r on r.StudentID = s.ID 
                            join Course c on c.ID = r.CourseID
                            join Payments p on p.StudentID= s.ID
                            where s.Studentname = @Name and s.Password = @password";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Name", Name),
                new SqlParameter("@password", password)
            };
            object ressult = DBconnections.ExecuteScalar(query, sqlParameters);
            int n;
            bool isNumeric = int.TryParse($"{ressult}", out n);
            if (!isNumeric)
            {
                n = 0;
            }
            return n;
        }

        public DataRow FindByName_andPassword(string Name, string password)
        {
            string query = "select * from Students s where s.Studentname = @Name and s.Password = @password";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Name", Name),
                new SqlParameter("@password", password)
            };
            DataTable ressult = DBconnections.ExecuteQuery(query, sqlParameters);
            if (ressult.Rows.Count <= 0)
            {
                throw new Exception("didn't Exist");
            }
            return ressult.Rows[0];
        }

        public bool insert(string studentname, string password, string city, string Street, string HousNum, string PhoneNum)
        {
            string query = "insert into Students(Studentname, Password, city, Street, HousNum, PhoneNum) values(@Studentname,@Password,@city, @Street, @HousNum,@PhoneNum)";
            SqlParameter[] sqlParameters = { new SqlParameter("@Studentname", studentname),
                                            new SqlParameter("@Password", password),
                                            new SqlParameter("@city", city),
                                            new SqlParameter("@Street", Street),
                                            new SqlParameter("@HousNum", HousNum),
                                            new SqlParameter("@PhoneNum", PhoneNum),}; ;
            int rowsAffected = DBconnections.ExecuteNoneQuery(query, sqlParameters);
            return rowsAffected > 0;
        }        

        public DataTable FindStudentData(string Name, string password)
        {
            string query = @"select * 
                            from Students s                             
                            where s.Studentname = @Name and s.Password = @password";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Name", Name),
                new SqlParameter("@password", password)
            };
            DataTable ressult = DBconnections.ExecuteQuery(query, sqlParameters);
            if (ressult.Rows.Count <= 0)
            {
                MessageBox.Show("invalid Name");
            }
            return ressult;
        }
        public DataTable FindStudentPayments(string Name, string password)
        {
            string query = @"select p.amount, p.ID
                            from Students s
                            join Payments p on p.StudentID = s.ID
                            where s.Studentname = @Name and s.Password = @password";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Name", Name),
                new SqlParameter("@password", password)
            };
            DataTable ressult = DBconnections.ExecuteQuery(query, sqlParameters);
            return ressult;
        }
    }
}
