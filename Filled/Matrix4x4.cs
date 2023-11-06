using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class Matrix4x4 : MonoBehaviour
{
    void Build4x4Classic()
    {
        var c0 = new Vector4(1.0f, 0.0f, 0.0f, 0.0f);
        var c1 = new Vector4(0.0f, 1.0f, 0.0f, 0.0f);
        var c2 = new Vector4(0.0f, 0.0f, 1.0f, 0.0f);
        var c3 = new Vector4(0.0f, 0.0f, 0.0f, 1.0f);
        var m = new Matrix4x4(c0, c1, c2, c3);
    }
    void Build4x4UnityMathematics()
    {
        var c0 = new float4(1.0f, 0.0f, 0.0f, 0.0f);
        var c1 = new float4(0.0f, 1.0f, 0.0f, 0.0f);
        var c2 = new float4(0.0f, 0.0f, 1.0f, 0.0f);
        var c3 = new float4(0.0f, 0.0f, 0.0f, 1.0f);
        var m = new float4x4(c0, c1, c2, c3);
    }
}
