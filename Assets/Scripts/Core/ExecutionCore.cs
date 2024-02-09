using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecutionCore : MonoBehaviour
{
    // After receiving the details of a player's action,
    // ExecutionCore determines the consequences of that action.

    // Core logic classes can only impact each other in one direction:
    // DelegationCore > RelayCore > ExecutionCore > DelegationCore

    // SCENE REFERENCE:
    [SerializeField] private DelegationCore delegationCore;
    [SerializeField] private Clock clock;

    public void ReceivePacket(RelayPacket packet) // Called by RelayCore
    {
        Debug.Log(packet.actionType);
    }
}