using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MamaRealStart : MonoBehaviour {



public Button start;
public Button oliver;
public Button olivia;
public Button serena;


private int selectedCharacter = 1;


void Start () {

Button startButton = start.GetComponent<Button>();
startButton.onClick.AddListener(StartOnClick);

Button oliverButton = oliver.GetComponent<Button>();
oliverButton.onClick.AddListener(OliverOnClick);

Button oliviaButton = olivia.GetComponent<Button>();
oliviaButton.onClick.AddListener(OliviaOnClick);

Button serenaButton = serena.GetComponent<Button>();
serenaButton.onClick.AddListener(SerenaOnClick);

}

void SerenaOnClick(){
selectedCharacter = 3;

}

void OliverOnClick(){
selectedCharacter = 1;

}

void OliviaOnClick(){
selectedCharacter = 2;

}







void StartOnClick(){


SceneManager.LoadScene(selectedCharacter);

}



}