using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public float perspectiveZoomSpeed = .5f;
    public float orthoZoomSpeed = .5f;
    public Camera camera;
	// Update is called once per frame
	void Update () {
		if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchZero.position - touchOne.deltaPosition;

            float prevTouchDeltaMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMagnitude = (touchZero.position - touchOne.position).magnitude;

            float deltaMagnitudeDiff = prevTouchDeltaMagnitude - touchDeltaMagnitude;
            Debug.Log(deltaMagnitudeDiff.ToString());
            SSTools.ShowMessage(deltaMagnitudeDiff.ToString(), SSTools.Position.bottom, SSTools.Time.oneSecond);

            if (camera.orthographic)
            {
                camera.orthographicSize -= deltaMagnitudeDiff * orthoZoomSpeed;
                camera.orthographicSize = Mathf.Max(camera.orthographicSize, 0.1f);
              
            }
            else
            {
                // Otherwise change the field of view based on the change in distance between the touches.
                camera.fieldOfView -= deltaMagnitudeDiff * perspectiveZoomSpeed;
                // Clamp the field of view to make sure it's between 0 and 180.

                camera.fieldOfView = Mathf.Clamp(camera.fieldOfView, 0.1f, 179.9f);

            }
        }
	}
}
