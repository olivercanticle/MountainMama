using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationXSlider : MonoBehaviour {

    public Slider rotationSlider;
    public GameObject cuteModel;

    private float angleSliderNumber;


    void Update()
    {

        angleSliderNumber = rotationSlider.value + 10f;
        cuteModel.transform.rotation = Quaternion.Euler(angleSliderNumber, cuteModel.transform.localEulerAngles.y, cuteModel.transform.localEulerAngles.z);

    }


}