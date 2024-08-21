using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using UnityEditor;

public class Volume : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider = null;
    [SerializeField] private Text volumeTextUI = null;
    [SerializeField] new private AudioSource audio = null;
    [SerializeField] private GameObject EventHandle = null;

    private void Start()
    {
        LoadValues();
    }

    public void VolumeSlider(float volume)
    {
 
       volumeTextUI.text = ((int)(volume * 10)).ToString();
       //volumeTextUI2.text = ((int)(volume * 10)).ToString();
    }


    public void ControlAudio(float volume)
    {
        audio.volume = volume;
    }

    public void SaveVolumeButton()
    {
        float volumeValue = volumeSlider.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValue);
        LoadValues();
        EventHandle.GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(null);
    }

    void LoadValues ()
    {
        float volumeValue = PlayerPrefs.GetFloat("VolumeValue");
        volumeSlider.value = volumeValue;
        audio.volume = volumeValue;
    }
}
