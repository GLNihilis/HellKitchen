using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour, IKitchenObjectParent
{
    [SerializeField] private KitchenObjectsSO kitchenObjectsSO;
    [SerializeField] private Transform counterTopPoint;
    //[SerializeField] private ClearCounter secondClearCounter;
    //[SerializeField] private bool testing;

    private KitchenObject kitchenObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

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

    public void Interact(Player player)
    {
        if (kitchenObject == null)
        {
            Transform kitchenObjectTransform = Instantiate(kitchenObjectsSO.prefabs, counterTopPoint);
            kitchenObjectTransform.GetComponent<KitchenObject>().SetKitchensObjectParent(this);
        }
        else
        {
            // Give the object to the player
            kitchenObject.SetKitchensObjectParent(player);
            
        }
    }

    public Transform GetKitchenObjectFollowTransform()
    {
        return counterTopPoint;
    }

    public void SetKitchenObject(KitchenObject kitchenObject)
    {
        this.kitchenObject = kitchenObject;
    }

    public KitchenObject GetKitchenObject() { return kitchenObject; }

    public void ClearKitchenObject()
    {
        kitchenObject = null;
    }

    public bool HasKitchenObject()
    {
        return kitchenObject != null;
    }
}
