using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class RulesButton : MonoBehaviour
{
    // auta kleinoun
    private Button rulesButton;

    [SerializeField] private Canvas canvas = null;
    [SerializeField] private GameObject rotator = null; 

    void Start()
    {
        rulesButton = GetComponent<Button>();
        rulesButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        canvas.transform.GetChild(0).gameObject.SetActive(false);
        rotator.GetComponent<Rotator>().enabled = false; 
        canvas.transform.GetChild(1).gameObject.SetActive(true);
    }

}
