using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class CameraDrag : MonoBehaviour
{
    // private Vector3 dragOrigin;
    // private Camera mainCamera;
    private Vector3 origin = new Vector3(Screen.width / 2f, Screen.height / 2f, 0f);

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject()) {
            Vector3 pos = Input.mousePosition - origin;
            pos.z = pos.y;
            pos.y = 0;
            
            // Debug.Log(Input.mousePosition.ToString() + " " + origin.ToString());
            // Debug.Log(pos);
            this.transform.position += pos / 100;
        }
    }
}