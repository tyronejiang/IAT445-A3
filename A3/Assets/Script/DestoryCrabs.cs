using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryCrabs : MonoBehaviour
{
    [SerializeField] private string crabTag = "crab";
    public GameObject coins;
    public static int theCrab =0;
    void OnCollisionEnter(Collision col) // chekc if coconut collide with the crab
    {
        if(col.gameObject.CompareTag(crabTag))
        {
            Destroy(col.gameObject); // destory the crab
            theCrab+=1; // check how many crabs have been killed
            Instantiate (coins, transform.position, Quaternion.Euler(new Vector3(-90, 0, 0))); // drop a coin from where the crab died
        }
    }
}
