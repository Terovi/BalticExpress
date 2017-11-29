﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/// <summary>
/// Game controller.
/// </summary>
public class GameController : MonoBehaviour {
	
	//private GameObject canvas;
	private GameObject wtf;
	public ButtonController bNext;
	public ButtonController bLeft;
	public ButtonController bRight;
	public ButtonController bUp;
	public ButtonController bDown;
	public GameObject ball;
	public float speed = 0.1f;
	public string loadLevel;

	// Use this for initialization
	//työkalumetodi millä voimme hakea unitysta jotain
	void Start () {
		//canvas = GameObject.Find ("CanvasQ");
		// wtf = GameObject.Find ("Questions");
		/*bNext = GameObject.Find ("ButtonNext").GetComponent<ButtonController> ();
		ball = GameObject.Find ("Ball");
		bLeft = GameObject.Find ("ButtonLeft").GetComponent<ButtonController> ();
		bUp = GameObject.Find ("ButtonUp").GetComponent<ButtonController> ();
		bRight = GameObject.Find("ButtonRight").GetComponent<ButtonController> ();
		bDown = GameObject.Find("ButtonDown").GetComponent<ButtonController> ();*/
		// wtf.SetActive (false);
		//bNext.SetActive (false);
		//canvas.SetActive(false);
	
	}
	// Update is called once per frame
	void Update () {
		if (bLeft.GetButtonPressed ()) {
			ball.transform.Translate (-1*speed, 0, 0);
		}
		if (bRight.GetButtonPressed ()) {
			ball.transform.Translate (1*speed, 0, 0);
		}	
		if (bUp.GetButtonPressed ()) {
			ball.transform.Translate (0,1*speed, 0);
		}	
		if (bDown.GetButtonPressed ()) {
			ball.transform.Translate (0,-1*speed,0);
		}

		/*if (bNext.GetButtonPressed ()) {
			SceneManager.LoadScene (loadLevel);
		}*/
		/*if (GUI.Button (new Rect (380, 185, 150, 30), "Main Menu")) {
			SceneManager.LoadScene ("MainMenu", LoadSceneMode.Single);
		}*/
}
}
