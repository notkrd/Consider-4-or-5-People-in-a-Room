using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HumanSpeech : MonoBehaviour
{
    public Text the_narrative;
    public HumanMotion my_motion;
    public ComposeText the_writer;
    public GameObject an_utterance;
    public bool can_talk;
    private bool recently_couldnt_talk;

    // Use this for initialization
    void Start()
    {
        the_writer.my_words = the_narrative;
        can_talk = true;
        recently_couldnt_talk = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (recently_couldnt_talk == false)
        {
            can_talk = true;
        }
        recently_couldnt_talk = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Discourse")
        {
            can_talk = false;
            recently_couldnt_talk = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Discourse")
        {
            can_talk = false;
            recently_couldnt_talk = true;
        }
    }

    public void ISay(string what_to_say)
    {
        if (can_talk)
        {
            GameObject this_utterance = (GameObject)Instantiate(an_utterance, transform.position, Quaternion.identity);
            this_utterance.GetComponent<TextMesh>().text = what_to_say;
            the_writer.AddToStory("\n\nLi said, \"" + what_to_say + "\" ");
        }
    }
}