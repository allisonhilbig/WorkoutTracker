using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker
{
    public class UserAccount
    {
        private String Name;
        private SqlConnection Con;

        public UserAccount()
        {
            Con = new SqlConnection();
            Con.ConnectionString = Constants.DBDATASOURCE + Constants.DBATTACHDBFILENAME
                + Constants.DBINTEGRATEDSECURITY + Constants.DBCONNECTTIMEOUT;
            Con.Open();
        }

        public String GetName()
        {
            return Name;
        }

        public void CloseConnection()
        {
            Con.Close();
        }

        public bool checkPassword(String username, String password)
        {
            Con = new SqlConnection();
            Con.ConnectionString = Constants.DBDATASOURCE + Constants.DBATTACHDBFILENAME
                + Constants.DBINTEGRATEDSECURITY + Constants.DBCONNECTTIMEOUT;
            Con.Open();

            SqlDataReader dataReader;
            SqlCommand comm;

            comm = new SqlCommand("SELECT Id FROM [Credentials] WHERE Username = @Username AND Password = @Password", Con);
            comm.Parameters.Add(new SqlParameter("Username", username));
            comm.Parameters.Add(new SqlParameter("Password", password));

            try
            {
                dataReader = comm.ExecuteReader();
                if (dataReader.HasRows)
                {
                    Name = username;
                    Con.Close();
                    return true;
                }
                Con.Close();
                return false;
            }
            catch
            {
                Con.Close();
                return false;
            }
        }

        public void getWorkout(Workout workout)
        {
            Con = new SqlConnection();
            Con.ConnectionString = Constants.DBDATASOURCE + Constants.DBATTACHDBFILENAME
                + Constants.DBINTEGRATEDSECURITY + Constants.DBCONNECTTIMEOUT;
            Con.Open();

            SqlDataReader dataReader;
            SqlCommand comm;
            Exercise headExercise = new Exercise();

            comm = new SqlCommand("SELECT (Characteristic1, Characteristic2, Characteristic3, Characteristic4, Value1, Value2, Value3, Value4, Name) FROM [Exercises] WHERE Id_Work = @Workout", Con);
            comm.Parameters.AddWithValue("Workout", workout);
            try
            {
                dataReader = comm.ExecuteReader();

                while (dataReader.Read())
                {
                    Exercise temp = new Exercise(dataReader.GetValue(8).ToString());
                    temp.setChar(0, dataReader.GetValue(0).ToString());
                    temp.setChar(1, dataReader.GetValue(1).ToString());
                    temp.setChar(2, dataReader.GetValue(2).ToString());
                    temp.setChar(3, dataReader.GetValue(3).ToString());
                    temp.setVal(0, dataReader.GetValue(4).ToString());
                    temp.setVal(1, dataReader.GetValue(5).ToString());
                    temp.setVal(2, dataReader.GetValue(6).ToString());
                    temp.setVal(3, dataReader.GetValue(7).ToString());
                    headExercise.SetCurrentExercise(temp);
                    headExercise.AddToCurrentNext(new Exercise());
                    headExercise.MoveNextNode();
                }
            }
            catch (SqlException e)
            {
                ;
            }
            Con.Close();
        }

        public void newWorkout(String workout, Exercise headExercise)
        {
            Con = new SqlConnection();
            Con.ConnectionString = Constants.DBDATASOURCE + Constants.DBATTACHDBFILENAME
                + Constants.DBINTEGRATEDSECURITY + Constants.DBCONNECTTIMEOUT;
            Con.Open();

            SqlCommand comm;
            
            while (headExercise.GetCurrentExercise() != null)
            {
                String characteristic = headExercise.GetCurrentExercise().getChar(0);
                comm = new SqlCommand("INSERT INTO [Exercises] (Id_Work, Characteristic1, Characteristic2, Characteristic3, Characteristic4, Value1, Value2, Value3, Value4, Name) VALUES (@workout,@Characteristic1,@Value1,@Characteristic2,@Value2,@Characteristic3,@Value3,@Characteristic4,@Value4,@Name)", Con);
                comm.Parameters.AddWithValue("Id_Work", workout);
                comm.Parameters.AddWithValue("Characteristic1", headExercise.GetCurrentExercise().getChar(0));
                comm.Parameters.AddWithValue("Characteristic2", headExercise.GetCurrentExercise().getChar(1));
                comm.Parameters.AddWithValue("Characteristic3", headExercise.GetCurrentExercise().getChar(2));
                comm.Parameters.AddWithValue("Characteristic4", headExercise.GetCurrentExercise().getChar(3));
                comm.Parameters.AddWithValue("Value0", headExercise.GetCurrentExercise().getVal(0));
                comm.Parameters.AddWithValue("Value1", headExercise.GetCurrentExercise().getVal(1));
                comm.Parameters.AddWithValue("Value2", headExercise.GetCurrentExercise().getVal(2));
                comm.Parameters.AddWithValue("Value3", headExercise.GetCurrentExercise().getVal(3));
                comm.Parameters.AddWithValue("Name", headExercise.GetCurrentExercise().getExerciseName());
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    ;
                }
                headExercise.MoveNextNode();
            }
            Con.Close();
        }

        private void deleteWorkout(Workout workout)
        {

        }

        public void newUser(String username, String password)
        {
            Con = new SqlConnection();
            Con.ConnectionString = Constants.DBDATASOURCE + Constants.DBATTACHDBFILENAME
                + Constants.DBINTEGRATEDSECURITY + Constants.DBCONNECTTIMEOUT;
            Con.Open();

            SqlCommand comm;
            comm = new SqlCommand("INSERT INTO [Credentials] (Username, Password) VALUES (@username, @password)", Con);
            comm.Parameters.AddWithValue("username", username);
            comm.Parameters.AddWithValue("password", password);
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                ;
            }
        }
    }
}
