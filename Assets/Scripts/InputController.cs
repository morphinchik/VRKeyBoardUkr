using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InputController : MonoBehaviour
{
    public TMP_InputField myInputField = null;

    public void alphabetFunction()
    {
        if (this.gameObject.name == "BackSpace" )
        {
         myInputField.text = myInputField.text.Substring(0, myInputField.text.Length - 1);
        }
        else
        myInputField.text += this.GetComponentInChildren<TMP_Text>().text;    
    }
   

}
