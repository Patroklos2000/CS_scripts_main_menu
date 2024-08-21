using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class PlayMenu : MonoBehaviour
{
    [SerializeField] new private Camera camera = null;

    void Start(){
        StartCoroutine(switchmenu());
    }

    IEnumerator switchmenu(){
        yield return new WaitUntil(() => camera.transform.position.z > 1500);
        transform.GetComponent<MoveCamera>().enabled = false;
    }
}
