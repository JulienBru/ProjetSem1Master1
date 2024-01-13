using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TreasureHunt : MonoBehaviour
{
    private int score = 0;
    private int targetScore = 6;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Treasure"))
        {
            Destroy(other.gameObject);

            score++;

            Debug.Log("Score: " + score);

            if (score >= targetScore)
            {
                Debug.Log("Vous avez gagné !");
            }
        }
    }
}

