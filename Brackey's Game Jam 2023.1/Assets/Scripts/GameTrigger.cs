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

    [SerializeField] GameObject Portal;

    [SerializeField] GameObject PlayerMovement;
    private PlayerMovement pm;

    [SerializeField] float counter = 0f;
    public bool check;  

    void Start()
    {
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
            Portal.transform.position = new Vector3(11.29f, -5.456f, 0);
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
