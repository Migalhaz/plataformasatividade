using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    [SerializeField] private float m_volume;
    void Awake()
    {
        if (instance != null) Destroy(gameObject);
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void OnEnable()
    {
        AudioObserverManager.OnVolumeChanged += SetVolume;
    }

    private void OnDisable()
    {
        AudioObserverManager.OnVolumeChanged -= SetVolume;
    }

    public void SetVolume(float volume)
    {
        m_volume = volume;
    }
}

public static class AudioObserverManager
{
    public static System.Action<float> OnVolumeChanged;

    public static void VolumeChanged(float volume)
    {
        OnVolumeChanged?.Invoke(volume);
    }
}