using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class playButton : MonoBehaviour
{
public void GotoMapMenu()
    {

        SceneManager.LoadScene("Main Menu 2");


    }

    public void Map1()
    {
        SceneManager.LoadScene("Map 1");

    }

    public void Map2()
    {
        SceneManager.LoadScene("Map 2");



    }


}
