using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationMeteo
{
    public partial class GraphControl : UserControl
    {
        int indiceX = 0;
        int idActuel;
        
        public GraphControl()
        {
            
            InitializeComponent();

            
        }

        public void ajoutervaleur(int value,int id)
        {
            if (indiceX == 10||idActuel!=id)
            {
                indiceX = 0;
                viderGraphique();
            }
            idActuel = id;
            label_graphique.Text = "Graphique de l'id : " + idActuel;
            
            chart.Series["Series valeurs trames"].Points.AddXY(indiceX, value);
            indiceX=indiceX+1;


        }
        public void viderGraphique()
        {
            chart.Series["Series valeurs trames"].Points.Clear();
        }




    }
}
