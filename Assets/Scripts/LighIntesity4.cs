using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LighIntesity4 : MonoBehaviour
{
    GameObject[] lights;


    // Start is called before the first frame update
    void Start()
    {
        lights = GameObject.FindGameObjectsWithTag("lights");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject player = other.gameObject;
        if (player.CompareTag("Player"))
        {
            foreach (GameObject light in lights)
            {
                light.GetComponent<Light>().intensity = 0.8f;
            }
        }
    }
}
