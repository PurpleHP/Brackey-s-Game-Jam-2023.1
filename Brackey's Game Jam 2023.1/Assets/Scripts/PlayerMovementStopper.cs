using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementStopper : MonoBehaviour
{
    [SerializeField] GameObject PlayerMovement;
    private PlayerMovement pm;
    // Start is called before the first frame update
    void Start()
    {
        pm = PlayerMovement.GetComponent<PlayerMovement>();

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player")){
            pm.enabled = false;
        }
    }
}
