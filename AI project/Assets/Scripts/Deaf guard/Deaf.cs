using UnityEngine;

public class Deaf : MonoBehaviour
{
    StateManager sm = new StateManager();
    int stateIndex = 0;
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
        }
        if (Input.GetKeyDown(KeyCode.E) && (stateIndex == 0 || stateIndex == 2))
        {
            sm.ChangeState(new DetectState(this));
            stateIndex = 1;
        }
        if (Input.GetKeyDown(KeyCode.R) && stateIndex == 1)
        {
            sm.ChangeState(new LostState(this));
            stateIndex = 2;
        }
    }
}
