using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMove : MonoBehaviour
{
    public float speed = 5f;
    public float minX = -5f;
    public float maxX = 5f;
    public float minZ = -5f;
    public float maxZ = 5f;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Mathf.Abs(transform.position.x) > maxX || Mathf.Abs(transform.position.z) > maxZ) {
            transform.Rotate(Vector3.up, 180f);
            Vector3 tmp = transform.position;
            tmp.x = Mathf.Clamp(tmp.x, minX, maxX);
            tmp.z = Mathf.Clamp(tmp.z, minZ, maxZ);
            transform.position = tmp;
        }
    }

}
