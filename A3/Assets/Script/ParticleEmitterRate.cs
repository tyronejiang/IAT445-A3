using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParticleEmitterRate : MonoBehaviour
{
    private ParticleSystem ps; // get particle system
    public float hSliderValue = 0.1F; // set initial slider value
    private bool showGUI = false; // hide GUI when the game start
    private GUIStyle guiStyle = new GUIStyle(); // set GUI style
    
     

    void Start()
    {
        ps = GetComponent<ParticleSystem>(); //get particle system
        
    }

    void Update()
    {
        var main = ps.main; // get particel system main input
        main.startSize = hSliderValue; // get startsize of the particel system
    }

    void OnGUI()
    {
        GUI.color = SetGUIColor(); // set GUI color
        guiStyle.fontSize = 48; // set GUI font size
        guiStyle.normal.textColor = Color.white; // set GUI font color
    
        if (showGUI)
        {
            if(Input.GetKey("1")) // press keyboard 1
         {
             hSliderValue = hSliderValue -0.01F; // change slider value to left
         }
         else if(Input.GetKey("2")) // press keyboard 2
         {
             hSliderValue = hSliderValue+0.01F; // change slider value to right
         } 
         // set slider max/min value so it not extend out
         if (hSliderValue >1.0F)
         hSliderValue = 1.0F;
         if (hSliderValue <0.0F)
         hSliderValue =0.0F; 
         // create the slider to the screen
            hSliderValue = GUI.HorizontalSlider(new Rect(3*Screen.width/10 ,Screen.height/10, Screen.width/2,Screen.height/2), hSliderValue, 0.0F, 1.0F);
         // create text label to the screen
            GUI.Label(new Rect(new Rect(3*Screen.width/10 ,Screen.height/8, Screen.width/2,Screen.height/2)), "Control flame with 1 and 2 " ,guiStyle);          
       
        }
        
    }
    internal Color SetGUIColor()  // Set the GUI Color
    {
        return Color.white;
    }

    void OnTriggerEnter(Collider other) // check if player enter the GUItrigger
    {
        if (other.gameObject.tag == "Player")
        { 
            if (!showGUI)
             showGUI = true; // show GUI if it is not show
        }
    }

    void OnTriggerExit(Collider other) // check if player exit the GUItrigger
    {
        if (other.gameObject.tag == "Player")
        {
            if (showGUI)
             showGUI = false; // close GUI if it is show
        }
    }
}
