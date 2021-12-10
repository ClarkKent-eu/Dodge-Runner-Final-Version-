using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{


    public List<GameObject> targets;
    //Restart button function

    public Button restartButton;
    public TextMeshproUGUI gameOverTextUGUI;


    private object gameManager;


    public object GameOver;
    private TextMeshPro gameOverTextUIGUI;

    public void GameOver1()
    {

        restartButton.gameObject.SetActive(true);
        



    }


    public void playGame()
    {
        // play game function for the menu
        



    }


    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);



    }
    // Start is called before the first frame update
    void Start()
    {
        
        gameOverTextUIGUI = GetComponent<TextMeshPro>();
        gameOverTextUIGUI.enabled = true;
    }





    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (!gameObject.CompareTag("GameOver"))
        {
         


        }


    }



    // Update is called once per frame
    void Update()
    {
        




    }
}
