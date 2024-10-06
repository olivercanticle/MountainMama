using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomInOut : MonoBehaviour {

    Camera maincamera;
    public float zoomAMT = 60f;

    void Start()
    {
        maincamera = GetComponent<Camera>();
    }


    void Update()
    {

        maincamera.fieldOfView = zoomAMT;

    }

    public void sliderZoom(float zoom)
    {
        zoomAMT = zoom;
    }

}