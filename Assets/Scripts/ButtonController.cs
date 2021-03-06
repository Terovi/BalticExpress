﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
/// <summary>
/// Button controller.
/// </summary>
public class ButtonController : MonoBehaviour,IPointerDownHandler,IPointerUpHandler {
	/// <summary>
	/// The button pressed.
	/// </summary>
	public bool buttonPressed = false;
	/// <summary>
	/// Gets the button pressed.
	/// </summary>
	/// <returns><c>true</c>, if button pressed was gotten, <c>false</c> otherwise.</returns>
	public bool GetButtonPressed () {
		return buttonPressed;
	}
	/// <summary>
	/// Raises the pointer down event.
	/// </summary>
	/// <param name="eventData">Event data.</param>
	public void OnPointerDown (PointerEventData eventData) {
		//Debug.Log (eventData);
		buttonPressed = true;

	}
	/// <summary>
	/// Raises the pointer up event.
	/// </summary>
	/// <param name="eventData">Event data.</param>
	public void OnPointerUp (PointerEventData eventData) {
		buttonPressed = false;

	}
}
