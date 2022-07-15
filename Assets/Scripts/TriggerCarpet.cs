using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCarpet : MonoBehaviour
{
    GameObject[] lights;
    public GameObject Player;
    //public GameObject lightsHolder;
    //GameObject.FindObjectOfType<Light>


    // Start is called before the first frame update
    void Start()
    {
        lights = GameObject.FindGameObjectsWithTag ("lights");
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
            //transform.rotation *= Quaternion.Euler(0, 90f * rotateSpeed * Time.deltaTime, 0);
            //transform.position = new Vector3(11.68f, 2.67f, -7.4f);
            //transform.rotation = new Quaternion(0, 90, 0, 0);
            //lights.GetComponent<Light>().color = Color.red;
            //GameObject.FindGameObjectsWithTag("lights").

            //for (int i = 0; i < lights.Count; i++)
            //{
            //lights[i].GetComponent<Light>().color = Color.red;
            //}
            Debug.Log("you have triggered the carpet");
            //lightsHolder.SetActive(true);
            foreach (GameObject light in lights)
            {
                light.GetComponent<Light>().color = Color.white;
            }
        }
    }
}
