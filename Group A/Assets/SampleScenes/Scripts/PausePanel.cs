using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePanel : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    public static bool pause;
    public static PausePanel pP;


    // Start is called before the first frame update
    private void Start()
    {
        pP = this;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause = !pause;
            if (pause)
            {
                pP.pausePanel.SetActive(true);
                Time.timeScale = 0f;
            }
            else
            {
                pP.pausePanel.SetActive(false);
                Time.timeScale = 1f;
            }
        }

    }
    public void Upause()
    {
        pause = false;
        pP.pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
