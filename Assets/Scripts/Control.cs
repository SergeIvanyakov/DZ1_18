using UnityEngine;

public class Control : MonoBehaviour
{
    private Vector3 _nachalnoePolojenieMouse;

    public Transform Level;
    public float Sensor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - _nachalnoePolojenieMouse;
            Level.Rotate(0, -delta.x * Sensor, 0);
        }
       _nachalnoePolojenieMouse =  Input.mousePosition; 
    }
}
