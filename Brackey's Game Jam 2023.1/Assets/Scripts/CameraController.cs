using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform Player; //the camera follow that object.
    [SerializeField] private float dampTime = 0.4f; //camera move more smooth
    private Vector3 cameraPos; //whic is where we want the camera move to
    private Vector3 velocity = Vector3.zero;
    [SerializeField] private CamShake camShake;


    void FixedUpdate()
    {
        if(!camShake.start){
            cameraPos = new Vector3(Player.position.x, Player.position.y, -10f);
            transform.position = Vector3.SmoothDamp(gameObject.transform.position, cameraPos, ref velocity, dampTime);
        }
       
    }
}
