
/* Copyright (C) 2008 Robin Debreuil -- Released under the BSD License */

using System;
using System.Collections.Generic;
using System.Text;

namespace DDW.Vex
{
	public class Instance : IInstance
	{
		public uint SortOrder { get { return 99; } }

		private uint definitionId;
		public uint DefinitionId { get { return definitionId; } set { definitionId = value; } }

		private uint instanceId;
		public uint InstanceId { get { return instanceId; } set { instanceId = value; } }

		private uint startTime;
		public uint StartTime { get { return startTime; } set { startTime = value; } }

        public uint Depth { get; set; }
        public string Name { get; set; }

        private List<Transform> transformations = new List<Transform>();
        public List<Transform> Transformations { get { return transformations; } }

		public uint EndTime;

		public bool IsMask = false;
		public uint MaskDepth = 0;

		public int CompareTo(Object o)
		{
			int result = 0;
			if (o is Instance)
			{
				Instance inst = (Instance)o;
				if (this.Depth != inst.Depth)
				{
					result = ((int)this.Depth) > ((int)inst.Depth) ? 1 : -1;
				}	
			}
			else if (o is IInstance)
			{
				IInstance inst = (IInstance)o;
				result = ((int)this.SortOrder) > ((int)inst.SortOrder) ? 1 : -1;
			}
			else
			{
				throw new ArgumentException("Objects being compared are not of the same type");
			}
			return result;
		}

		//private uint endTime;
		//public uint EndTime
		//{
		//    get
		//    {
		//        return endTime;
		//    }
		//    set
		//    {
		//        endTime = value;
		//    }
		//}
	}
}
