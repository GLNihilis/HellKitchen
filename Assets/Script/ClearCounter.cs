using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter
{
    [SerializeField] private KitchenObjectsSO kitchenObjectsSO;
    //[SerializeField] private ClearCounter secondClearCounter;
    //[SerializeField] private bool testing;

    // Update is called once per frame
    void Update()
    {
        //if (testing && Input.GetKeyUp(KeyCode.T))
        //{
        //    if (kitchenObject != null)
        //    {
        //        kitchenObject.SetKitchensObjectParent(secondClearCounter);
        //    }
        //}
    }

    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            // There is no KitchenObject here
            if (player.HasKitchenObject())
            {
                // Player is carrying something
                player.GetKitchenObject().SetKitchensObjectParent(this);
            }

        }
        else
        {
            // There is a KitchenObject here
        }
    }

}
