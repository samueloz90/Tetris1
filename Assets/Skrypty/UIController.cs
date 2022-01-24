using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public Text text;

    void Start(){
        GameData.Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(text != null)
        text.text = "Score:" + GameData.Score;
    }

    public void PressPlay(){
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void PressExit(){
        Application.Quit();
    }
}
