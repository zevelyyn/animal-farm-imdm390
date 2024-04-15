using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class replaceChicken : MonoBehaviour
{
    public GameObject sickChickenPrefab;
    public Text healthText;
    private float health;
    public bool isHealthyChickenPrefab = true;
    
    // Start is called before the first frame update
    void Start()
    {
        health = float.Parse(healthText.text);
    }

    // Update is called once per frame
    void Update()
    {
        health = float.Parse(healthText.text);
        if (health < 50 && isHealthyChickenPrefab) {
            Vector3 position = transform.position;
            Quaternion rotation = transform.rotation;
            Vector3 scale = transform.localScale;

            GameObject newChicken = Instantiate(sickChickenPrefab, position, rotation);
            newChicken.transform.localScale = scale;
            Destroy(gameObject);
            isHealthyChickenPrefab = false;
            // healthText.text = health.ToString();
        }
    }
}
