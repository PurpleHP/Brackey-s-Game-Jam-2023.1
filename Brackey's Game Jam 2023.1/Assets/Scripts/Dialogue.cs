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

    void Start()
    {
        StartCoroutine(Type());
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

        foreach (float a in dialogueTime)
        {
            if ((a < counter && a > counter - 0.8) && checkDia)
            {
                checkDia = false;
                StartCoroutine(NextSentences());
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
