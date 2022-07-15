using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBlue : MonoBehaviour
{
    GameObject[] lights;
    //public GameObject lightsHolder;

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
            //lightsHolder.SetActive(true);
           
            foreach (GameObject light in lights)
            {
                light.GetComponent<Light>().color = Color.blue;
            }
        }
    }
}
