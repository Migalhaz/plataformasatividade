using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int m_coins;
    void Start()
    {
        m_coins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_coins++;
            PlayerObserverManager.ChangeCoinCount(m_coins);
        }
    }
}

public static class PlayerObserverManager
{
    public static System.Action<int> OnCoinCountChanged;

    public static void ChangeCoinCount(int value)
    {
        OnCoinCountChanged?.Invoke(value);
    }
}
