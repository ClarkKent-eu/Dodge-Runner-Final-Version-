using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{

    public TextMeshPro GameOver;

    public float speed = 40.0f;
    private Rigidbody playerRb;
    public float jumpForce = 17;
    public float gravityModifier;
    public bool isOnGround = true;
    private Vector3 startPos;
    public bool gameOver = false;



    // Start is called before the first frame update
    void Start()

    {
        startPos = this.transform.position;

        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)//When the space bar is pressed the player exert a jumpforce 
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }



        transform.Translate(Vector3.forward * Time.deltaTime * speed);


    }




    private void OnCollisionEnter(Collision collision)
    {



        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }

        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            //If the player coolides with the obstacle "an object with the tag osbstacle"

            gameOver = true;
            //Game Over 
            Debug.Log("Game Over!");
            Destroy(gameObject);
            gameObject.SetActive(true);
            GameOver.text = "Game Over";



                }


    }

}


        
            
    


