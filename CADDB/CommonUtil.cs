using System;

using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;

namespace CADDB
{
    public static class CommonUtil
    {
        // Get all the vertices of the polyline and return it to the calling method in comma seperated value
        public static string GetPolylineCoordinates(Polyline pl)
        {
            var vCount = pl.NumberOfVertices;
            Point2d coord;
            string coords = "";

            for (int i = 0; i <= vCount - 1; i++)
            {
                coord = pl.GetPoint2dAt(i);
                coords += coord[0].ToString() + "," + coord[1].ToString();
                if (i < vCount - 1)  coords += ",";
            }
            return coords;
        }

        internal static void AddXDataToEntity(string appName, Entity ent, int xdValue)
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;

            using (Transaction tr = db.TransactionManager.StartTransaction())
            {
                // Get the registered application names table
                RegAppTable regTable = tr.GetObject(db.RegAppTableId, OpenMode.ForRead) as RegAppTable;
                if (!regTable.Has(appName))
                {
                    regTable.UpgradeOpen();
                    // Add the application name to Xdata
                    RegAppTableRecord regAppTableRecord = new RegAppTableRecord();
                    regAppTableRecord.Name = appName;
                    regTable.Add(regAppTableRecord);
                    tr.AddNewlyCreatedDBObject(regAppTableRecord, true);
                }
                // Append the Xdata to entity
                ResultBuffer rb = new ResultBuffer(
                    new TypedValue(1001, appName), 
                    new TypedValue((int)DxfCode.ExtendedDataInteger32, xdValue));
                ent.XData = rb;
                rb.Dispose();
                tr.Commit();
            }
        }

        internal static int GetColorIndex(string colorName)
        {
            int color = 7;  // white
            switch (colorName.ToUpper())
            {
                case "RED":
                    color = 1;
                    break;
                case "YELLOW":
                    color = 2;
                    break;
                case "GREEN":
                    color = 3;
                    break;
                case "CYAN":
                    color = 4;
                    break;
                case "BLUE":
                    color = 5;
                    break;
                case "MAGENTA":
                    color = 6;
                    break;
                case "WHITE":
                    color = 7;
                    break;
                case "BYBLOCK":
                    color = 0;
                    break;
                case "BYLAYER":
                    color = 256;
                    break;
                default:
                    color = 256;
                    break;
            }
            return color;
        }
    }
}
