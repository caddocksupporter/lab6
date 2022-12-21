using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class readData : MonoBehaviour
{
    protected FileInfo theSourceFile = null;
    protected StreamReader reader = null;
    protected string text = " "; // assigned to allow first line to be read below
    public GameObject Textbox;
    
    private int input;
    public Text DataNum;

    List<string> textList = new List<string>();

    string inputText;
    int userInput;


    void Start()
    {
        theSourceFile = new FileInfo("Assets/Resources/test.txt");
        reader = theSourceFile.OpenText();
        int.TryParse(GetComponent<InputField>().text, out input);
        print(input);
        //input = GetComponent<InputField>();
    }

    void Update()
    {
        if (text != null)
        {
            text = reader.ReadLine();
            textList.Add(text);

            text = GetComponent<Text>().text;
        }

        if (DataNum.text != null)
        {
            
            int.TryParse(DataNum.text, out userInput);
        }

        // match with input and output the correct value
        //int userInput = Int32.Parse(text);   // user input

        // read the corresponding result from user input
        if (textList.Count > userInput)
        {
            Textbox.GetComponent<Text>().text = (textList[userInput-1]);
        } else
        {
            Textbox.GetComponent<Text>().text = ("Out of index, no such item!");
        }
    }
}
