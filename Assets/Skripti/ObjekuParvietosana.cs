using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjekuParvietosana : MonoBehaviour, IPointerDownHandler, IDragHandler, IBeginDragHandler, IEndDragHandler {
    private RectTransform transformacijuLogs;
    public Canvas kanva;

    private void Awake()  {
        transformacijuLogs = GetComponent<RectTransform>();
    }
    public void OnPointerDown(PointerEventData notikums) {
        Debug.Log("Kreisas klikšķis uz pārvietojamā objekta!");
    }
    public void OnDrag(PointerEventData notikums){
        Debug.Log("Objekts tiek pārvietots!");
        transformacijuLogs.anchoredPosition += notikums.delta / kanva.scaleFactor;
    }
    public void OnBeginDrag(PointerEventData notikums){
        Debug.Log("Uzsākta objekta pārvietošana!");
    }
    public void OnEndDrag(PointerEventData notikums)  {
        Debug.Log("Pabeigta objekta pārvietošana");
    }
}
