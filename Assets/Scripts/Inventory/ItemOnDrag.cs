using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.UI;

public class ItemOnDrag : MonoBehaviour,IBeginDragHandler, IEndDragHandler,IDragHandler
{
    public Transform originalParent;
    public TrackedDeviceEventData eventDatatracked;



    public void OnBeginDrag(PointerEventData eventData)
    {
        originalParent = transform.parent;
        transform.SetParent(transform.parent.parent);
        //transform.position = eventData.position;
        transform.position = eventDatatracked.position;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
   

    public void OnDrag(PointerEventData eventData)
    {
        //transform.position = eventData.position;
        transform.position = eventDatatracked.position;
        Debug.Log(eventData.pointerCurrentRaycast.gameObject.name);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
