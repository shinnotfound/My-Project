using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Support : Roles
{
    public override void Info()
    {
        base.Info();
        Heal();
    }

    private void Heal()
    {
        Debug.Log("Healed everyone in the party within 5 meters.");
    }
}
