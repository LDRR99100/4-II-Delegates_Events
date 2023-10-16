using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntuacion5 : MonoBehaviour
{
    public juegoPuntuacion notificador;
    // Start is called before the first frame update
    void Start()
    {
        notificador.callFivePoints += addFivePoints;
    }

    private Vector3 direction;
    // Update is called once per frame
    void addFivePoints()
    {
        notificador.puntuacion += 1.666666666666f;

    }
}
