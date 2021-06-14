using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    public GameObject door;
    public Vector3 target = new Vector3(1.953262f, 3.338906f, 0.1712306f);

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.name == "Egg")
        {
            door.transform.position = target;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
