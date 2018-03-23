using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ADBMS_PROJ
{
    class connection
    {
        

        public OracleConnection Con = new OracleConnection("Data Source = (DESCRIPTION = " +
"(ADDRESS = (PROTOCOL = TCP)(HOST = ICEFROG-PC)(PORT = 1521))" +
"(CONNECT_DATA =" +
  "(SERVER = DEDICATED)" +
  "(SERVICE_NAME = XE)" +
")" +
");User Id = rebms; password = 123four;");

        public Boolean ExecuteQuery(String sql)
        {
            OracleCommand OC = new OracleCommand(sql, Con);
           
            Con.Open();
            OC.ExecuteNonQuery();
            Con.Close();
            return true;
        }
        public DataTable GetResult(String sql) {
            OracleCommand OC = new OracleCommand(sql, Con);
            Con.Open();
            OracleDataAdapter DA = new OracleDataAdapter(sql,Con);
            DataTable DS = new DataTable();
            DA.Fill(DS);
            Con.Close();
            return DS;
        }


        public String Getnum()
        {
            OracleCommand OC = new OracleCommand("size_prop", Con);

            OC.CommandType = CommandType.StoredProcedure;
            OC.Parameters.Add("vSUCCESS", OracleDbType.Int64, 100);
            OC.Parameters["vSUCCESS"].Direction = ParameterDirection.Output;
            Con.Open();
            OC.ExecuteNonQuery();
            Con.Close();
            return OC.Parameters["vSUCCESS"].Value.ToString();
            


        }
        public String Getperc_1(String cs)
        {
            OracleCommand OC = new OracleCommand("PERC_STAT", Con);

            OC.CommandType = CommandType.StoredProcedure;
            OC.Parameters.Add("PARAM1", OracleDbType.Varchar2).Value = cs;
            OC.Parameters.Add("vSUCCESS", OracleDbType.Int64, 100);
            OC.Parameters["vSUCCESS"].Direction = ParameterDirection.Output;
            Con.Open();
            OC.ExecuteNonQuery();
            Con.Close();
            return OC.Parameters["vSUCCESS"].Value.ToString();



        }



        public String Getperc_2(String cs)
        {
            OracleCommand OC = new OracleCommand("tran_type", Con);

            OC.CommandType = CommandType.StoredProcedure;
            OC.Parameters.Add("PARAM1", OracleDbType.Varchar2).Value = cs;
            OC.Parameters.Add("vSUCCESS", OracleDbType.Int64, 100);
            OC.Parameters["vSUCCESS"].Direction = ParameterDirection.Output;
            Con.Open();
            OC.ExecuteNonQuery();
            Con.Close();
            return OC.Parameters["vSUCCESS"].Value.ToString();



        }

        public Boolean Getperc_3(String s0,String s1,String s2, int s3)
        {
            OracleCommand OC = new OracleCommand("cp", Con);

            OC.CommandType = CommandType.StoredProcedure;
            OC.Parameters.Add("PARAM0", OracleDbType.Varchar2).Value = s0;
            OC.Parameters.Add("PARAM1", OracleDbType.Varchar2).Value = s1;
            OC.Parameters.Add("PARAM2", OracleDbType.Varchar2).Value = s2;
            OC.Parameters.Add("PARAM3", OracleDbType.Int16).Value = s3;
            Con.Open();
            OC.ExecuteNonQuery();
            Con.Close();
            return true;



        }







    }
}
