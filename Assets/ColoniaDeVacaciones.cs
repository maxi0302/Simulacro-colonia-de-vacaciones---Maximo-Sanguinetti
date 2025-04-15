using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoniaDeVacaciones : MonoBehaviour
{
    public int infantiles;
    public int juveniles;
    int profInfantiles;
    int profJuveniles;
    int profesTotales;
    int cordinadores;
    int listaDeEspera;

    void Start()
    {

        if (infantiles < 0 || infantiles > 100)
        {
            Debug.Log("ERROR: Cantidad de alumnos infantiles no valida");
            return;
        }
        if (juveniles < 0 || juveniles > 100)
        {
            Debug.Log("ERROR: Cantidad de juveniles no valida");
            return;
        }

        listaDeEspera = infantiles % 10 + juveniles % 20;
        infantiles -= infantiles % 10;
        juveniles -= juveniles % 20;

        profInfantiles = infantiles / 10;
        profJuveniles = juveniles / 20;
        profesTotales = profInfantiles + profJuveniles;

        if (profesTotales % 5 != 0)
        {
            cordinadores = 1;
            profesTotales -= profesTotales % 5;
        }
        cordinadores += profesTotales / 5;

        Debug.Log("Se necesitan " + profInfantiles + " profesores para los inscriptos infantiles");
        Debug.Log("Se necesitan " + profJuveniles + " profesores para lo inscriptos juveniles");
        Debug.Log("Se necesitan " + cordinadores + " cordinadores");
        Debug.Log("Hay " + listaDeEspera + " alumnos en lista de espera");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
