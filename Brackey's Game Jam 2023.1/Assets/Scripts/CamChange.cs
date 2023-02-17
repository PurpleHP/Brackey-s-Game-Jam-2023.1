using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamChange : MonoBehaviour
{
    // Start is called before the first frame update [SerializeField] GameObject Wall;
    private CameraController pm;
    [SerializeField] GameObject CameraController;

    void Start()
    {
        pm = CameraController.GetComponent<CameraController>();
        pm.enabled = false;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            pm.enabled = true;
        }
    }
}
