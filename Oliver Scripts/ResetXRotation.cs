using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetXRotation : MonoBehaviour {

public GameObject cuteModel;
public Button yourButton;

private float initialRotation = 0.0f;

void Start () {

initialRotation = cuteModel.transform.localEulerAngles.x;

Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

void TaskOnClick(){
        cuteModel.transform.localRotation = Quaternion.Euler(initialRotation, cuteModel.transform.localEulerAngles.y, cuteModel.transform.localEulerAngles.z);
    }

}