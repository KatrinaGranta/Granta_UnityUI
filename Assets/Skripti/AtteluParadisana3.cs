using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtteluParadisana3 : MonoBehaviour
{
    public GameObject Cepures1;
    public GameObject Cepures2;
    public GameObject Cepures3;
    public GameObject Cepures4;

    public void Cepures1Attelosana(bool vetiba)
    {
        Cepures1.SetActive(vetiba);
    }
    public void Cepures2Attelosana(bool vetiba)
    {
        Cepures2.SetActive(vetiba);
    }
    public void Cepures3Attelosana(bool vetiba)
    {
        Cepures3.SetActive(vetiba);
    }
    public void Cepures4Attelosana(bool vetiba)
    {
        Cepures4.SetActive(vetiba);
    }
}