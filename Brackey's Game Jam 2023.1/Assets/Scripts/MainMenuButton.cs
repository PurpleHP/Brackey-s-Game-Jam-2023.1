using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuButton : MonoBehaviour
{
    // Start is called before the first frame update    [SerializeField] Image black;
    [SerializeField] int goToLevel;
    [SerializeField] Animator anim;
    [SerializeField] Image black;

    void Awake()
    {
        StartCoroutine(NextLevel());

    }


    IEnumerator NextLevel()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(()=>black.color.a == 1);
        SceneManager.LoadScene(goToLevel);
    }
    
}
