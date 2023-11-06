using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneJumper: MonoBehaviour
{
    public static void JumpToSceneByName(string name)
    {
        SceneManager.LoadScene(name);
    }

    public static void ExitGame()
    {
        Application.Quit();
    }
}
