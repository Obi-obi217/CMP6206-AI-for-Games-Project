using UnityEngine;

public class DetectState : State
{
    Agent owner;
    public DetectState(Agent owner)
    {
        this.owner = owner;
    }
    public override void Enter()
    {
        Debug.Log("Entering Detect State");
    }
    public override void Execute()
    {
        Debug.Log("Executing Detect State");
    }
    public override void Exit()
    {
        Debug.Log("Exiting Detect State");
    }
}

