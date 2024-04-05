using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraDrag : MonoBehaviour
{
    private Vector3 dragOrigin;
    private Camera mainCamera;
    private Vector3 origin = new Vector3(Screen.width / 2f, Screen.height / 2f, 50f);

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 pos = Input.mousePosition - origin;
            Debug.Log(pos);
            this.transform.position = pos / 2;
        }
    }
}