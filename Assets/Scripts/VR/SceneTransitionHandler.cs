using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionHandler : MonoBehaviour
{
    public static SceneTransitionHandler instance;
    public string DefultMainScene;
    

    public static bool InitializeAsHost = false;

    public void SwitchSceneHost()
    {
        InitializeAsHost = true;
        SceneManager.LoadScene(DefultMainScene,LoadSceneMode.Single);
    }

    public void SwitchSceneClient()
    {
        SceneManager.LoadScene(DefultMainScene,LoadSceneMode.Single);
    }
}
