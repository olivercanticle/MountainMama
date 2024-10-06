using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeStage : MonoBehaviour {

    public GameObject backgroundToShow;
    public GameObject backgroundToHide1;
    public GameObject backgroundToHide2;
    public GameObject backgroundToHide3;
    public Button yourButton;

    void Start () {

        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick(){

        backgroundToShow.SetActive(true);
        backgroundToHide1.SetActive(false);
        backgroundToHide2.SetActive(false);
        backgroundToHide3.SetActive(false);

    }






}