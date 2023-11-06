using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class Quaternion : MonoBehaviour
{
    void QuaternionMultiplicationClassic()
    {
        var axis = Vector3.up;
        var q = Quaternion.AngleAxis(45.0f, axis);
        var orientation = Quaternion.Euler(45.0f, 90.0f, 180.0f);
        var result = q * orientation;
    }
    void QuaternionMultiplicationUnityMathematics()
    {
        var axis = new float3(0.0f, 1.0f, 0.0f);
        var q = quaternion.AxisAngle(axis, math.radians(45.0f));
        var orientation = quaternion.Euler(
            math.radians(45.0f),
            math.radians(90.0f),
            math.radians(180.0f));
        var result = math.mul(q, orientation);
    }
}
