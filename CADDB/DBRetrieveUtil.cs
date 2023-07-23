using System;
using System.Data;
using DataTable = System.Data.DataTable;
using System.Data.SqlClient; 

using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.EditorInput;


namespace CADDB
{
    public class DBRetrieveUtil
    {
        public string RetrieveAndDrawLines()
        {
            string result = null;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = DBUtil.GetConnection();
                string sql = "SELECT Id, StartPtX, StartPtY, EndPtX, EndPtY, Layer, Color, LineType FROM dbo.Lines WHERE IsDeleted IS NULL";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Document doc = Application.DocumentManager.MdiActiveDocument;
                    Database db = doc.Database;
                    Editor ed = doc.Editor;

                    doc.LockDocument();
                    using (Transaction tr = db.TransactionManager.StartTransaction())
                    {
                        ed.WriteMessage("Drawing Lines");
                        BlockTable bt = tr.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;
                        BlockTableRecord btr = tr.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;

                        int id = 0;
                        string layer = "", ltype = "", color = "";
                        int i = 0;
                        double[] coords = new double[4];
                        foreach (DataRow row in dt.Rows)
                        {
                            id = Convert.ToInt32(row["ID"]);
                            coords[i] = Convert.ToDouble(row["StartPtX"]);
                            coords[i + 1] = Convert.ToDouble(row["StartPtY"]);
                            coords[i + 2] = Convert.ToDouble(row["EndPtX"]);
                            coords[i + 3] = Convert.ToDouble(row["EndPtY"]);
                            layer = row["layer"].ToString();
                            color = row["color"].ToString();
                            ltype = row["LineType"].ToString();

                            Point3d pt1 = new Point3d(coords[i], coords[i + 1], 0);
                            Point3d pt2 = new Point3d(coords[i + 2], coords[i + 3], 0);

                            Line ln = new Line(pt1, pt2);
                            ln.Layer = layer;
                            ln.Linetype = ltype;
                            ln.ColorIndex = CommonUtil.GetColorIndex(color);

                            btr.AppendEntity(ln);
                            tr.AddNewlyCreatedDBObject(ln, true);
                            CommonUtil.AddXDataToEntity("CADDB", ln, id);
                        }

                        tr.Commit();
                    }
                }
                result = "Done. Completed retrieve Lines from CADDB";
            }
            catch (Exception ex)
            {
                result = "Error found: " + ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)  conn.Close();
            }


            return result;
        }





        // Original code
        public string RetrieveAndDrawMTexts000()
        {
            string result = "";
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = DBUtil.GetConnection();
                string sql = "SELECT Id, InsPtX, InsPtY, Layer, Color, TextStyle, Height, Width, Text, Attachment FROM dbo.MTexts WHERE IsDeleted IS NULL";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Document doc = Application.DocumentManager.MdiActiveDocument;
                    Database db = doc.Database;
                    Editor ed = doc.Editor;

                    doc.LockDocument();
                    using (Transaction trans = db.TransactionManager.StartTransaction())
                    {
                        doc.Editor.WriteMessage("Drawing MTexts!");
                        BlockTable bt = trans.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;
                        BlockTableRecord btr = trans.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;

                        int id;
                        string layer = "", style = "", txt = "";
                        double height = 0.0, width = 0.0;
                        double insPtX = 0.0, insPtY = 0.0;
                        int attPt = 1;
                        TextStyleTable stTab;
                        stTab = trans.GetObject(db.TextStyleTableId, OpenMode.ForRead) as TextStyleTable;
                        foreach (DataRow dr in dt.Rows)
                        {
                            MText mtx = new MText();
                            id = Convert.ToInt32(dr["Id"]);
                            insPtX = Convert.ToDouble(dr["InsPtX"]);
                            insPtY = Convert.ToDouble(dr["InsPtY"]);
                            Point3d insPt = new Point3d(insPtX, insPtY, 0);
                            layer = dr["Layer"].ToString();
                            //ed.WriteMessage(layer);
                            style = dr["TextStyle"].ToString();
                            height = Convert.ToDouble(dr["Height"]);
                            width = Convert.ToDouble(dr["Width"]);
                            txt = dr["Text"].ToString();
                            attPt = Convert.ToInt32(dr["Attachment"]);
                            
                            // Set the current Textstyle
                            db.Textstyle = stTab[style];
                            mtx.TextStyleId = db.Textstyle;
                            mtx.Layer = layer;
                            mtx.Contents = txt;
                            mtx.TextHeight = height;
                            mtx.Width = width;
                            mtx.Location = insPt;
                            mtx.Attachment = (AttachmentPoint)attPt;
                            
                            btr.AppendEntity(mtx);
                            trans.AddNewlyCreatedDBObject(mtx, true);
                            CommonUtil.AddXDataToEntity("CADDB", mtx, id);
                        }
                        trans.Commit();
                    }
                }
                result = "Done. Completed successfully!";
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






        internal string RetrieveAndDrawMTexts()
        {
            string result = null;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = DBUtil.GetConnection();
                string sql = "SELECT Id, InsPtX, InsPtY, Layer, Color, TextStyle, Height, Width, Text, Attachment FROM dbo.MTexts WHERE IsDeleted IS NULL";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Document doc = Application.DocumentManager.MdiActiveDocument;
                    Database db = doc.Database;
                    Editor ed = doc.Editor;

                    doc.LockDocument();
                    using (Transaction tr = db.TransactionManager.StartTransaction())
                    {
                        ed.WriteMessage("Drawing MTexts");
                        BlockTable bt = tr.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;
                        BlockTableRecord btr = tr.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;

                        int id = 0;
                        double insPtX = 0.0, insPtY = 0.0;
                        string layer = "", color = "", txtStyle = "", text = "";
                        double height = 0.0, width = 0.0;
                        int attachment = 0;
                        TextStyleTable textStyleTable = tr.GetObject(db.TextStyleTableId, OpenMode.ForRead) as TextStyleTable;
                        //double[] coords = new double[2];
                        foreach (DataRow row in dt.Rows)
                        {

                            id = Convert.ToInt32(row["Id"]);
                            ed.WriteMessage("\nMTexts" + id);
                            
                            insPtX = Convert.ToDouble(row["InsPtX"]);
                            insPtY = Convert.ToDouble(row["InsPtY"]);
                            Point3d insPt = new Point3d(insPtX, insPtY, 0);

                            layer = row["layer"].ToString(); // "Layer" ?
                            //color = row["color"].ToString();
                            txtStyle = row["TextStyle"].ToString();
                            height = Convert.ToDouble(row["Height"]);
                            width = Convert.ToDouble(row["Width"]);
                            text = row["Text"].ToString();
                            attachment = Convert.ToInt32(row["Attachment"]);

                            MText mText = new MText();
                            mText.Layer = layer;
                            //mText.ColorIndex = CommonUtil.GetColorIndex(color);//
                            // Set the current text style
                            db.Textstyle = textStyleTable[txtStyle];
                            mText.TextStyleId = db.Textstyle;
                            // 
                            mText.Contents = text;
                            mText.TextHeight = height; // Height != TextHeight
                            mText.Width = width;
                            mText.Location = insPt;
                            mText.Attachment = (AttachmentPoint)attachment;

                            btr.AppendEntity(mText);
                            tr.AddNewlyCreatedDBObject(mText, true);
                            CommonUtil.AddXDataToEntity("CADDB", mText, id);
                        }

                        tr.Commit();
                    }
                }
                result = "Done. Completed retrieve MTexts from CADDB";
            }
            catch (Exception ex)
            {
                result = "Error found: " + ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }


            return result;
        }






        public string RetrieveAndDrawPLines()
        {
            string result = "";
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = DBUtil.GetConnection();
                string sql = "SELECT Id, Layer, LineType, Length, Coordinates, IsClosed FROM dbo.PLines WHERE IsDeleted IS NULL";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Document doc = Application.DocumentManager.MdiActiveDocument;
                    Database db = doc.Database;
                    Editor ed = doc.Editor;

                    doc.LockDocument();
                    using (Transaction trans = db.TransactionManager.StartTransaction())
                    {
                        doc.Editor.WriteMessage("Drawing PLines!");
                        BlockTable bt = trans.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;
                        BlockTableRecord btr = trans.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;

                        int id;
                        string layer = "", ltype = "", coords = "";
                        string[] vertices;
                        double length = 0.0;
                        double PtX = 0.0, PtY = 0.0;
                        bool IsClosed = false;
                        foreach (DataRow dr in dt.Rows)
                        {
                            id = Convert.ToInt32(dr["Id"]);
                            layer = dr["Layer"].ToString();
                            ltype = dr["LineType"].ToString();
                            coords = dr["Coordinates"].ToString();
                            vertices = coords.Split(',');
                            IsClosed = Convert.ToBoolean(dr["IsClosed"]);

                            Polyline pl = new Polyline();
                            Point2d pt;
                            int j = 0;
                            // get a pair at a time
                            for (int i = 0; i <= vertices.Length - 2; i += 2)   // <=
                            {
                                PtX = Convert.ToDouble(vertices[i]);
                                PtY = Convert.ToDouble(vertices[i + 1]);
                                pt = new Point2d(PtX, PtY);
                                pl.AddVertexAt(j, pt, 0, 0, 0);
                                j += 1;
                            }
                            if (IsClosed) { pl.Closed = true; }
                            pl.Layer = layer;
                            pl.Linetype = ltype;

                            btr.AppendEntity(pl);
                            trans.AddNewlyCreatedDBObject(pl, true);
                            CommonUtil.AddXDataToEntity("CADDB", pl, id);
                        }
                        trans.Commit();
                    }
                }
                result = "Done. Completed retrieve and draw polylines successfully!";
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







        public string RetrieveAndDrawBlocksNoAttribute()
        {
            string result = "";
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = DBUtil.GetConnection();
                string sql = "SELECT Id, InsertionPt, BlockName, Layer, Rotation FROM dbo.BlocksNoAttribute WHERE IsDeleted IS NULL";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Document doc = Application.DocumentManager.MdiActiveDocument;
                    Database db = doc.Database;
                    Editor ed = doc.Editor;

                    doc.LockDocument();
                    using (Transaction trans = db.TransactionManager.StartTransaction())
                    {
                        doc.Editor.WriteMessage("Drawing Blocks No Attribute!");
                        BlockTable bt = trans.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;
                        BlockTableRecord btr = trans.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;

                        int id;
                        string layer = "", blkName = "", insertionPt = "";
                        string[] insPt;
                        double insPtX = 0.0, insPtY = 0.0;
                        double rotation = 0.0;
                        foreach (DataRow dr in dt.Rows)
                        {
                            id = Convert.ToInt32(dr["Id"]);
                            insertionPt = dr["InsertionPt"].ToString();
                            insPt = insertionPt.Split(',');
                            insPtX = Convert.ToDouble(insPt[0]);
                            insPtY = Convert.ToDouble(insPt[1]);
                            Point3d insPoint = new Point3d(insPtX, insPtY, 0);
                            blkName = dr["BlockName"].ToString();
                            layer = dr["Layer"].ToString();
                            rotation = Convert.ToDouble(dr["Rotation"]);
                            ObjectId blkId = bt[blkName];

                            BlockReference blk = new BlockReference(insPoint, blkId);
                            blk.Layer = layer;
                            blk.Rotation = rotation;
                            
                            btr.AppendEntity(blk);
                            trans.AddNewlyCreatedDBObject(blk, true);
                            CommonUtil.AddXDataToEntity("CADDB", blk, id);
                        }
                        trans.Commit();
                    }
                }
                result = "Done. Completed retrieve and draw Blocks No Attribute successfully!";
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





        public string RetrieveAndDrawBlocksWithAttributes()
        {
            string result = "";
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = DBUtil.GetConnection();
                string sql = "SELECT Id, InsertionPt, BlockName, Layer, Rotation, Attributes FROM dbo.BlocksWithAttributes WHERE IsDeleted IS NULL";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Document doc = Application.DocumentManager.MdiActiveDocument;
                    Database db = doc.Database;
                    Editor ed = doc.Editor;

                    doc.LockDocument();
                    using (Transaction trans = db.TransactionManager.StartTransaction())
                    {
                        doc.Editor.WriteMessage("Drawing Blocks With Attributes!");
                        BlockTable bt = trans.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;
                        BlockTableRecord btr = trans.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;

                        int id;
                        string layer = "", blkName = "", insertionPt = "";
                        string[] insPt;
                        double insPtX = 0.0, insPtY = 0.0;
                        double rotation = 0.0;
                        foreach (DataRow dr in dt.Rows)
                        {
                            id = Convert.ToInt32(dr["Id"]);
                            insertionPt = dr["InsertionPt"].ToString();
                            insPt = insertionPt.Split(',');
                            insPtX = Convert.ToDouble(insPt[0]);
                            insPtY = Convert.ToDouble(insPt[1]);
                            Point3d insPoint = new Point3d(insPtX, insPtY, 0);
                            blkName = dr["BlockName"].ToString();
                            layer = dr["Layer"].ToString();
                            rotation = Convert.ToDouble(dr["Rotation"]);
                            ObjectId blkId = bt[blkName];

                            BlockReference blk = new BlockReference(insPoint, blkId);
                            blk.Layer = layer;
                            blk.Rotation = rotation;

                            btr.AppendEntity(blk);
                            trans.AddNewlyCreatedDBObject(blk, true);
                            CommonUtil.AddXDataToEntity("CADDB", blk, id);
                        }
                        trans.Commit();
                    }
                }
                result = "Done. Completed retrieve and draw Blocks With Attributes successfully!";
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


    }
}
