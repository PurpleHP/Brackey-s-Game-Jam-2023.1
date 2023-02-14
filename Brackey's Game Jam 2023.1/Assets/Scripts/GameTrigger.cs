using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTrigger : MonoBehaviour
{
    [SerializeField] GameObject PlayerBody;
    private SpriteRenderer sr;

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
        else
        {
            check = true;
        }

    }
}
