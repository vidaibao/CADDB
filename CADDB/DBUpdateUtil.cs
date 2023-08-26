using System;
using System.Data.Sql;
using System.Data.SqlClient;
using DataTable = System.Data.DataTable;

using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using System.Data;

namespace CADDB
{
    public class DBUpdateUtil
    {

        // use command xdlist, list in acad for checking id of entity
        public string UpdateLines()
        {
            string result = "";
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = DBUtil.GetConnection();
                SqlDataAdapter adapter = new SqlDataAdapter();

                Document doc = Application.DocumentManager.MdiActiveDocument;
                Database db = doc.Database;
                Editor ed = doc.Editor;

                doc.LockDocument();
                using (Transaction trans = db.TransactionManager.StartTransaction())
                {
                    TypedValue[] tv = new TypedValue[1];
                    tv.SetValue(new TypedValue((int)DxfCode.Start, "LINE"), 0);
                    SelectionFilter filter = new SelectionFilter(tv);

                    PromptSelectionResult ssPrompt = ed.SelectAll(filter);
                    // Check if there is object selected
                    if (ssPrompt.Status == PromptStatus.OK)
                    {
                        int id;
                        double startPtX = 0.0, startPtY = 0.0, endPtX = 0.0, endPtY = 0.0;
                        string layer = "", ltype = "", color = "";
                        double len = 0.0;
                        Line line = new Line();
                        string sql = "";
                        SelectionSet ss = ssPrompt.Value;

                        sql = @"UPDATE dbo.Lines " +
                                "SET StartPtX = @StartPtX, StartPtY = @StartPtY, EndPtX = @EndPtX, EndPtY = @EndPtY, " +
                                "Layer = @Layer, Color = @Color, Linetype = @Linetype, Length = @Length, modified= @Modified " +
                                "WHERE id = @Id";

                        conn.Open();

                        // Loop through the selection set and insert into database one line object at a time
                        foreach (SelectedObject sObj in ss)
                        {
                            line = trans.GetObject(sObj.ObjectId, OpenMode.ForRead) as Line;

                            startPtX = line.StartPoint.X;
                            startPtY = line.StartPoint.Y;
                            endPtX = line.EndPoint.X;
                            endPtY = line.EndPoint.Y;
                            layer = line.Layer;
                            ltype = line.Linetype;
                            color = line.Color.ToString();
                            len = line.Length;
                            id = CommonUtil.ReadXDataFromEntity("CADDB", line);

                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@Id", id);
                            cmd.Parameters.AddWithValue("@StartPtX", startPtX);
                            cmd.Parameters.AddWithValue("@StartPtY", startPtY);
                            cmd.Parameters.AddWithValue("@EndPtX", endPtX);
                            cmd.Parameters.AddWithValue("@EndPtY", endPtY);
                            cmd.Parameters.AddWithValue("@Layer", layer);
                            cmd.Parameters.AddWithValue("@Color", color);
                            cmd.Parameters.AddWithValue("@Linetype", ltype);
                            cmd.Parameters.AddWithValue("@Length", len);
                            cmd.Parameters.AddWithValue("@Modified", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                result = "Done. Completed Update Lines successfully!";

            }
            catch (Exception ex)
            {
                result = "Error encountered: " + ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return result;
        }





        public string UpdateMTexts()
        {
            string result = "";
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = DBUtil.GetConnection();
                SqlDataAdapter adapter = new SqlDataAdapter();
                
                Document doc = Application.DocumentManager.MdiActiveDocument;
                Database db = doc.Database;
                Editor ed = doc.Editor;

                doc.LockDocument();
                using (Transaction trans = doc.TransactionManager.StartTransaction())
                {
                    TypedValue[] tv = new TypedValue[1];
                    tv.SetValue(new TypedValue((int)DxfCode.Start, "MTEXT"), 0);
                    SelectionFilter filter = new SelectionFilter(tv);

                    PromptSelectionResult ssPrompt = ed.SelectAll(filter);
                    // Check if there is object selected
                    if (ssPrompt.Status == PromptStatus.OK)
                    {
                        int id;
                        double insPtX = 0.0, insPtY = 0.0;
                        string layer = "", textstyle = "";
                        string color = "";
                        double height = 0.0, width = 0.0;
                        int attachment;
                        MText mtx = new MText();
                        string tx = "";
                        string sql = "";
                        //TextStyleTable stTab;
                        //stTab = trans.GetObject(db.TextStyleTableId, OpenMode.ForRead) as TextStyleTable;
                        SelectionSet ss = ssPrompt.Value;

                        sql = @"UPDATE dbo.MTexts " +
                                "SET insPtX = @InsPtX, insPtY = @insPtY, Layer = @Layer, Color = @Color, TextStyle = @TextStyle, " +
                                "Height = @Height, Width = @Width, Text = @Text, Attachment = @Attachment, modified= @Modified " +
                                "WHERE id = @Id";

                        conn.Open();

                        // Loop through the selection set and one line at a time
                        foreach (SelectedObject sObj in ss)
                        {
                            mtx = trans.GetObject(sObj.ObjectId, OpenMode.ForRead) as MText;

                            insPtX = mtx.Location.X;
                            insPtY = mtx.Location.Y;
                            layer = mtx.Layer;
                            color = mtx.Color.ToString();
                            textstyle = mtx.TextStyleName;
                            height = mtx.TextHeight;
                            width = mtx.Width;
                            tx = mtx.Contents;
                            attachment = Convert.ToInt32(mtx.Attachment);
                            id = CommonUtil.ReadXDataFromEntity("CADDB", mtx);

                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@Id", id);
                            cmd.Parameters.AddWithValue("@InsPtX", insPtX);
                            cmd.Parameters.AddWithValue("@InsPtY", insPtY);
                            cmd.Parameters.AddWithValue("@Layer", layer);
                            cmd.Parameters.AddWithValue("@Color", color);
                            cmd.Parameters.AddWithValue("@TextStyle", textstyle);
                            cmd.Parameters.AddWithValue("@Height", height);
                            cmd.Parameters.AddWithValue("@Width", width);
                            cmd.Parameters.AddWithValue("@Text", tx);
                            cmd.Parameters.AddWithValue("@Attachment", attachment);
                            cmd.Parameters.AddWithValue("@Modified", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    result = "Done. Completed Update MTexts successfully!";
                }
            }
            catch (System.Exception ex)
            {
                result = "Error encountered: " + ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return result;
        }




        public string UpdateCircles()
        {
            string result = "";
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = DBUtil.GetConnection();
                SqlDataAdapter adapter = new SqlDataAdapter();
                Document doc = Application.DocumentManager.MdiActiveDocument;
                Database db = doc.Database;
                Editor ed = doc.Editor;

                doc.LockDocument();
                using (Transaction trans = doc.TransactionManager.StartTransaction())
                {
                    TypedValue[] tv = new TypedValue[1];
                    tv.SetValue(new TypedValue((int)DxfCode.Start, "CIRCLE"), 0);
                    SelectionFilter filter = new SelectionFilter(tv);

                    PromptSelectionResult ssPrompt = ed.SelectAll(filter);
                    // Check if there is object selected
                    if (ssPrompt.Status == PromptStatus.OK)
                    {
                        int id;
                        double centerPtX = 0.0, centerPtY = 0.0;
                        string layer = "", ltype = "";
                        string color = "";
                        double radius = 0.0;
                        Circle circle = new Circle();
                        string sql = "";
                        SelectionSet ss = ssPrompt.Value;

                        sql = @"UPDATE dbo.Circles " +
                            "SET centerPtX = @centerPtX, centerPtY = @centerPtY, Layer = @Layer, Color = @Color, " +
                            "Linetype = @Linetype, radius = @radius, modified= @Modified " +
                            "WHERE id = @Id";

                        conn.Open();

                        // Loop through the selection set and insert into database one object at a time
                        foreach (SelectedObject sObj in ss)
                        {
                            circle = trans.GetObject(sObj.ObjectId, OpenMode.ForRead) as Circle;

                            centerPtX = circle.Center.X;
                            centerPtY = circle.Center.Y;
                            layer = circle.Layer;
                            ltype = circle.Linetype;
                            color = circle.Color.ToString();
                            radius = circle.Radius;
                            id = CommonUtil.ReadXDataFromEntity("CADDB", circle);

                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@Id", id);
                            cmd.Parameters.AddWithValue("@CenterPtX", centerPtX);
                            cmd.Parameters.AddWithValue("@CenterPtY", centerPtY);
                            cmd.Parameters.AddWithValue("@Layer", layer);
                            cmd.Parameters.AddWithValue("@Color", color);
                            cmd.Parameters.AddWithValue("@Linetype", ltype);
                            cmd.Parameters.AddWithValue("@Radius", radius);
                            cmd.Parameters.AddWithValue("@Modified", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    result = "Done. Completed successfully!";
                }
            }
            catch (System.Exception ex)
            {
                result = "Error encountered: " + ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return result;
        }

        public string UpdatePolylines()
        {
            string result = "";
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = DBUtil.GetConnection();
                SqlDataAdapter adapter = new SqlDataAdapter();
                Document doc = Application.DocumentManager.MdiActiveDocument;
                Database db = doc.Database;
                Editor ed = doc.Editor;

                doc.LockDocument();
                using (Transaction trans = doc.TransactionManager.StartTransaction())
                {
                    TypedValue[] tv = new TypedValue[1];
                    tv.SetValue(new TypedValue((int)DxfCode.Start, "LWPOLYLINE"), 0);
                    SelectionFilter filter = new SelectionFilter(tv);

                    PromptSelectionResult ssPrompt = ed.SelectAll(filter);
                    // Check if there is object selected
                    if (ssPrompt.Status == PromptStatus.OK)
                    {
                        int id;
                        string layer = "", ltype = "";
                        string coords = "";
                        double len = 0.0;
                        bool isClosed = false;
                        Polyline pline = new Polyline();
                        string sql = "";
                        SelectionSet ss = ssPrompt.Value;

                        sql = @"UPDATE dbo.Plines " +
                            "SET Layer = @Layer, Linetype = @Linetype, Length = @Length, Coordinates = @Coordinates, IsClosed = @IsClosed, modified = @Modified " +
                            "WHERE id = @Id";

                        conn.Open();

                        // Loop through the selection set and update lwpolyline one at a time
                        foreach (SelectedObject sObj in ss)
                        {
                            pline = trans.GetObject(sObj.ObjectId, OpenMode.ForRead) as Polyline;

                            layer = pline.Layer;
                            ltype = pline.Linetype;
                            len = pline.Length;
                            coords = CommonUtil.GetPolylineCoordinates(pline);
                            isClosed = pline.Closed;
                            id = CommonUtil.ReadXDataFromEntity("CADDB", pline);

                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@Id", id);
                            cmd.Parameters.AddWithValue("@Layer", layer);
                            cmd.Parameters.AddWithValue("@Linetype", ltype);
                            cmd.Parameters.AddWithValue("@Length", len);
                            cmd.Parameters.AddWithValue("@Coordinates", coords);
                            cmd.Parameters.AddWithValue("@IsClosed", isClosed);
                            cmd.Parameters.AddWithValue("@Modified", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    result = "Done. Completed successfully!";
                }
            }
            catch (System.Exception ex)
            {
                result = "Error encountered: " + ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return result;
        }

        public string UpdateBlocksNoAttributes()
        {
            string result = "";
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = DBUtil.GetConnection();
                SqlDataAdapter adapter = new SqlDataAdapter();
                Document doc = Application.DocumentManager.MdiActiveDocument;
                Database db = doc.Database;
                Editor ed = doc.Editor;

                doc.LockDocument();
                using (Transaction trans = doc.TransactionManager.StartTransaction())
                {
                    TypedValue[] tv = new TypedValue[1];
                    tv.SetValue(new TypedValue((int)DxfCode.Start, "INSERT"), 0);
                    SelectionFilter filter = new SelectionFilter(tv);

                    PromptSelectionResult ssPrompt = ed.SelectAll(filter);
                    // Check if there is object selected
                    if (ssPrompt.Status == PromptStatus.OK)
                    {
                        int id;
                        double insPtX = 0.0, insPtY = 0.0;
                        string blkName = "";
                        string layer = "";
                        double rotation = 0.0;
                        BlockReference blk;
                        string insPt = "";
                        string sql = "";
                        SelectionSet ss = ssPrompt.Value;

                        sql = @"UPDATE dbo.BlocksNoAttribute " +
                            "SET insertionPt = @insertionPt, BlockName = @BlockName, Layer = @Layer, Rotation = @Rotation, modified = @Modified " +
                            "WHERE id = @Id";

                        conn.Open();

                        // Loop through the selection set and update one block at a time
                        foreach (SelectedObject sObj in ss)
                        {
                            blk = trans.GetObject(sObj.ObjectId, OpenMode.ForRead) as BlockReference;
                            if (blk.AttributeCollection.Count == 0 && !blk.Name.Contains("*"))
                            {
                                insPtX = blk.Position.X;
                                insPtY = blk.Position.Y;
                                insPt = insPtX.ToString() + "," + insPtY.ToString();
                                blkName = blk.Name;
                                layer = blk.Layer;
                                rotation = blk.Rotation;
                                id = CommonUtil.ReadXDataFromEntity("CADDB", blk);

                                SqlCommand cmd = new SqlCommand(sql, conn);
                                cmd.Parameters.AddWithValue("@Id", id);
                                cmd.Parameters.AddWithValue("@InsertionPt", insPt);
                                cmd.Parameters.AddWithValue("@BlockName", blkName);
                                cmd.Parameters.AddWithValue("@Layer", layer);
                                cmd.Parameters.AddWithValue("@Rotation", rotation);
                                cmd.Parameters.AddWithValue("@Modified", DateTime.Now);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                result = "Done. Completed successfully!";
            }
            catch (System.Exception ex)
            {
                result = "Error encountered: " + ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return result;
        }

        // Load all the Blocks (With Attributes) Objects
        public string UpdateBlocksWithAttributes()
        {
            string result = "";
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = DBUtil.GetConnection();
                SqlDataAdapter adapter = new SqlDataAdapter();

                // Get the Document and Editor object
                Document doc = Application.DocumentManager.MdiActiveDocument;
                Database db = doc.Database;
                Editor ed = doc.Editor;

                using (Transaction trans = doc.TransactionManager.StartTransaction())
                {
                    TypedValue[] tv = new TypedValue[1];
                    tv.SetValue(new TypedValue((int)DxfCode.Start, "INSERT"), 0);
                    SelectionFilter filter = new SelectionFilter(tv);

                    PromptSelectionResult ssPrompt = ed.SelectAll(filter);
                    // Check if there is object selected
                    if (ssPrompt.Status == PromptStatus.OK)
                    {
                        int id;
                        double insPtX = 0.0, insPtY = 0.0;
                        string blkName = "";
                        string layer = "";
                        double rotation = 0.0;
                        BlockReference blk;
                        string insPt = "";
                        string attributes = "";
                        string sql = "";
                        SelectionSet ss = ssPrompt.Value;

                        sql = @"UPDATE dbo.BlocksWithAttributes " +
                                "SET insertionPt = @insertionPt, BlockName = @BlockName, Layer = @Layer, Rotation = @Rotation, Attributes = @Attributes, Modified = @Modified " +
                                "WHERE id = @Id";

                        conn.Open();

                        // Loop through the selection set and update one block at a time
                        foreach (SelectedObject sObj in ss)
                        {
                            blk = trans.GetObject(sObj.ObjectId, OpenMode.ForRead) as BlockReference;
                            if (blk.AttributeCollection.Count > 0 && !blk.Name.Contains("*"))
                            {
                                insPtX = blk.Position.X;
                                insPtY = blk.Position.Y;
                                insPt = insPtX.ToString() + "," + insPtY.ToString();
                                blkName = blk.Name;
                                layer = blk.Layer;
                                rotation = blk.Rotation;
                                id = CommonUtil.ReadXDataFromEntity("CADDB", blk);

                                // Loop through the Block Attributes
                                foreach (ObjectId attRefId in blk.AttributeCollection)
                                {
                                    DBObject obj = trans.GetObject(attRefId, OpenMode.ForRead);
                                    AttributeReference attRef = obj as AttributeReference;
                                    if (attRef != null)
                                    {
                                        attributes += attRef.Tag + "=" + attRef.TextString + ",";
                                    }
                                }
                                attributes = attributes.Substring(0, attributes.Length - 1);

                                SqlCommand cmd = new SqlCommand(sql, conn);
                                cmd.Parameters.AddWithValue("@Id", id);
                                cmd.Parameters.AddWithValue("@InsertionPt", insPt);
                                cmd.Parameters.AddWithValue("@BlockName", blkName);
                                cmd.Parameters.AddWithValue("@Layer", layer);
                                cmd.Parameters.AddWithValue("@Rotation", rotation);
                                cmd.Parameters.AddWithValue("@Attributes", attributes);
                                cmd.Parameters.AddWithValue("@Modified", DateTime.Now);
                                cmd.ExecuteNonQuery();

                                attributes = "";
                            }
                        }
                    }
                }
                result = "Done. Completed successfully!";
            }
            catch (System.Exception ex)
            {
                result = ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return result;
        }



    }
}
