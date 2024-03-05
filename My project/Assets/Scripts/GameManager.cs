using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    void Awake()
    {
        if (instance != null) Destroy(gameObject);
        instance = this;
        DontDestroyOnLoad(gameObject);

    }

    private void Start()
    {
        SceneManager.LoadScene("SplashScene");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        
    }

    public void LoadGameplayScene()
    {
        SceneManager.LoadScene("Gameplay");
        SceneManager.LoadScene("GUI", LoadSceneMode.Additive);
    }
}
