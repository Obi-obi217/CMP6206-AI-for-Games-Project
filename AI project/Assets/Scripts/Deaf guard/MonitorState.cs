using UnityEngine;

public class MonitorState : State
{
    Deaf owner;
    public MonitorState(Deaf owner)
    {
        this.owner = owner;
    }
    public override void Enter()
    {
        
    }
    public override void Execute()
    {
        //Debug.Log("Executing Monitor State");
    }
    public override void Exit()
    {
        //Debug.Log("Exiting Monitor State");
    }
}
