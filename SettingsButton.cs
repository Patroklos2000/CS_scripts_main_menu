using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class SettingsButton : MonoBehaviour
{
    private Button settingsButton;
   
    [SerializeField] private Canvas canvas = null;
    [SerializeField] private GameObject EventHandle = null;
    [SerializeField] private GameObject MusicScript = null;
    [SerializeField] private Button backButton = null;

    void Start()
    {
        settingsButton = GetComponent<Button>();
        settingsButton.onClick.AddListener(SettingsMenu);
        backButton.onClick.AddListener(Back);
    }

    void SettingsMenu()
    {
        canvas.transform.GetChild(0).gameObject.SetActive(false);
        canvas.transform.GetChild(2).gameObject.SetActive(true);
    }

    void Back()
    {
        canvas.transform.GetChild(0).gameObject.SetActive(true);
        canvas.transform.GetChild(2).gameObject.SetActive(false);
        MusicScript.GetComponent<Volume>().SaveVolumeButton();
        EventHandle.GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(null);
    }
}
