using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TelaParadisana : MonoBehaviour
{
  
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public GameObject slaideris;
    public GameObject slaideris2;

    public void izkritosais(int skaitlis)
    {
        if (skaitlis == 0)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
        }
        if (skaitlis == 1)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
        }
        if (skaitlis == 2)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[2];
        }
        if (skaitlis == 3)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[3];
        }
    }
    public void mainitIzmerus() {
        float pasreizejaVertiba = slaideris.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector3(1F * pasreizejaVertiba, 1F * pasreizejaVertiba, 1);
    }
    public void mainitIzmerus2()
    {
        float pasreizejaVertiba = slaideris.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector3(1F * pasreizejaVertiba, 1F * pasreizejaVertiba, 1);
    }
}
        
    
