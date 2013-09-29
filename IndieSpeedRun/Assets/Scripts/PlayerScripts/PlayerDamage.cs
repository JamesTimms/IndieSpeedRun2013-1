﻿using UnityEngine;
using System.Collections;

public class PlayerDamage : MonoBehaviour {
	public UISprite warmthBar;
	public float playerHealth = 5.0f;
	public UISprite fader;
	void OnTriggerEnter( Collider objectCollider ){
		float enemyDamage = objectCollider.gameObject.GetComponent< EnemyDestroyClick >( ).enemyDamage;
		if ( objectCollider.tag == "Enemy" ){
			warmthBar.fillAmount = warmthBar.fillAmount - enemyDamage;
			if(fader != null)
			{
				//If your number X falls between A and B, and you would
				//like Y to fall between C and D, you can apply the following linear transform:
				//Y = (X-A)/(B-A) * (D-C) + C
				float x = warmthBar.fillAmount;
				fader.alpha = 1.0f - (((x-0.0f)/(1.0f - 0.0f) * (1.0f-0.6f)) + 0.6f);
			}
		}
	}
}