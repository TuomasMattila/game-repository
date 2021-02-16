using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private float rotSpeed = 1000.0f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Rotate the object around its local X axis
        if(Input.GetKey(KeyCode.W))
            transform.Rotate(Vector3.right * rotSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.Rotate(Vector3.left * rotSpeed * Time.deltaTime);

        // Rotate the object around its local Y axis
        if(Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);
        if(Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.down * rotSpeed * Time.deltaTime);

        // Rotate the object around its local Z axis
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.forward * rotSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.back * rotSpeed * Time.deltaTime);
    }
}
