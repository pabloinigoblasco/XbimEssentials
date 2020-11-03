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
namespace Xbim.Ifc4x3.ElectricalDomain
{
	public partial class @IfcElectricTimeControlType : IIfcElectricTimeControlType
	{

		[CrossSchemaAttribute(typeof(IIfcElectricTimeControlType), 10)]
		Ifc4.Interfaces.IfcElectricTimeControlTypeEnum IIfcElectricTimeControlType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcElectricTimeControlTypeEnum.TIMECLOCK:
						return Ifc4.Interfaces.IfcElectricTimeControlTypeEnum.TIMECLOCK;
					case IfcElectricTimeControlTypeEnum.TIMEDELAY:
						return Ifc4.Interfaces.IfcElectricTimeControlTypeEnum.TIMEDELAY;
					case IfcElectricTimeControlTypeEnum.RELAY:
						return Ifc4.Interfaces.IfcElectricTimeControlTypeEnum.RELAY;
					case IfcElectricTimeControlTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcElectricTimeControlTypeEnum.USERDEFINED;
					case IfcElectricTimeControlTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcElectricTimeControlTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcElectricTimeControlTypeEnum.TIMECLOCK:
						PredefinedType = IfcElectricTimeControlTypeEnum.TIMECLOCK;
						return;
					case Ifc4.Interfaces.IfcElectricTimeControlTypeEnum.TIMEDELAY:
						PredefinedType = IfcElectricTimeControlTypeEnum.TIMEDELAY;
						return;
					case Ifc4.Interfaces.IfcElectricTimeControlTypeEnum.RELAY:
						PredefinedType = IfcElectricTimeControlTypeEnum.RELAY;
						return;
					case Ifc4.Interfaces.IfcElectricTimeControlTypeEnum.USERDEFINED:
						PredefinedType = IfcElectricTimeControlTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcElectricTimeControlTypeEnum.NOTDEFINED:
						PredefinedType = IfcElectricTimeControlTypeEnum.NOTDEFINED;
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