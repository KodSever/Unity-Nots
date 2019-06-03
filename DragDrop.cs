using UnityEngine;
using UnityEngine.EventSystems;
public class Draggable : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler

{
    public enum Slot { Chest, Key, Weapon}
    public Slot slot = Slot.Chest;
    public Transform eskiTransform;
    public void OnBeginDrag(PointerEventData eventData)
    {
        print("Begin Drag: "+gameObject.name);
        eskiTransform = transform.parent;
        transform.SetParent(transform.parent.parent);

        GetComponent<CanvasGroup>().blocksRaycasts = false;

    }

    public void OnDrag(PointerEventData eventData)
    {

        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(eskiTransform);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour,IDropHandler
{
    public Draggable.Slot Slot = Draggable.Slot.Chest;
    public void OnDrop(PointerEventData eventData)
    {
        
        Debug.Log("onToDrop gameObject: " + transform.name);//TableTop
        Debug.Log("onToDrop pointerGameObject: " + eventData.pointerDrag.gameObject.name);//Card
        //eventData.pointerDrag.transform.SetParent(transform);

        Draggable draggable = eventData.pointerDrag.GetComponent<Draggable>();
        if (draggable!=null)
        {
            draggable.eskiTransform = this.transform;
        }
    }
    
}

