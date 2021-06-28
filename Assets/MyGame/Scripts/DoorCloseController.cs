using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCloseController : MonoBehaviour
{
    public GameObject door;
    public Vector3 target = new Vector3();
    public AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider trigger)
    {
        Debug.Log("Trigger" + trigger.name);
        if (trigger.gameObject.name == "HeadCollider")
        {
            door.transform.position = target;
            audioData.Play();
            Debug.Log("Door Close Works");
        }
    }
}
