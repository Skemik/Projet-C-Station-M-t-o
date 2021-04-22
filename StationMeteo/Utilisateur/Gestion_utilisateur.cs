﻿using System;
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

namespace StationMeteo
{
	public partial class Form1
	{
		DataTable userTable=new DataTable("userTable");
		DataTable accessTable=new DataTable("accessTable");
		DataColumn colonne = new DataColumn();

		public void creerUserTable()
        {
			DataRow instance;
        //ID
		colonne.DataType = System.Type.GetType("System.Int32");
		colonne.ColumnName = "ID";
			colonne.Caption = "ID";
		colonne.ReadOnly = true;
		colonne.Unique = true;
		colonne.AutoIncrement = true;
		colonne.AllowDBNull = false;
		userTable.Columns.Add(colonne);//ajout à la table user

			//UserName
		colonne = new DataColumn();
		colonne.DataType = System.Type.GetType("System.String");
		colonne.ReadOnly = false;
		colonne.Unique = false;
		colonne.AutoIncrement = false;
		colonne.AllowDBNull = false;
		colonne.ColumnName = "UserName";
		userTable.Columns.Add(colonne);

		//UserPassword
		colonne = new DataColumn();
		colonne.DataType = System.Type.GetType("System.String");
		colonne.ColumnName = "UserPassword";
		colonne.AllowDBNull = true;
		userTable.Columns.Add(colonne);

		//Access_ID
		colonne = new DataColumn();
		colonne.DataType = System.Type.GetType("System.Int32");
		colonne.ColumnName = "Access_ID";
		userTable.Columns.Add(colonne);


		instance = userTable.NewRow();
		instance["ID"] = 1;
		instance["UserName"] = "Hakan";
		instance["UserPassword"] = "Helb123";
		instance["Access_ID"] = 0;
		userTable.Rows.Add(instance);
		dataSetUtilisateur.Tables.Add(userTable);
		}

		public void creerAccesTable()
		{
			DataRow instance;
			//ID
			colonne = new DataColumn();
			colonne.DataType = System.Type.GetType("System.Int32");
			colonne.ColumnName = "ID";
			colonne.Caption = "ID";
			colonne.ReadOnly = true;
			colonne.Unique = true;
			colonne.AutoIncrement = true;
			accessTable.Columns.Add(colonne);

			//Name
			colonne = new DataColumn();
			colonne.DataType = System.Type.GetType("System.String");
			colonne.ColumnName = "Name";
			colonne.ReadOnly = false;
			colonne.Unique = false;
			colonne.AutoIncrement = false;
			accessTable.Columns.Add(colonne);

			//AllowCreateID
			colonne = new DataColumn();
			colonne.DataType = System.Type.GetType("System.Boolean");
			colonne.ReadOnly = false;
			colonne.Unique = false;
			colonne.AutoIncrement = false;
			colonne.ColumnName = "AllowCreateID";
			accessTable.Columns.Add(colonne);

			//AllowDestroyID
			colonne = new DataColumn();
			colonne.DataType = System.Type.GetType("System.Boolean");
			colonne.ReadOnly = false;
			colonne.Unique = false;
			colonne.AutoIncrement = false;
			colonne.ColumnName = "AllowDestroyID";
			accessTable.Columns.Add(colonne);

			//AllowConfigAlarm
			colonne = new DataColumn();
			colonne.DataType = System.Type.GetType("System.Boolean");
			colonne.ReadOnly = false;
			colonne.Unique = false;
			colonne.AutoIncrement = false;
			colonne.ColumnName = "AllowConfigAlarm";
			accessTable.Columns.Add(colonne);

			//UserCreation
			colonne = new DataColumn();
			colonne.DataType = System.Type.GetType("System.Boolean");
			colonne.ReadOnly = false;
			colonne.Unique = false;
			colonne.AutoIncrement = false;
			colonne.ColumnName = "UserCreation";
			accessTable.Columns.Add(colonne);
			
			instance = accessTable.NewRow();
			instance["ID"] = 0;
			instance["Name"] = "AdminRights";
			instance["AllowCreateID"] = "true";
			instance["AllowDestroyID"] = "true";
			instance["AllowConfigAlarm"] = "true";
			instance["UserCreation"] = "true";
			accessTable.Rows.Add(instance);

			instance = accessTable.NewRow();
			instance["ID"] = 1;
			instance["Name"] = "MasterRights";
			instance["AllowCreateID"] = "true";
			instance["AllowDestroyID"] = "true";
			instance["AllowConfigAlarm"] = "true";
			instance["UserCreation"] = "false";
			accessTable.Rows.Add(instance);

			instance = accessTable.NewRow();
			instance["ID"] = 2;
			instance["Name"] = "MiddleRights";
			instance["AllowCreateID"] = "true";
			instance["AllowDestroyID"] = "false";
			instance["AllowConfigAlarm"] = "true";
			instance["UserCreation"] = "false";
			accessTable.Rows.Add(instance);

			instance = accessTable.NewRow();
			instance["ID"] = 3;
			instance["Name"] = "BasicRights";
			instance["AllowCreateID"] = "false";
			instance["AllowDestroyID"] = "false";
			instance["AllowConfigAlarm"] = "true";
			instance["UserCreation"] = "false";
			accessTable.Rows.Add(instance);

			instance = accessTable.NewRow();
			instance["ID"] = 4;
			instance["Name"] = "NoRights";
			instance["AllowCreateID"] = "false";
			instance["AllowDestroyID"] = "false";
			instance["AllowConfigAlarm"] = "false";
			instance["UserCreation"] = "false";
			accessTable.Rows.Add(instance);

			dataSetUtilisateur.Tables.Add(accessTable);
		}


		private void MakeDataRelation()
		{

			DataColumn childColumn = dataSetUtilisateur.Tables["userTable"].Columns["ACCESS_ID"];
			
			DataColumn parentColumn = dataSetUtilisateur.Tables["accessTable"].Columns["ID"];
			
			DataRelation relation = new DataRelation("AccesUtilisateur", parentColumn, childColumn);

			dataSetUtilisateur.Tables["userTable"].ParentRelations.Add(relation);
		}

		private void BindToDataGrid()
		{
			// Instruct the DataGrid to bind to the DataSet, with the
			// ParentTable as the topmost DataTable.
			//dataGrid1.SetDataBinding(dataSet, "ParentTable");
			grid_userTable.AutoGenerateColumns = true;
			grid_userTable.DataSource = dataSetUtilisateur;
			grid_userTable.DataMember = "userTable";

			grid_accessTable.AutoGenerateColumns = true;
			grid_accessTable.DataSource = dataSetUtilisateur;
			grid_accessTable.DataMember = "accessTable";

			for (int i = 0; i < 4; i++)
			{
				grid_userTable.Columns[i].Width = grid_userTable.Width / 4;
			}
			for (int i = 0; i < 6; i++)
			{
				grid_accessTable.Columns[i].Width = (grid_accessTable.Width / 6)+3;
			}
		}

		private void afficherUtilisateurs(object sender, EventArgs e)
        {
			grid_accessTable.Visible = true;
			grid_userTable.Visible = true;
			grid.Visible = false;
			userControlConfig.Visible = false;
			graphiqueOuvert = false;
			graphControl1.Visible = false;
		}

		private void seConnecter(object sender, EventArgs e)
		{
			userControl_Connexion.Visible = true;
		}

	}
}