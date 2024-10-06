using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetZRotation : MonoBehaviour {

public GameObject cuteModel;
public Button yourButton;

private float initialRotation = 0.0f;

void Start () {

initialRotation = cuteModel.transform.localEulerAngles.z;

Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

void TaskOnClick(){
        cuteModel.transform.localRotation = Quaternion.Euler(cuteModel.transform.localEulerAngles.x, cuteModel.transform.localEulerAngles.y, initialRotation);
    }

}