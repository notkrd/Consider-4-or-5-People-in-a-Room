using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComposeText : MonoBehaviour {
    public Text my_words;

	// Use this for initialization
	void Start () {
        my_words.text += "\n\n\nConsider a couple people in a room. ";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddToStory(string some_content)
    {
        my_words.text += some_content;
    }
}
