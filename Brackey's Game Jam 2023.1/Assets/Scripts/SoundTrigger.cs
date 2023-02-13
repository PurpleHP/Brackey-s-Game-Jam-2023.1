using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    [SerializeField] AudioSource triggerSound;
    private bool touched = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(!touched){
            triggerSound.Play();
            touched = true;
        }
    }

}