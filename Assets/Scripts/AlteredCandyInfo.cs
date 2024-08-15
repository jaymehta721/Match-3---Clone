using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class AlteredCandyInfo
{
    private List<GameObject> newCandy { get; set; } = new();
    public int maxDistance { get; set; }

    /// <summary>
    /// Returns distinct list of altered candy
    /// </summary>
    public IEnumerable<GameObject> alteredCandy => newCandy.Distinct();

    public void AddCandy(GameObject go)
    {
        if (!newCandy.Contains(go))
        {
            newCandy.Add(go);
        }
    }
}
