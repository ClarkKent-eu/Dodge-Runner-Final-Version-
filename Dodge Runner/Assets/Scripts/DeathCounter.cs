using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeathCounter : MonoBehaviour
{
    private int Death;
    public TextMeshProUGUI DeathCounter1;


    // Start is called before the first frame update
    void Start()
    {
        


 
        UpdateDeath(0);
    
        
    }

    private void UpdateDeath(int DeathToAdd)
    {

        Death += DeathToAdd;
        DeathCounter1.text = "Deaths: " + Death;



    }




    // Update is called once per frame
    void Update()
    {









        
    }
}
