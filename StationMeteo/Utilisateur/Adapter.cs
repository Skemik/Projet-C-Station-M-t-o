using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace StationMeteo.Utilisateur
{
    class Adapter
    {
		internal static void Insert(string Name,string password,int right)
		{
			Tools.Adapter.InsertCommand.Parameters[0].Value = Name;
			Tools.Adapter.InsertCommand.Parameters[1].Value = password;
			Tools.Adapter.InsertCommand.Parameters[2].Value = right;

			try
			{
				Tools.connexion.Open();

				int buffer = Tools.Adapter.InsertCommand.ExecuteNonQuery();

				if (buffer != 0) MessageBox.Show("User successfully inserted");
				else MessageBox.Show("User not inserted");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Tools.connexion.Close();
			}
		}
		internal static void Delete(String Name)
		{
		
			Tools.Adapter.DeleteCommand.Parameters[0].Value = Name;

			try
			{
				Tools.connexion.Open();

				int buffer = Tools.Adapter.DeleteCommand.ExecuteNonQuery();

				if (buffer != 0) MessageBox.Show("User successfully deleted");
				else MessageBox.Show("User not found");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Tools.connexion.Close();
			}
		}
		internal static void Fill(DataSet dataset, string TableName, string DB_Table, DataGridView Grid)
		{
			dataset.Tables[TableName].Clear();

			Tools.Adapter.SelectCommand = new OleDbCommand("SELECT * from " + DB_Table + ";", Tools.connexion);

			try
			{
				Tools.connexion.Open();

				Tools.Adapter.Fill(dataset.Tables[TableName]);

				Grid.DataSource = dataset.Tables[TableName];
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Tools.connexion.Close();
			}
		}
		internal static void Update(DataTable Table)
		{
			try
			{
				Tools.connexion.Open();

				Tools.Adapter.Update(Table);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Tools.connexion.Close();
			}
		}

		internal static int SelectUtilisateur(String pseudo,String mdp)
        {
			int accessId = 0;
			string SelectUtilisateur_CommandText = "SELECT Access_Id from UserTable WHERE UserName = '" + pseudo+"' AND UserPassword = '"+mdp+"';";

			OleDbCommand commande;

			try
			{
				Tools.connexion.Open();
				
				commande =Tools.Adapter.SelectCommand = new OleDbCommand(SelectUtilisateur_CommandText,Tools.connexion);

				OleDbDataReader reader = commande.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
						accessId=(int)reader[0];
                    }
                }
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Tools.connexion.Close();
			}
			return accessId;
		}
	}
}
