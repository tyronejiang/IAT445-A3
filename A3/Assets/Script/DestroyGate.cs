using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGate : MonoBehaviour
{
   public AudioSource gateSound;
   [SerializeField] private GateAnimator gate;

   void Start (){
       gateSound = GetComponent<AudioSource>(); //get soundeffect
    }
    void OnTriggerEnter(Collider other)
    {
        if (ScoreSystem.theScore >= 250) //check score
        {
            gate.OpenDoor(); //animate open door
            gateSound.Play(); //play soundeffect
        }
        
            
            
            
        
        
    }
    void OnTriggerExit(Collider other){
        gate.CloseDoor(); //animate close door
    }
    
}

