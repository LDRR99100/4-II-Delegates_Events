using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptGrupoAmarillo2 : MonoBehaviour
{
    public ScriptGeneral2 notificador;
    // Start is called before the first frame update
    void Start()
    {
        notificador.callBigger += getBigger;
    }

    private Vector3 direction;
    // Update is called once per frame
    void getBigger()
    {
        int counter = 0;
        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale[0] + 1, gameObject.transform.localScale[1] + 1, gameObject.transform.localScale[2] + 1);
        if(counter == 0) {
        gameObject.transform.position = new Vector3(gameObject.transform.position[0], gameObject.transform.position[1] + 0.5f, gameObject.transform.position[2]);
        counter++;
        }
    }
}
