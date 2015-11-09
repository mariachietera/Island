using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class run : RAINAction
{
	private Wander cWander;

    public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
		GameObject obj = GameObject.Find ("Zombie_Man");
		cWander = obj.GetComponent<Wander>;
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
		Debug.Log ("************Run!*****************");
		cWander.enabled = true;
		return ActionResult.SUCCESS;
	}

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }
}