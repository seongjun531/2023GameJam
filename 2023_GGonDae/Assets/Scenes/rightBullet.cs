using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightBullet : MonoBehaviour
{
    GameObject player;
    public float bulletSpeed = 10.0f;

    void Start()
    {
        this.player = GameObject.Find("asdf");
        transform.position = this.player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(bulletSpeed * Time.deltaTime, 0, 0);
    }
}
