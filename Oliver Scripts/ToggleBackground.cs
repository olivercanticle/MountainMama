using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleBackground : MonoBehaviour {

public GameObject background1;
public GameObject background2;
public GameObject background3;
public GameObject background4;
public Button yourButton;

private bool backgroundsVisible = true;

void Start () {

Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

void TaskOnClick(){

if (backgroundsVisible) {

background1.SetActive(false);
background2.SetActive(false);
background3.SetActive(false);
background4.SetActive(false);

backgroundsVisible = false;

}
else {

background1.SetActive(true);
background2.SetActive(true);
background3.SetActive(true);
background4.SetActive(true);

backgroundsVisible = true;
}


}






}