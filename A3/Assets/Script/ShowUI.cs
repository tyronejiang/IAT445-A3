using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI : MonoBehaviour
{
    public GameObject uiObject;
  
    void Start()
    {
        uiObject.SetActive(false); // hide GUI when game start
    }

   
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (ScoreSystem.theScore < 250){ // check socre
                uiObject.SetActive(true); // show GUI
                StartCoroutine("WaitForSec"); // hide GUI after a few seconds
            }
            

        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3); // wait for 3 seconds
        uiObject.SetActive(false); // hide GUI
        
    }
}
