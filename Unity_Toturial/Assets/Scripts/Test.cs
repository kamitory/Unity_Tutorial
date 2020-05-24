using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Test : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler
{
    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("Begin Drag");
        transform.position = eventData.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Drag");
        
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Drop");
       
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
       
    }
}
