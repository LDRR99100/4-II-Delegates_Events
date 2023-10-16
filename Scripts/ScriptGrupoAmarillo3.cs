using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptGrupoAmarillo3 : MonoBehaviour
{
    public ScriptGeneral3 notificador;
    // Start is called before the first frame update
    public Rigidbody rbc; 
    void Start()
    {
        notificador.callColorJump += colorJump;
        rbc = gameObject.AddComponent<Rigidbody>();
    }

    private Vector3 direction;
    // Update is called once per frame
    void colorJump()
    {
        float jumpAmount = 5;
        gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
        rbc.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
    }
}
