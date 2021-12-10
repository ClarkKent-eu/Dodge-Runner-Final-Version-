using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class playButton : MonoBehaviour
{


    public string URL= "https://clarkkent-eu.github.io/Dodge-Runner-Final-Version-/";
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


    public void sourcecode()
    {

        Application.OpenURL("The source code on Github");

    }

}
