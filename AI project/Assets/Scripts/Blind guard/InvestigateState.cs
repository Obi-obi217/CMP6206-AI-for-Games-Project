using UnityEngine;

public class InvestigateState : State
{
    Blind owner;
    public InvestigateState(Blind owner)
    {
        this.owner = owner;
    }
    public override void Enter()
    {
        Debug.Log("Entering Investigate State");
    }
    public override void Execute()
    {
        Debug.Log("Executing Investigate State");
    }
    public override void Exit()
    {
        Debug.Log("Exiting Investigate State");
    }
}

