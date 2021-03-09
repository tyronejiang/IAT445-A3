using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runaway : MonoBehaviour
{
 [SerializeField] private string crabTag = "crab";
 
 private  Animator animator;
 private  Rigidbody rb;
 private float speed = 1f;
    private void Start()
    {
        animator = gameObject.GetComponent<Animator>(); // get animation
        rb = gameObject.GetComponent<Rigidbody>(); // get rigidbody
    }
    void Update() {
          var ray = Camera.main.ScreenPointToRay(Input.mousePosition); // create raycast
          RaycastHit hit;
          
          if (Physics.Raycast(ray , out hit)) // check if raycast hit the crab
          {
              if(hit.transform.CompareTag(crabTag)) {
                  
                      animator.SetBool("move", true); // enable the animation
                      rb.velocity = speed * Vector3.left; // move the crab
                    
              }
              
              else{
                  animator.SetBool("move", false); // stop the animation
              }

              
              
          }

              
          
      }
      
      
      
}
