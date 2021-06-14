using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController : MonoBehaviour
{

    public GameObject egg;
    public GameObject vase1;
    public GameObject vase2;
    public GameObject vase3;

    private void EggGravity()
    {

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (vase1.activeInHierarchy == true && vase2.activeInHierarchy == true && vase3.activeInHierarchy == true)
        {
            egg.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
