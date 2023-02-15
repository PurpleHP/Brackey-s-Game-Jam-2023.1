using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameTrigger : MonoBehaviour
{
    [SerializeField] GameObject Terrain;
    private TilemapRenderer tr;

    [SerializeField] GameObject PlayerBody;
    private SpriteRenderer sr;
    

    [SerializeField] GameObject PlayerMovement;
    private PlayerMovement pm;
    [SerializeField] Animator a;

    [SerializeField] float counter = 0f;
    public bool check;  
    [SerializeField] Animation anim;
    void Start()
    {
        anim = PlayerBody.GetComponent<Animation>();
        a = PlayerBody.GetComponent<Animator>();
        sr = PlayerBody.GetComponent<SpriteRenderer>();
        pm = PlayerMovement.GetComponent<PlayerMovement>();
        tr = Terrain.GetComponent<TilemapRenderer>();
    }


    void Update()
    {
        if(counter >= 0f)
        {
            counter += Time.deltaTime;
        }
        if (counter > 5f)
        {
            sr.enabled = true;
            pm.enabled = true;
        }
         if (counter > 10f){
            tr.enabled = true;
        }
        if (counter > 15f){
            pm.jumpMove = true;
        }
        if (counter > 20f){
            pm.dashMove = true;
        }
        else
        {
            check = true;
        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Portal")){
            a.enabled = true;
            //anim.Play();
        }
    }
}
