using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIController : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI m_txt;
    private void OnEnable()
    {
        PlayerObserverManager.OnCoinCountChanged += UpdateCoinValue;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnCoinCountChanged -= UpdateCoinValue;
    }

    void UpdateCoinValue(int value)
    {
        m_txt.text = $"COINS: {value}";
    }
}
