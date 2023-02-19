using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGhost : MonoBehaviour
{
    [SerializeField] GameObject Ghost;
    [SerializeField] GameObject DialogManager;
    private Dialogue dia;
    private Ghost ghost;
    void Start()
    {
         ghost = Ghost.GetComponent<Ghost>();
         dia = DialogManager.GetComponent<Dialogue>();
    }
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ghost.startingGhost = true;
            dia.startGhost = true;
        }
    }
}
