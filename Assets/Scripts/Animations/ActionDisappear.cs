using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionDisappear : MonoBehaviour
{
    [SerializeField] Animator bubbleSpriteAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeactivateBubbleSprite()
    {
        bubbleSpriteAnim.SetBool("taskComplete", true);
    }
}