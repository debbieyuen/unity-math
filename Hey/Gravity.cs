using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = (target.position +
            new Vector3(0, .5f, 0)) - transform.position;
        // store it in a quaternion variable
        Quaternion rotation = Quaternion.LookRotation(relativePos);

        Quaternion current = transform.localRotation;

        // rotation doesn't happen immediately
        transform.localRotation = Quaternion.Slerp(
            current, rotation, Time.deltaTime);
        transform.Translate(0, 0, 3 * Time.deltaTime);

    }
}
