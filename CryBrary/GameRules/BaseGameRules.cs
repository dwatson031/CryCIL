﻿using System;

namespace CryEngine
{
	/// <summary>
	/// This is the base GameRules interface. All game rules must implement this.
	/// </summary>
	/// <remarks>For most use cases, deriving from CryGameCode's BaseGameRules is a more efficient solution.</remarks>
    public abstract class BaseGameRules : CryScriptInstance
    {
        // Shared
        public virtual void PrecacheLevel() { }
        public virtual void RequestSpawnGroup(EntityId spawnGroupId) { }
		public virtual void SetPlayerSpawnGroup(EntityId playerId, EntityId spawnGroupId) { }
		public virtual EntityId GetPlayerSpawnGroup(EntityId actorId) { return new EntityId(System.Convert.ToUInt32(0)); }
        public virtual void ShowScores(bool show) { }

		public virtual void OnSetTeam(EntityId actorId, EntityId teamId) { }

        // Server-only
		protected virtual void OnHit(HitInfo hitInfo) { }

        public virtual void OnSpawn() { }

        public virtual void OnClientConnect(int channelId, bool isReset = false, string playerName = "") { }
        public virtual void OnClientDisconnect(int channelId) { }

		public virtual void OnClientEnteredGame(int channelId, EntityId playerId, bool reset, bool loadingSaveGame) { }

		public virtual void OnItemDropped(EntityId itemId, EntityId actorId) { }
		public virtual void OnItemPickedUp(EntityId itemId, EntityId actorId) { }

		public virtual void SvOnVehicleDestroyed(EntityId vehicleId) { }
		public virtual void SvOnVehicleSubmerged(EntityId vehicleId, float ratio) { }

		public virtual void OnAddTaggedEntity(EntityId shooterId, EntityId targetId) { }

		public virtual void OnChangeSpectatorMode(EntityId actorId, byte mode, EntityId targetId, bool resetAll) { }
		public virtual void RequestSpectatorTarget(EntityId playerId, int change) { }

		public virtual void OnChangeTeam(EntityId actorId, int teamId) { }

		public virtual void OnSpawnGroupInvalid(EntityId playerId, EntityId spawnGroupId) { }

        public virtual void RestartGame(bool forceInGame) { }

        // Client-only
        public virtual void OnConnect() { }
		public virtual void OnDisconnect(DisconnectionCause cause, string description) { }

		public virtual void OnRevive(EntityId actorId, Vec3 pos, Vec3 rot, int teamId) { }
		public virtual void OnReviveInVehicle(EntityId actorId, EntityId vehicleId, int seatId, int teamId) { }
		public virtual void OnKill(EntityId actorId, EntityId shooterId, string weaponClassName, int damage, int material, int hitType) { }

		public virtual void OnVehicleDestroyed(EntityId vehicleId) { }
		public virtual void OnVehicleSubmerged(EntityId vehicleId, float ratio) { }
    }

	public enum DisconnectionCause
	{
		/// <summary>
		/// This cause must be first! - timeout occurred.
		/// </summary>
		Timeout = 0,
		/// <summary>
		/// Incompatible protocols.
		/// </summary>
		ProtocolError,
		/// <summary>
		/// Failed to resolve an address.
		/// </summary>
		ResolveFailed,
		/// <summary>
		/// Versions mismatch.
		/// </summary>
		VersionMismatch,
		/// <summary>
		/// Server is full.
		/// </summary>
		ServerFull,
		/// <summary>
		/// User initiated kick.
		/// </summary>
		Kicked,
		/// <summary>
		/// Teamkill ban/ admin ban.
		/// </summary>
		Banned,
		/// <summary>
		/// Context database mismatch.
		/// </summary>
		ContextCorruption,
		/// <summary>
		/// Password mismatch, cdkey bad, etc.
		/// </summary>
		AuthenticationFailed,
		/// <summary>
		/// Misc. game error.
		/// </summary>
		GameError,
		/// <summary>
		/// DX11 not found.
		/// </summary>
		NotDX11Capable,
		/// <summary>
		/// The nub has been destroyed.
		/// </summary>
		NubDestroyed,
		/// <summary>
		/// Icmp reported error.
		/// </summary>
		ICMPError,
		/// <summary>
		/// NAT negotiation error.
		/// </summary>
		NatNegError,
		/// <summary>
		/// Punk buster detected something bad.
		/// </summary>
		PunkDetected,
		/// <summary>
		/// Demo playback finished.
		/// </summary>
		DemoPlaybackFinished,
		/// <summary>
		/// Demo playback file not found.
		/// </summary>
		DemoPlaybackFileNotFound,
		/// <summary>
		/// User decided to stop playing.
		/// </summary>
		UserRequested,
		/// <summary>
		/// User should have controller connected.
		/// </summary>
		NoController,
		/// <summary>
		/// Unable to connect to server.
		/// </summary>
		CantConnect,
		/// <summary>
		/// Arbitration failed in a live arbitrated session.
		/// </summary>
		ArbitrationFailed,
		/// <summary>
		/// Failed to successfully join migrated game
		/// </summary>
		FailedToMigrateToNewHost,
		/// <summary>
		/// The session has just been deleted
		/// </summary>
		SessionDeleted,
		/// <summary>
		/// Unknown cause
		/// </summary>
		Unknown
	}

    public struct HitInfo
    {
        /// <summary>
        /// EntityId of the shooter
        /// </summary>
        public EntityId ShooterId { get; set; }
        /// <summary>
        /// EntityId of the target which got shot
        /// </summary>
        public EntityId TargetId { get; set; }
        /// <summary>
        /// EntityId of the weapon
        /// </summary>
        public EntityId WeaponId { get; set; }
        /// <summary>
        /// 0 if hit was not caused by a projectile
        /// </summary>
        public EntityId ProjectileId { get; set; }

        /// <summary>
        /// damage count of the hit
        /// </summary>
        public float Damage { get; set; }
        public float ImpulseStrength { get; set; }
        /// <summary>
        /// radius of the hit
        /// </summary>
        public float Radius { get; set; }
        public float Angle { get; set; }
        /// <summary>
        /// material id of the surface which got hit
        /// </summary>
        public int MaterialId { get; set; }
        /// <summary>
        /// type id of the hit, see IGameRules::GetHitTypeId for more information
        /// </summary>
        public int TypeId { get; set; }
        /// <summary>
        /// type of bullet, if hit was of type bullet
        /// </summary>
        public int BulletType { get; set; }

        public float MinimumDamage { get; set; }
        /// <summary>
        /// bullet pierceability
        /// </summary>
        public float Pierceability { get; set; }

        public int PartId { get; set; }

        /// <summary>
        /// position of the hit
        /// </summary>
        public Vec3 Position { get; set; }
        /// <summary>
        /// direction of the hit
        /// </summary>
        public Vec3 Direction { get; set; }
        public Vec3 Normal { get; set; }

        public UInt16 ProjectileClassId { get; set; }
        public UInt16 WeaponClassId { get; set; }

        public bool Remote { get; set; }
        /// <summary>
        /// set to true if shot was aimed - i.e. first bullet, zoomed in etc.
        /// </summary>
        public bool Aimed { get; set; }
        /// <summary>
        /// true if the hit should knockdown
        /// </summary>
        public bool KnocksDown { get; set; }
        /// <summary>
        /// true if the hit should knockdown when hit in a leg
        /// </summary>
        public bool KnocksDownLeg { get; set; }
        /// <summary>
        /// true if the 'shooter' didn't actually shoot, ie. a weapon acting on their behalf did (team perks)
        /// </summary>
        public bool HitViaProxy { get; set; }
        /// <summary>
        /// true if this hit directly results from an explosion
        /// </summary>
        public bool Explosion { get; set; }
        /// <summary>
        /// dynamic pierceability reduction
        /// </summary>
        public float ArmorHeating { get; set; }
        /// <summary>
        /// number of surfaces the bullet has penetrated
        /// </summary>
        public int PenetrationCount { get; set; }
    }
}