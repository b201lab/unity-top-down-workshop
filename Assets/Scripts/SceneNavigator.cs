using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour
{
    public string sceneName;

    public void Execute()
    {
        SceneManager.LoadScene(sceneName);
    }
}
