using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Cinemachine;

public class CameraController : MonoBehaviour, IBeginDragHandler, IDragHandler
{

    public Transform CameraTransform;
    public Camera CameraObject;
    public int speedCamera;




    public void Update()
    {

    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (Mathf.Abs(eventData.delta.x) > Mathf.Abs(eventData.delta.y))
        {
            if(CameraTransform.transform.position.x < 5)
            {
                if (eventData.delta.x > 0)
                {
                    CameraTransform.position += Vector3.right * speedCamera;
                }
            }
            if (CameraTransform.transform.position.x > -5)
            {
                if (eventData.delta.x < 0)
                {
                    CameraTransform.position += Vector3.left * speedCamera;
                }
            }
            
        }
        else
        {
            if (CameraTransform.transform.position.y < 5)
            {
                if (eventData.delta.y > 0)
                {
                    CameraTransform.position += Vector3.up * speedCamera;
                }
            }
            if (CameraTransform.transform.position.y > -5)
            {
                if (eventData.delta.y < 0)
                {
                    CameraTransform.position += Vector3.down * speedCamera;
                }
            }

        }
    }

    public void OnDrag(PointerEventData eventData)
    {

    }

}   
