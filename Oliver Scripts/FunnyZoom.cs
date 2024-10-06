using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FunnyZoom : MonoBehaviour {

    public Camera maincamera;


    public Slider zoomSlider;

    private float zoomSliderNumber;


    void Update()
    {

        zoomSliderNumber = zoomSlider.value + 1f;
        maincamera.fieldOfView = zoomSliderNumber;

    }


}