using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] GameObject Player;
    private Animator a;
    void Start()
    {
        a = Player.GetComponent<Animator>();

    }


    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            a.enabled = true;
        }
    }
}
