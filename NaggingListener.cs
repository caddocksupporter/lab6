using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NaggingListener : MonoBehaviour
{
    public bool IsTalking = false;
    string Words = "switch";
    public string QCode = null;

    void StartAsking(string[] args)
    {
        IsTalking = true;

        if (IsTalking == true)
        {
            Console.WriteLine("Ask what you want"); //input integer from 001 to 999
            Words = QCode;
            string Qcode = Console.ReadLine(); //read your input
            int NewReply = Int32.Parse(Words);

            switch (Words)
            {
                case "001":
                    Console.Write("even you did try to tell right now is the best moment of mine, I still refuse to believe, I want it better.");
                    break;
                case "002":
                    Console.Write("Now prove that it's possible to rule a nation without deceiving or even manipulate your people.");
                    break;
                case "003":
                    Debug.LogFormat("When you said someone smiles like sunshine, you must be meaning his or her smile will literally set you on fire.");
                    break;
                case "004":
                    Console.Write("When you desire liberty, it's expected to take up every single responsibility");
                    break;
                case "005":
                    Console.Write("Do what you want");
                    break;
                case "006":
                    Console.Write("Do what you want");
                    break;
                case "007":
                    Console.Write("Do what you want");
                    break;
                case "008":
                    Console.Write("Do what you want");
                    break;
                case "009":
                    Console.Write("Do what you want");
                    break;

            }
        }
    }
}
