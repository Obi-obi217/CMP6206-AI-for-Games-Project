using UnityEngine;

public class Deaf : MonoBehaviour
{
    private Sight sightComp;
    private DeafMovement movementComp;
    StateManager sm = new StateManager();
    int stateIndex = 0;
    bool hasBeenLost = false;

    void Start()
    {
        sm.ChangeState(new MonitorState(this));

    }

    // Update is called once per frame
    void Update()
    {
        // Update the state manager
        sm.Update();

        if (Input.GetKeyDown(KeyCode.W) && stateIndex == 2)
        {
            sm.ChangeState(new MonitorState(this));
            stateIndex = 0;
            movementComp.StartRotation();
            hasBeenLost = false;
        }
        if ((Input.GetKeyDown(KeyCode.E) || sightComp.CanSeePlayer()) && (stateIndex == 0 || stateIndex == 2))
        {
            sm.ChangeState(new DetectState(this));
            stateIndex = 1;
            movementComp.StopRotation();

        }
        if (Input.GetKeyDown(KeyCode.R) && stateIndex == 1)
        {
            sm.ChangeState(new LostState(this));
            stateIndex = 2;
            Invoke("HasBeenLost", 3f);
        }
    }

    private void HasBeenLost()
    {
        hasBeenLost = true;
    }

}
