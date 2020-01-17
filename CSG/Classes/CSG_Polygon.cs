using UnityEngine;
using System.Collections.Generic;

namespace Parabox.CSG
{
    /// <summary>
    /// Represents a polygon face with an arbitrary number of vertices.
    /// </summary>
    sealed class CSG_Polygon
    {
        public List<CSG_Vertex> vertices;
        public CSG_Plane plane;
        public int subMeshIndex;

        public CSG_Polygon(List<CSG_Vertex> list, int subMeshIndex)
        {
            vertices = list;
            plane = new CSG_Plane(list[0].position, list[1].position, list[2].position);
            this.subMeshIndex = subMeshIndex;
        }

        public void Flip()
        {
            vertices.Reverse();

            for (int i = 0; i < vertices.Count; i++)
                vertices[i].Flip();

            plane.Flip();
        }

        public override string ToString()
        {
            return "normal: " + plane.normal;
        }
    }
}
