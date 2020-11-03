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
namespace Xbim.Ifc4x3.StructuralElementsDomain
{
	public partial class @IfcPileType : IIfcPileType
	{

		[CrossSchemaAttribute(typeof(IIfcPileType), 10)]
		Ifc4.Interfaces.IfcPileTypeEnum IIfcPileType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcPileTypeEnum.BORED:
						return Ifc4.Interfaces.IfcPileTypeEnum.BORED;
					case IfcPileTypeEnum.DRIVEN:
						return Ifc4.Interfaces.IfcPileTypeEnum.DRIVEN;
					case IfcPileTypeEnum.JETGROUTING:
						return Ifc4.Interfaces.IfcPileTypeEnum.JETGROUTING;
					case IfcPileTypeEnum.COHESION:
						return Ifc4.Interfaces.IfcPileTypeEnum.COHESION;
					case IfcPileTypeEnum.FRICTION:
						return Ifc4.Interfaces.IfcPileTypeEnum.FRICTION;
					case IfcPileTypeEnum.SUPPORT:
						return Ifc4.Interfaces.IfcPileTypeEnum.SUPPORT;
					case IfcPileTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcPileTypeEnum.USERDEFINED;
					case IfcPileTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcPileTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcPileTypeEnum.BORED:
						PredefinedType = IfcPileTypeEnum.BORED;
						return;
					case Ifc4.Interfaces.IfcPileTypeEnum.DRIVEN:
						PredefinedType = IfcPileTypeEnum.DRIVEN;
						return;
					case Ifc4.Interfaces.IfcPileTypeEnum.JETGROUTING:
						PredefinedType = IfcPileTypeEnum.JETGROUTING;
						return;
					case Ifc4.Interfaces.IfcPileTypeEnum.COHESION:
						PredefinedType = IfcPileTypeEnum.COHESION;
						return;
					case Ifc4.Interfaces.IfcPileTypeEnum.FRICTION:
						PredefinedType = IfcPileTypeEnum.FRICTION;
						return;
					case Ifc4.Interfaces.IfcPileTypeEnum.SUPPORT:
						PredefinedType = IfcPileTypeEnum.SUPPORT;
						return;
					case Ifc4.Interfaces.IfcPileTypeEnum.USERDEFINED:
						PredefinedType = IfcPileTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcPileTypeEnum.NOTDEFINED:
						PredefinedType = IfcPileTypeEnum.NOTDEFINED;
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