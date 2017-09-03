using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumPadManager : MonoBehaviour {

    private string number;
    private InputField target;
    public GameObject previewObject;
    Text previewText;
    
	// Use this for initialization
	void Start () {
        previewText = previewObject.GetComponent<Text>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void SetTarget(InputField target)
    {
        this.target = target;
        number = target.text;
        previewText.text = number;
    }

    public void InputNumber(string s)
    {
        number += s;
        Debug.Log("Number = " + number);
        previewText.text = number;
    }

    public void BackSpace()
    {
        Debug.Log("Delete");
        
        if (number != null && number.Length > 0)
        {
            number = number.Substring(0, number.Length - 1);
            previewText.text = number;
            Debug.Log("Number = " + number);
        }else
        {
            Debug.Log("Number length = 0");
        }
    }
    public void Enter()
    {
        target.GetComponent<InputFieldManager>().SetText(number);
    }
}
