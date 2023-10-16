using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptGeneral3 : MonoBehaviour
{
    public delegate void delegateMethod();
    public event delegateMethod callColorJump;
    public event delegateMethod callLookAtObject;    
    public Rigidbody rbc;
    public float speed;
    public Vector3 InputCollector;
    // Start is called before the first frame update
    void Start()
    {
        rbc = gameObject.AddComponent<Rigidbody>();
        rbc.constraints = RigidbodyConstraints.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        
        speed = 25.0f;
        InputCollector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    void FixedUpdate() 
    {
        rbc.AddForce(InputCollector * speed);
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "cylinder") {
            callColorJump();
            callLookAtObject();
        }
    }
}
