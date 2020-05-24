using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag_DropTest : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler
{
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
        //throw new System.NotImplementedException();
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
        Debug.Log("Drag");
        //throw new System.NotImplementedException();
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Drop");
        //throw new System.NotImplementedException();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
        //throw new System.NotImplementedException();
    }
}
