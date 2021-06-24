using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class setting_buttonn : MonoBehaviour {

    private bool isPause = false;
    private GameObject normalPanel;
    private GameObject pausePanel;
    private string current_scene;

    void Awake()
    {
        normalPanel = GameObject.Find("Canvas").transform.Find("StopUI").gameObject;
        pausePanel = GameObject.Find("Canvas").transform.Find("PauseUI").gameObject;
        current_scene = EditorApplication.currentScene;
    }

    public void ActivePause()
    {
        if (!isPause)
        {
            Time.timeScale = 0;
            pausePanel.SetActive(true);
            normalPanel.SetActive(false);
        }
        else
        {
            Time.timeScale = 1.0f;
            pausePanel.SetActive(false);
            normalPanel.SetActive(true);
        }
        isPause = !isPause;
    }

    public void RetryBt()
    {
        Debug.Log("게임 재시작");
        Time.timeScale = 1.0f;
        Application.LoadLevel(current_scene);
    }
    public void QuitBt()
    {
        Debug.Log("게임종료");
        Application.Quit();
    }

}
