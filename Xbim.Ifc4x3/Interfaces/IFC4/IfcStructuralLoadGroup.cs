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
namespace Xbim.Ifc4x3.StructuralAnalysisDomain
{
	public partial class @IfcStructuralLoadGroup : IIfcStructuralLoadGroup
	{

		[CrossSchemaAttribute(typeof(IIfcStructuralLoadGroup), 6)]
		Ifc4.Interfaces.IfcLoadGroupTypeEnum IIfcStructuralLoadGroup.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcLoadGroupTypeEnum.LOAD_GROUP:
						return Ifc4.Interfaces.IfcLoadGroupTypeEnum.LOAD_GROUP;
					case IfcLoadGroupTypeEnum.LOAD_CASE:
						return Ifc4.Interfaces.IfcLoadGroupTypeEnum.LOAD_CASE;
					case IfcLoadGroupTypeEnum.LOAD_COMBINATION:
						return Ifc4.Interfaces.IfcLoadGroupTypeEnum.LOAD_COMBINATION;
					case IfcLoadGroupTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcLoadGroupTypeEnum.USERDEFINED;
					case IfcLoadGroupTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcLoadGroupTypeEnum.NOTDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcLoadGroupTypeEnum.LOAD_GROUP:
						PredefinedType = IfcLoadGroupTypeEnum.LOAD_GROUP;
						return;
					case Ifc4.Interfaces.IfcLoadGroupTypeEnum.LOAD_CASE:
						PredefinedType = IfcLoadGroupTypeEnum.LOAD_CASE;
						return;
					case Ifc4.Interfaces.IfcLoadGroupTypeEnum.LOAD_COMBINATION:
						PredefinedType = IfcLoadGroupTypeEnum.LOAD_COMBINATION;
						return;
					case Ifc4.Interfaces.IfcLoadGroupTypeEnum.USERDEFINED:
						PredefinedType = IfcLoadGroupTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcLoadGroupTypeEnum.NOTDEFINED:
						PredefinedType = IfcLoadGroupTypeEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStructuralLoadGroup), 7)]
		Ifc4.Interfaces.IfcActionTypeEnum IIfcStructuralLoadGroup.ActionType 
		{ 
			get
			{
				//## Custom code to handle enumeration of ActionType
				//##
				switch (ActionType)
				{
					case IfcActionTypeEnum.PERMANENT_G:
						return Ifc4.Interfaces.IfcActionTypeEnum.PERMANENT_G;
					case IfcActionTypeEnum.VARIABLE_Q:
						return Ifc4.Interfaces.IfcActionTypeEnum.VARIABLE_Q;
					case IfcActionTypeEnum.EXTRAORDINARY_A:
						return Ifc4.Interfaces.IfcActionTypeEnum.EXTRAORDINARY_A;
					case IfcActionTypeEnum.USERDEFINED:
						//## Optional custom handling of ActionType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcActionTypeEnum.USERDEFINED;
					case IfcActionTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcActionTypeEnum.NOTDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of ActionType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcActionTypeEnum.PERMANENT_G:
						ActionType = IfcActionTypeEnum.PERMANENT_G;
						return;
					case Ifc4.Interfaces.IfcActionTypeEnum.VARIABLE_Q:
						ActionType = IfcActionTypeEnum.VARIABLE_Q;
						return;
					case Ifc4.Interfaces.IfcActionTypeEnum.EXTRAORDINARY_A:
						ActionType = IfcActionTypeEnum.EXTRAORDINARY_A;
						return;
					case Ifc4.Interfaces.IfcActionTypeEnum.USERDEFINED:
						ActionType = IfcActionTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcActionTypeEnum.NOTDEFINED:
						ActionType = IfcActionTypeEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStructuralLoadGroup), 8)]
		Ifc4.Interfaces.IfcActionSourceTypeEnum IIfcStructuralLoadGroup.ActionSource 
		{ 
			get
			{
				//## Custom code to handle enumeration of ActionSource
				//##
				switch (ActionSource)
				{
					case IfcActionSourceTypeEnum.DEAD_LOAD_G:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.DEAD_LOAD_G;
					case IfcActionSourceTypeEnum.COMPLETION_G1:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.COMPLETION_G1;
					case IfcActionSourceTypeEnum.LIVE_LOAD_Q:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.LIVE_LOAD_Q;
					case IfcActionSourceTypeEnum.SNOW_S:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.SNOW_S;
					case IfcActionSourceTypeEnum.WIND_W:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.WIND_W;
					case IfcActionSourceTypeEnum.PRESTRESSING_P:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.PRESTRESSING_P;
					case IfcActionSourceTypeEnum.SETTLEMENT_U:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.SETTLEMENT_U;
					case IfcActionSourceTypeEnum.TEMPERATURE_T:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.TEMPERATURE_T;
					case IfcActionSourceTypeEnum.EARTHQUAKE_E:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.EARTHQUAKE_E;
					case IfcActionSourceTypeEnum.FIRE:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.FIRE;
					case IfcActionSourceTypeEnum.IMPULSE:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.IMPULSE;
					case IfcActionSourceTypeEnum.IMPACT:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.IMPACT;
					case IfcActionSourceTypeEnum.TRANSPORT:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.TRANSPORT;
					case IfcActionSourceTypeEnum.ERECTION:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.ERECTION;
					case IfcActionSourceTypeEnum.PROPPING:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.PROPPING;
					case IfcActionSourceTypeEnum.SYSTEM_IMPERFECTION:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.SYSTEM_IMPERFECTION;
					case IfcActionSourceTypeEnum.SHRINKAGE:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.SHRINKAGE;
					case IfcActionSourceTypeEnum.CREEP:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.CREEP;
					case IfcActionSourceTypeEnum.LACK_OF_FIT:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.LACK_OF_FIT;
					case IfcActionSourceTypeEnum.BUOYANCY:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.BUOYANCY;
					case IfcActionSourceTypeEnum.ICE:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.ICE;
					case IfcActionSourceTypeEnum.CURRENT:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.CURRENT;
					case IfcActionSourceTypeEnum.WAVE:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.WAVE;
					case IfcActionSourceTypeEnum.RAIN:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.RAIN;
					case IfcActionSourceTypeEnum.BRAKES:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.BRAKES;
					case IfcActionSourceTypeEnum.USERDEFINED:
						//## Optional custom handling of ActionSource == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.USERDEFINED;
					case IfcActionSourceTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcActionSourceTypeEnum.NOTDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of ActionSource
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.DEAD_LOAD_G:
						ActionSource = IfcActionSourceTypeEnum.DEAD_LOAD_G;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.COMPLETION_G1:
						ActionSource = IfcActionSourceTypeEnum.COMPLETION_G1;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.LIVE_LOAD_Q:
						ActionSource = IfcActionSourceTypeEnum.LIVE_LOAD_Q;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.SNOW_S:
						ActionSource = IfcActionSourceTypeEnum.SNOW_S;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.WIND_W:
						ActionSource = IfcActionSourceTypeEnum.WIND_W;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.PRESTRESSING_P:
						ActionSource = IfcActionSourceTypeEnum.PRESTRESSING_P;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.SETTLEMENT_U:
						ActionSource = IfcActionSourceTypeEnum.SETTLEMENT_U;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.TEMPERATURE_T:
						ActionSource = IfcActionSourceTypeEnum.TEMPERATURE_T;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.EARTHQUAKE_E:
						ActionSource = IfcActionSourceTypeEnum.EARTHQUAKE_E;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.FIRE:
						ActionSource = IfcActionSourceTypeEnum.FIRE;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.IMPULSE:
						ActionSource = IfcActionSourceTypeEnum.IMPULSE;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.IMPACT:
						ActionSource = IfcActionSourceTypeEnum.IMPACT;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.TRANSPORT:
						ActionSource = IfcActionSourceTypeEnum.TRANSPORT;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.ERECTION:
						ActionSource = IfcActionSourceTypeEnum.ERECTION;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.PROPPING:
						ActionSource = IfcActionSourceTypeEnum.PROPPING;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.SYSTEM_IMPERFECTION:
						ActionSource = IfcActionSourceTypeEnum.SYSTEM_IMPERFECTION;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.SHRINKAGE:
						ActionSource = IfcActionSourceTypeEnum.SHRINKAGE;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.CREEP:
						ActionSource = IfcActionSourceTypeEnum.CREEP;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.LACK_OF_FIT:
						ActionSource = IfcActionSourceTypeEnum.LACK_OF_FIT;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.BUOYANCY:
						ActionSource = IfcActionSourceTypeEnum.BUOYANCY;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.ICE:
						ActionSource = IfcActionSourceTypeEnum.ICE;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.CURRENT:
						ActionSource = IfcActionSourceTypeEnum.CURRENT;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.WAVE:
						ActionSource = IfcActionSourceTypeEnum.WAVE;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.RAIN:
						ActionSource = IfcActionSourceTypeEnum.RAIN;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.BRAKES:
						ActionSource = IfcActionSourceTypeEnum.BRAKES;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.USERDEFINED:
						ActionSource = IfcActionSourceTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcActionSourceTypeEnum.NOTDEFINED:
						ActionSource = IfcActionSourceTypeEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStructuralLoadGroup), 9)]
		Ifc4.MeasureResource.IfcRatioMeasure? IIfcStructuralLoadGroup.Coefficient 
		{ 
			get
			{
				if (!Coefficient.HasValue) return null;
				return new Ifc4.MeasureResource.IfcRatioMeasure(Coefficient.Value);
			} 
			set
			{
				Coefficient = value.HasValue ? 
					new MeasureResource.IfcRatioMeasure(value.Value) :  
					 new MeasureResource.IfcRatioMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStructuralLoadGroup), 10)]
		Ifc4.MeasureResource.IfcLabel? IIfcStructuralLoadGroup.Purpose 
		{ 
			get
			{
				if (!Purpose.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Purpose.Value);
			} 
			set
			{
				Purpose = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
		IEnumerable<IIfcStructuralResultGroup> IIfcStructuralLoadGroup.SourceOfResultGroup 
		{ 
			get
			{
				return Model.Instances.Where<IIfcStructuralResultGroup>(e => (e.ResultForLoadGroup as IfcStructuralLoadGroup) == this, "ResultForLoadGroup", this);
			} 
		}
		IEnumerable<IIfcStructuralAnalysisModel> IIfcStructuralLoadGroup.LoadGroupFor 
		{ 
			get
			{
				return Model.Instances.Where<IIfcStructuralAnalysisModel>(e => e.LoadedBy != null &&  e.LoadedBy.Contains(this), "LoadedBy", this);
			} 
		}
	//## Custom code
	//##
	}
}