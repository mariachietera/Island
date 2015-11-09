using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class test : RAINAction
{
	private Perspective cPerspective;

    public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
		GameObject obj = GameObject.Find ("Zombie_Man");
		cPerspective = obj.GetComponents<cPerspective>;
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
		Debug.Log ("Executing BT Action");
		if (cPerspective.enemy) {
			return ActionResult.SUCCESS;
		} else
			return ActionResult.FAILURE;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }
}