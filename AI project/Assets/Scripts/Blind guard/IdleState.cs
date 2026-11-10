using UnityEngine;

public class IdleState : State
{
    Blind owner;
    public IdleState(Blind owner)
    {
        this.owner = owner;
    }
    public override void Enter()
    {
        //Debug.Log("Entering Idle State");
    }
    public override void Execute()
    {
        //Debug.Log("Executing Idle State");
    }
    public override void Exit()
    {
        //Debug.Log("Exiting Idle State");
    }
}

