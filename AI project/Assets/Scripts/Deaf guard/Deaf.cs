using UnityEngine;

public class Deaf : MonoBehaviour
{
    private Sight sightComp;
    private DeafMovement movementComp;
    //private Hearing hearingComp;
    StateManager sm = new StateManager();
    int stateIndex = 0;
    bool hasBeenLost = false;
    State monitorState;
    State detectState;
    State lostState;
    void Start()
    {
        sm.ChangeState(new MonitorState(this));
        monitorState = new MonitorState(this);
        detectState = new DetectState(this);
        lostState = new LostState(this);

        movementComp = GetComponent<DeafMovement>();
        sightComp = GetComponent<Sight>();

    }

    // Update is called once per frame
    void Update()
    {
        // Update the state manager
        sm.Update();

        if (movementComp != null && sightComp != null )
        {
            if (Input.GetKeyDown(KeyCode.W) || stateIndex == 2 && hasBeenLost)
            {
                sm.ChangeState(monitorState);
                stateIndex = 0;
                movementComp.StartRotation();
                hasBeenLost = false;
                Debug.Log("Entering Monitor State");
            }
            if ((Input.GetKeyDown(KeyCode.E) || (sightComp.CanSeePlayer())) && (stateIndex == 0 || stateIndex == 2))
            {

                CancelInvoke("HasBeenLost");
                sm.ChangeState(detectState);
                stateIndex = 1;
                movementComp.StopRotation();
                Debug.Log("Entering Detect State");
                //Invoke("PlaySound", 1f);

            }
            if ((Input.GetKeyDown(KeyCode.R) || !sightComp.CanSeePlayer()) && stateIndex == 1 && !hasBeenLost)
            {
                //CancelInvoke("PlaySound");
                sm.ChangeState(lostState);
                stateIndex = 2;
                Invoke("HasBeenLost", 3f);
                Debug.Log("Entering Lost State");
            }
        }
    }

    private void HasBeenLost()
    {
        hasBeenLost = true;
    }

    //public void PlaySound()
    //{
    //    hearingComp.HearSound(transform.position);
    //}
}
