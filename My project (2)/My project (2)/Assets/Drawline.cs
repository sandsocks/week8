using UnityEngine;

public class Drawline : MonoBehaviour
{
    Coords startPointX = new Coords(-160, 0);
    Coords endPointX = new Coords(160, 0);
    Coords startPointY = new Coords(0, 100);
    Coords endPointY = new Coords(0, -100);
    Coords point = new Coords(10, 20);
    Coords[] pointArray =
    {
        new Coords(50,-50),//1
        new Coords(0,-40),//2
        new Coords(-5,-20),//3
        new Coords(-20,0),//4
        new Coords(60,-30),//5
        new Coords(-30,-10),//6
        new Coords(-30,10),//7
        new Coords(-10,5),//8
        new Coords(10,15),//9
        new Coords(-5,25),//10
        new Coords(25,30),//11
        new Coords(30,0),//12
        new Coords(35,-15),//13
        new Coords(45,-5),//14
        new Coords(60,0),//15
        new Coords(68,3)//16
    };
    void Start()
    {
        Coords.DrawLine(startPointX, endPointX, 1, Color.red);
        Coords.DrawLine(startPointY, endPointY, 1, Color.blue);

        //Coords.DrawPoint(point, 2, Color.white);

        foreach (var p in pointArray)
        {
            Coords.DrawPoint(p, 2, Color.white);
        }

        Coords.DrawLine(pointArray[0], pointArray[1], 0.5f, Color.green);
        Coords.DrawLine(pointArray[1], pointArray[2], 0.5f, Color.green);
        Coords.DrawLine(pointArray[2], pointArray[4], 0.5f, Color.green);
        Coords.DrawLine(pointArray[2], pointArray[3], 0.5f, Color.green);
        Coords.DrawLine(pointArray[3], pointArray[5], 0.5f, Color.green);
        Coords.DrawLine(pointArray[3], pointArray[7], 0.5f, Color.green);
        Coords.DrawLine(pointArray[7], pointArray[8], 0.5f, Color.green);
        Coords.DrawLine(pointArray[3], pointArray[6], 0.5f, Color.green);
        Coords.DrawLine(pointArray[8], pointArray[9], 0.5f, Color.green);
        Coords.DrawLine(pointArray[8], pointArray[10], 0.5f, Color.green);
        Coords.DrawLine(pointArray[8], pointArray[11], 0.5f, Color.green);
        Coords.DrawLine(pointArray[11], pointArray[12], 0.5f, Color.green);
        Coords.DrawLine(pointArray[11], pointArray[13], 0.5f, Color.green);
        Coords.DrawLine(pointArray[13], pointArray[14], 0.5f, Color.green);
        Coords.DrawLine(pointArray[14], pointArray[15], 0.5f,Color.green);
    }
}