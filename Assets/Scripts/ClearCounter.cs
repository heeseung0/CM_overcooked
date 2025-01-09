using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour{

    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    [SerializeField] private Transform counterTopPoint;

    public void Interact() {
        Debug.Log(string.Format("Interact!   [{0}]", this.name));
        Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
        kitchenObjectTransform.localPosition = Vector3.zero;

        Debug.Log(kitchenObjectTransform.GetComponent<KitchenObject>().GetKitchenObjectSO());
    }
}
