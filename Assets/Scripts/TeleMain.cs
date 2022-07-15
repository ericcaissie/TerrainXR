using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleMain : MonoBehaviour
{

    public GameObject character;
    public Transform NewLocation;
    //public GameObject NewCharacter;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        GameObject player = other.gameObject;
        if (player.CompareTag("Player"))
        {
            Debug.Log("collision acquired");
            character.transform.position = NewLocation.position;
        }
    }
}