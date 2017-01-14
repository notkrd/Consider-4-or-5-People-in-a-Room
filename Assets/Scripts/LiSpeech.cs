using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiSpeech : MonoBehaviour {
    public HumanSpeech li_speech;

    private void Start()
    {

    }

    private void Update()
    {
        SwearOnCommand();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Walls")
        {
            li_speech.ISay("Hello wall, my only friend. ");
        }
    }

    void SwearOnCommand()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            li_speech.ISay("Fuck.");
        }
    }
}
