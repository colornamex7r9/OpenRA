#region Copyright & License Information
/*
 * Copyright (c) The OpenRA Developers and Contributors
 * This file is part of OpenRA, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation, either version 3 of
 * the License, or (at your option) any later version. For more
 * information, see COPYING.
 */
#endregion

using System.Collections.Generic;

namespace OpenRA.Mods.Common.UpdateRules.Rules
{
	public class RenameOnDeath : UpdateRule
	{
		public override string Name => "Rename Explodes to FireWarheadOnDeath and ThrowsShrapnel to FireProjectilesOnDeath.";

		public override string Description =>
			" The Explodes trait was renamed to FireWarheadsOnDeath." +
			" The ThrowsShrapnel trait was renamed to FireProjectilesOnDeath.";

		public override IEnumerable<string> UpdateActorNode(ModData modData, MiniYamlNodeBuilder actorNode)
		{
			actorNode.RenameChildrenMatching("Explodes", "FireWarheadsOnDeath");
			actorNode.RenameChildrenMatching("ThrowsShrapnel", "FireProjectilesOnDeath");

			yield break;
		}
	}
}
