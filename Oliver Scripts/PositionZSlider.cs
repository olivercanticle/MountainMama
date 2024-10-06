using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionZSlider : MonoBehaviour {

    public Slider positionSlider;
    public GameObject cuteModel;

    private float positionSliderNumber;


    void Update()
    {

        positionSliderNumber = positionSlider.value + 0.1f;
        cuteModel.transform.position = new Vector3(cuteModel.transform.position.x, cuteModel.transform.position.y, positionSliderNumber);

    }


}