using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptGrupoVerde2 : MonoBehaviour
{
    public ScriptGeneral2 notificador;
    // Start is called before the first frame update
    void Start()
    {
        notificador.callMove += moveToCylinder;
    }

    private Vector3 direction;
    // Update is called once per frame
    void moveToCylinder()
    {
        float speed = 50.0f;
        GameObject cylinder = GameObject.FindWithTag("cylinder");
        Vector3 cylinderY0 = new Vector3(cylinder.transform.position[0], 0, cylinder.transform.position[2]);
        direction = cylinderY0 - gameObject.transform.position;
        transform.LookAt(cylinder.transform);
        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
}
