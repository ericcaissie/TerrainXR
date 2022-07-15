using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimation : MonoBehaviour
{

    //public float rotateSpeed = 5f;
    public GameObject Player;
    private float maxDist = 3.0f;
    //public bool doorIsOpen = false
    private Animator playerAnim;
    private AudioSource playerAudio;
    public AudioClip openDoor;
    public AudioClip closeDoor;
    private float soundFX = 0.3f;


    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(Player.transform.position, transform.position) < maxDist)
        {
            //exclamationObject.SetActive(false);
            //animator.SetBool("IsWaving", false);
            //animator.SetTrigger("Walk");
            gameObject.GetComponent<Animator>().enabled = true;
            //animator.SetTrigger("Walk");
            //transform.position = new Vector3(11.68f, 2.67f, -7.4f);
            //transform.rotation = new Quaternion(0, 0, 0, 0);
            //GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 0);
            playerAnim.SetTrigger("OpenDoor");
            playerAudio.PlayOneShot(openDoor, soundFX);

        }


    }
}
