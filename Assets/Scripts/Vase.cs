using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vase : MonoBehaviour
{
    public GameObject egg;
    public GameObject vase;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.name == "Tullip")
        {
            Debug.Log("Flowers");
            egg.GetComponent<Rigidbody>().useGravity = true;
            vase.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
