using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScreenWin : MonoBehaviour
{
    //Connect stars with score tab on the right of the screen then save it into an array
    public GameObject[] stars;

    public Text textTitle;
    public static int scoring;


    public void Show(int errors)
    {
        textTitle.text = (PlayerPrefs.GetString("lang") == "In" ? "Luar Biasa!" : "Wonderful!");

        // Remove all previous stars
        for (int i = 0; i < stars.Length; i++)
        {
            stars[i].SetActive(false);
        }
        // Show all stars depending on the number of tries
        for (int i = 0; i < stars.Length - errors; i++)
        {
            stars[i].SetActive(true);
            //add array of stars as points to be represented into the score located in score manager
            //when player leaves game the core is saved into a highscore
            //when player finishes all the words then they can save their score into the highscores


        }
        // Show the Win popup
        gameObject.SetActive(true);
        SoundEngine.instance.PlaySound(SoundEngine.instance.audioWin);

        //add scoring function here

    }


    public void Close()
    {
        gameObject.SetActive(false);
    }


}
