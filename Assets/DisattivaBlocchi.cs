﻿using UnityEngine;
using System.Collections;

public class DisattivaBlocchi : MonoBehaviour {
	private BoxCollider2D blocco;
	// Use this for initialization
	void Start () {
		blocco = GetComponent <BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		//blocco.enabled = ((blocco.transform.position.y + 0.32f) < CharacterAction.trans.position.y) && !CharacterAction.scendiScale;

		if (((blocco.transform.position.y + 0.29f) < CharacterAction.trans.position.y))
						blocco.enabled = true;
				else
						blocco.enabled = false;

		if(CharacterAction.scendiScale && CharacterAction.scale)
			blocco.enabled = false;
	}
}