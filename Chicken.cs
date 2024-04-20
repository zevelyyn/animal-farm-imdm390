using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour {
    public static GameObject healthyChickenPrefab;
    public static GameObject fatChickenPrefab;
    public static GameObject steroidChickenPrefab;
    public static GameObject sickChickenPrefab;
    // private float xMin = -5f;
    // private float xMax = 7f;
    // private float zMin = -2f;
    // private float zMax = 4;
    // pathways to prefabs and sounds (can be changed)
    // public GameObject[] prefabs = new GameObject [] 
    //     {Resources.Load<GameObject>("Assets/Resources/healthyChicken.png"),
    //     Resources.Load<GameObject>("Assets/Resources/fatChicken.png"), 
    //     Resources.Load<GameObject>("Assets/Resources/steroidChicken.png"), 
    //     Resources.Load<GameObject>("Assets/Resources/sickChicken.png")};

    public GameObject[] prefabs = new GameObject [] 
        {healthyChickenPrefab, fatChickenPrefab, steroidChickenPrefab, sickChickenPrefab};
    // public AudioClip[] sounds = new AudioClip[] 
    //     {Resources.Load<AudioClip>("Assets/Resources/healthyAudio"),
    //     Resources.Load<AudioClip>("Assets/Resources/fatAudio"),
    //     Resources.Load<AudioClip>("Assets/Resources/steroidAudio"), 
    //     Resources.Load<AudioClip>("Assets/Resources/sickAudio")};
    public GameObject MyPrefab;
    public AudioClip MySound;
    void Start() {
        // for (int i = 0; i < 10; i++) {}
        // position = new Vector3(Random.Range(xMin, xMax), 0f, Random.Range(zMin, zMax));
        MyChicken(prefabs[0], MySound, new Vector3(0, 0, 0), Quaternion.identity); // instantiate healthy chicken
        // MyChicken(prefabs[0], sounds[0], position, Quaternion.identity);
    }

    void Update() {
        
    }


    public void MyChicken(GameObject prefab, AudioClip sound, Vector3 pos, Quaternion rot) {
        GameObject chickenObj = Instantiate(prefab, pos, rot);
        Chicken chicken = chickenObj.AddComponent<Chicken>();
        AudioSource audioSource = chickenObj.AddComponent<AudioSource>();

        chicken.MySound = sound;
        chicken.MyPrefab = prefab;
    }
    
    // change status of existing chicken
    // idx: 0 = healthy, 1 = fat, 2 = steroid, 3 = sick
    // e.g. to replace curr chicken w/ a fat chicken, call ChangeChicken(1)
    public void ChangeChicken(int idx) {
        MyChicken(prefabs[idx], MySound, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    // create new chicken w/ same status
    public void NewChicken(Vector3 pos, Quaternion rot) { // new chicken's position and rotation
        MyChicken(this.MyPrefab, this.MySound, pos, rot);
    }

    // public void MakeNoise() {
    //     AudioSource audioSrc = GetComponent<AudioSource>();
    //     audioSrc.clip = this.MySound;
    //     audioSrc.Play();
    // }

}