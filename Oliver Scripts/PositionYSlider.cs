using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionYSlider : MonoBehaviour {

    public Slider positionSlider;
    public GameObject cuteModel;

    private float positionSliderNumber;


    void Update()
    {

        positionSliderNumber = positionSlider.value + 0.1f;
        cuteModel.transform.position = new Vector3(cuteModel.transform.position.x, positionSliderNumber, cuteModel.transform.position.z);

    }


}