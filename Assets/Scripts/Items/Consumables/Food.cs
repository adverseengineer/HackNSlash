﻿using UnityEngine;
using System.Collections;

[AddComponentMenu("Item/Consumables/Food")]
public sealed class Food : Consumable
{
	public StatusEffect eff1;
	public StatusEffect eff2;
	public StatusEffect eff3;
	public sealed override int CalculateValue()
	{
		//TODO: food value formula
		return 0;
	}
}
