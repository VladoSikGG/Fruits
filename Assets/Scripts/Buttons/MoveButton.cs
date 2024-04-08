using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveButton : MonoBehaviour
{
    [SerializeField] private int _direction;
    private Movement _platformMove;
    private void Awake()
    {
        _platformMove = FindObjectOfType<Movement>().GetComponent<Movement>();
        
        EventTrigger evTrig = gameObject.AddComponent<EventTrigger>();
        
        EventTrigger.Entry clickEvent = new EventTrigger.Entry()
        {
            eventID = EventTriggerType.PointerDown
        };
        clickEvent.callback.AddListener(EventMove);
        evTrig.triggers.Add(clickEvent);
        
        EventTrigger.Entry clickEventStop = new EventTrigger.Entry()
        {
            eventID = EventTriggerType.PointerUp
        };
        clickEventStop.callback.AddListener(EventStop);
        evTrig.triggers.Add(clickEventStop);
    }

    private void EventMove(BaseEventData eventData)
    {
        _platformMove.ChooseSide(_direction);
        Debug.Log("Succesful");
    }
    private void EventStop(BaseEventData eventData)
    {
        _platformMove.UpButton();
        Debug.Log("Succesful stop");
    }
    
}
