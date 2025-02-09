using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Today you will be required to make the first GameObject move at a constant or variable speed towards its target, instead of instantly moving towards the target.
 * This GameObject we will call the “Pursuer”
 * Make it so the second game object (the one being chased) can move around (either through keyboard input or randomly through code). We will call this GameObject the “Evader”
 * EXTRA: Make it so the Pursuer will only chase the evader when the evader is moving away from the pursuer (you will need dot products and velocities for this one)
 * Anything else cool you can think of!
 */

public class W2_Pursuer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movePersuer();
        
    }

    public void movePersuer()
    {
        //Get the vectors of the objects
        Vector3 EvaderPos = GameObject.Find("Evader").transform.position;
        MyVector3 MyEvaderPos = new MyVector3(EvaderPos.x,EvaderPos.y,EvaderPos.z);

        Vector3 PursuerPos = gameObject.transform.position;
        MyVector3 MyPursuerPos = new MyVector3(PursuerPos.x,PursuerPos.y,PursuerPos.z);

        // Normalise the vectors of the GameObjects
        //MyEvaderPos = Workshop2.Normalising_Vectors(MyEvaderPos);
        MyPursuerPos = Workshop2.Normalising_Vectors(MyPursuerPos);

        // Move the Pursuer by the normalised amount
        MyVector3 movement = MyVector3.SubtractingVector3(MyEvaderPos, MyPursuerPos);
        //MyVector3 movement = Workshop2.Scaling_Vectors(MyVector3.SubtractingVector3(MyEvaderPos, MyPursuerPos), 5.0f);
        MyVector3 newcoords = Workshop2.Scaling_Vectors(MyVector3.AddingVectors3(movement, MyPursuerPos), 2);

        gameObject.transform.position = newcoords.ToUnityVector();
    }

}
