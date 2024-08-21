using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class CogButton : MonoBehaviour
{
    private bool isActive = false;
    private Button cogButton;

    [SerializeField] private Canvas canvas = null;
    [SerializeField] private Sprite cog1 = null;
    [SerializeField] private Sprite cog2 = null;

    void Start()
    {
        cogButton = canvas.transform.GetChild(0).GetComponent<Button>();
        cogButton.onClick.AddListener(DoThis);
    }

    public void DoThis()
    {
        cogButton.transform.GetChild(0).gameObject.SetActive(!isActive);
        //canvas.transform.GetChild(1).gameObject.SetActive(isActive);
        isActive = !isActive;
        if(cogButton.GetComponent<Image>().sprite == cog2){
            cogButton.GetComponent<Image>().sprite = cog1;
        }
        else{
            cogButton.GetComponent<Image>().sprite = cog2;
        }
    }
}
