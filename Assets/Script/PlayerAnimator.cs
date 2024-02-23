using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private const string Is_Walking = "IsWalking";

    [SerializeField] private Player player;

    private Animator animator;

    void Start()
    {
        
    }

    private void Awake()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool(Is_Walking, player.IsWalking());
    }
}
