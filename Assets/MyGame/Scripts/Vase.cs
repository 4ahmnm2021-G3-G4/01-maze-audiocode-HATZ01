using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vase : MonoBehaviour
{
    public GameObject flower;
    public GameObject vase;

    public GameObject vaseAndFlower;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.tag == "tullip")
        {
            vase.SetActive(false);
            flower.SetActive(false);
            vaseAndFlower.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
