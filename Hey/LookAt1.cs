using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt1 : MonoBehaviour
{
    // Get our target
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(relativePos);
    }
}
