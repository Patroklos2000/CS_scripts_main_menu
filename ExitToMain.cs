using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitToMain : MonoBehaviour
{
    private Button exitToMain;
    [SerializeField] private Canvas canvas = null;
    [SerializeField] private GameObject rotator = null;

    void Start()
    {
        exitToMain = GetComponent<Button>();
        exitToMain.onClick.AddListener(ExitToMainMenu);
    }

    void ExitToMainMenu()
    {
        rotator.GetComponent<Rotator>().enabled = true;        
        rotator.transform.GetChild(0).GetComponent<MoveCamera>().enabled = false;        
    
        StartCoroutine(waiter());

    }

    IEnumerator waiter()
    {

        canvas.transform.GetChild(0).GetComponent<Image>().enabled = false;
        exitToMain.GetComponent<MoveCamera>().enabled = true;
        yield return new WaitForSeconds(3);
        canvas.transform.GetChild(0).GetComponent<Image>().enabled = true;
        exitToMain.GetComponent<MoveCamera>().enabled = false;
        canvas.transform.GetChild(0).GetComponent<CogButton>().DoThis();
        canvas.transform.GetChild(0).gameObject.SetActive(false);
        canvas.transform.GetChild(1).gameObject.SetActive(true);
    }

}
