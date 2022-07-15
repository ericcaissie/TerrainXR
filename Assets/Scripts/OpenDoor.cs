using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    //public float rotateSpeed = 5f;
    public GameObject Player;
    private float maxDist = 4.0f;
    //public bool doorIsOpen = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(Player.transform.position, transform.position) > maxDist)
        {
            //exclamationObject.SetActive(false);
            //animator.SetBool("IsWaving", false);
            //animator.SetTrigger("Walk");
            //gameObject.GetComponent<MoveTo>().enabled = true;
            //animator.SetTrigger("Walk");
            //transform.position = new Vector3(11.68f, 2.67f, -7.4f);
            //transform.rotation = new Quaternion(0, 0, 0, 0);
            GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 0);
           
        }

        if (Vector3.Distance(Player.transform.position, transform.position) < maxDist)
        {
            //exclamationObject.SetActive(false);
            //animator.SetBool("IsWaving", false);
            //animator.SetTrigger("Walk");
            //gameObject.GetComponent<MoveTo>().enabled = true;
            //animator.SetTrigger("Walk");
            //transform.position = new Vector3(11.68f, 2.67f, -7.4f);
            //transform.rotation = new Quaternion(0, 90, 0, 0);
            GetComponent<Transform>().rotation = Quaternion.Euler(0, 90, 0);
        }
    }

    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //transform.rotation *= Quaternion.Euler(0, 90f * rotateSpeed * Time.deltaTime, 0);
            //transform.position = new Vector3(11.68f, 2.67f, -7.4f);
            transform.rotation = new Quaternion(0, 90, 0, 0);
        }
    }
    */


    

    
}
