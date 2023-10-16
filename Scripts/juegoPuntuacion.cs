using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class juegoPuntuacion : MonoBehaviour
{
    public delegate void delegateMethod();
    public event delegateMethod callFivePoints;
    public event delegateMethod callTenPoints;
    public event delegateMethod callBigger;     
    public Rigidbody rbc;
    public float speed;
    public Vector3 InputCollector;
    public float puntuacion;
    public TextMeshProUGUI puntuacionCanvas;
    // Start is called before the first frame update
    void Start()
    {
        rbc = gameObject.AddComponent<Rigidbody>();
        rbc.constraints = RigidbodyConstraints.FreezeRotation;
        puntuacionCanvas.text = "PUNTUACION: 0";
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
        if (collision.gameObject.tag == "grupoamarillo") {
            callTenPoints();
            puntuacionCanvas.text = "PUNTUACION: " + puntuacion.ToString();
            Debug.Log("Esfera consumida! La puntuancion ahora es de :" + puntuacion);
            Destroy(collision.gameObject);
        } else if(collision.gameObject.tag == "grupoverde") {
            callFivePoints();
            puntuacionCanvas.text = "PUNTUACION: " + puntuacion.ToString();
            Debug.Log("Esfera consumida! La puntuancion ahora es de :" + puntuacion);
            Destroy(collision.gameObject);
        } else if(collision.gameObject.tag == "cylinder") {
            callBigger();
            Destroy(collision.gameObject);
        }
    }
}
