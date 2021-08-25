using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Cognitive_Stimulation
{
    public class Procedure
    {
        static SqlConnection con = new SqlConnection(@"Data Source=J2IEGW-003L\SQLEXPRESS;Initial Catalog=PDPNUIG;Integrated Security=True");

        public static DataTable GetUsers()
        {
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT ID,Name FROM dbo.[User]", con))
            {

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataSet GetUserDetails(int UserID)
        {
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT u.ID,u.Age,u.Gender FROM dbo.[user] u where  u.ID =" + UserID, con))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        public static DataSet GetUserGameDetails(int UserID)
        {
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT gt.[Name] as [Training Group] " +
                ",g.[Name] as [Training] " +
                ",[Level] " +
                ",[DateStart] as [Date Start]  " +
                ",[DateEnd] as [Date End]  " +
                ",[TimePlayed] as[Time Played] " +
                ",[ScoreCorrect] as [Score Correct] " +
                ",[ScoreInCorrect] as [Score Incorrect] " +
                ",[Completed] " +
                "FROM [dbo].[GameType] gt " +
                "inner join dbo.game g on gt.ID = g.GameType " +
                "left join dbo.[Score] sc on g.ID = sc.GameID and sc.UserID = " + UserID, con))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);

                return ds;
            }
        }


        public static void StartGame(int UserID, int GameID, int Level)
        {
            using (SqlCommand cmd = new SqlCommand(
                "INSERT INTO dbo.Score ([UserID],[GameID],DateStart,Level, Completed) " +
                "output INSERTED.ID " +
                "VALUES(@UserID,@GameID,GetDate(),@Level, 0)", con))
            {
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.Parameters.AddWithValue("@GameID", GameID);
                cmd.Parameters.AddWithValue("@Level", Level);
                con.Open();

                int SessionID = (int)cmd.ExecuteScalar();

                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();

                Session.UserGameID = SessionID;
            }
        }
        public static void UpdateTimeGame(int UserGameID, string TimePlayed, int ScoreCorrect, int ScoreInCorrect)
        {
            using (SqlCommand cmd = new SqlCommand(
                "update [dbo].[Score] " +
                "set TimePlayed = @TimePlayed, " +
                "ScoreCorrect = @ScoreCorrect, " +
                "ScoreInCorrect = @ScoreInCorrect " +
                " where ID = @UserGameID", con))
            {
                cmd.Parameters.AddWithValue("@UserGameID", UserGameID);
                cmd.Parameters.AddWithValue("@TimePlayed", TimePlayed);
                cmd.Parameters.AddWithValue("@ScoreCorrect", ScoreCorrect);
                cmd.Parameters.AddWithValue("@ScoreInCorrect", ScoreInCorrect);

                con.Open();

                cmd.ExecuteNonQuery();

                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();

            }
        }

        public static void StopGame(int UserGameID, bool Completed)
        {
            using (SqlCommand cmd = new SqlCommand(
                "update [dbo].[Score] " +
                "set Completed = @Completed, " +
                "DateEnd = GetDate() " +
                "where ID = @UserGameID", con))
            {
                cmd.Parameters.AddWithValue("@UserGameID", UserGameID);
                cmd.Parameters.AddWithValue("@Completed", Completed);
                con.Open();

                cmd.ExecuteNonQuery();

                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();

            }
        }


        public static StringBuilder GetBestScore()
        {
            int GameID = Session.GameID;
            int UserID = Session.UserID;

            StringBuilder builder = new StringBuilder();

            Console.WriteLine(builder);
            using (SqlCommand cmd = new SqlCommand(
                "SELECT[Level] " +
                ",[TimePlayed] " +
                ",[ScoreCorrect] " +
                ",[ScoreInCorrect] " +
                ",[Completed] " +
                ",[DateStart] " +
                ",[DateEnd] " +
                "FROM  dbo.[Score] " +
                "where UserID = @UserID and GameID = @GameID  and Completed = 1 " +
                "order by[Level] desc,  (ScoreCorrect-ScoreInCorrect) desc", con))
            {
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.Parameters.AddWithValue("@GameID", GameID);
                con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    builder.Append("Level: " + rdr.GetInt32(0).ToString() + "\n\n");
                    builder.Append("Time Played: " + rdr.GetString(1) + "\n\n");
                    if (rdr.GetInt32(2) > 0)
                        builder.Append("Score Correct: " + rdr.GetInt32(2) + "\n\n");
                    if (rdr.GetInt32(3) > 0)
                        builder.Append("Score Incorrect: " + rdr.GetInt32(3) + "\n\n");

                }
                else
                {
                    Console.WriteLine("not available ");
                }
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();


                return builder;
            }
        }
    }
}
