using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;




public class GameOver : MonoBehaviour


{

    public TextMeshProUGUI gameOverText;
    private object gameManager;



    // Start is called before the first frame update
    void Start()


    {



    }




    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("Game Over!");
        Destroy(gameObject);

       
      


    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
