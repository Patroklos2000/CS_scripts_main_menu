using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] new private Camera camera;
    [SerializeField] private float x_position;
    [SerializeField] private float y_position;
    [SerializeField] private float z_position;
    [SerializeField] private float x_rotation;
    [SerializeField] private float y_rotation;
    [SerializeField] private float z_rotation;
    [SerializeField] private int stopPosition_z;
    [SerializeField] private int speed;
    private Vector3 moveToPosition;
    private Quaternion moveToRotation;
    private bool boolean = false;

    void Start()
    {
        moveToPosition = new Vector3(x_position, y_position, z_position);
        moveToRotation = Quaternion.Euler(x_rotation, y_rotation, z_rotation);
    }

    void OnEnable(){
        boolean = false;
        Debug.Log("boolean false");
        if(stopPosition_z != 0)
        StartCoroutine(switchmenu());
    }

    void Update()
    {
        camera.transform.rotation = Quaternion.Lerp(camera.transform.rotation, moveToRotation, speed * Time.deltaTime);
        camera.transform.position = Vector3.Lerp(camera.transform.position, moveToPosition, speed * Time.deltaTime);
    }

    IEnumerator switchmenu(){
        yield return new WaitUntil(() => camera.transform.position.z > stopPosition_z);
        Debug.Log("boolean true");
        boolean = true;
        transform.GetComponent<MoveCamera>().enabled = false;
    }

    public bool getBool(){
        return boolean;
    }
}
