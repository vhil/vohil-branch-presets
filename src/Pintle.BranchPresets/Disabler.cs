﻿namespace Pintle.BranchPresets
{
	using Sitecore.Common;

	public abstract class Disabler<TSwitchType> : Switcher<DisablerState, TSwitchType>
	{
		// ReSharper disable once PublicConstructorInAbstractClass
		public Disabler() : base(DisablerState.Enabled)
		{
		}

		public static bool IsActive => CurrentValue == DisablerState.Enabled;
	}

	public enum DisablerState
	{
		Disabled,
		Enabled
	}
}