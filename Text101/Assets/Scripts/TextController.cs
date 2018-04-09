using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
    public Text p_text;
	// Use this for initialization
	void Start () {
	    p_text.text = "Hello Truong ^^!";
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Space)) {
	        p_text.text = "In my last post I talked about"
	                        + " why it is important to know whether words in English"
	                        + " are countable or uncountable. However, I didn’t mention the fact that many words can be both countable and uncountable. This post discusses some of the reasons for this.Food and drink is an area where words are commonly countable or uncountable. Often, the substance is uncountable, but a single portion (especially in the context of ordering something in a café) is countable";
	    }
	}
}
