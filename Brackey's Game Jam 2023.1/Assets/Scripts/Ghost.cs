using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject player;
    [SerializeField] private float speedX;
    [SerializeField] private float speedY;
    [SerializeField] private Rigidbody2D rb;
    public bool startingGhost = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(startingGhost){
            if ((transform.position.x - player.transform.position.x) > 0.08)
            {
                speedX = -Mathf.Abs(speedX);
                transform.rotation = Quaternion.Euler(new Vector3(0,180,0));

            }
            else if ((transform.position.x - player.transform.position.x) < -0.08)
            {
                speedX = Mathf.Abs(speedX);
                transform.rotation = Quaternion.Euler(new Vector3(0,0,0));

            }
            if ((transform.position.y - player.transform.position.y) > 0.08)
            {
                speedY = -Mathf.Abs(speedY);
            }
            else if ((transform.position.y - player.transform.position.y) < -0.08)
            {
                speedY = Mathf.Abs(speedY);
            }
            rb.velocity = new Vector2(speedX, speedY);
        }
        

    }
}
