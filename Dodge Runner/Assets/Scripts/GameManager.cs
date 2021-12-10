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
    


    private object gameManager;





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
        SceneManager.LoadScene("Main Menu 1");



    }
    // Start is called before the first frame update
    void Start()
    {
        
  
        
    }


    



    // Update is called once per frame
    void Update()
    {
        




    }
}
