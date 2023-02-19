using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Final : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject Player;

    [SerializeField] Image black;
    [SerializeField] int nextLevel;
    [SerializeField] Animator anim;

    [SerializeField] GameObject DialogManager;
    private Dialogue dia;
    void Start()
    {
        dia = DialogManager.GetComponent<Dialogue>();
    }

 
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            dia.startConv = true;
            StartCoroutine(NextLevel());
        }
    }
    IEnumerator NextLevel()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(()=>black.color.a == 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
