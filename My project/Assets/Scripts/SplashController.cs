using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(GoToMainMenu), 2f);
    }

    void GoToMainMenu()
    {
        GameManager.instance.LoadMainMenu();
    }
}
