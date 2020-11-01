using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TimerScript : MonoBehaviour
{
    public static float score;
    public static float highScore = 10000000000;

    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Berhasil")
        {
            if (score < highScore)
            {
                highScore = score;
            }
            scoreText.text = "Anda selesai dalam " + (score / 100).ToString() + "s" + "\n" + "Waktu Tercepat " + (highScore / 100).ToString() + "s" + "\n";

        }
        else if (SceneManager.GetActiveScene().name == "LevelMenu")
        {
            score = 0;
        }
        else
        {
            score = score + 1;
        }
        Debug.Log(score);

    }
}
