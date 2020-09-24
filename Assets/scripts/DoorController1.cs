using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using TMPro;
using UnityEngine;


public class DoorController1 : MonoBehaviour
{
    public TextMeshProUGUI CountText;
    public GameObject winTextObject;
    public GameObject dooropen;
    private void Start()
    {
        dooropen.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
   {
        dooropen.SetActive(true);

        if (other.tag == "Door")     
        {
           Animator anim = other.GetComponentInChildren<Animator>();
           if (Input.GetKeyDown(KeyCode.E))
            anim.SetTrigger("OpenClose");
        }
   }
}
