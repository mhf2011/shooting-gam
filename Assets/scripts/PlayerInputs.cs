using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputs : MonoBehaviour
{
    [SerializeField] InputAction leftClick;
    // [SerializeField] private Animator animator;
    public bool shoot = false;

    void OnEnable()
    {
        leftClick.Enable();
    }


    void Update()
    {
        if (leftClick.IsPressed())
        {
            Debug.Log("playing animation");
            // animator.Play("Fire_animation");
            shoot = true;

        }
        else
        {
            shoot = false;

        }
    }
}
