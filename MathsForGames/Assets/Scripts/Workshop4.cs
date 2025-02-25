using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workshop4
{
    public static Vector3 LerpValue(Vector3 A, Vector3 B, float T)
    {
        return A * (1.0f - T)+B*T;
    }
}
