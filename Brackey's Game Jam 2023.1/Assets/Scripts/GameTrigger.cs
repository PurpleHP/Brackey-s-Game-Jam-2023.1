using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using TMPro;


public class GameTrigger : MonoBehaviour
{
    [SerializeField] GameObject Terrain;
    private TilemapRenderer tr;

    [SerializeField] float counter = 0f;

    [SerializeField] float bodyTime;
    [SerializeField] float eyesTime;
    [SerializeField] float moveTime;
    [SerializeField] float jumpTime;
    [SerializeField] float dashTime;


    [SerializeField] GameObject PlayerDemo;
    [SerializeField] GameObject PlayerBody;

    private SpriteRenderer sr;
    private SpriteRenderer eye;

    [SerializeField] GameObject Portal;

    [SerializeField] GameObject PlayerMovement;
    private PlayerMovement pm;

    private Dialogue dia;
    [SerializeField] float[] dialogueTime;
    private bool checkDia = true;

    [SerializeField] TextMeshProUGUI textDisplay;
    [SerializeField] string[] sentences;
    [SerializeField] float typingspeed;
    private int index;

    void Start()
    {
        sr = PlayerDemo.GetComponent<SpriteRenderer>();
        eye = PlayerBody.GetComponent<SpriteRenderer>();

        pm = PlayerMovement.GetComponent<PlayerMovement>();
        tr = Terrain.GetComponent<TilemapRenderer>();
        StartCoroutine(Type());

    }

    void Update()
    {
        counter += Time.deltaTime;
        
        if (counter > bodyTime)
        {
            sr.enabled = true;
        }
        if (counter > moveTime)
        {
            pm.enabled = true;
        }

         if (counter > eyesTime){
            eye.enabled = true;
            tr.enabled = true;
            Portal.transform.position = new Vector3(11.29f, -5.456f, 0);
        }
        if (counter > jumpTime){
            pm.jumpMove = true;
        }
        if (counter > dashTime){
            pm.dashMove = true;
        }
        foreach(float a in dialogueTime){
            if((a < counter && a > counter-0.8) && checkDia){
                checkDia = false;
                 StartCoroutine(NextSentences());
            }
        }


    }
    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingspeed);
        }
    }
    IEnumerator NextSentences()
    {
        if(index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
            yield return new WaitForSeconds(1);
            checkDia = true;
        }
    }
}
