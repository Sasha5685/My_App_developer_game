using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraController : MonoBehaviour, IBeginDragHandler, IDragHandler
{

    public Transform CameraTransform;
    public Camera CameraObject;
    public int speedCamera;
    float touchesPrevPosDifference, touchesCurPosDifference, zoomModifier;
    Vector2 firstTouchPrevPos, secondTouchPrevPos;
    public float zoomMin = 2;
    public float zoomMax = 5;
    bool multiTouch;

    [SerializeField]
    public float zoomModifierSpeed = 0.1f;

    public void Update()
    {
        if (Input.touchCount == 2)
        {
            Touch firstTouch = Input.GetTouch(0);
            Touch secondTouch = Input.GetTouch(1);

            firstTouchPrevPos = firstTouch.position - firstTouch.deltaPosition;
            secondTouchPrevPos = secondTouch.position - secondTouch.deltaPosition;

            touchesPrevPosDifference = (firstTouchPrevPos - secondTouchPrevPos).magnitude;
            touchesCurPosDifference = (firstTouch.position - secondTouch.position).magnitude;

            zoomModifier = (firstTouch.deltaPosition - secondTouch.deltaPosition).magnitude * zoomModifierSpeed;

            if (touchesPrevPosDifference > touchesCurPosDifference)
                CameraObject.orthographicSize += zoomModifier;
            if (touchesPrevPosDifference < touchesCurPosDifference)
                CameraObject.orthographicSize -= zoomModifier;

        }

        CameraObject.orthographicSize = Mathf.Clamp(CameraObject.orthographicSize, 2f, 10f);
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
            if (CameraTransform.transform.position.x > -5)
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
