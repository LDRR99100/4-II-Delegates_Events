using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptGrupoVerde3 : MonoBehaviour
{
    public ScriptGeneral3 notificador;
    // Start is called before the first frame update
    void Start()
    {
        notificador.callLookAtObject += lookAtObject;
    }

    private Vector3 direction;
    // Update is called once per frame
    void lookAtObject()
    {
        GameObject capsule = GameObject.FindWithTag("capsule");
        transform.LookAt(capsule.transform);
    }
}
