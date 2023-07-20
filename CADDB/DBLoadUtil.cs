using System;

using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.EditorInput;

using System.Data;
using System.Data.SqlClient;

namespace CADDB
{
    public class DBLoadUtil
    {
        // Load all the Line Objs into DB 
        public string LoadLines()
        {
            string result = null;
            SqlConnection conn = DBUtil.GetConnection();

            try
            {
                // Get Document n Editor object
                Document doc = Application.DocumentManager.MdiActiveDocument;
                Editor ed = doc.Editor;

                using (Transaction tr = doc.TransactionManager.StartTransaction())
                {
                    TypedValue[] tvs = new TypedValue[] { new TypedValue((int)DxfCode.Start, "LINE") };
                    SelectionFilter filter = new SelectionFilter(tvs);

                    PromptSelectionResult psr = ed.SelectAll(filter);
                    // Check if there is object selected
                    if (psr.Status == PromptStatus.OK)
                    {
                        double startPtX = 0.0, startPtY = 0.0, endPtX = 0.0, endPtY = 0.0;
                        string layer = "", ltype = "", color = "";
                        double len = 0.0;
                        Line line = new Line();
                        SelectionSet ss = psr.Value as SelectionSet;

                        String sql = @"INSERT INTO dbo.Lines (StartPtX, StartPtY, EndPtX, EndPtY, Layer, Color, LineType, Length, Created) 
                                       VALUES (@StartPtX, @StartPtY, @EndPtX, @EndPtY, @Layer, @Color, @LineType, @Length, @Created)";

                        conn.Open();

                        // Loop through the ss n insert into DB, one line at a time
                        foreach (SelectedObject sObj in ss)
                        {
                            line = tr.GetObject(sObj.ObjectId, OpenMode.ForRead) as Line;
                            startPtX = line.StartPoint.X;
                            startPtY = line.StartPoint.Y;
                            endPtX = line.EndPoint.X;
                            endPtY = line.EndPoint.Y;
                            layer = line.Layer;
                            color = line.Color.ToString();
                            ltype = line.Linetype;
                            len = line.Length;

                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@StartPtX", startPtX);
                            cmd.Parameters.AddWithValue("@StartPtY", startPtY);
                            cmd.Parameters.AddWithValue("@EndPtX", endPtX);
                            cmd.Parameters.AddWithValue("@EndPtY", endPtY);
                            cmd.Parameters.AddWithValue("@Layer", layer);
                            cmd.Parameters.AddWithValue("@Color", color);
                            cmd.Parameters.AddWithValue("@LineType", ltype);
                            cmd.Parameters.AddWithValue("@Length", len);
                            cmd.Parameters.AddWithValue("@Created", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        ed.WriteMessage("No object selected!");
                    }

                    result = "Done. Completed loading to CADDB";

                    tr.Commit();
                }
            }
            catch (System.Exception ex)
            {
                result = ex.Message;
            }
            finally 
            {
                if (conn.State == ConnectionState.Open) { conn.Close(); }
            }

            return result;
        }
    }
}
