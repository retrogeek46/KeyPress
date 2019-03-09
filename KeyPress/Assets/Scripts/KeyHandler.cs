using System;
using UnityEngine;
using UnityEngine.UI;

public class KeyHandler : MonoBehaviour {

    //passed as argument in function
    public GameObject[] keysSetter;
    //setter for above array
    public static GameObject[] keys; 
    //string
    private static string[] keyNames = {"Oem3", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "D0", "OemMinus", "Oemplus", "Back",
                                        "Tab", "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "Oem4", "Oem6",
                                        "CapsLock", "A", "S", "D", "F", "G", "H", "J", "K", "L", "OemSemicolon", "Oem7", "OemPipe", "Return",
                                        "LShiftKey", "Z", "X", "C", "V", "B", "N", "M", "Oemcomma", "OemPeriod", "Oem2", "RShiftKey",
                                        "LControlKey", "LWin", "LMenu", "Space", "RMenu", "RWin", "Apps", "RControlKey",
                                        "Up", "Left", "Down", "Right",
                                        "Insert", "Home", "PageUp", "Delete", "End", "PageDown" };

    // Use this for initialization
    void Awake() {
        //initialize static gameobject array from inspector values
        keys = keysSetter;
    }
    
    //change color of key in scene based on key press
    static void ChangeKeyColor(GameObject key, bool pressed) {
        if (pressed) {
            key.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        } else if (!pressed) {
            key.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }
        
    }
    
    //Takes string argument and calls PressKey
    public static void ChangeKey(string searchString, bool pressed) {
        //arrows
        int index = Array.IndexOf(keyNames, searchString);
        if (index > -1) {
            ChangeKeyColor(keys[index], pressed);
        } 
    }
}
