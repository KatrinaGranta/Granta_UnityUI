using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtteluParadisana2 : MonoBehaviour
{

    public GameObject Aksesuars1;
    public GameObject Aksesuars2;
    public GameObject Aksesuars3;
    public GameObject Aksesuars4;

    public void Aksesuars1Attelosana(bool vetiba)
    {
        Aksesuars1.SetActive(vetiba);
    }
    public void Aksesuars2Attelosana(bool vetiba)
    {
        Aksesuars2.SetActive(vetiba);
    }
    public void Aksesuars3Attelosana(bool vetiba)
    {
        Aksesuars3.SetActive(vetiba);
    }
    public void Aksesuars4Attelosana(bool vetiba)
    {
        Aksesuars4.SetActive(vetiba);
    }
}
