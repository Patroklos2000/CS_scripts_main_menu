using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class PlayButton : MonoBehaviour
{    
    private Button playButton;
    
    [SerializeField] private Canvas canvas = null;
    [SerializeField] private GameObject rotator = null;       
    [SerializeField] private DeckCreation DeckCreationScript; 
    [SerializeField] new private Camera camera;  
    
    void Start()    
    {
        playButton = GetComponent<Button>();        
        playButton.onClick.AddListener(TaskOnClick); 
        rotator.GetComponent<Rotator>().enabled = true;           
    }

    void OnEnable(){
        StartCoroutine(waitforcamera());
    }    
    
    void TaskOnClick()    
    {           
        rotator.GetComponent<Rotator>().enabled = false;        
        this.transform.parent.parent.gameObject.SetActive(false);
        canvas.transform.GetChild(0).GetComponent<MoveCamera>().enabled = true;
        canvas.transform.GetChild(0).GetComponent<Enabler>().enabled = true;
         
        //Create Deck        
       // DeckCreationScript = FindObjectOfType<DeckCreation>();        
       // DeckCreationScript.CreateDeck();    
    }

    IEnumerator waitforcamera(){
        yield return new WaitUntil(() => camera.transform.position.z < -928);
        transform.GetComponent<MoveCamera>().enabled = false;
        rotator.GetComponent<Rotator>().enabled = true;
    }
}
