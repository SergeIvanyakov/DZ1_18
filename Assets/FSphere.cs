using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSphere : MonoBehaviour
{
    public Vector3 force;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = force;
        rb.AddForce(force, ForceMode.VelocityChange);
        

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        
        
    }


}
