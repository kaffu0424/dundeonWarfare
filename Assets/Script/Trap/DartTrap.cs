using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class DartTrap : Trap
{
    [SerializeField] Animator trap_ani;
    [SerializeField] GameObject bullet;

    private TrapData data;
    private void Start()
    {
        data = TrapManager.Instance.GetData(0);
        InitializeTrap(
            data.trap_id,
            data.trap_name,
            data.trap_damage,
            data.trap_delay,
            data.trap_cost,
            data.trap_hp,
            data.trap_range,
            data.trap_type
            );
        // InitializeTrap(0, "DartTrap", 2, 0.6f, 500, 9999, 3, 1);
        trap_ani = GetComponent<Animator>();
    }

    protected override void attack()
    {
        trap_ani.SetTrigger("Attack");
    }
}