using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLife : MonoBehaviour
{
    public AudioSource lifesound;
    void Update()
    {
        transform.Rotate(0, 1, 0, Space.World);
    }

    void OnTriggerEnter(Collider other)
    {
        lifesound.Play();
        GlobalLife.lifeValue += 1;
        this.gameObject.SetActive(false);
    }
}
