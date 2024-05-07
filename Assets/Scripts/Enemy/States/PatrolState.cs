using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : BaseState
{
    //this one helps the way point we are currently targeting
    public int waypointIndex;
    public override void Enter() {

    }

    public override void Perform() {
        PatrolCycle();
    }

    public override void Exit() {
        
    }

    public void PatrolCycle()
    {
        
    }

}
