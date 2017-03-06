using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public Text scoreText;
	private int _score = 0;
	const string ScorePrefix = "Score : ";

	// Use this for initialization
	void Start () {

		scoreText = this.GetComponent<Text> ();
		scoreText.text = ScorePrefix + _score;
	}

	public void AddScore(int scoreAdded)
	{
		_score += scoreAdded;
		scoreText.text = ScorePrefix + _score;
	}

}
