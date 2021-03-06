﻿namespace PewPew.WebApp.Shared.View
{
	/// <summary>
	/// A public representation of a player connected to the lobby.
	/// </summary>
	public class LobbyPublicPlayerProfile
	{
		public int TeamId { get; set; }
		public string DisplayName { get; set; } = string.Empty;
		public string ShipClass { get; set; } = ShipTypes.Scout;
	}
}
