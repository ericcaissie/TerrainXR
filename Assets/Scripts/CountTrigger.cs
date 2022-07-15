using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountTrigger : MonoBehaviour
{
    GameObject[] lights;
    public int ballCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        lights = GameObject.FindGameObjectsWithTag("lights");
    }

    // Update is called once per frame
    void Update()
    {
        if (ballCount == 4)
        {
            foreach (GameObject light in lights)
            {
                light.GetComponent<Light>().intensity = 0.1f;
            }
            ballCount = 0;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ballCount++;
            other.enabled = false;
            //Destroy(gameObject);

        }
    }
}
