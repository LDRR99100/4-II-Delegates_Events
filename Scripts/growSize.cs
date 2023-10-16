using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    public juegoPuntuacion notificador;
    // Start is called before the first frame update
    void Start()
    {
        notificador.callBigger += getBigger;
    }

    private Vector3 direction;
    // Update is called once per frame
    void getBigger()
    {
        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale[0] + 1, gameObject.transform.localScale[1] + 1, gameObject.transform.localScale[2] + 1);
    }
}
