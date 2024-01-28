using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    public void MoveToScene(string sceneName)
    {
        if(sceneName == "quit")
        {
            Application.Quit();
        }
        SceneManager.LoadScene(sceneName);
    }
}
