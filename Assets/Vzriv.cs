using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vzriv : MonoBehaviour
{
    public Rigidbody[] rbs = new Rigidbody[4];
    public float forse;
    public Transform other;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Explode();
    }

    private void Explode()
    {
        var point = transform.position;
        float dist = Vector3.Distance(other.position, transform.position);
        if (dist < 1.1)
        {
            for (int i = 0; i < rbs.Length; i++)
            {
                var offset = rbs[i].position - point;
                var ang = offset.normalized;
                rbs[i].AddForce(ang * forse, ForceMode.Impulse);
            }
        }

    }
}
