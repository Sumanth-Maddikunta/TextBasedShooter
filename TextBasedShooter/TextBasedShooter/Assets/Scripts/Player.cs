using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    //public Text text;

    public TouchScreenKeyboard keyboard;//Phone
    public string textInput;

    public InputField inputField;//PC
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        /* keyboard= TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, false, false);
         textInput = keyboard.text;*/

        textInput = inputField.text;

        Debug.Log(" Player :" + textInput);
        
    }
}
