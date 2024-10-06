using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationYSlider : MonoBehaviour {

    public Slider rotationSlider;
    public GameObject cuteModel;

    private float angleSliderNumber;


    void Update()
    {

        angleSliderNumber = rotationSlider.value + 10f;
        cuteModel.transform.rotation = Quaternion.Euler(cuteModel.transform.localEulerAngles.x, angleSliderNumber, cuteModel.transform.localEulerAngles.z);

    }


}