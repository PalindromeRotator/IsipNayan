using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TextFieldScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_InputField text;
    void Start()
    {
        // Debug.Log(text.text);
    }
    public string CopyText(){
        return text.text;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
