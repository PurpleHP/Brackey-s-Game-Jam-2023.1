using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textDisplay;
    [SerializeField] float[] dialogueTime;
    [SerializeField] string[] sentences;
    [SerializeField] float typingspeed;
    [SerializeField] float counter = 0f;
    private bool checkDia = true;
    private int index;
    [SerializeField] private bool ghostLevel = false;
    public bool startGhost = false;
    [SerializeField] private bool lastLevel = false;

    public bool startConv = false;
    void Start()
    {
    }

    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingspeed);
        }
    }
    private void Update()
    {
        counter += Time.deltaTime;
        if(!ghostLevel){
            foreach (float a in dialogueTime)
            {
                if ((a < counter && a > counter - 0.8) && checkDia)
                {
                    checkDia = false;
                    StartCoroutine(NextSentences());
                }
            }
        }
        else if(ghostLevel){
            if(startGhost){
                StartCoroutine(Type());
                startGhost = false;
            }
        }
        else if(lastLevel){
            if(startConv){
                StartCoroutine(Type());
                startConv = false;
            }
           
        }
    }
        
    

    IEnumerator NextSentences()
    {
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
            yield return new WaitForSeconds(1);
            checkDia = true;
        }
    }
}
