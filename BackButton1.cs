using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackButton1 : MonoBehaviour
{
    private Button backButton;
    [SerializeField] private Canvas canvas = null;

    void Start(){
        backButton = GetComponent<Button>();        
        backButton.onClick.AddListener(TaskOnClick);   
    }

    void TaskOnClick(){
        canvas.transform.gameObject.SetActive(true);
        canvas.transform.GetChild(0).GetChild(0).GetComponent<MoveCamera>().enabled = true;
        this.transform.parent.GetComponent<Enabler>().enabled = false;
    }
}
