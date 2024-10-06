using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeModel : MonoBehaviour
{

public Button yourButton;



    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }


void TaskOnClick(){

Scene scene = SceneManager.GetActiveScene();
SceneManager.LoadScene(0);


}


}