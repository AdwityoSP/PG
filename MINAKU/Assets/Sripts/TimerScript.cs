using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TimerScript : MonoBehaviour
{
    public static float score;
    public static float highScore1 = 10000000000;

    public static float highScore2 = 10000000000;

    public static float highScore3 = 10000000000;

    public Text scoreText;

    public static string beforeScene;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Berhasil")
        {
            if (beforeScene == "MainGame1")
            {
                if (score < highScore1)
                {
                    highScore1 = score;
                }

                scoreText.text = "Anda selesai dalam " + (score / 100).ToString() + "s" + "\n" + "Waktu Tercepat di " + beforeScene + " " + (highScore1 / 100).ToString() + "s" + "\n";
            }


            if (beforeScene == "MainGame2")
            {
                if (score < highScore2)
                {
                    highScore2 = score;
                }

                scoreText.text = "Anda selesai dalam " + (score / 100).ToString() + "s" + "\n" + "Waktu Tercepat di " + beforeScene + " " + (highScore2 / 100).ToString() + "s" + "\n";
            }


            if (beforeScene == "MainGame3")
            {
                if (score < highScore3)
                {
                    highScore3 = score;
                }
                scoreText.text = "Anda selesai dalam " + (score / 100).ToString() + "s" + "\n" + "Waktu Tercepat di " + beforeScene + " " + (highScore3 / 100).ToString() + "s" + "\n";
            }





        }
        else if (SceneManager.GetActiveScene().name == "LevelMenu")
        {
            score = 0;
        }
        else
        {
            beforeScene = SceneManager.GetActiveScene().name;
            Debug.Log(beforeScene);
            scoreText.text = (score / 100) + "s";
            score = score + 1;
        }

    }


}
