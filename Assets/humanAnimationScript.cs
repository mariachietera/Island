using UnityEngine;
using System.Collections;
using UnitySteer.Behaviors;


[RequireComponent(typeof(SteerForPursuit))]
public class humanAnimationScript : MonoBehaviour {

	public SteerForPursuit cSteering;
	public Animator animator;
    // Use this for initialization
    void Start()
    {
        
        cSteering = GetComponent<SteerForPursuit>();
        animator = GetComponent<Animator>();
        //the Steering is enabled
        cSteering.enabled = true;
        animator.SetInteger("speed", 5);
        Debug.Log("Speed: " + animator.speed);
    }
	
	// Update is called once per frame
	void Update () {

        Vector3 robotCurrPos;
		robotCurrPos = transform.position;


        Debug.Log("distance: " + Vector3.Distance(robotCurrPos, cSteering.Quarry.transform.position));
        

        if (Vector3.Distance(robotCurrPos, cSteering.Quarry.transform.position) < cSteering.AcceptableDistance + 3) {
			cSteering.enabled = false;
			animator.SetInteger("speed", 0);
        }

        Debug.Log("Speed: " + animator.speed);
    }
}