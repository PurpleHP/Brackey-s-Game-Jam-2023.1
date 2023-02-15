using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform Player; //the camera follow that object.
    [SerializeField] private float dampTime = 0.4f; //camera move more smooth
    private Vector3 cameraPos; //whic is where we want the camera move to
    private Vector3 velocity = Vector3.zero;
    [SerializeField] private float camHeight = 0f;


    void FixedUpdate()
    {
        if(Player.position.x > -2)
        {
            cameraPos = new Vector3(Player.position.x, camHeight, -10f);
            transform.position = Vector3.SmoothDamp(gameObject.transform.position, cameraPos, ref velocity, dampTime);
        }
    }
}
