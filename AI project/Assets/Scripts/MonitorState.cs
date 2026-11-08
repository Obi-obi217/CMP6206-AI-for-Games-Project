using UnityEngine;

public class MonitorState : State
{
    Agent owner;
    public MonitorState(Agent owner)
    {
        this.owner = owner;
    }
    public override void Enter()
    {
        Debug.Log("Entering Monitor State");
    }
    public override void Execute()
    {
        Debug.Log("Executing Monitor State");
    }
    public override void Exit()
    {
        Debug.Log("Exiting Monitor State");
    }
}
