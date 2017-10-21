using UnityEngine;
using static System.Math;
using KerbalFuture;

namespace SpaceFolder
{
	class LatLongHelper : MonoBehaviour
	{
		public double XFromLatLongAlt(double _lat, double _long,
											 double _alt)
		{
			return _alt * Cos(_lat) * Cos(_long);
		}

		public double YFromLatLongAlt(double _lat, double _long,
											 double _alt)
		{
			return _alt * Cos(_lat) * Sin(_long);
		}

		public double ZFromLatAlt(double _lat, double _alt)
		{
			return _alt * Cos(_lat);
		}
	}
}