using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{

    [SerializeField] private KitchenObjectsSO kitchenObjectsSO;

    public KitchenObjectsSO GetKitchenObjectsSO() { return kitchenObjectsSO; }

    private IKitchenObjectParent kitchenObjectParent;

    public void SetKitchensObjectParent(IKitchenObjectParent kitchenObjectParent)
    {
        if (this.kitchenObjectParent != null)
        {
            this.kitchenObjectParent.ClearKitchenObject();                             // Previous
        }

        this.kitchenObjectParent = kitchenObjectParent;                                // New one

        if (kitchenObjectParent.HasKitchenObject())
        {
            Debug.Log("IKitchenObjectParent already has a KitchenObject!");
        }

        kitchenObjectParent.SetKitchenObject(this);

        transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
        transform.localPosition = Vector3.zero;
    }

    public IKitchenObjectParent GetKitchenObjectParent() { return kitchenObjectParent; }


}