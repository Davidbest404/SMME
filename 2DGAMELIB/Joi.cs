using System;

namespace _2DGAMELIB
{
	[Serializable]
	public class Joi
	{
		public Joi()
		{
		}

		public Joi(Joi Joi)
		{
			this.Joint = Joi.Joint;
		}

		public Joi(Vector2D Joint)
		{
			this.Joint = Joint;
		}

		public Joi(ref Vector2D Joint)
		{
			this.Joint = Joint;
		}

		public Vector2D Joint = Dat.Vec2DZero;
	}
}
