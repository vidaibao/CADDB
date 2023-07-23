using System;

using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
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

                    result = "Done. Completed loading Lines to CADDB";

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




        // Load all the MText Objs into DB 
        public string LoadMTexts()
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
                    TypedValue[] tvs = new TypedValue[] { new TypedValue((int)DxfCode.Start, "MTEXT") };
                    SelectionFilter filter = new SelectionFilter(tvs);

                    PromptSelectionResult psr = ed.SelectAll(filter);
                    // Check if there is object selected
                    if (psr.Status == PromptStatus.OK)
                    {
                        double insPtX = 0.0, insPtY = 0.0;
                        string layer = "", color = "", txtStyle = "", text = "";
                        double height = 0.0, width = 0.0;
                        int attachment = 0;
                        MText mText = new MText();

                        SelectionSet ss = psr.Value as SelectionSet;

                        String sql = @"INSERT INTO dbo.MTexts (InsPtX, InsPtY, Layer, Color, TextStyle, Height, Width, Text, Attachment, Created) 
                                       VALUES (@InsPtX, @InsPtY, @Layer, @Color, @TextStyle, @Height, @Width, @Text, @Attachment, @Created)";

                        conn.Open();

                        // Loop through the ss n insert into DB, one line at a time
                        foreach (SelectedObject sObj in ss)
                        {
                            mText = tr.GetObject(sObj.ObjectId, OpenMode.ForRead) as MText;
                            insPtX = mText.Location.X;
                            insPtY = mText.Location.Y;
                            layer = mText.Layer;
                            color = mText.Color.ToString();
                            txtStyle = mText.TextStyleName;
                            height = mText.TextHeight;
                            width = mText.Width;
                            text = mText.Text;
                            attachment = Convert.ToInt32(mText.Attachment);

                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@InsPtX", insPtX);
                            cmd.Parameters.AddWithValue("@InsPtY", insPtY);
                            cmd.Parameters.AddWithValue("@Layer", layer);
                            cmd.Parameters.AddWithValue("@Color", color);
                            cmd.Parameters.AddWithValue("@TextStyle", txtStyle);
                            cmd.Parameters.AddWithValue("@Height", height);
                            cmd.Parameters.AddWithValue("@Width", width);
                            cmd.Parameters.AddWithValue("@Text", text);
                            cmd.Parameters.AddWithValue("@Attachment", attachment);
                            cmd.Parameters.AddWithValue("@Created", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        ed.WriteMessage("No object selected!");
                    }

                    result = "Done. Completed loading MTexts to CADDB";
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





        // Load all the PolyLine Objs into DB 
        public string LoadPolyLines()
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
                    TypedValue[] tvs = new TypedValue[] { new TypedValue((int)DxfCode.Start, "LWPOLYLINE") };
                    SelectionFilter filter = new SelectionFilter(tvs);

                    PromptSelectionResult psr = ed.SelectAll(filter);
                    // Check if there is object selected
                    if (psr.Status == PromptStatus.OK)
                    {
                        string layer = "", ltype = "", coords = "";
                        double len = 0.0;
                        bool isClosed = false;
                        
                        Polyline pline = new Polyline();
                        SelectionSet ss = psr.Value as SelectionSet;

                        String sql = @"INSERT INTO dbo.Plines (Layer, LineType, Length, Coordinates, IsClosed, Created) 
                                       VALUES (@Layer, @LineType, @Length, @Coordinates, @IsClosed, @Created)";

                        conn.Open();

                        // Loop through the ss n insert into DB, one pline at a time
                        foreach (SelectedObject sObj in ss)
                        {
                            pline = tr.GetObject(sObj.ObjectId, OpenMode.ForRead) as Polyline;
                            layer = pline.Layer;
                            ltype = pline.Linetype;
                            len = pline.Length;
                            isClosed = pline.Closed;
                            // Coordinates
                            coords = CommonUtil.GetPolylineCoordinates(pline);

                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@Layer", layer);
                            cmd.Parameters.AddWithValue("@LineType", ltype);
                            cmd.Parameters.AddWithValue("@Length", len);
                            cmd.Parameters.AddWithValue("@Coordinates", coords);
                            cmd.Parameters.AddWithValue("@IsClosed", isClosed);
                            cmd.Parameters.AddWithValue("@Created", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        ed.WriteMessage("No object selected!");
                    }

                    result = "Done. Completed loading PolyLines to CADDB";

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






        // Load all the Blocks (No Attribute) into DB 
        public string LoadBlocksNoAttribute()
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
                    TypedValue[] tvs = new TypedValue[] { new TypedValue((int)DxfCode.Start, "INSERT") };
                    SelectionFilter filter = new SelectionFilter(tvs);

                    PromptSelectionResult psr = ed.SelectAll(filter);
                    // Check if there is object selected
                    if (psr.Status == PromptStatus.OK)
                    {
                        double insPtX = 0.0, insPtY = 0.0, rotation = 0.0;
                        string insPt = "", blkName = "", layer = "";
                        BlockReference blk = null;
                        SelectionSet ss = psr.Value as SelectionSet;

                        String sql = @"INSERT INTO dbo.BlocksNoAttribute (InsertionPt, BlockName, Layer, Rotation, Created) 
                                       VALUES (@InsertionPt, @BlockName, @Layer, @Rotation, @Created)";

                        conn.Open();

                        // Loop through the ss n insert into DB, one line at a time
                        foreach (SelectedObject sObj in ss)
                        {
                            blk = tr.GetObject(sObj.ObjectId, OpenMode.ForRead) as BlockReference;
                            // 
                            if (blk.AttributeCollection.Count == 0 & !blk.Name.Contains("*"))
                            {
                                insPtX = blk.Position.X;
                                insPtY = blk.Position.Y;
                                insPt = insPtX.ToString() + "," + insPtY.ToString();
                                blkName = blk.Name; // .Name not . BlockName
                                layer = blk.Layer;
                                rotation = blk.Rotation;

                                SqlCommand cmd = new SqlCommand(sql, conn);
                                cmd.Parameters.AddWithValue("@InsertionPt", insPt);
                                cmd.Parameters.AddWithValue("@BlockName", blkName);
                                cmd.Parameters.AddWithValue("@Layer", layer);
                                cmd.Parameters.AddWithValue("@Rotation", rotation);
                                cmd.Parameters.AddWithValue("@Created", DateTime.Now);
                                cmd.ExecuteNonQuery();
                            }
                            
                        }
                    }
                    else
                    {
                        ed.WriteMessage("No object selected!");
                    }

                    result = "Done. Completed loading BlocksNoAttribute to CADDB";

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





        // Load all the Blocks (With Attributes) into DB 
        public string LoadBlocksWithAttributes()
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
                    TypedValue[] tvs = new TypedValue[] { new TypedValue((int)DxfCode.Start, "INSERT") };
                    SelectionFilter filter = new SelectionFilter(tvs);

                    PromptSelectionResult psr = ed.SelectAll(filter);
                    // Check if there is object selected
                    if (psr.Status == PromptStatus.OK)
                    {
                        double insPtX = 0.0, insPtY = 0.0, rotation = 0.0;
                        string insPt = "", blkName = "", layer = "";
                        string attributes = "";
                        BlockReference blk = null;
                        SelectionSet ss = psr.Value as SelectionSet;

                        String sql = @"INSERT INTO dbo.BlocksWithAttributes (InsertionPt, BlockName, Layer, Rotation, Attributes, Created) 
                                       VALUES (@InsertionPt, @BlockName, @Layer, @Rotation, @Attributes, @Created)";

                        conn.Open();

                        // Loop through the ss n insert into DB, one line at a time
                        foreach (SelectedObject sObj in ss)
                        {
                            blk = tr.GetObject(sObj.ObjectId, OpenMode.ForRead) as BlockReference;
                            // 
                            if (blk.AttributeCollection.Count > 0 & !blk.Name.Contains("*"))
                            {
                                insPtX = blk.Position.X;
                                insPtY = blk.Position.Y;
                                insPt = insPtX.ToString() + "," + insPtY.ToString();
                                blkName = blk.Name;
                                layer = blk.Layer;
                                rotation = blk.Rotation;

                                // Loop throught the blocks attributes
                                foreach (ObjectId attRefId in blk.AttributeCollection)
                                {
                                    DBObject obj = tr.GetObject(attRefId, OpenMode.ForRead);
                                    AttributeReference attRef = obj as AttributeReference;
                                    if (attRef != null)
                                    {
                                        attributes += attRef.Tag + "*" + attRef.TextString + ",";
                                    }
                                }
                                attributes = attributes.Substring(0, attributes.Length - 1); // delete the last ','

                                SqlCommand cmd = new SqlCommand(sql, conn);
                                cmd.Parameters.AddWithValue("@InsertionPt", insPt);
                                cmd.Parameters.AddWithValue("@BlockName", blkName);
                                cmd.Parameters.AddWithValue("@Layer", layer);
                                cmd.Parameters.AddWithValue("@Rotation", rotation);
                                cmd.Parameters.AddWithValue("@Attributes", attributes);
                                cmd.Parameters.AddWithValue("@Created", DateTime.Now);
                                cmd.ExecuteNonQuery();

                                attributes = "";
                            }

                        }
                    }
                    else
                    {
                        ed.WriteMessage("No object selected!");
                    }

                    result = "Done. Completed loading BlocksWithAttribute to CADDB";

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
