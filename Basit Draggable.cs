using UnityEngine;
using UnityEngine.EventSystems;
public class Draggable : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler

{
    public void OnBeginDrag(PointerEventData eventData)
    {
        print("Tıklama sayısı: "+eventData.clickCount);
    }

    public void OnDrag(PointerEventData eventData)
    {
        print("Dragging: " + eventData.dragging);
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        print("Dragging End: " + eventData.dragging);
    }
}
