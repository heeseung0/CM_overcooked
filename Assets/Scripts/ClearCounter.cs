using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    public void Interact() {
        Debug.Log(string.Format("Interact!   [{0}]", this.name));
    }
}
