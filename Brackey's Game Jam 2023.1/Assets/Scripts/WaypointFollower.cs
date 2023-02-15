using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] Transform[] Waypoints;
    int waypointindex = 0;
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] Rigidbody2D rotate;

    void Start()
    {
        transform.position = Waypoints[waypointindex].transform.position;
        rotate = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, Waypoints[waypointindex].transform.position, moveSpeed * Time.deltaTime);
        if (waypointindex == 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));

        }
        else
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));

        }
        if (transform.position == Waypoints[waypointindex].transform.position)
        {
            waypointindex += 1;
        }
        if (waypointindex == Waypoints.Length)
        {
            waypointindex = 0;
        }
    }
}
