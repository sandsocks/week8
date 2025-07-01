using UnityEngine;

public class Coords
{
    float x;
    float y;
    float z;

    public Coords(float _x, float _y)
    {
        x = _x;
        y = _y;
        z = -1;             //initial depth in z as -1
    }

    static public void DrawLine(Coords startPos, Coords endPos, float width, Color colour)
    {
        //create game object with two points
        GameObject line = new GameObject("Line" + startPos.ToString() + endPos.ToString());

        //add component to render the line
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();

        //create and assign material to line renderer
        lineRenderer.material = new Material(Shader.Find("Universal Render Pipeline/Lit"));
        lineRenderer.material.color = colour;       //to assign color
        lineRenderer.positionCount = 2; //two points define straight line

        //Define start position of line
        lineRenderer.SetPosition(0, new Vector3(startPos.x, startPos.y, startPos.z));

        //Define end position of line
        lineRenderer.SetPosition(1, new Vector3(endPos.x, endPos.y, endPos.z));
        lineRenderer.startWidth = width;            //start width
        lineRenderer.endWidth = width;              //end width
    }
    
    static public void DrawPoint(Coords pointPosition, float width, Color colour)
    {
            //create game object with two points
        GameObject line = new GameObject("Line" + pointPosition.ToString());

            //add component to render the line
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();

            //create and assign material to line renderer
        lineRenderer.material = new Material(Shader.Find("Universal Render Pipeline/Lit"));
        lineRenderer.material.color = colour;       //to assign color
        lineRenderer.positionCount = 2; //two points define straight line

            //Define start position of point
        lineRenderer.SetPosition(0, new Vector3(pointPosition.x - width /3.0f, pointPosition.y - width/3.0f, pointPosition.z));
            //Define end position of line
        lineRenderer.SetPosition(1, new Vector3(pointPosition.x + width /3.0f, pointPosition.y + width/3.0f, pointPosition.z));
        lineRenderer.startWidth = width;            //start width
        lineRenderer.endWidth = width;              //end width
    }
}