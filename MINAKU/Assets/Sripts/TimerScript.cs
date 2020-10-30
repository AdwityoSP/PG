using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TimerScript : MonoBehaviour
{
    public static float score;

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
            scoreText.text = "Anda selesai dalam " + (score / 100).ToString() + "s";
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
