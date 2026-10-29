using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace _2DGAMELIB
{
	[Serializable]
	public class Par
	{
		public Pars Parent
		{
			get
			{
				return this.parent;
			}
		}

		public void SetParent(Pars Parent)
		{
			this.parent = Parent;
		}

		public List<Out> OP
		{
			get
			{
				this.Edit = true;
				this.EditH = true;
				return this.op;
			}
			set
			{
				this.op = value;
				this.Edit = true;
				this.EditH = true;
			}
		}

		public IEnumerable<Out> InitializeOP
		{
			set
			{
				this.op.Clear();
				this.op.AddRange(value);
				this.Edit = true;
				this.EditH = true;
			}
		}

		public List<Joi> JP
		{
			get
			{
				return this.jp;
			}
			set
			{
				this.jp = value;
			}
		}

		public IEnumerable<Joi> InitializeJP
		{
			set
			{
				this.jp.Clear();
				this.jp.AddRange(value);
			}
		}

		public Vector2D BasePointBase
		{
			get
			{
				return this.basePointBase;
			}
			set
			{
				this.basePointBase = value;
				this.Edit = true;
				this.EditH = true;
			}
		}

		public Vector2D BasePointCont
		{
			get
			{
				return this.basePointCont;
			}
			set
			{
				this.basePointCont = value;
				this.Edit = true;
				this.EditH = true;
			}
		}

		public Vector2D BasePoint
		{
			get
			{
				return this.basePointBase + this.basePointCont;
			}
		}

		public Vector2D PositionBase
		{
			get
			{
				return this.positionBase;
			}
			set
			{
				this.positionBase = value;
				this.Edit = true;
				this.EditH = true;
			}
		}

		public Vector2D PositionCont
		{
			get
			{
				return this.positionContO;
			}
			set
			{
				this.positionContO = value;
				this.Edit = true;
				this.EditH = true;
			}
		}

		public Vector2D Position
		{
			get
			{
				double d = 3.141592653589793 * this.AnglePare / 180.0;
				double num = Math.Cos(d);
				double num2 = Math.Sin(d);
				this.positionCont.X = this.positionContO.X * num + this.positionContO.Y * -num2;
				this.positionCont.Y = this.positionContO.X * num2 + this.positionContO.Y * num;
				return (this.positionBase + this.positionCont) * this.positionSize + this.positionVector;
			}
		}

		public Vector2D Position_nc
		{
			get
			{
				double d = 3.141592653589793 * this.AnglePare / 180.0;
				Math.Cos(d);
				Math.Sin(d);
				return this.positionBase * this.positionSize + this.positionVector;
			}
		}

		public double PositionSize
		{
			get
			{
				return this.positionSize;
			}
			set
			{
				this.positionSize = value;
				this.Edit = true;
				this.EditH = true;
				this.EditPS = true;
			}
		}

		public Vector2D PositionVector
		{
			get
			{
				return this.positionVector;
			}
			set
			{
				this.positionVector = value;
				this.Edit = true;
				this.EditH = true;
			}
		}

		public double AnglePare
		{
			get
			{
				return this.anglePare;
			}
			set
			{
				this.anglePare = value;
				this.Edit = true;
				this.EditH = true;
			}
		}

		public double AngleBase
		{
			get
			{
				return this.angleBase;
			}
			set
			{
				this.angleBase = value;
				this.Edit = true;
				this.EditH = true;
			}
		}

		public double AngleCont
		{
			get
			{
				return this.angleCont;
			}
			set
			{
				this.angleCont = value;
				this.Edit = true;
				this.EditH = true;
			}
		}

		public double Angle
		{
			get
			{
				return this.anglePare + this.angleBase + this.angleCont;
			}
		}

		public double SizeBase
		{
			get
			{
				return this.sizeBase;
			}
			set
			{
				this.sizeBase = value;
				this.Edit = true;
				this.EditH = true;
				this.EditS = true;
			}
		}

		public double SizeCont
		{
			get
			{
				return this.sizeCont;
			}
			set
			{
				this.sizeCont = value;
				this.Edit = true;
				this.EditH = true;
				this.EditS = true;
			}
		}

		public double Size
		{
			get
			{
				return this.sizeBase * this.sizeCont * this.positionSize;
			}
		}

		public double SizeXBase
		{
			get
			{
				return this.xSizeBase;
			}
			set
			{
				this.xSizeBase = value;
				this.Edit = true;
				this.EditH = true;
			}
		}

		public double SizeXCont
		{
			get
			{
				return this.xSizeCont;
			}
			set
			{
				this.xSizeCont = value;
				this.Edit = true;
				this.EditH = true;
			}
		}

		public double SizeX
		{
			get
			{
				return this.xSizeBase * this.xSizeCont;
			}
		}

		public double SizeYBase
		{
			get
			{
				return this.ySizeBase;
			}
			set
			{
				this.ySizeBase = value;
				this.Edit = true;
				this.EditH = true;
			}
		}

		public double SizeYCont
		{
			get
			{
				return this.ySizeCont;
			}
			set
			{
				this.ySizeCont = value;
				this.Edit = true;
				this.EditH = true;
			}
		}

		public double SizeY
		{
			get
			{
				return this.ySizeBase * this.ySizeCont;
			}
		}

		public bool Closed
		{
			get
			{
				return this.closed;
			}
			set
			{
				this.closed = value;
				this.Edit = true;
				this.EditH = true;
			}
		}

		public Pen Pen
		{
			get
			{
				return this.pen;
			}
			set
			{
				if (this.pen != value && this.pen != null)
				{
					this.pen.Dispose();
				}
				this.pen = value;
				if (this.pen != null)
				{
					this.pen.StartCap = LineCap.Round;
					this.pen.EndCap = LineCap.Round;
				}
				this.EditP = true;
			}
		}

		public double PenWidth
		{
			get
			{
				return this.penWidth;
			}
			set
			{
				this.penWidth = value;
				this.EditP = true;
			}
		}

		public Color PenColor
		{
			get
			{
				return this.pen.Color;
			}
			set
			{
				this.pen.Color = value;
			}
		}

		public void SetPen(Pen Pen)
		{
			this.pen = Pen;
			if (this.pen != null)
			{
				this.pen.StartCap = LineCap.Round;
				this.pen.EndCap = LineCap.Round;
			}
			this.EditP = true;
		}

		public Brush Brush
		{
			get
			{
				return this.brush;
			}
			set
			{
				if (this.brush != value && this.brush != null)
				{
					this.brush.Dispose();
				}
				this.brush = value;
			}
		}

		public Color BrushColor
		{
			get
			{
				return ((SolidBrush)this.brush).Color;
			}
			set
			{
				((SolidBrush)this.brush).Color = value;
			}
		}

		public void SetBrush(Brush Brush)
		{
			this.brush = Brush;
		}

		public Color HitColor
		{
			get
			{
				return this.HitBrush.Color;
			}
			set
			{
				this.HitBrush.Color = value;
			}
		}

		public void EditTrue()
		{
			this.Edit = true;
			this.EditH = true;
		}

		public void SetDefault()
		{
			this.pen = new Pen(Color.Black, 1f);
			this.pen.StartCap = LineCap.Round;
			this.pen.EndCap = LineCap.Round;
			this.brush = new SolidBrush(Color.LightGray);
			this.HitBrush = new SolidBrush(Color.Transparent);
			this.gp1 = new GraphicsPath();
			this.gp2 = new GraphicsPath();
			this.gph = new GraphicsPath();
		}

		public Par()
		{
			this.pen.StartCap = LineCap.Round;
			this.pen.EndCap = LineCap.Round;
		}

		public Par(Par Par)
		{
			this.Copy(Par);
		}

		protected void Copy(Par Par)
		{
			this.Tag = Par.Tag;
			this.op = new List<Out>(Par.op.Count);
			for (int i = 0; i < Par.op.Count; i++)
			{
				this.op.Add(new Out(Par.op[i]));
			}
			this.jp = new List<Joi>(Par.jp.Count);
			for (int j = 0; j < Par.jp.Count; j++)
			{
				this.jp.Add(new Joi(Par.jp[j]));
			}
			this.basePointBase = Par.basePointBase;
			this.basePointCont = Par.basePointCont;
			this.positionBase = Par.positionBase;
			this.positionContO = Par.positionContO;
			this.positionCont = Par.positionCont;
			this.positionSize = Par.positionSize;
			this.positionVector = Par.positionVector;
			this.anglePare = Par.anglePare;
			this.angleBase = Par.angleBase;
			this.angleCont = Par.angleCont;
			this.sizeBase = Par.sizeBase;
			this.sizeCont = Par.sizeCont;
			this.xSizeBase = Par.xSizeBase;
			this.xSizeCont = Par.xSizeCont;
			this.ySizeBase = Par.ySizeBase;
			this.ySizeCont = Par.ySizeCont;
			this.penWidth = Par.penWidth;
			this.Dra = Par.Dra;
			this.closed = Par.closed;
			if (Par.pen != null)
			{
				this.Pen = Par.pen.Copy();
			}
			if (Par.brush != null)
			{
				this.Brush = Par.brush.Copy();
			}
			this.Hit = Par.Hit;
			if (Par.HitBrush != null)
			{
				this.HitBrush = (SolidBrush)Par.HitBrush.Copy();
			}
		}

		private void Calculation(double Unit)
		{
			this.us = Unit * this.Size;
			this.usx = this.us * this.SizeX;
			this.usy = this.us * this.SizeY;
			this.bp = this.BasePoint;
			this.bp.X = this.bp.X * this.usx;
			this.bp.Y = this.bp.Y * this.usy;
			this.mv = this.Position;
			this.mv.X = this.mv.X * Unit - this.bp.X;
			this.mv.Y = this.mv.Y * Unit - this.bp.Y;
			this.a = 3.141592653589793 * this.Angle / 180.0;
			this.M11 = Math.Cos(this.a);
			this.M12 = Math.Sin(this.a);
			this.gp1.Reset();
			this.gp2.Reset();
			if (this.Closed)
			{
				using (List<Out>.Enumerator enumerator = this.op.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Out @out = enumerator.Current;
						this.ps = new PointF[@out.ps.Count];
						for (int i = 0; i < @out.ps.Count; i++)
						{
							this.p.X = @out.ps[i].X * this.usx;
							this.p.Y = @out.ps[i].Y * this.usy;
							this.Transform(ref this.p);
							this.p.X = this.p.X + this.mv.X;
							this.p.Y = this.p.Y + this.mv.Y;
							this.ps[i].X = (float)this.p.X;
							this.ps[i].Y = (float)this.p.Y;
						}
						this.gp1.AddClosedCurve(this.ps, @out.Tension);
						if (@out.Outline)
						{
							this.gp2.StartFigure();
							this.gp2.AddClosedCurve(this.ps, @out.Tension);
						}
					}
					return;
				}
			}
			foreach (Out out2 in this.op)
			{
				this.ps = new PointF[out2.ps.Count];
				for (int j = 0; j < out2.ps.Count; j++)
				{
					this.p.X = out2.ps[j].X * this.usx;
					this.p.Y = out2.ps[j].Y * this.usy;
					this.Transform(ref this.p);
					this.p.X = this.p.X + this.mv.X;
					this.p.Y = this.p.Y + this.mv.Y;
					this.ps[j].X = (float)this.p.X;
					this.ps[j].Y = (float)this.p.Y;
				}
				this.gp1.AddCurve(this.ps, out2.Tension);
				if (out2.Outline)
				{
					this.gp2.StartFigure();
					this.gp2.AddCurve(this.ps, out2.Tension);
				}
			}
		}

		private void Transform(ref Vector2D p)
		{
			p.X -= this.bp.X;
			p.Y -= this.bp.Y;
			this.v.X = p.X * this.M11 + p.Y * -this.M12;
			this.v.Y = p.X * this.M12 + p.Y * this.M11;
			p.X = this.v.X + this.bp.X;
			p.Y = this.v.Y + this.bp.Y;
		}

		public void Draw(double Unit, Graphics Graphics)
		{
			if (this.Dra)
			{
				if (this.Edit)
				{
					this.Calculation(Unit);
					this.Edit = false;
				}
				if (this.pen != null && (this.EditP || this.EditPS))
				{
					this.pen.Width = (float)(Unit * this.penWidth * this.positionSize);
					this.EditP = false;
					this.EditPS = false;
				}
				if (this.brush != null)
				{
					Graphics.FillPath(this.brush, this.gp1);
				}
				if (this.pen != null)
				{
					Graphics.DrawPath(this.pen, this.gp2);
				}
			}
		}

		private void CalculationH(double Unit)
		{
			this.ush = Unit * this.Size;
			this.usxh = this.ush * this.SizeX;
			this.usyh = this.ush * this.SizeY;
			this.bph = this.BasePoint;
			this.bph.X = this.bph.X * this.usxh;
			this.bph.Y = this.bph.Y * this.usyh;
			this.mvh = this.Position;
			this.mvh.X = this.mvh.X * Unit - this.bph.X;
			this.mvh.Y = this.mvh.Y * Unit - this.bph.Y;
			this.ah = 3.141592653589793 * this.Angle / 180.0;
			this.M11h = Math.Cos(this.ah);
			this.M12h = Math.Sin(this.ah);
			this.gph.Reset();
			if (this.Closed)
			{
				using (List<Out>.Enumerator enumerator = this.op.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Out @out = enumerator.Current;
						this.psh = new PointF[@out.ps.Count];
						for (int i = 0; i < @out.ps.Count; i++)
						{
							this.ph.X = @out.ps[i].X * this.usxh;
							this.ph.Y = @out.ps[i].Y * this.usyh;
							this.TransformH(ref this.ph);
							this.ph.X = this.ph.X + this.mvh.X;
							this.ph.Y = this.ph.Y + this.mvh.Y;
							this.psh[i].X = (float)this.ph.X;
							this.psh[i].Y = (float)this.ph.Y;
						}
						this.gph.AddClosedCurve(this.psh, @out.Tension);
					}
					return;
				}
			}
			foreach (Out out2 in this.op)
			{
				this.psh = new PointF[out2.ps.Count];
				for (int j = 0; j < out2.ps.Count; j++)
				{
					this.ph.X = out2.ps[j].X * this.usxh;
					this.ph.Y = out2.ps[j].Y * this.usyh;
					this.TransformH(ref this.ph);
					this.ph.X = this.ph.X + this.mvh.X;
					this.ph.Y = this.ph.Y + this.mvh.Y;
					this.psh[j].X = (float)this.ph.X;
					this.psh[j].Y = (float)this.ph.Y;
				}
				this.gph.AddCurve(this.psh, out2.Tension);
			}
		}

		private void TransformH(ref Vector2D ph)
		{
			ph.X -= this.bph.X;
			ph.Y -= this.bph.Y;
			this.vh.X = ph.X * this.M11h + ph.Y * -this.M12h;
			this.vh.Y = ph.X * this.M12h + ph.Y * this.M11h;
			ph.X = this.vh.X + this.bph.X;
			ph.Y = this.vh.Y + this.bph.Y;
		}

		public void DrawH(double Unit, Graphics Graphics)
		{
			if (this.Hit)
			{
				if (this.EditH)
				{
					this.CalculationH(Unit);
					this.EditH = false;
				}
				Graphics.FillPath(this.HitBrush, this.gph);
			}
		}

		public void SetJointP(int Index, Par Par)
		{
			if (Index < this.jp.Count)
			{
				Par.PositionBase = this.ToGlobal(this.jp[Index].Joint);
			}
			Par.Edit = true;
			Par.EditH = true;
		}

		public void SetJointPA(int Index, Par Par)
		{
			if (Index < this.jp.Count)
			{
				Par.PositionBase = this.ToGlobal(this.jp[Index].Joint);
			}
			Par.AnglePare = this.Angle;
			Par.Edit = true;
			Par.EditH = true;
		}

		public Vector2D ToGlobal(Vector2D Local)
		{
			double size = this.Size;
			double num = size * this.SizeX;
			double num2 = size * this.SizeY;
			Vector2D basePoint = this.BasePoint;
			basePoint.X *= num;
			basePoint.Y *= num2;
			Vector2D position = this.Position;
			position.X -= basePoint.X;
			position.Y -= basePoint.Y;
			double d = 3.141592653589793 * this.Angle / 180.0;
			double num3 = Math.Cos(d);
			double num4 = Math.Sin(d);
			double num5 = -num4;
			double num6 = num3;
			Local.X *= num;
			Local.Y *= num2;
			Local.X -= basePoint.X;
			Local.Y -= basePoint.Y;
			Vector2D vector2D;
			vector2D.X = Local.X * num3 + Local.Y * num5;
			vector2D.Y = Local.X * num4 + Local.Y * num6;
			Local.X = vector2D.X;
			Local.Y = vector2D.Y;
			Local.X += basePoint.X;
			Local.Y += basePoint.Y;
			Local.X += position.X;
			Local.Y += position.Y;
			return Local;
		}

		public Vector2D ToGlobal_nc(Vector2D Local)
		{
			double size = this.Size;
			double num = size * this.SizeX;
			double num2 = size * this.SizeY;
			Vector2D basePoint = this.BasePoint;
			basePoint.X *= num;
			basePoint.Y *= num2;
			Vector2D position_nc = this.Position_nc;
			position_nc.X -= basePoint.X;
			position_nc.Y -= basePoint.Y;
			double d = 3.141592653589793 * this.Angle / 180.0;
			double num3 = Math.Cos(d);
			double num4 = Math.Sin(d);
			double num5 = -num4;
			double num6 = num3;
			Local.X *= num;
			Local.Y *= num2;
			Local.X -= basePoint.X;
			Local.Y -= basePoint.Y;
			Vector2D vector2D;
			vector2D.X = Local.X * num3 + Local.Y * num5;
			vector2D.Y = Local.X * num4 + Local.Y * num6;
			Local.X = vector2D.X;
			Local.Y = vector2D.Y;
			Local.X += basePoint.X;
			Local.Y += basePoint.Y;
			Local.X += position_nc.X;
			Local.Y += position_nc.Y;
			return Local;
		}

		public Vector2D ToLocal(Vector2D Global)
		{
			double size = this.Size;
			double num = size * this.SizeX;
			double num2 = size * this.SizeY;
			Vector2D basePoint = this.BasePoint;
			basePoint.X *= num;
			basePoint.Y *= num2;
			Vector2D position = this.Position;
			position.X = basePoint.X - position.X;
			position.Y = basePoint.Y - position.Y;
			num = num.Reciprocal();
			num2 = num2.Reciprocal();
			double d = 3.141592653589793 * -this.Angle / 180.0;
			double num3 = Math.Cos(d);
			double num4 = Math.Sin(d);
			double num5 = -num4;
			double num6 = num3;
			Global.X += position.X;
			Global.Y += position.Y;
			Global.X -= basePoint.X;
			Global.Y -= basePoint.Y;
			Vector2D vector2D;
			vector2D.X = Global.X * num3 + Global.Y * num5;
			vector2D.Y = Global.X * num4 + Global.Y * num6;
			Global.X = vector2D.X;
			Global.Y = vector2D.Y;
			Global.X += basePoint.X;
			Global.Y += basePoint.Y;
			Global.X *= num;
			Global.Y *= num2;
			return Global;
		}

		public Par GetInter(Par Par)
		{
			Par par = new Par();
			par.Tag = this.Tag;
			for (int i = 0; i < this.op.Count; i++)
			{
				Out @out = new Out();
				for (int j = 0; j < this.op[i].ps.Count; j++)
				{
					@out.ps.Add((this.op[i].ps[j] + Par.op[i].ps[j]) * 0.5);
				}
				@out.Tension = (float)(((double)this.op[i].Tension + (double)Par.op[i].Tension) * 0.5);
				@out.Outline = this.op[i].Outline;
				par.op.Add(@out);
			}
			for (int k = 0; k < this.jp.Count; k++)
			{
				par.jp.Add(new Joi((this.jp[k].Joint + Par.jp[k].Joint) * 0.5));
			}
			par.basePointBase = (this.basePointBase + Par.basePointBase) * 0.5;
			par.basePointCont = (this.basePointCont + Par.basePointCont) * 0.5;
			par.positionBase = (this.positionBase + Par.positionBase) * 0.5;
			par.positionContO = (this.positionContO + Par.positionContO) * 0.5;
			par.positionCont = (this.positionCont + Par.positionCont) * 0.5;
			par.positionSize = (this.positionSize + Par.positionSize) * 0.5;
			par.positionVector = (this.positionVector + Par.positionVector) * 0.5;
			par.anglePare = (this.anglePare + Par.anglePare) * 0.5;
			par.angleBase = (this.angleBase + Par.angleBase) * 0.5;
			par.angleCont = (this.angleCont + Par.angleCont) * 0.5;
			par.sizeBase = (this.sizeBase + Par.sizeBase) * 0.5;
			par.sizeCont = (this.sizeCont + Par.sizeCont) * 0.5;
			par.xSizeBase = (this.xSizeBase + Par.xSizeBase) * 0.5;
			par.xSizeCont = (this.xSizeCont + Par.xSizeCont) * 0.5;
			par.ySizeBase = (this.ySizeBase + Par.ySizeBase) * 0.5;
			par.ySizeCont = (this.ySizeCont + Par.ySizeCont) * 0.5;
			par.penWidth = (this.penWidth + Par.penWidth) * 0.5;
			par.Dra = this.Dra;
			par.closed = this.closed;
			if (this.pen != null)
			{
				par.pen = this.pen.Copy();
			}
			if (this.brush != null)
			{
				par.brush = this.brush.Copy();
			}
			par.Hit = this.Hit;
			if (this.HitBrush != null)
			{
				par.HitBrush = (SolidBrush)this.HitBrush.Copy();
			}
			return par;
		}

		public bool IsParT()
		{
			return this is ParT;
		}

		public ParT ToParT()
		{
			return (ParT)this;
		}

		public List<int> GetPath()
		{
			List<int> list = new List<int>
			{
				this.parent.IndexOf(this)
			};
			Pars pars = this.parent;
			for (Pars pars2 = pars.Parent; pars2 != null; pars2 = pars.Parent)
			{
				list.Insert(0, pars2.IndexOf(pars));
				pars = pars2;
			}
			return list;
		}

		public Pars GetRoot()
		{
			Pars pars = this.parent;
			while (pars.Parent != null)
			{
				pars = pars.Parent;
			}
			return pars;
		}

		public override string ToString()
		{
			return this.Tag;
		}

		public void ReverseX()
		{
			this.op.ReverseX(ref this.basePointBase);
			this.jp.ReverseX(ref this.basePointBase);
			this.angleBase = 360.0 - this.angleBase;
			this.angleCont = 360.0 - this.angleCont;
		}

		public void ReverseY()
		{
			this.op.ReverseY(ref this.basePointBase);
			this.jp.ReverseY(ref this.basePointBase);
			this.angleBase = 360.0 - this.angleBase;
			this.angleCont = 360.0 - this.angleCont;
		}

		public bool IsParentTag(string Tag)
		{
			return this.Parent != null && this.Parent.Tag == Tag;
		}

		public bool IsRootTag(string Tag)
		{
			Pars root = this.GetRoot();
			return root != null && root.Tag == Tag;
		}

		public bool ContainsParentTag(string Tag)
		{
			return this.Parent != null && this.Parent.Tag.Contains(Tag);
		}

		public bool ContainsRootTag(string Tag)
		{
			Pars root = this.GetRoot();
			return root != null && root.Tag.Contains(Tag);
		}

		public double GetArea()
		{
			Vector2D[] array = this.op.EnumPoints().ToArray<Vector2D>();
			Vector2D vector2D = this.ToGlobal(array[0]);
			Vector2D vector2D2 = vector2D;
			double num = 0.0;
			for (int i = 1; i < array.Length; i++)
			{
				Vector2D vector2D3 = this.ToGlobal(array[i]);
				num += vector2D2.X * vector2D3.Y - vector2D3.X * vector2D2.Y;
				vector2D2 = vector2D3;
			}
			num += vector2D2.X * vector2D.Y - vector2D.X * vector2D2.Y;
			return Math.Abs(num * 0.5);
		}

		public void ScalingXY(double Scale)
		{
			this.op.ScalingXY(ref this.basePointBase, Scale);
			this.jp.ScalingXY(ref this.basePointBase, Scale);
		}

		public void ScalingX(double Scale)
		{
			this.op.ScalingX(ref this.basePointBase, Scale);
			this.jp.ScalingX(ref this.basePointBase, Scale);
		}

		public void ScalingY(double Scale)
		{
			this.op.ScalingY(ref this.basePointBase, Scale);
			this.jp.ScalingY(ref this.basePointBase, Scale);
		}

		public void ExpansionXY(double Rate)
		{
			this.op.ExpansionXY(ref this.basePointBase, Rate);
			this.jp.ExpansionXY(ref this.basePointBase, Rate);
		}

		public void ExpansionX(double Rate)
		{
			this.op.ExpansionX(ref this.basePointBase, Rate);
			this.jp.ExpansionX(ref this.basePointBase, Rate);
		}

		public void ExpansionY(double Rate)
		{
			this.op.ExpansionY(ref this.basePointBase, Rate);
			this.jp.ExpansionY(ref this.basePointBase, Rate);
		}

		public void Dispose()
		{
			if (this.pen != null)
			{
				this.pen.Dispose();
			}
			if (this.brush != null)
			{
				this.brush.Dispose();
			}
			this.HitBrush.Dispose();
			this.gp1.Dispose();
			this.gp2.Dispose();
			this.gph.Dispose();
		}

		private Pars parent;

		public string Tag = "";

		protected List<Out> op = new List<Out>();

		protected List<Joi> jp = new List<Joi>();

		protected Vector2D basePointBase = Dat.Vec2DZero;

		protected Vector2D basePointCont = Dat.Vec2DZero;

		protected Vector2D positionBase = Dat.Vec2DZero;

		protected Vector2D positionContO = Dat.Vec2DZero;

		protected Vector2D positionCont = Dat.Vec2DZero;

		protected double positionSize = 1.0;

		protected Vector2D positionVector = Dat.Vec2DZero;

		protected double anglePare;

		protected double angleBase;

		protected double angleCont;

		protected double sizeBase = 1.0;

		protected double sizeCont = 1.0;

		protected double xSizeBase = 1.0;

		protected double xSizeCont = 1.0;

		protected double ySizeBase = 1.0;

		protected double ySizeCont = 1.0;

		public bool Dra = true;

		private bool closed;

		[NonSerialized]
		protected Pen pen = new Pen(Color.Black, 1f);

		protected double penWidth;

		private bool EditP = true;

		[NonSerialized]
		protected Brush brush = new SolidBrush(Color.LightGray);

		public bool Hit = true;

		[NonSerialized]
		protected SolidBrush HitBrush = new SolidBrush(Color.Transparent);

		private double us;

		private double usx;

		private double usy;

		private Vector2D bp;

		private Vector2D mv;

		private double a;

		private double M11;

		private double M12;

		[NonSerialized]
		private GraphicsPath gp1 = new GraphicsPath();

		[NonSerialized]
		private GraphicsPath gp2 = new GraphicsPath();

		private Vector2D p;

		private Vector2D v;

		private PointF[] ps;

		protected bool Edit = true;

		protected bool EditS = true;

		protected bool EditPS = true;

		private double ush;

		private double usxh;

		private double usyh;

		private Vector2D bph;

		private Vector2D mvh;

		private double ah;

		private double M11h;

		private double M12h;

		[NonSerialized]
		private GraphicsPath gph = new GraphicsPath();

		private Vector2D ph;

		private Vector2D vh;

		private PointF[] psh;

		private bool EditH = true;
	}
}
