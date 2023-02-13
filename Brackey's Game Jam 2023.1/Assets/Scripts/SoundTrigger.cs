using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    [SerializeField] AudioSource triggerSound;
    void OnTriggerEnter2D(Collider2D other)
    {
        triggerSound.Play();
    }

}