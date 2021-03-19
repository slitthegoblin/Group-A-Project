using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenueManager : MonoBehaviour
{
    public void LoadSceane(string s)
    {
        SceneManager.LoadScene(s);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
