using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{


    public List<GameObject> targets;
    public Button restartButton;
    public TextMeshproUGUI gameOverText;
    private object gameManager;
    public object GameOver;

    public void GameOver1()
    {

        restartButton.gameObject.SetActive(true);
        



    }


    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);



    }
    // Start is called before the first frame update
    void Start()
    {



    }


    public void gameOver()
    {


        gameOverText.gameObject.Equals(true);

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
