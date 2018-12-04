using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SwipCameraRotation : TouchLogicV2
{

    private Touch initTouch = new Touch();
    public Camera cam;
    private float rotX = 0f;
    private float rotY = 0f;
    private float rotZ = 0f;
    private Vector3 originRot;
    public float rotSpeed = 0.5f;
    public float dir = -1;
    void Start()
    {
        originRot = cam.transform.eulerAngles;
        rotX = originRot.x;
        rotY = originRot.y;
        rotZ = originRot.z;
    }

    private void FixedUpdate()
    {
        if (Input.touchCount == 1)
        {
            foreach (Touch touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Began)
                {
                    initTouch = touch;
                }
                else if (touch.phase == TouchPhase.Moved)
                {
                    float deltaX = initTouch.position.x - touch.position.x;
                    float deltaY = initTouch.position.y - touch.position.y;
                    rotY += deltaX * Time.deltaTime * rotSpeed * dir;
                    Mathf.Clamp(rotX, -80f, 80f);
                    cam.transform.eulerAngles = new Vector3(rotX, rotY, rotZ);
                }
                else if (touch.phase == TouchPhase.Ended)
                {
                    initTouch = new Touch();
                }
            }
        }
    }
}
