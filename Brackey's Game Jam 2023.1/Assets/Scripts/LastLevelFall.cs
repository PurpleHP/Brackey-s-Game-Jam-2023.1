using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LastLevelFall : MonoBehaviour
{
    [SerializeField] GameObject Wall;
    [SerializeField] GameObject Explosion;


    private Animator a;
    void Start()
    {
        a = Wall.GetComponent<Animator>();
        Explosion.SetActive(false);
        a.enabled = false;

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            a.enabled = true;
            Explosion.SetActive(true);

        }
    }

}
