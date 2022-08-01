using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandGunPickUp : MonoBehaviour
{
    public GameObject realHandGun;
    public GameObject fakeHandGun;
    public AudioSource handgunPickUpSound;
    public GameObject pickUpDisplay;
    public GameObject pistolImage;

    void OnTriggerEnter(Collider other)
    {
        realHandGun.SetActive(true);
        fakeHandGun.SetActive(false);
        handgunPickUpSound.Play();
        GetComponent<BoxCollider>().enabled = false;
        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<Text>().text = "HANDGUN";
        pickUpDisplay.SetActive(true);
        pistolImage.SetActive(true);
    }
}
