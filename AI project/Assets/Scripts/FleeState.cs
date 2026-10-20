using UnityEngine;

public class FleeState : State
{
    Agent owner;
    public FleeState(Agent owner)
    {
        this.owner = owner;
    }
    public override void Enter()
    {
        Debug.Log("Entering Flee State");
    }
    public override void Execute()
    {
        Debug.Log("Executing Flee State");
    }
    public override void Exit()
    {
        Debug.Log("Exiting Flee State");
    }
}

