using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionXSlider : MonoBehaviour {

    public Slider positionSlider;
    public GameObject cuteModel;

    private float positionSliderNumber;


    void Update()
    {

        positionSliderNumber = positionSlider.value + 0.1f;
        cuteModel.transform.position = new Vector3(positionSliderNumber, cuteModel.transform.position.y, cuteModel.transform.position.z);

    }


}