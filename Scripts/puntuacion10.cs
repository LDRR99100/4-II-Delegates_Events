using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntuacion10 : MonoBehaviour
{
    public juegoPuntuacion notificador;
    // Start is called before the first frame update
    void Start()
    {
        notificador.callTenPoints += addTenPoints;
    }

    private Vector3 direction;
    // Update is called once per frame
    void addTenPoints()
    {
        notificador.puntuacion += 5;
    }
}
