using System.Collections;
using UnityEngine;

public class TeletubijuSkana : MonoBehaviour{

    public  AudioSource skanasAvots;
    public  AudioClip SkanaKOAtskano;

    public void uzbiditsUzAttela()
    {
        skanasAvots.PlayOneShot(SkanaKOAtskano);
    }
    public void kursorsNoietNoAttela(){
        skanasAvots.Stop();
    }
}
