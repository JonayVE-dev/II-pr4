using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody body;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate() 
    {
        float horizontalForce = Input.GetAxis("Horizontal") * speed;
        float verticalForce = Input.GetAxis("Vertical") * speed;
        body.AddForce(new Vector3(horizontalForce, 0, verticalForce));
    }   
}
