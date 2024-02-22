using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 noPackageColor = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 1);
    [SerializeField] float DestroyDelay;
    [SerializeField] GameObject UI;
    bool HasP = false;

    SpriteRenderer spriteRenderer;

    void Start() {
        //Getting component from GameObject example: Sprite component Car
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && !HasP) {
            Debug.Log("Package picked up");
            HasP = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject,DestroyDelay);
        }
        if (other.tag == "Customer" && HasP) {
            Debug.Log("Package delivered :)");
            HasP = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
