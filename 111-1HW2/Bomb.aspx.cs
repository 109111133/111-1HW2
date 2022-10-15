using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1HW2
{
    public partial class Bomb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[,] ia_Map = new string[10, 10];
            int[,] shelly = new int[10, 10];
            int[] ia_MIndex = new int[10] { 0, 7, 13, 28, 44, 62, 74, 75, 87, 90 };

            for (int Q = 0; Q<ia_MIndex.Length; Q++)
            {
                int X = ia_MIndex[Q] /ia_MIndex.Length;
                int Y = ia_MIndex[Q] %ia_MIndex.Length;
                if (X!=0 & Y != 0) {
                    shelly[X-1, Y-1] +=1;
                }

                if (X!=0 & Y != 9)
                {
                    shelly[X-1, Y+1] +=1;
                }

                if (X!=9 & Y != 9)
                {
                    shelly[X+1, Y+1] +=1;
                }

                if (X!=9 & Y !=0)
                {
                    shelly[X+1, Y-1] +=1;
                }

                if (X!=0)
                {
                    shelly[X-1, Y] +=1;
                }

                if (Y!=0)
                {
                    shelly[X, Y-1] +=1;
                }

                if (X!=9)
                {
                    shelly[X+1, Y] +=1;
                }

                if (Y!=9)
                {
                    shelly[X, Y+1] +=1;
                }

                ia_Map[X, Y]="*";

            }
            lin(ia_Map,shelly);
        }
        void lin(string[,] A, int[,]C)
        {
            for (int R = 0; R<A.GetLength(0); R++)
            {
                for (int E = 1; E<A.GetLength(1); E++)
                {
                    if (A[R, E]!="*") A[R, E]=C[R,E].ToString();
                    if (A[R, E]=="0") A[R, E]="?";
                    Response.Write(A[R, E]+"  ");
                }
                Response.Write("<br>");
            }
        }
    }
}