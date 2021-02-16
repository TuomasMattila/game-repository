using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public KeyCode keyLeft;
    public KeyCode keyRight;
    public Quaternion rotRotation;

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(keyLeft))
        //    GetComponent<Rigidbody>().rotation.eulerAngles += rotRotation.eulerAngles;
    }
}
