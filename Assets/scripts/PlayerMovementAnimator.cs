using UnityEngine;

public class PlayerMovementAnimator : MonoBehaviour
{
    [SerializeField] Animator animator;
    Movment MovmentScript;
    bool previousIsMoving = false;

    void Start()
    {
        MovmentScript = GetComponent<Movment>();
    }

    void Update()
    {
        Vector2 movementVector = MovmentScript.movment.ReadValue<Vector2>();
        bool currentIsMoving = movementVector.magnitude > 0f;

        if (currentIsMoving != previousIsMoving) 
        {
            animator.SetBool("IsMoving", currentIsMoving);
            previousIsMoving = currentIsMoving;
        }
    }
}
