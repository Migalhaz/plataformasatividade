using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Slider m_slider;
    void Start()
    {
        m_slider.onValueChanged.AddListener(OnChangeValue);
    }

    void OnChangeValue(float value)
    {
        AudioObserverManager.VolumeChanged(value);
    }
}
