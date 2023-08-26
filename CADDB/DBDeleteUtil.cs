using System;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using System.Data.SqlClient;
using System.Data;

namespace CADDB
{
    public class DBDeleteUtil
    {
        public string DeleteLines()
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
                    PromptEntityResult ers = ed.GetEntity("Pick a Line to delete: ");
                    Line line = (Line)trans.GetObject(ers.ObjectId, OpenMode.ForWrite);
                    if (line != null)
                    {
                        int id = 0;
                        string sql = "";
                        id = CommonUtil.ReadXDataFromEntity("CADDB", line);
                        
                        // This is using hard delete method (deleting record physically)
                        //sql = @"DELETE FROM dbo.Lines WHERE id = @Id";

                        // This is using soft delete method (updating the IsDeleted status to 1 and not deleting record)
                        sql = @"UPDATE dbo.Lines " +
                               "SET IsDeleted = @isDeleted, Deleted = @Deleted WHERE id = @Id";

                        conn.Open();

                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@IsDeleted", 1);
                        cmd.Parameters.AddWithValue("@Deleted", DateTime.Now);
                        cmd.ExecuteNonQuery();

                        // Delete the object from AutoCAD physically
                        line.Erase();
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

        public string DeleteMTexts()
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
                    PromptEntityResult ers = ed.GetEntity("Pick MText to delete: ");
                    MText mtx = (MText)trans.GetObject(ers.ObjectId, OpenMode.ForWrite);
                    if (mtx != null)
                    {
                        int id;
                        string sql = "";
                        id = CommonUtil.ReadXDataFromEntity("CADDB", mtx);

                        // This is using hard delete method (deleting record physically)
                        // sql = @"DELETE FROM dbo.MTexts WHERE id = @Id";

                        // This is using soft delete method (updating the IsDeleted status to 1 and not deleting record)
                        sql = @"UPDATE dbo.MTexts " +
                               "SET IsDeleted = @isDeleted, Deleted = @Deleted WHERE id = @Id";

                        conn.Open();

                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@IsDeleted", 1);
                        cmd.Parameters.AddWithValue("@Deleted", DateTime.Now);
                        cmd.ExecuteNonQuery();

                        // Delete the object from AutoCAD physically
                        mtx.Erase();
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

        public string DeleteCircles()
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
                    PromptEntityResult ers = ed.GetEntity("Pick a Circle to delete: ");
                    Circle cir = (Circle)trans.GetObject(ers.ObjectId, OpenMode.ForWrite);
                    if (cir != null)
                    {
                        int id;
                        string sql = "";
                        id = CommonUtil.ReadXDataFromEntity("CADDB", cir);

                        // This is using hard delete method (deleting record physically)
                        // sql = @"DELETE FROM dbo.Circles WHERE id = @Id";

                        // This is using soft delete method (updating the IsDeleted status to 1 and not deleting record)
                        sql = @"UPDATE dbo.Circles " +
                               "SET IsDeleted = @isDeleted, Deleted = @Deleted WHERE id = @Id";

                        conn.Open();

                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@IsDeleted", 1);
                        cmd.Parameters.AddWithValue("@Deleted", DateTime.Now);
                        cmd.ExecuteNonQuery();

                        // Delete the object from AutoCAD physically
                        cir.Erase();
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

        public string DeletePlines()
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
                    PromptEntityResult ers = ed.GetEntity("Pick a Pline to delete: ");
                    Polyline pline = (Polyline)trans.GetObject(ers.ObjectId, OpenMode.ForWrite);
                    if (pline != null)
                    {
                        int id = 0;
                        string sql = "";
                        id = CommonUtil.ReadXDataFromEntity("CADDB", pline);

                        // This is using hard delete method (deleting record physically)
                        //sql = @"DELETE FROM dbo.Plines WHERE id = @Id";

                        // This is using soft delete method (updating the IsDeleted status to 1 and not deleting record)
                        sql = @"UPDATE dbo.Plines " +
                               "SET IsDeleted = @isDeleted, Deleted = @Deleted WHERE id = @Id";

                        conn.Open();

                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@IsDeleted", 1);
                        cmd.Parameters.AddWithValue("@Deleted", DateTime.Now);
                        cmd.ExecuteNonQuery();

                        // Delete the object from AutoCAD physically
                        pline.Erase();
                        trans.Commit();
                    }
                }
                result = "Done. Completed Delete_Plines successfully!";
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

        public string DeleteBlocksNoAttribute()
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
                    PromptEntityResult ers = ed.GetEntity("Pick a Block (no attribute) to delete: ");
                    BlockReference blk = (BlockReference)trans.GetObject(ers.ObjectId, OpenMode.ForWrite);
                    if (blk != null)
                    {
                        int id;
                        string sql = "";
                        id = CommonUtil.ReadXDataFromEntity("CADDB", blk);

                        // This is using hard delete method (deleting record physically)
                        // sql = @"DELETE FROM dbo.BlocksNoAttribute WHERE id = @Id";

                        // This is using soft delete method (updating the IsDeleted status to 1 and not deleting record)
                        sql = @"UPDATE dbo.BlocksNoAttribute " +
                               "SET IsDeleted = @isDeleted, Deleted = @Deleted WHERE id = @Id";

                        conn.Open();

                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@IsDeleted", 1);
                        cmd.Parameters.AddWithValue("@Deleted", DateTime.Now);
                        cmd.ExecuteNonQuery();

                        // Delete the object from AutoCAD physically
                        blk.Erase();
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

        public string DeleteBlocksWithAttributes()
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
                    PromptEntityResult ers = ed.GetEntity("Pick a Block (with attribute) to delete: ");
                    BlockReference blk = (BlockReference)trans.GetObject(ers.ObjectId, OpenMode.ForWrite);
                    if (blk != null)
                    {
                        int id;
                        string sql = "";
                        id = CommonUtil.ReadXDataFromEntity("CADDB", blk);

                        // This is using hard delete method (deleting record physically)
                        // sql = @"DELETE FROM dbo.BlocksWithAttributes WHERE id = @Id";

                        // This is using soft delete method (updating the IsDeleted status to 1 and not deleting record)
                        sql = @"UPDATE dbo.BlocksWithAttributes " +
                               "SET IsDeleted = @isDeleted, Deleted = @Deleted WHERE id = @Id";

                        conn.Open();

                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@IsDeleted", 1);
                        cmd.Parameters.AddWithValue("@Deleted", DateTime.Now);
                        cmd.ExecuteNonQuery();

                        // Delete the object from AutoCAD physically
                        blk.Erase();
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
    }
}
