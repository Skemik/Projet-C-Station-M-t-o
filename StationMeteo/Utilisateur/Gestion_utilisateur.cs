using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Collections;
using System.Data.OleDb;

namespace StationMeteo
{
	public partial class Form1
	{

		internal static DataSet Local_UserAccess = new DataSet();

		internal static DataTable Local_UserTable = new DataTable();
		internal static DataTable Local_AccessTable = new DataTable();

		public int access_Id=0;


		private static void ConfigDataset()
		{
			DataColumn UserKey_ID = new DataColumn("A", System.Type.GetType("System.Int16"));
			DataColumn UserName = new DataColumn("B", System.Type.GetType("System.String"));
			DataColumn UserPassword = new DataColumn("C", System.Type.GetType("System.String"));
			DataColumn Access_Id = new DataColumn("D", System.Type.GetType("System.Int16"));
			DataColumn AccessKey_Id = new DataColumn("E", System.Type.GetType("System.Int16"));
			DataColumn AccessName = new DataColumn("F", System.Type.GetType("System.String"));
			DataColumn AllowCreateID = new DataColumn("G", System.Type.GetType("System.Boolean"));
			DataColumn AllowDestroyID = new DataColumn("H", System.Type.GetType("System.Boolean"));
			DataColumn AllowConfigAlarm = new DataColumn("I", System.Type.GetType("System.Boolean"));
			DataColumn UserCreation = new DataColumn("J", System.Type.GetType("System.Boolean"));

			Local_UserTable.TableName = "Local_UserTable";
			Local_AccessTable.TableName = "Local_AccessTable";

			Local_UserAccess.Tables.Add(Local_UserTable);
			Local_UserAccess.Tables.Add(Local_AccessTable);

			UserKey_ID.AutoIncrement = true;
			UserKey_ID.Unique = true;
			UserKey_ID.ColumnName = "UserKey_ID";
			UserKey_ID.DataType = System.Type.GetType("System.Int32");
			Local_UserTable.Columns.Add(UserKey_ID);

			UserName.AutoIncrement = false;
			UserName.Unique = false;
			UserName.ColumnName = "UserName";
			UserName.DataType = System.Type.GetType("System.String");
			Local_UserTable.Columns.Add(UserName);

			UserPassword.AutoIncrement = false;
			UserPassword.Unique = false;
			UserPassword.ColumnName = "UserPassword";
			UserPassword.DataType = System.Type.GetType("System.String");
			Local_UserTable.Columns.Add(UserPassword);

			Access_Id.AutoIncrement = false;
			Access_Id.Unique = false;
			Access_Id.ColumnName = "Access_Id";
			Access_Id.DataType = System.Type.GetType("System.Int32");
			Local_UserTable.Columns.Add(Access_Id);

			AccessKey_Id.AutoIncrement = true;
			AccessKey_Id.Unique = true;
			AccessKey_Id.ColumnName = "AccessKey_Id";
			AccessKey_Id.DataType = System.Type.GetType("System.Int32");
			Local_AccessTable.Columns.Add(AccessKey_Id);

			AccessName.AutoIncrement = false;
			AccessName.Unique = false;
			AccessName.ColumnName = "AccessName";
			AccessName.DataType = System.Type.GetType("System.String");
			Local_AccessTable.Columns.Add(AccessName);

			AllowCreateID.AutoIncrement = false;
			AllowCreateID.Unique = false;
			AllowCreateID.ColumnName = "AllowCreateID";
			AllowCreateID.DataType = System.Type.GetType("System.Boolean");
			Local_AccessTable.Columns.Add(AllowCreateID);

			AllowDestroyID.AutoIncrement = false;
			AllowDestroyID.Unique = false;
			AllowDestroyID.ColumnName = "AllowDestroyID";
			AllowDestroyID.DataType = System.Type.GetType("System.Boolean");
			Local_AccessTable.Columns.Add(AllowDestroyID);

			AllowConfigAlarm.AutoIncrement = false;
			AllowConfigAlarm.Unique = false;
			AllowConfigAlarm.ColumnName = "AllowConfigAlarm";
			AllowConfigAlarm.DataType = System.Type.GetType("System.Boolean");
			Local_AccessTable.Columns.Add(AllowConfigAlarm);

			UserCreation.AutoIncrement = false;
			UserCreation.Unique = false;
			UserCreation.ColumnName = "UserCreation";
			UserCreation.DataType = System.Type.GetType("System.Boolean");
			Local_AccessTable.Columns.Add(UserCreation);

			DataColumn parentColumn = Local_UserAccess.Tables["Local_AccessTable"].Columns["AccessKey_Id"];
			DataColumn childColumn = Local_UserAccess.Tables["Local_UserTable"].Columns["Access_Id"];

			DataRelation relation = new DataRelation("parent2Child", parentColumn, childColumn);

			Local_UserAccess.Tables["Local_UserTable"].ParentRelations.Add(relation);
		}

		private void afficherUtilisateurs(object sender, EventArgs e)
        {
			cacherTouslesComposantsGraphiques();
			grid_accessTable.Visible = true;
			grid_userTable.Visible = true;
			Utilisateur.Adapter.Fill(Local_UserAccess, "Local_UserTable", "UserTable", grid_userTable);
			userControl_SupprimerUtilisateur.Visible = true;
			update_button.Visible = true;
			tabControl_users.Visible = true;
			gererAffichageGridUsersAccess();

		}

		private void seConnecter(object sender, EventArgs e)
		{
			cacherTouslesComposantsGraphiques();
			userControl_Connexion.Visible = true;


		}
		private void connexionUtilisateur(object sender, EventArgs e)
		{
			String pseudo = userControl_Connexion.connexion_username.Text;
			String mdp = userControl_Connexion.connexion_password.Text;
			access_Id=Utilisateur.Adapter.SelectUtilisateur(pseudo, mdp);
            if (access_Id != 0)
            {
				MessageBox.Show("Vous êtes connecté ! ");
            }
            gererAccesSelonDroits(access_Id);
            userControl_Connexion.Visible = false;
			
		}

		private void afficherAjouterUnUtilisateurClick(object sender, EventArgs e)
		{
			cacherTouslesComposantsGraphiques();
			userControl_newuser.Visible = true;

		}

		private void ajouterUtilisateurClick(object sender, EventArgs e)
		{
			int droit;
			String pseudo=userControl_newuser.input_usernameNewuser.Text;
			String mdp = userControl_newuser.input_pwNewuser.Text;
			int.TryParse(userControl_newuser.input_rightsNewuser.Text, out droit);
			Utilisateur.Adapter.Insert(pseudo,mdp,droit);
			Utilisateur.Adapter.Fill(Local_UserAccess, "Local_UserTable", "UserTable", grid_userTable);
			gererAffichageGridUsersAccess();
		}

		private void supprimerUtilisateur(object sender, EventArgs e)
        {
			String pseudo = userControl_SupprimerUtilisateur.deleteUser_text.Text;
			Utilisateur.Adapter.Delete(pseudo);
			Utilisateur.Adapter.Fill(Local_UserAccess, "Local_UserTable", "UserTable", grid_userTable);
			gererAffichageGridUsersAccess();

		}

		private void update(object sender, EventArgs e)
		{
			Utilisateur.Adapter.Update(Local_UserAccess.Tables["Local_UserTable"]);
			Utilisateur.Adapter.Fill(Local_UserAccess, "Local_UserTable", "UserTable", grid_userTable);
			gererAccesSelonDroits(access_Id);
			gererAffichageGridUsersAccess();
			cacherTouslesComposantsGraphiques();

		}

		private void gererAccesSelonDroits(int accessLevel)
        {
            if (accessLevel == 5)
			{
				lire_config_toolstrip.Enabled = false;
				ajouter_config_toolstrip.Enabled = false;
				ajouter_alarme_toolstrip.Enabled = false;
				afficher_utilisateurs_toolstrip.Enabled = false;

				seConnecter_toolstrip.Enabled = false;
				seDeconnecter_toolstrip.Enabled = true;
				sauve_config_toolstrip.Enabled = false;


			}
			else if (accessLevel==4)
            {
				lire_config_toolstrip.Enabled = false;
				ajouter_config_toolstrip.Enabled = false;
				ajouter_alarme_toolstrip.Enabled = true;
				afficher_utilisateurs_toolstrip.Enabled = false;
				seConnecter_toolstrip.Enabled = false;
				seDeconnecter_toolstrip.Enabled = true;
				sauve_config_toolstrip.Enabled = false;

			}
			else if (accessLevel == 3|| accessLevel == 2)
			{
				lire_config_toolstrip.Enabled = true;
				ajouter_config_toolstrip.Enabled = true;
				ajouter_alarme_toolstrip.Enabled = true;
				afficher_utilisateurs_toolstrip.Enabled = false;
				seConnecter_toolstrip.Enabled = false;
				seDeconnecter_toolstrip.Enabled = true;
				sauve_config_toolstrip.Enabled = true;
			}
			else if (accessLevel == 1)
			{
				lire_config_toolstrip.Enabled = true;
				ajouter_config_toolstrip.Enabled = true;
				ajouter_alarme_toolstrip.Enabled = true;
				afficher_utilisateurs_toolstrip.Enabled = true;
				seConnecter_toolstrip.Enabled = false;
				seDeconnecter_toolstrip.Enabled = true;
				sauve_config_toolstrip.Enabled = true;
			}
			else if (accessLevel == 0)
            {
				lire_config_toolstrip.Enabled = false;
				ajouter_config_toolstrip.Enabled = false;
				ajouter_alarme_toolstrip.Enabled = false;
				afficher_utilisateurs_toolstrip.Enabled = false;
				seConnecter_toolstrip.Enabled = true;
				seDeconnecter_toolstrip.Enabled = false;
				sauve_config_toolstrip.Enabled = false;
			}
		}

		private void deconnexion(object sender, EventArgs e)
        {
			access_Id = 0;
			gererAccesSelonDroits(access_Id);
			cacherTouslesComposantsGraphiques();
			MessageBox.Show("Vous vous êtes déconnecté ! ");
        }

		private void gererAffichageGridUsersAccess()
        {
			int rowcountUser = 7;	
            if (grid_userTable.RowCount <= 7)
            {
				grid_userTable.ScrollBars = ScrollBars.None;
				rowcountUser = grid_userTable.RowCount;
				tabControl_users.Location = new System.Drawing.Point(517, 27);

			}
            else
            {

				grid_userTable.ScrollBars = ScrollBars.Vertical;
			}
			for (int i = 0; i < grid_userTable.ColumnCount; i++)
			{
				grid_userTable.Columns[i].Width = boxwidth;


			}
            for (int i = 0; i < rowcountUser; i++)
            {
                grid_userTable.Rows[i].Height = boxheight;

            }
            for (int i = 0; i < grid_accessTable.ColumnCount; i++)
            {
                grid_accessTable.Columns[i].Width = boxwidth;


            }
            for (int i = 0; i < grid_accessTable.RowCount; i++)
            {
                grid_accessTable.Rows[i].Height = boxheight;

            }
			grid_userTable.Width = boxwidth * grid_userTable.ColumnCount + 3;
			grid_userTable.Height = boxheight * rowcountUser + 22;
			if (rowcountUser != grid_userTable.RowCount)
            {
				grid_userTable.Width = boxwidth * grid_userTable.ColumnCount + 20;
				grid_userTable.Height = boxheight * rowcountUser -4;
				tabControl_users.Location = new System.Drawing.Point(530, 27);
			}
            grid_accessTable.Width = boxwidth * grid_accessTable.ColumnCount + 3;
            grid_accessTable.Height = boxheight * grid_accessTable.RowCount + 20;
		}

	}
}
