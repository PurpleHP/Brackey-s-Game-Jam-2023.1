using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yellow : MonoBehaviour
{
    [SerializeField] GameObject whiteIsCorrect;
    private bool whiteCheck;
    [SerializeField] GameObject redIsCorrect;
    // Start is called before the first frame update
    void Start()
    {
        whiteCheck = true;
        whiteIsCorrect.SetActive(true);
        redIsCorrect.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Change();
            Destroy(gameObject);
        }
    }
 
    void Change(){
        if(whiteCheck){
            whiteIsCorrect.SetActive(false);
            redIsCorrect.SetActive(true);
            whiteCheck = false;

        }else{
            whiteIsCorrect.SetActive(true);
            redIsCorrect.SetActive(false);
            whiteCheck = true;
        }
    }
}
