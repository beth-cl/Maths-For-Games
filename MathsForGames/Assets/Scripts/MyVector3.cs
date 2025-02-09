using System.Collections.Generic;
using UnityEngine;

public class MyVector3
{
    public float x, y, z;


    public MyVector3(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;

    }


    //Create a static function that takes in two MyVector3 objects, adds them together, and returns the resulting vector
    public static MyVector3 AddingVectors3(MyVector3 vectorA, MyVector3 vectorB)
    {
        MyVector3 vectorC = new MyVector3(0f, 0f, 0f);

        vectorC.x = vectorA.x + vectorB.x;
        vectorC.y = vectorA.y + vectorB.y;
        vectorC.z = vectorA.z + vectorB.z;

        return vectorC;
    }

    //Create a static function that takes in two MyVector3 objects, and subtracts them, and returns the resulting vector
    public static MyVector3 SubtractingVector3(MyVector3 vectorA, MyVector3 vectorB)
    {
        MyVector3 vectorC = new MyVector3(0f, 0f, 0f);

        vectorC.x = vectorA.x - vectorB.x;
        vectorC.y = vectorA.y - vectorB.y;
        vectorC.z = vectorA.z - vectorB.z;

        return vectorC;
    }

    //Create a function inside MyVector3 that returns the magnitude or length of that vector

    public float Vector3Length()
    {
        float vectorC = Mathf.Sqrt(x*x + y*y + z*z);

        return vectorC;
    }


    // Workshop 2 Create a static function that takes in one vector and returns the length/magnitude squared
    public float LengthSq()
    {
        float rv;
        rv = x * x + y * y + z * z;
        return rv;

    }

    //Create a function inside MyVector3 that converts your class object into a UnityEngine.Vector3(this will be needed for the next part)

    public Vector3 ToUnityVector()
    {
        Vector3 vectorC = new Vector3(x,y,z);

        return vectorC;
    }


}
