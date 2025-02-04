using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToCube : MonoBehaviour
{

    void Start()
    {
        // Find position of the other GameObject (you can use GameObject.Find to do this)
        Vector3 CubePos = GameObject.Find("Cube").transform.position;

        MyVector3 CubePos2 = new MyVector3(CubePos.x, CubePos.y, CubePos.z);

        Debug.Log(CubePos);

        // Use the other GameObject position and the position of itself(transform.position) to determine a direction from its position to the other GameObject
        Vector3 SpherePos = GameObject.Find("Sphere").transform.position;

        MyVector3 SpherePos2 = new MyVector3(SpherePos.x, SpherePos.y, SpherePos.z);

        Debug.Log(SpherePos);

        /* Apply this direction to the transform.position of this object, so that it will immediately move to the position of the other object 
        (this will happen in a single frame and as such appear to have “teleported”, but this is fine for now)*/
        //stay - move = movement add movement to move

        MyVector3 movement = MyVector3.SubtractingVector3(CubePos2, SpherePos2);

        MyVector3 newcoords = MyVector3.AddingVectors3(movement, SpherePos2);

        gameObject.transform.position = newcoords.ToUnityVector();

        Debug.Log(movement.ToUnityVector());
        Debug.Log(newcoords.ToUnityVector());

        //Make it so this happens on a Key Press
    }




}
