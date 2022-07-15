using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAudio : MonoBehaviour
{

    private AudioSource playerAudio;
    public AudioClip openDoor;
    public AudioClip closeDoor;
    private float soundFX = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        
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
            playerAudio.PlayOneShot(openDoor, soundFX);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        GameObject player = other.gameObject;
        if (player.CompareTag("Player"))
        {
            playerAudio.PlayOneShot(closeDoor, soundFX);
        }

    }
}
