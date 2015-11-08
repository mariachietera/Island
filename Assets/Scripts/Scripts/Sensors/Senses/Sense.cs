using UnityEngine;
using System.Collections;

public class Sense : MonoBehaviour {
	public bool bDebug = true;
	public Aspect.aspect aspectName = Aspect.aspect.Enemy;
	public float detectionRate = 1.0f;

	protected float elapsedTime = 0.0f;

	protected virtual void Initialise() { }
	protected virtual void UpdateSense() { }

	// Use this for initialization
	void Start () {
		elapsedTime = 0.0f;
		Initialise();
	}
	
	// Update is called once per frame
	void Update () {
		UpdateSense();
	}
}
