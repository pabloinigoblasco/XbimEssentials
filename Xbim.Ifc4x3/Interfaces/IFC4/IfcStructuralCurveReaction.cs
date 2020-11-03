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
	public partial class @IfcStructuralCurveReaction : IIfcStructuralCurveReaction
	{

		[CrossSchemaAttribute(typeof(IIfcStructuralCurveReaction), 10)]
		Ifc4.Interfaces.IfcStructuralCurveActivityTypeEnum IIfcStructuralCurveReaction.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcStructuralCurveActivityTypeEnum.CONST:
						return Ifc4.Interfaces.IfcStructuralCurveActivityTypeEnum.CONST;
					case IfcStructuralCurveActivityTypeEnum.LINEAR:
						return Ifc4.Interfaces.IfcStructuralCurveActivityTypeEnum.LINEAR;
					case IfcStructuralCurveActivityTypeEnum.POLYGONAL:
						return Ifc4.Interfaces.IfcStructuralCurveActivityTypeEnum.POLYGONAL;
					case IfcStructuralCurveActivityTypeEnum.EQUIDISTANT:
						return Ifc4.Interfaces.IfcStructuralCurveActivityTypeEnum.EQUIDISTANT;
					case IfcStructuralCurveActivityTypeEnum.SINUS:
						return Ifc4.Interfaces.IfcStructuralCurveActivityTypeEnum.SINUS;
					case IfcStructuralCurveActivityTypeEnum.PARABOLA:
						return Ifc4.Interfaces.IfcStructuralCurveActivityTypeEnum.PARABOLA;
					case IfcStructuralCurveActivityTypeEnum.DISCRETE:
						return Ifc4.Interfaces.IfcStructuralCurveActivityTypeEnum.DISCRETE;
					case IfcStructuralCurveActivityTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcStructuralCurveActivityTypeEnum.USERDEFINED;
					case IfcStructuralCurveActivityTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcStructuralCurveActivityTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcStructuralCurveActivityTypeEnum.CONST:
						PredefinedType = IfcStructuralCurveActivityTypeEnum.CONST;
						return;
					case Ifc4.Interfaces.IfcStructuralCurveActivityTypeEnum.LINEAR:
						PredefinedType = IfcStructuralCurveActivityTypeEnum.LINEAR;
						return;
					case Ifc4.Interfaces.IfcStructuralCurveActivityTypeEnum.POLYGONAL:
						PredefinedType = IfcStructuralCurveActivityTypeEnum.POLYGONAL;
						return;
					case Ifc4.Interfaces.IfcStructuralCurveActivityTypeEnum.EQUIDISTANT:
						PredefinedType = IfcStructuralCurveActivityTypeEnum.EQUIDISTANT;
						return;
					case Ifc4.Interfaces.IfcStructuralCurveActivityTypeEnum.SINUS:
						PredefinedType = IfcStructuralCurveActivityTypeEnum.SINUS;
						return;
					case Ifc4.Interfaces.IfcStructuralCurveActivityTypeEnum.PARABOLA:
						PredefinedType = IfcStructuralCurveActivityTypeEnum.PARABOLA;
						return;
					case Ifc4.Interfaces.IfcStructuralCurveActivityTypeEnum.DISCRETE:
						PredefinedType = IfcStructuralCurveActivityTypeEnum.DISCRETE;
						return;
					case Ifc4.Interfaces.IfcStructuralCurveActivityTypeEnum.USERDEFINED:
						PredefinedType = IfcStructuralCurveActivityTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcStructuralCurveActivityTypeEnum.NOTDEFINED:
						PredefinedType = IfcStructuralCurveActivityTypeEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}