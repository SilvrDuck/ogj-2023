using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu]
public class TileData : ScriptableObject
{
    // Start is called before the first frame update
    public TileBase[] tiles;

    public AntHandler[] allAnts;

    public float walkingSpeed;

}
