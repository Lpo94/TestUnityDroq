using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    
    [SerializeField]
    GameObject playerObject;

    private BasicDamageSpell mySpellInfo;
    private Pathing myPathing;
    private Vector3 myTarget;
    private Vector3 moveDirection; 

    void Awake()
    {
        mySpellInfo = new BasicDamageSpell(5, 2f, 2f, 2f, 2f);
        myPathing = new Pathing(Pathing.differentPaths.staticPosition);
        myTarget = (gameObject.GetComponent<targetSystem>() as targetSystem).target;
        moveDirection = (myTarget - transform.position).normalized;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += moveDirection * (mySpellInfo.getSpeed * Time.deltaTime);

    }
}
