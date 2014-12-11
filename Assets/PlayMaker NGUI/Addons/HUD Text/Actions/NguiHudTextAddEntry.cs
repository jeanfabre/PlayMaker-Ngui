// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.

using UnityEngine;
using AnimationOrTween;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("NGUI")]
	[Tooltip("Add a new scrolling text entry. Requires NGUI and a HUDText component")]
	public class NguiHudTextAddEntry : FsmStateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(HUDText))]
        [Tooltip("The GameObject on which there is a HUD Text.")]
        public FsmOwnerDefault target;
		
		[RequiredField]
		[Tooltip("The value. Accepts a float, an Int or a String.")]
		public FsmVar variable;
		
			
		[Tooltip("The color.")]
		public FsmColor color;
		
		[Tooltip("The duration.")]
		public FsmFloat duration;
		
		HUDText hudText;
		
		
		
		public override void Reset()
		{
			target = null;
			color = null;
			duration = 1f;
		}
		
		public override void OnEnter()
		{
			GameObject _go = Fsm.GetOwnerDefaultTarget(target);
			if (_go==null)
			{
				LogWarning("No gameObject target");
				Finish();
				return;
			}
			
			hudText = _go.GetComponent<HUDText>();
			if (hudText==null)
			{
				LogWarning("No HUDText on target");
				Finish();
				return;
			}
			
			AddEntry();

			Finish();
	
		}

	

		public void AddEntry()
		{
			hudText.Add(PlayMakerUtils.GetValueFromFsmVar(this.Fsm,variable),color.Value,duration.Value);
		}
		
	}
}