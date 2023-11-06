using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class Random : MonoBehaviour
{
    void RandomNumberClassic()
    {
        float randomFloat1 = UnityEngine.Random.value;
        float randomFloat2 = UnityEngine.Random.Range(-5.0f, 5.0f);
    }

    void RandomNumberUnityMathematics()
    {
        uint seed = 1;
        Unity.Mathematics.Random rng = new Unity.Mathematics.Random(seed);
        float randomFloat1 = rng.NextFloat();
        float randomFloat2 = rng.NextFloat(-5.0f, 5.0f);
    }
}
