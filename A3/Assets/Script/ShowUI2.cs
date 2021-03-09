using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI2 : MonoBehaviour
{
    public GameObject uiObject;
    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false); // hide GUI when game start
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (DestoryCrabs.theCrab < 1){ // check if crab is killed
                uiObject.SetActive(true); // show GUI
                StartCoroutine("WaitForSec"); // hide GUI after a few seconds
            }
            else
            {
                Destroy(gameObject);
            }
            
            

        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3); // wait for 3 seconds
        uiObject.SetActive(false); // hide GUI

        
    }
}
