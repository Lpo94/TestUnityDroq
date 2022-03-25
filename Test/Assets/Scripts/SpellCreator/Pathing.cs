using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathing
{
    public enum differentPaths { homingToTarget, staticPosition}
    private differentPaths myPath;
    public differentPaths getPath { get { return myPath; }}

    public Pathing(differentPaths setPath)
    {
        myPath = setPath;
    }

}
