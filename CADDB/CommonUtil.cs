using System;

using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
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

            for (int i = 0; i < vCount - 1; i++)
            {
                coord = pl.GetPoint2dAt(i);
                coords += coord[0].ToString() + "," + coord[1].ToString();
                if (i < vCount - 1)  coords += ",";
            }
            return coords;
        }
    }
}
