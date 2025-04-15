using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoniaDeVacaciones : MonoBehaviour
{
    public int infantiles;
    public int juveniles;
    int profInfantiles;
    int profJuveniles;
    int cordinadores;

    void Start()
    {
        if (infantiles < 0 || juveniles < 0)
        {
            Debug.Log("ERROR: Cantidad de alumnos no valida");
            return;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
