using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workshop3
{

    /*Create a static function that takes in a Vector2 (or MyVector2 if you made one) 
     * and returns the angle of that Vector2 as a float (in radians, NOT degrees!)*/
    public static float VectorToRadians(MyVector2 V)
    {
        float rv = 0.0f;

        //rv = Mathf.Atan(V.y / V.x);

        rv = Mathf.Atan2(V.y, V.x);

        return rv;
    }


    /*Create a static function that takes in an angle (in radians) as a float 
     * and returns a Vector2 (or MyVector2) that represents the direction of that angle*/
    public static MyVector2 RadiansToVector(float angle)
    {
        MyVector2 rv = new MyVector2(0f,0f);

        rv.x = Mathf.Cos(angle);
        rv.y = Mathf.Sin(angle);

        return rv;
    }


    /*Create a static function that takes in an Euler Angle (pitch, yaw and roll as radians) 
 * and returns a Vector3 (or MyVector3) that represents that Euler rotation as a directional vector*/

    public static MyVector3 EulerAnglesToDirection(MyVector3 EulerAngles)
    {
        MyVector3 rv = new MyVector3(0f, 0f, 0f);

        rv.x = Mathf.Cos(EulerAngles.y) * Mathf.Cos(EulerAngles.x);
        rv.y = Mathf.Sin(EulerAngles.x);
        rv.z = Mathf.Cos(EulerAngles.x) * Mathf.Sin(EulerAngles.y);

        return rv;
    }

    /*Create a static function that takes in two MyVector3 arguments,
     * and returns the Cross Product of those two as a Vector3 (or MyVector3)*/
     public static MyVector3 VectorCrossProduct(MyVector3 A, MyVector3 B)
    {
        MyVector3 C = new MyVector3(0f, 0f, 0f);

        C.x = A.y * B.z - A.z * B.y;
        C.y = A.z *B.x - A.x * B.z;
        C.z = A.x * B.y - A.y * B.x;

        return C;
    }
}


//workshop 4
public class Matrix4by4
{
    public float[,] values;
    public Matrix4by4(Vector4 column1, Vector4 column2, Vector4 column3, Vector4 column4)
    {
        values = new float[4, 4];
         
    }
    public Matrix4by4(MyVector3 column1, MyVector3 column2, MyVector3 column3, MyVector3 column4)
    {

    }

    public static Vector4 operator *(Matrix4by4 lhs, Vector4 rhs)
    {
        return Vector4.zero;
    }

}