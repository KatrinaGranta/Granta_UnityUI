using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VardaVecumaParadisana : MonoBehaviour{
 
    public string teksts, teksts1;
    
    public GameObject Vards;
    public GameObject Vecums;

    public GameObject TekstaAttelosana;

    
    public void uzglabatTekstu(){
        teksts = Vards.GetComponent<Text>().text;
        teksts1 = Vecums.GetComponent<Text>().text;
        TekstaAttelosana.GetComponent<Text>().text = "Multeņu varonis " + teksts.ToUpper() + " ir "+teksts1.ToUpper() + " gadus vecs!";
    }

}
