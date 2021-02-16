using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketForce : MonoBehaviour
{
    [SerializeField]
    int MovementSpeed;
    [SerializeField]
    KeyCode keyPositive;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(keyPositive))
            transform.position += transform.up * Time.deltaTime * MovementSpeed;
    }
}