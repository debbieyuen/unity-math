using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class ComponentwiseVector : MonoBehaviour
{
    void ComponentwiseVectorMultiplyClassic()
    {
        var v0 = new Vector4(2.0f, 4.0f, 6.0f, 8.0f);
        var v1 = new Vector4(1.0f, -1.0f, 1.0f, -1.0f);
        var result = Vector4.Scale(v0, v1);
        // result == new Vector4(2.0f, -4.0f, 6.0f, -8.0f).
    }

    void ComponentwiseVectorMultiplyUnityMathematics()
    {
        var v0 = new float4(2.0f, 4.0f, 6.0f, 8.0f);
        var v1 = new float4(1.0f, -1.0f, 1.0f, -1.0f);
        var result = v0 * v1;
        // result == new Vector4(2.0f, -4.0f, 6.0f, -8.0f).
    }
}
