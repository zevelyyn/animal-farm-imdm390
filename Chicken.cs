using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Monobehavior {
    // pathways to prefabs and sounds (can be changed)
    const public GameObject[4] prefabs = [Resources.Load<GameObject>("Assets/Resources/healthyChicken.png"),
                                         Resources.Load<GameObject>("Assets/Resources/fatChicken.png"), 
                                         Resources.Load<GameObject>("Assets/Resources/steroidChicken.png"), 
                                         Resources.Load<GameObject>("Assets/Resources/sickChicken.png")];
    const public AudioClip[4] sounds = [Resources.Load<AudioClip>("Assets/Resources/healthyAudio"),
                                        Resources.Load<AudioClip>("Assets/Resources/fatAudio"),
                                        Resources.Load<AudioClip>("Assets/Resources/steroidAudio"), 
                                        Resources.Load<AudioClip>("Assets/Resources/sickAudio")];
    public GameObject MyPrefab;
    public AudioClip MySound;
    void Start() {
        MyChicken(prefabs[0], audios[0], new Vector3(0, 0, 0), Quaternion.identity); // instantiate healthy chicken
    }

    void Update() {
    }


    public void MyChicken(GameObject prefab, Audioclip sound, Vector3 pos, Quaternion rot) {
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
        MyChicken(prefabs[idx], sounds[idx], transform.position, transform.rotation);
        Destroy(gameObject);
    }

    // create new chicken w/ same status
    public void NewChicken(Vector3 posOffset, Quaternion rotOffset) { // new chicken's position and rotation WRT curr chicken, respectively
        MyChicken(this.MyPrefab, this.MySound, transform.position + posOffset, transform.rotation + rotOffset);
    }

    public void MakeNoise() {
        AudioSource audioSrc= GetComponent<AudioSource>();
        audioSrc.clip = this.MySound;
        audioSrc.Play();
    }

}