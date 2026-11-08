using UnityEngine;

public class ReturningState : State
{
    Blind owner;
    public ReturningState(Blind owner)
    {
        this.owner = owner;
    }
    public override void Enter()
    {
        Debug.Log("Entering Returning State");
    }
    public override void Execute()
    {
        Debug.Log("Executing Returning State");
    }
    public override void Exit()
    {
        Debug.Log("Exiting Returning State");
    }
}

