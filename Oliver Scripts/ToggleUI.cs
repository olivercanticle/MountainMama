using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleUI : MonoBehaviour {

public GameObject rotateX;
public GameObject rotateY;
public GameObject rotateZ;
public GameObject zoom;
public GameObject backgrounds;
public GameObject positionX;
public GameObject positionY;
public GameObject positionZ;
public GameObject sensitivity;
public GameObject reset;
public GameObject changeModel;
public Button yourButton;

private bool visibleUI = true;

void Start () {

Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

void TaskOnClick(){

if (visibleUI) {

rotateX.SetActive(false);
rotateY.SetActive(false);
rotateZ.SetActive(false);
zoom.SetActive(false);
backgrounds.SetActive(false);
positionX.SetActive(false);
positionY.SetActive(false);
positionZ.SetActive(false);
sensitivity.SetActive(false);
reset.SetActive(false);
changeModel.SetActive(false);

visibleUI = false;


}
else {

rotateX.SetActive(true);
rotateY.SetActive(true);
rotateZ.SetActive(true);
zoom.SetActive(true);
backgrounds.SetActive(true);
positionX.SetActive(true);
positionY.SetActive(true);
positionZ.SetActive(true);
sensitivity.SetActive(true);
reset.SetActive(true);
changeModel.SetActive(true);

visibleUI = true;

}


}






}