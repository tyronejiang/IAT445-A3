using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectScore : MonoBehaviour
{
    public AudioSource collectSound;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") // check if player collide with coins
        {
            collectSound.Play(); // play collect coins soundeffect
            ScoreSystem.theScore += 50; // add socre
            Destroy(gameObject); // destory the coin after score add
        }
        
    }
}
