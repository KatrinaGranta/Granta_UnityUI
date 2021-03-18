using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtteluParadisana4 : MonoBehaviour
{
    public GameObject Krekls1;
    public GameObject Krekls2;
    public GameObject Krekls3;
    public GameObject Krekls4;

    public void Krekls1Attelosana(bool vetiba)
    {
        Krekls1.SetActive(vetiba);
    }
    public void Krekls2Attelosana(bool vetiba)
    {
        Krekls2.SetActive(vetiba);
    }
    public void Krekls3Attelosana(bool vetiba)
    {
        Krekls3.SetActive(vetiba);
    }
    public void Krekls4Attelosana(bool vetiba)
    {
        Krekls4.SetActive(vetiba);
    }
}
