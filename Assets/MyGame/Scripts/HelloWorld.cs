//smeerws: 
//printing messages to the unity console
using System;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        string helloWorldText = "Hello World (hw)";

        print("(print) Hello World");
        Debug.Log("(Debug.Log) Hello World");
        Console.WriteLine("(Console.WriteLine) Hello World");   //Console.WriteLine does nothing inside the Unity Engine,
                                                                //because Unity uses a custom console, only accessed 
                                                                //through Unity Engine: Debug.Log, ...
                                                                //Unity doesn't display the standard C# Console
        print("(print - helloWorldText)" + helloWorldText);
        Debug.Log("(Debug.Log - helloWorldText)" + helloWorldText);
        Console.WriteLine("Console.WriteLine - helloWorldText)" + helloWorldText);
    }
}
