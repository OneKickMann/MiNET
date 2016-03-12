using MiNET.Net;
using MiNET.Utils;
using MiNET.Worlds;

namespace MiNET.Sounds
{
	public class Sound
	{
		public short Id { get; private set; }
		public int Pitch { get; set; }
		public Vector3 Position { get; set; }

		public Sound(short id, Vector3 position = new Vector3(), int pitch = 0)
		{
			Id = id;
			Position = position;
			Pitch = pitch;
		}


		public virtual void Spawn(Level level)
		{
			McpeLevelEvent levelEvent = new McpeLevelEvent
			{
				eventId = Id,
				data = Pitch,
				x = (float) Position.X,
				y = (float) Position.Y,
				z = (float) Position.Z
			};

			level.RelayBroadcast(levelEvent);
		}
	}
}