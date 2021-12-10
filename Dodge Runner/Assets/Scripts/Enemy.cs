using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class Enemy: MonoBehaviour
{

    public Rigidbody enemyRb;
    public float speed;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("player");




    }

    // Update is called once per frame
    void Update()
    {
        enemyRb.AddForce((player.transform.position - transform.position).normalized * speed);
        


    }
}
