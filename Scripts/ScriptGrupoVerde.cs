using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptGrupoVerde : MonoBehaviour
{
    public ScriptGeneral notificador;
    // Start is called before the first frame update
    void Start()
    {
        notificador.callColor += setRandomColor;
    }

    // Update is called once per frame
    void setRandomColor()
    {
        gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}
