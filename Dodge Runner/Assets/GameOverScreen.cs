using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverScreen : MonoBehaviour

    
{
    public TextMeshProUGUI gameOverText;
    private object pointValue;



    // Start is called before the first frame update
    void Start()
    {
        



    }



    public void GameOver()
    {



        gameOverText.gameObject.SetActive(true);


    }


    private void OnMouseDown()
    {
      
    }

    private void OnTriggerEnter(Collider other)
    {

        if (!gameObject.CompareTag("GameOver"))
        {
           
        


        }

    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
