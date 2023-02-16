using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManagment : MonoBehaviour
{
    [SerializeField] Image black;
    [SerializeField] int index;
    [SerializeField] Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //StartCourutine(Fading());
    }

    IEnumerator Fading(){
        anim.SetBool("Fade", true);
        yield return new WaitUntil(()=>black.color.a == 1);
        SceneManager.LoadScene(index);
    }
}
