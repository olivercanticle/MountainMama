using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResetScene : MonoBehaviour
{

public Button yourButton;



    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }


void TaskOnClick(){

Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);


}


}