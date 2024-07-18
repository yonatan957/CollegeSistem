using ShabatGuest.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace College.DAL.Repositries
{
    internal class CoursRepository
    {
        private readonly DBconnections DBconnections;

        public CoursRepository(DBconnections dBconnections)
        {
            DBconnections = dBconnections;
        }

        public bool Insert(string Coursename, string Endtime, string price, string Start_Date, string Startour, string Sunday, string Monday, string Thursday, string Tuesday, string Wednesday, string Friday)
        {
            string query = @"insert into Course( Coursename, Endtime, price, Start_Date, Startour, Sunday, Monday, Thursday, Tuesday, Wednesday, Friday)
                            values (@Coursename,@Endtime,@price,@Start_Date,@Startour,@Sunday,@Monday,@Thursday,@Tuesday,@Wednesday,@Friday)";
            SqlParameter[] sqlParameters = { new SqlParameter("@Coursename", Coursename),
                                            new SqlParameter("@Endtime", Endtime),
                                            new SqlParameter("@price", price),
                                            new SqlParameter("@Start_Date", Start_Date),
                                            new SqlParameter("@Startour", Startour),
                                            new SqlParameter("@Sunday", Sunday),
                                            new SqlParameter("@Monday", Monday),
                                            new SqlParameter("@Thursday", Thursday),
                                            new SqlParameter("@Tuesday", Tuesday),
                                            new SqlParameter("@Wednesday", Wednesday),
                                            new SqlParameter("@Friday", Friday)}; 
            int rowsAffected = DBconnections.ExecuteNoneQuery(query, sqlParameters);
            return rowsAffected > 0;
        }

        public bool InsertTopic(string CourseID, string lecturerID, string Topicname, string hours)
        {
            string query = @"insert into Topic( CourseID, lecturerID, Topicname, Hours)
                            values (@CourseID, @lecturerID, @Topicname, @hours)";
            SqlParameter[] sqlParameters = { new SqlParameter("@CourseID", CourseID),
                                            new SqlParameter("@lecturerID", lecturerID),
                                            new SqlParameter("@Topicname", Topicname),
                                            new SqlParameter("@hours", hours)};
            int rowsAffected = DBconnections.ExecuteNoneQuery(query, sqlParameters);
            return rowsAffected > 0;
        }
        public int PriceCurse(string CourseID)
        {
            string query = @"select sum(l.priceForHour * t.Hours)
                            from Course c
                            join Topic t on t.CourseID = c.ID
                            join Lecturers l on l.ID = t.lecturerID
                            where c.ID = @CID
                            ";
            SqlParameter[] sqlParameters = {new SqlParameter("@CID", CourseID)};
            object ressult = DBconnections.ExecuteScalar(query, sqlParameters);
            int n;
            bool isNumeric = int.TryParse($"{ressult}", out n);
            if (!isNumeric)
            {
                n = 0;
            }
            return n;
        }
        public bool IfCurseExist(string CourseID)
        {
            string query = "select * from Course c where c.ID = @CID ";
            SqlParameter[] sqlParameters = { new SqlParameter("@CID", CourseID) };
            DataTable ressult = DBconnections.ExecuteQuery(query, sqlParameters);
            if (ressult.Rows.Count <= 0)
            {
                return false;
            }
            return true;
        }
        public int Studentpade(string CourseID)
        {
            string query = @"select sum(c.price)
                            from Registrations r
                            join Course c on c.ID = r.CourseID
                            where c.ID = @CID
                            ";
            SqlParameter[] sqlParameters = { new SqlParameter("@CID", CourseID) };
            object ressult = DBconnections.ExecuteScalar(query, sqlParameters);
            int n;
            bool isNumeric = int.TryParse($"{ressult}", out n);
            if (!isNumeric)
            {
                n = 0;
            }
            return n;
        }
        public DataTable FindAll()
        {
            string query = "select * from Course order by Categories.ID";
            DataTable ressult = DBconnections.ExecuteQuery(query, null);
            if (ressult.Rows.Count == 0)
            {
                MessageBox.Show("FindAll Get Empty DataTable");
            }
            return ressult;
        }

        public DataTable FindByCursesStudentName_andPassword(string Name, string password)
        {
            string query = @"select c.Coursename, c.price 
                            from Students s 
                            join Registrations r on r.StudentID = s.ID 
                            join Course c on c.ID = r.CourseID
                            where s.Studentname = @Name and s.Password = @password";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Name", Name),
                new SqlParameter("@password", password)
            };
            DataTable ressult = DBconnections.ExecuteQuery(query, sqlParameters);
            return ressult;
        }
        public bool addtocorse(string sid, string cid)
        {
            string query = "insert into Registrations(StudentID, CourseID) values (@sid, @cid)";
            SqlParameter[] sqlParameters =
{
                new SqlParameter("@sid", sid),
                new SqlParameter("@cid", cid)
            };
            int rowsAffected = DBconnections.ExecuteNoneQuery(query, sqlParameters);
            return rowsAffected > 0;
        }
    }
}
