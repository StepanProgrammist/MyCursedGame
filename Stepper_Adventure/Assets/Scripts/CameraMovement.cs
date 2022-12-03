using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float movespeed = 2f;
    public Transform player;
    public float offsetX = -3f;
    public float offsetY = -1f;

    void Start()
    {
        Screen.SetResolution(1600, 900, true);
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (transform.position.x - player.position.x > Mathf.Abs(offsetX))
            transform.position += Vector3.left * movespeed * Time.deltaTime;
        else if (transform.position.x - player.position.x < offsetX)
            transform.position += Vector3.right * movespeed * Time.deltaTime;
        if (transform.position.y - player.position.y > Mathf.Abs(offsetY))
            transform.position += Vector3.down * movespeed * Time.deltaTime;
        else if (transform.position.y - player.position.y < offsetY)
            transform.position += Vector3.up * movespeed * Time.deltaTime;
    }
}
