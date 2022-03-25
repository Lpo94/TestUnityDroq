using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCreator
{
    public enum SpellTypes { Fireball, Dash }
    public SpellCreator(SpellTypes spellCast, GameObject playerObject, Vector3 targetPosition)
    {
        GameObject mySpell = Resources.Load("Prefabs/FireballPrefab") as GameObject;
        targetSystem myTarget = mySpell.GetComponent<targetSystem>() as targetSystem;
        myTarget.target = targetPosition;
        mySpell.transform.position = playerObject.transform.position;
        GameObject.Instantiate(mySpell);
    }
}
