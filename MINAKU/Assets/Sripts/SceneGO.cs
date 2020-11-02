using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneGO : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (HeartsHealthVisual.isDead == true)
        {
            SceneManager.LoadScene("GameOver");
        }
        else
        {
            HeartsHealthVisual.heartsHealthSystemStatic.Damage(4);
        }

    }
}
