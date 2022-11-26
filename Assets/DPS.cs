using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DPS : Roles
{
    public override void Info()
    {
        base.Info();
        ATKBuff();
    }

    private void ATKBuff() {

        Debug.Log($"Attack damage has been increase by 30%! {_dmg} >>> {(_def * (1 + .30))}");
    }
    
}
