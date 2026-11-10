using UnityEngine;

public class LostState : State
{
    Deaf owner;
    public LostState(Deaf owner)
    {
        this.owner = owner;
    }
    public override void Enter()
    {
        //Debug.Log("Entering Lost State");
    }
    public override void Execute()
    {
        //Debug.Log("Executing Lost State");
    }
    public override void Exit()
    {
        //Debug.Log("Exiting Lost State");
    }
}

