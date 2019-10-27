using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComponent;
    [SerializeField] State startingStateStory;

    State state;

	// Use this for initialization
	void Start () {
        state = startingStateStory;
        textComponent.text = state.GetStateStory();
	}
	
	// Update is called once per frame
	void Update () {
        ManageState();
	}

    private void ManageState()
    {
        var nextState = state.GetNextStates();
        for (int index = 0; index < nextState.Length; index++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextState[index];
            }
        }
        textComponent.text = state.GetStateStory();
    }
}
