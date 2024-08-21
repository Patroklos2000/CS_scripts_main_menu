using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enabler : MonoBehaviour
{
    void OnEnable()
    {
        StartCoroutine(waitforcamera()); 
    }

    void OnDisable(){
        this.transform.GetChild(1).GetComponent<Button>().enabled = false;
    }

    IEnumerator waitforcamera(){
        yield return new WaitUntil(() => this.GetComponent<MoveCamera>().getBool());
        this.transform.GetChild(1).GetComponent<Button>().enabled = true;
    }

}
