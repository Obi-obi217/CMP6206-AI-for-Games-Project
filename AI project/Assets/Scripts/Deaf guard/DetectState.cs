using UnityEngine;

public class DetectState : State
{
    Deaf owner;
    public DetectState(Deaf owner)
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

