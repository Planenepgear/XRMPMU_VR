using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class NetworkMoveProvider : ActionBasedContinuousMoveProvider
{
    [SerializeField]
    public bool enableinputeActions;

    protected override Vector2 ReadInput()
    {
        if (!enableinputeActions) return Vector2.zero;
        return base.ReadInput();
    }
}
