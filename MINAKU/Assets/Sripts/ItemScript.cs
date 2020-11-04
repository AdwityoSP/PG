using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemScript : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        HeartsHealthVisual.heartsHealthSystemStatic.Heal(2);
        Destroy(this.gameObject);


    }
}
