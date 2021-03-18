using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtteluParadisana : MonoBehaviour
{

    public GameObject Kombinzons1;
    public GameObject Kombinzons2;
    public GameObject Kombinzons3;
    public GameObject Kombinzons4;

    public void Kombizons1Attelosana(bool vetiba)
    {
        Kombinzons1.SetActive(vetiba);
    }
    public void Kombizons2Attelosana(bool vetiba)
    {
        Kombinzons2.SetActive(vetiba);
    }
    public void Kombizons3Attelosana(bool vetiba)
    {
        Kombinzons3.SetActive(vetiba);
    }
    public void Kombizons4Attelosana(bool vetiba)
    {
        Kombinzons4.SetActive(vetiba);
    }
}