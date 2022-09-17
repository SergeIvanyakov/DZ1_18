using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject obj;
              
    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "SSphere") 
        { 
            Debug.Log("BOOM!!!!!");
        } 
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.name == "SSphere")
        {
            Debug.Log("Exit!!!!!");
        }
    }
}
