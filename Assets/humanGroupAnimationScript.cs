using UnityEngine;
using System.Collections;
using UnitySteer.Behaviors;

[RequireComponent(typeof(SteerForPoint))]
public class humanGroupAnimationScript : MonoBehaviour {

    public SteerForPoint cSteering;
    public Animator animator;
    // Use this for initialization
    void Start()
    {

        cSteering = GetComponent<SteerForPoint>();
        animator = GetComponent<Animator>();
        //the Steering is enabled
        cSteering.enabled = true;
        animator.SetInteger("speed", 5);
        Debug.Log("Speed: " + animator.speed);
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 robotCurrPos;
        Vector3 robotTargetPos = new Vector3();
        robotCurrPos = transform.position;

        robotTargetPos = cSteering.TargetPoint;
        if (Vector3.Distance(robotCurrPos, robotTargetPos) < 1.0)
        {
            Debug.Log("Stop, disable steering. Transition to iddle");
            cSteering.enabled = false;
            animator.SetInteger("speed", 0);
        }
    }
}
