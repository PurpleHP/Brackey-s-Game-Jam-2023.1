using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Portal : MonoBehaviour
{
    [SerializeField] GameObject Player;

    [SerializeField] Image black;
    [SerializeField] int nextLevel;
    [SerializeField] Animator anim;
    private Animator a;
    [SerializeField] private bool playAnim = true;
    void Start()
    {
        a = Player.GetComponent<Animator>();
    }


 
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if(playAnim){
                a.enabled = true;
            }
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
