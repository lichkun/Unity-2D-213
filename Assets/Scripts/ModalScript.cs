using Mono.Cecil;
using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class ModalScript : MonoBehaviour
{
    [SerializeField]
    private GameObject content;
    [SerializeField]
    private TMPro.TextMeshProUGUI titleTMP;
    [SerializeField]
    private TMPro.TextMeshProUGUI messageTMP;
    [SerializeField]
    private TMPro.TextMeshProUGUI Button1Text;
    [SerializeField]
    private TMPro.TextMeshProUGUI Button2Text;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.ShowModal(!content.activeInHierarchy);
        GameState.modalScriptInstance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            this.ShowModal(!content.activeInHierarchy);
        }
    }
    public void  ShowModal(bool isShown, string title = null, string message = null)
    {
        if(isShown)
        {
            if (title == null) title = "Pause";
            else { Button2Text.text = "Repeat level"; Button1Text.text = "Next level"; }
            if (message == null) message = "Press 'Continue' or Esc for play";
            Time.timeScale = 0.0f;
            titleTMP.text = title;
            messageTMP.text = message;
            content.SetActive(true);
        }
        else
        {
            Time.timeScale = 1.0f;
            content.SetActive(false);
        }
    }
    public void OnGoButtonClick()
    {
        if (GameState.isLevelCompleted)
            SceneManager.LoadScene(2);
        else
            ShowModal(false);
    }
    public void OnExitButtonClick()
    {
        #if UNITY_STANDALONE
                Application.Quit();
        #endif
        #if UNITY_EDITOR
         if (Button2Text.text == "Repeat level") SceneManager.LoadScene(SceneManager.GetActiveScene().name);
         else UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    
}
