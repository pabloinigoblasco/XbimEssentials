// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.IfcRail.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.IfcRail.DateTimeResource;
//## Custom using statements
//##


namespace Xbim.IfcRail.DateTimeResource
{
	[ExpressType("IfcResourceTime", 1259)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcResourceTime : IfcSchedulingTime, IInstantiableEntity, IEquatable<@IfcResourceTime>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcResourceTime(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcDuration? _scheduleWork;
		private IfcPositiveRatioMeasure? _scheduleUsage;
		private IfcDateTime? _scheduleStart;
		private IfcDateTime? _scheduleFinish;
		private IfcLabel? _scheduleContour;
		private IfcDuration? _levelingDelay;
		private IfcBoolean? _isOverAllocated;
		private IfcDateTime? _statusTime;
		private IfcDuration? _actualWork;
		private IfcPositiveRatioMeasure? _actualUsage;
		private IfcDateTime? _actualStart;
		private IfcDateTime? _actualFinish;
		private IfcDuration? _remainingWork;
		private IfcPositiveRatioMeasure? _remainingUsage;
		private IfcPositiveRatioMeasure? _completion;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcDuration? @ScheduleWork 
		{ 
			get 
			{
				if(_activated) return _scheduleWork;
				Activate();
				return _scheduleWork;
			} 
			set
			{
				SetValue( v =>  _scheduleWork = v, _scheduleWork, value,  "ScheduleWork", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcPositiveRatioMeasure? @ScheduleUsage 
		{ 
			get 
			{
				if(_activated) return _scheduleUsage;
				Activate();
				return _scheduleUsage;
			} 
			set
			{
				SetValue( v =>  _scheduleUsage = v, _scheduleUsage, value,  "ScheduleUsage", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcDateTime? @ScheduleStart 
		{ 
			get 
			{
				if(_activated) return _scheduleStart;
				Activate();
				return _scheduleStart;
			} 
			set
			{
				SetValue( v =>  _scheduleStart = v, _scheduleStart, value,  "ScheduleStart", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcDateTime? @ScheduleFinish 
		{ 
			get 
			{
				if(_activated) return _scheduleFinish;
				Activate();
				return _scheduleFinish;
			} 
			set
			{
				SetValue( v =>  _scheduleFinish = v, _scheduleFinish, value,  "ScheduleFinish", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcLabel? @ScheduleContour 
		{ 
			get 
			{
				if(_activated) return _scheduleContour;
				Activate();
				return _scheduleContour;
			} 
			set
			{
				SetValue( v =>  _scheduleContour = v, _scheduleContour, value,  "ScheduleContour", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 9)]
		public IfcDuration? @LevelingDelay 
		{ 
			get 
			{
				if(_activated) return _levelingDelay;
				Activate();
				return _levelingDelay;
			} 
			set
			{
				SetValue( v =>  _levelingDelay = v, _levelingDelay, value,  "LevelingDelay", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 10)]
		public IfcBoolean? @IsOverAllocated 
		{ 
			get 
			{
				if(_activated) return _isOverAllocated;
				Activate();
				return _isOverAllocated;
			} 
			set
			{
				SetValue( v =>  _isOverAllocated = v, _isOverAllocated, value,  "IsOverAllocated", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 11)]
		public IfcDateTime? @StatusTime 
		{ 
			get 
			{
				if(_activated) return _statusTime;
				Activate();
				return _statusTime;
			} 
			set
			{
				SetValue( v =>  _statusTime = v, _statusTime, value,  "StatusTime", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 12)]
		public IfcDuration? @ActualWork 
		{ 
			get 
			{
				if(_activated) return _actualWork;
				Activate();
				return _actualWork;
			} 
			set
			{
				SetValue( v =>  _actualWork = v, _actualWork, value,  "ActualWork", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 13)]
		public IfcPositiveRatioMeasure? @ActualUsage 
		{ 
			get 
			{
				if(_activated) return _actualUsage;
				Activate();
				return _actualUsage;
			} 
			set
			{
				SetValue( v =>  _actualUsage = v, _actualUsage, value,  "ActualUsage", 13);
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 14)]
		public IfcDateTime? @ActualStart 
		{ 
			get 
			{
				if(_activated) return _actualStart;
				Activate();
				return _actualStart;
			} 
			set
			{
				SetValue( v =>  _actualStart = v, _actualStart, value,  "ActualStart", 14);
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 15)]
		public IfcDateTime? @ActualFinish 
		{ 
			get 
			{
				if(_activated) return _actualFinish;
				Activate();
				return _actualFinish;
			} 
			set
			{
				SetValue( v =>  _actualFinish = v, _actualFinish, value,  "ActualFinish", 15);
			} 
		}	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 16)]
		public IfcDuration? @RemainingWork 
		{ 
			get 
			{
				if(_activated) return _remainingWork;
				Activate();
				return _remainingWork;
			} 
			set
			{
				SetValue( v =>  _remainingWork = v, _remainingWork, value,  "RemainingWork", 16);
			} 
		}	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 17)]
		public IfcPositiveRatioMeasure? @RemainingUsage 
		{ 
			get 
			{
				if(_activated) return _remainingUsage;
				Activate();
				return _remainingUsage;
			} 
			set
			{
				SetValue( v =>  _remainingUsage = v, _remainingUsage, value,  "RemainingUsage", 17);
			} 
		}	
		[EntityAttribute(18, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 18)]
		public IfcPositiveRatioMeasure? @Completion 
		{ 
			get 
			{
				if(_activated) return _completion;
				Activate();
				return _completion;
			} 
			set
			{
				SetValue( v =>  _completion = v, _completion, value,  "Completion", 18);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_scheduleWork = value.StringVal;
					return;
				case 4: 
					_scheduleUsage = value.RealVal;
					return;
				case 5: 
					_scheduleStart = value.StringVal;
					return;
				case 6: 
					_scheduleFinish = value.StringVal;
					return;
				case 7: 
					_scheduleContour = value.StringVal;
					return;
				case 8: 
					_levelingDelay = value.StringVal;
					return;
				case 9: 
					_isOverAllocated = value.BooleanVal;
					return;
				case 10: 
					_statusTime = value.StringVal;
					return;
				case 11: 
					_actualWork = value.StringVal;
					return;
				case 12: 
					_actualUsage = value.RealVal;
					return;
				case 13: 
					_actualStart = value.StringVal;
					return;
				case 14: 
					_actualFinish = value.StringVal;
					return;
				case 15: 
					_remainingWork = value.StringVal;
					return;
				case 16: 
					_remainingUsage = value.RealVal;
					return;
				case 17: 
					_completion = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcResourceTime other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}