using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingCounter : BaseCounter
{
    [SerializeField] private KitchenObjectsSO cutKitchenObjectsSO;

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
            else
            {
                // Player is not carrying anything

            }

        }
        else
        {
            // There is a KitchenObject here
            if (player.HasKitchenObject())
            {
                // Player is carrying something
            }
            else
            {
                // Player is not carrying anything
                GetKitchenObject().SetKitchensObjectParent(player);
            }
        }
    }

    public override void InteractAlternate(Player player)
    {
        if (!HasKitchenObject())
        {
            // There is a KitchenObject here
            GetKitchenObject().DestroySelf();
            KitchenObject.SpawnKitchenObject(cutKitchenObjectsSO, this);
            
        }
    }
}