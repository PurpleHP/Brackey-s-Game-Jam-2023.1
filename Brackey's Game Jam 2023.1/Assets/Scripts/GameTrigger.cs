using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTrigger : MonoBehaviour
{
    [SerializeField] GameObject PlayerBody;
    private SpriteRenderer sr;
    //[SerializeField] SpriteRenderer tr;

    [SerializeField] GameObject PlayerMovement;
    private PlayerMovement pm;

    [SerializeField] float counter = 0f;
    public bool check;  

    void Start()
    {
        sr = PlayerBody.GetComponent<SpriteRenderer>();
        pm = PlayerMovement.GetComponent<PlayerMovement>();
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
            //tr.enabled = true;
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
}
