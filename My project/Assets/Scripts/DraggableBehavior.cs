using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DraggableBehavior : MonoBehaviour
{
    
    private Camera cameraObj;
    public bool draggable;
    public Vector3 position, offset;
    public UnityEvent dragStartEvent, dragEndEvent;
    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        offset = transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition);
        yield return new WaitForFixedUpdate();
        draggable = true;
        dragStartEvent.Invoke();
        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            position = cameraObj.ScreenToWorldPoint(Input.mousePosition)+offset;
            transform.position = position;
        }
    }

    private void OnMouseUp()
    {
        draggable = false;
        dragEndEvent.Invoke();
    }
}
