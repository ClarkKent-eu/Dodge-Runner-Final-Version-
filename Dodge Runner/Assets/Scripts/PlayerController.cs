using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 40.0f;
    private Rigidbody playerRb;
    public float jumpForce = 17;
    public float gravityModifier;
    public bool isOnGround = true;
    private Vector3 startPos;
    public bool gameOver = false;
    private AudioSource playerAudio;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    public AudioClip pickup;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public bool hasPowerup;
    public GameObject gameOverText;
    public GameObject LevelPassedText;
    public GameObject VictoryDance;
    public AudioSource Audio;



    // Start is called before the first frame update
    void Start()

    {
        startPos = this.transform.position;

        playerRb = GetComponent<Rigidbody>();
        playerAudio = GetComponent<AudioSource>();
        Physics.gravity *= gravityModifier;



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)//When the space bar is pressed the player exert a jumpforce 
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAudio.PlayOneShot(jumpSound, 1.0f);
            dirtParticle.Stop();

        }



        transform.Translate(Vector3.forward * Time.deltaTime * speed);


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {

            Destroy(other.gameObject);
            hasPowerup = true;
            speed = 20;
            jumpForce = 30;

            playerAudio.PlayOneShot(pickup, 1.0f);


        }

    }




    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticle.Stop();

        }

        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            //If the player collides with the obstacle "an object with the tag osbstacle"
            isOnGround = false;

            //Game Over 
            Debug.Log("Game Over!");
            Destroy(gameObject);
            playerAudio.PlayOneShot(crashSound, 1.0f);
            explosionParticle.Play();


            dirtParticle.Stop();


            //For the game over text to appearr on the screen 
            gameOverText.SetActive(true);




            explosionParticle.Play();

        }

        if (collision.gameObject.CompareTag("LevelPassed"))
        {

            Destroy(gameObject);
            Debug.Log("Level Passed!");
            LevelPassedText.SetActive(true);
            VictoryDance.SetActive(true);




        }


        if (collision.gameObject.CompareTag("enemy"))
        {
            Destroy(gameObject);
            gameOverText.SetActive(true);
            



        }


   

    }


}        
            
    


