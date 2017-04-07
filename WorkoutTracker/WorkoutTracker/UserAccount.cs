using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker
{
    class UserAccount
    {
        private String UserID;
        private String Password;
        private String[] ExerciseList;
        private Workout[] Workouts;

        public UserAccount()
        {

        }

        protected bool checkPassword(String username, String password, SqlConnection con)
        {
            SqlDataReader dataReader;
            SqlCommand comm;

            comm = new SqlCommand("SELECT Id FROM [Credentials] WHERE Username = @username AND Password = @password", con);
            comm.Parameters.Add(new SqlParameter("Username", username));
            comm.Parameters.Add(new SqlParameter("Password", password));

            try
            {
                dataReader = comm.ExecuteReader();
                return !dataReader.HasRows;
            }
            catch
            {
                return false;
            }
        }

        private void getWorkout(Workout workout)
        {

        }

        private void newWorkout()
        {

        }

        private void deleteWorkout(Workout workout)
        {

        }
    }
}
