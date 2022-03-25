using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 2.0f;  // Units per second
    public Vector3 targetPostion;
    private bool reachedTarget = true;
    private bool castingSpell = false; 

    void Start()
    {

    }

    void Update()
    {
        if(!reachedTarget)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPostion, moveSpeed * Time.deltaTime);
        }
        if (Input.GetMouseButton(0))
        {
            if (!castingSpell)
            {
                var pos = Input.mousePosition;
                pos.z = transform.position.z - Camera.main.transform.position.z;
                targetPostion = Camera.main.ScreenToWorldPoint(pos);
                reachedTarget = false;
            }
        }
        if(Input.GetKeyDown("space"))
        {
            SpellCreator spellCreator = new SpellCreator(SpellCreator.SpellTypes.Fireball, transform.gameObject, targetPostion);
        }
        if(transform.position == targetPostion)
        {
            reachedTarget = true;
        }


    }
}
