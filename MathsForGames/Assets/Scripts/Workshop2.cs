using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workshop2
{

    //Create a static function that takes in a vector and a scalar and returns a new vector that has been multiplied by the scalar
    public static MyVector3 Scaling_Vectors(MyVector3 vectorA, float scalar)
    {
        MyVector3 vector_scaled = new MyVector3(0f, 0f,0f);

        vector_scaled.x = vectorA.x * scalar;
        vector_scaled.y = vectorA.y * scalar;
        vector_scaled.z = vectorA.z * scalar;

        return vector_scaled;

    }

    //Create a static function that takes in a vector and a divisor and returns a new vector that has been divided by the divisor
    public static MyVector3 Dividing_Vectors(MyVector3 vectorA, float divisor)
    {
        MyVector3 vector_divided = new MyVector3(0f, 0f, 0f);

        vector_divided.x = vectorA.x / divisor;
        vector_divided.y = vectorA.y / divisor;
        vector_divided.z = vectorA.z / divisor;

        return vector_divided;
    }

    //Create a static function that takes in one vector and returns that vector normalized. You will need do step 3 before you can do this.
    public static MyVector3 Normalising_Vectors(MyVector3 vectorA)
    {
        MyVector3 vector_normalised = new MyVector3(0f, 0f, 0f);

        vector_normalised = Dividing_Vectors(vectorA, vectorA.Vector3Length());

        return vector_normalised;
    }

    //Create a static function that takes in two vectors and returns the dot product of those two vectors. You could add a Boolean argument to normalize it if necessary before the dot product
    public static float DotProduct(MyVector3 vectorA, MyVector3 vectorB, bool should_normalise = true)
    {
        float dotProduct = 0f;

        MyVector3 vectorA_normalised = new MyVector3(0f, 0f, 0f);
        MyVector3 vectorB_normalised = new MyVector3(0f, 0f, 0f);

        if (should_normalise)
        {
            vectorA_normalised = Normalising_Vectors(vectorA);
            vectorB_normalised = Normalising_Vectors(vectorB);
        }

        dotProduct = (vectorA_normalised.x * vectorB_normalised.x + vectorA_normalised.y * vectorB_normalised.y);

        return dotProduct;
    }
}
