using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace fcomm
{
    class metier
    {
        public metier()
        {
            OpenDBConnexion1();
        }
        public Boolean exit = false;
        public MySqlConnection mycon;

        private bool OpenDBConnexion1()
        {
            bool connectSucceeded = false;
            System.IO.StreamReader str = new System.IO.StreamReader(Application.StartupPath + "/config.inf");
            string strcon = "";
            try
            {
                strcon = str.ReadLine();
                strcon += ";database=f_commerce;charset=utf8;";
                Program.Str_con = strcon;
            }
            catch
            {

            }
            str.Close();


            mycon = new MySqlConnection(strcon);
            try
            {
                System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();
                if (ping.Send(mycon.DataSource).Status == System.Net.NetworkInformation.IPStatus.Success)
                {

                    mycon.Open();
                    connectSucceeded = true;
                }
                else
                {
                    MessageBox.Show("Impossible de connecter.\n Le serveur " + mycon.DataSource + " Inaccéssible. ");
                    exit = true;
                }
            }
            catch (Exception)
            {
                //verif_db();
            }

            return connectSucceeded;
        }
        public DataSet recuperer_table(String req, DataSet ds, String Table)
        {
            try
            {
                MySqlDataAdapter myadap = new MySqlDataAdapter(req, mycon);
                try
                {
                    ds.Tables[Table].Rows.Clear();
                }
                catch { }
                myadap.Fill(ds, Table);
                return ds;
            }
            catch
            {
                return null;
            }


        }
        public DataSet recuperer_table(String req, String Table)
        
        {
            try
            {

                MySqlDataAdapter myadap = new MySqlDataAdapter(req, mycon);
                DataSet ds = new DataSet();

                myadap.Fill(ds, Table);
                return ds;
            }
            catch
            {
                return null;
            }


        }
        public Boolean Execute(String req)
        {
            MySqlCommand cmd = new MySqlCommand(req, mycon);

            int i = cmd.ExecuteNonQuery();
            if (i == 0)
            {
                return false;
            }
            else
            {
                mycon.BeginTransaction().Commit();
                return true;

            }
        }
    }

}
