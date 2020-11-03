// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

//## Custom using statements
//##

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.DateTimeResource
{
	public partial class @IfcTaskTime : IIfcTaskTime
	{

		[CrossSchemaAttribute(typeof(IIfcTaskTime), 4)]
		Ifc4.Interfaces.IfcTaskDurationEnum? IIfcTaskTime.DurationType 
		{ 
			get
			{
				//## Custom code to handle enumeration of DurationType
				//##
				switch (DurationType)
				{
					case IfcTaskDurationEnum.ELAPSEDTIME:
						return Ifc4.Interfaces.IfcTaskDurationEnum.ELAPSEDTIME;
					case IfcTaskDurationEnum.WORKTIME:
						return Ifc4.Interfaces.IfcTaskDurationEnum.WORKTIME;
					case IfcTaskDurationEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcTaskDurationEnum.NOTDEFINED;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of DurationType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcTaskDurationEnum.ELAPSEDTIME:
						DurationType = IfcTaskDurationEnum.ELAPSEDTIME;
						return;
					case Ifc4.Interfaces.IfcTaskDurationEnum.WORKTIME:
						DurationType = IfcTaskDurationEnum.WORKTIME;
						return;
					case Ifc4.Interfaces.IfcTaskDurationEnum.NOTDEFINED:
						DurationType = IfcTaskDurationEnum.NOTDEFINED;
						return;
					
					case null:
						DurationType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTaskTime), 5)]
		Ifc4.DateTimeResource.IfcDuration? IIfcTaskTime.ScheduleDuration 
		{ 
			get
			{
				if (!ScheduleDuration.HasValue) return null;
				return new Ifc4.DateTimeResource.IfcDuration(ScheduleDuration.Value);
			} 
			set
			{
				ScheduleDuration = value.HasValue ? 
					new IfcDuration(value.Value) :  
					 new IfcDuration?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTaskTime), 6)]
		Ifc4.DateTimeResource.IfcDateTime? IIfcTaskTime.ScheduleStart 
		{ 
			get
			{
				if (!ScheduleStart.HasValue) return null;
				return new Ifc4.DateTimeResource.IfcDateTime(ScheduleStart.Value);
			} 
			set
			{
				ScheduleStart = value.HasValue ? 
					new IfcDateTime(value.Value) :  
					 new IfcDateTime?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTaskTime), 7)]
		Ifc4.DateTimeResource.IfcDateTime? IIfcTaskTime.ScheduleFinish 
		{ 
			get
			{
				if (!ScheduleFinish.HasValue) return null;
				return new Ifc4.DateTimeResource.IfcDateTime(ScheduleFinish.Value);
			} 
			set
			{
				ScheduleFinish = value.HasValue ? 
					new IfcDateTime(value.Value) :  
					 new IfcDateTime?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTaskTime), 8)]
		Ifc4.DateTimeResource.IfcDateTime? IIfcTaskTime.EarlyStart 
		{ 
			get
			{
				if (!EarlyStart.HasValue) return null;
				return new Ifc4.DateTimeResource.IfcDateTime(EarlyStart.Value);
			} 
			set
			{
				EarlyStart = value.HasValue ? 
					new IfcDateTime(value.Value) :  
					 new IfcDateTime?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTaskTime), 9)]
		Ifc4.DateTimeResource.IfcDateTime? IIfcTaskTime.EarlyFinish 
		{ 
			get
			{
				if (!EarlyFinish.HasValue) return null;
				return new Ifc4.DateTimeResource.IfcDateTime(EarlyFinish.Value);
			} 
			set
			{
				EarlyFinish = value.HasValue ? 
					new IfcDateTime(value.Value) :  
					 new IfcDateTime?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTaskTime), 10)]
		Ifc4.DateTimeResource.IfcDateTime? IIfcTaskTime.LateStart 
		{ 
			get
			{
				if (!LateStart.HasValue) return null;
				return new Ifc4.DateTimeResource.IfcDateTime(LateStart.Value);
			} 
			set
			{
				LateStart = value.HasValue ? 
					new IfcDateTime(value.Value) :  
					 new IfcDateTime?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTaskTime), 11)]
		Ifc4.DateTimeResource.IfcDateTime? IIfcTaskTime.LateFinish 
		{ 
			get
			{
				if (!LateFinish.HasValue) return null;
				return new Ifc4.DateTimeResource.IfcDateTime(LateFinish.Value);
			} 
			set
			{
				LateFinish = value.HasValue ? 
					new IfcDateTime(value.Value) :  
					 new IfcDateTime?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTaskTime), 12)]
		Ifc4.DateTimeResource.IfcDuration? IIfcTaskTime.FreeFloat 
		{ 
			get
			{
				if (!FreeFloat.HasValue) return null;
				return new Ifc4.DateTimeResource.IfcDuration(FreeFloat.Value);
			} 
			set
			{
				FreeFloat = value.HasValue ? 
					new IfcDuration(value.Value) :  
					 new IfcDuration?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTaskTime), 13)]
		Ifc4.DateTimeResource.IfcDuration? IIfcTaskTime.TotalFloat 
		{ 
			get
			{
				if (!TotalFloat.HasValue) return null;
				return new Ifc4.DateTimeResource.IfcDuration(TotalFloat.Value);
			} 
			set
			{
				TotalFloat = value.HasValue ? 
					new IfcDuration(value.Value) :  
					 new IfcDuration?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTaskTime), 14)]
		Ifc4.MeasureResource.IfcBoolean? IIfcTaskTime.IsCritical 
		{ 
			get
			{
				if (!IsCritical.HasValue) return null;
				return new Ifc4.MeasureResource.IfcBoolean(IsCritical.Value);
			} 
			set
			{
				IsCritical = value.HasValue ? 
					new MeasureResource.IfcBoolean(value.Value) :  
					 new MeasureResource.IfcBoolean?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTaskTime), 15)]
		Ifc4.DateTimeResource.IfcDateTime? IIfcTaskTime.StatusTime 
		{ 
			get
			{
				if (!StatusTime.HasValue) return null;
				return new Ifc4.DateTimeResource.IfcDateTime(StatusTime.Value);
			} 
			set
			{
				StatusTime = value.HasValue ? 
					new IfcDateTime(value.Value) :  
					 new IfcDateTime?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTaskTime), 16)]
		Ifc4.DateTimeResource.IfcDuration? IIfcTaskTime.ActualDuration 
		{ 
			get
			{
				if (!ActualDuration.HasValue) return null;
				return new Ifc4.DateTimeResource.IfcDuration(ActualDuration.Value);
			} 
			set
			{
				ActualDuration = value.HasValue ? 
					new IfcDuration(value.Value) :  
					 new IfcDuration?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTaskTime), 17)]
		Ifc4.DateTimeResource.IfcDateTime? IIfcTaskTime.ActualStart 
		{ 
			get
			{
				if (!ActualStart.HasValue) return null;
				return new Ifc4.DateTimeResource.IfcDateTime(ActualStart.Value);
			} 
			set
			{
				ActualStart = value.HasValue ? 
					new IfcDateTime(value.Value) :  
					 new IfcDateTime?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTaskTime), 18)]
		Ifc4.DateTimeResource.IfcDateTime? IIfcTaskTime.ActualFinish 
		{ 
			get
			{
				if (!ActualFinish.HasValue) return null;
				return new Ifc4.DateTimeResource.IfcDateTime(ActualFinish.Value);
			} 
			set
			{
				ActualFinish = value.HasValue ? 
					new IfcDateTime(value.Value) :  
					 new IfcDateTime?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTaskTime), 19)]
		Ifc4.DateTimeResource.IfcDuration? IIfcTaskTime.RemainingTime 
		{ 
			get
			{
				if (!RemainingTime.HasValue) return null;
				return new Ifc4.DateTimeResource.IfcDuration(RemainingTime.Value);
			} 
			set
			{
				RemainingTime = value.HasValue ? 
					new IfcDuration(value.Value) :  
					 new IfcDuration?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTaskTime), 20)]
		Ifc4.MeasureResource.IfcPositiveRatioMeasure? IIfcTaskTime.Completion 
		{ 
			get
			{
				if (!Completion.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveRatioMeasure(Completion.Value);
			} 
			set
			{
				Completion = value.HasValue ? 
					new MeasureResource.IfcPositiveRatioMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveRatioMeasure?() ;
				
			}
		}
	//## Custom code
	//##
	}
}