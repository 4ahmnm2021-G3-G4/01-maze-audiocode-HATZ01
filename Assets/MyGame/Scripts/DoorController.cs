using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    public GameObject door;
    public float speed;
    public Vector3 target = new Vector3(1.953262f, 3.338906f, 0.1712306f);
    public AudioSource audioData;
    public AudioSource audioData2;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        audioData2 = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.name == "Egg")
        {
            // door.transform.position = target;
            animator.SetBool("doorOpen", true);
            audioData.Play();
            audioData2.Play();
        }
    }
}
