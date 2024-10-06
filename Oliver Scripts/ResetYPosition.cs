using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetYPosition : MonoBehaviour {

public GameObject cuteModel;
public Button yourButton;

private float initialPosition = 0.0f;

void Start () {

initialPosition = cuteModel.transform.position.y; 

Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

void TaskOnClick(){
        cuteModel.transform.position = new Vector3(transform.position.x, initialPosition, transform.position.z);

}






}