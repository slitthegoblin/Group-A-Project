using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public string[] DialogLines;
    private int CurrentLine = 0;
    public string DisplayLine;
    public SphereCollider Zone;
    public bool IsTalk;
    public void NextLine()
    {
        CurrentLine++;
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentLine == DialogLines.Length)
        {
            CurrentLine = 0;
            DisplayLine = DialogLines[CurrentLine];
        }
        DisplayLine = DialogLines[CurrentLine];
        //Tester
        if (!IsTalk)
        {
            CurrentLine = 0;
        }
    }
}
