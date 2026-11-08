using UnityEngine;

public class AlertedState : State
{
    Agent owner;
    public AlertedState(Agent owner)
    {
        this.owner = owner;
    }
    public override void Enter()
    {
        Debug.Log("Entering Alerted State");
    }
    public override void Execute()
    {
        Debug.Log("Executing Alerted State");
    }
    public override void Exit()
    {
        Debug.Log("Exiting Alerted State");
    }
}

