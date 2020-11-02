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

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.ElectricalDomain
{
	public partial class @IfcProtectiveDeviceType : IIfcProtectiveDeviceType
	{

		[CrossSchemaAttribute(typeof(IIfcProtectiveDeviceType), 10)]
		Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum IIfcProtectiveDeviceType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcProtectiveDeviceTypeEnum.CIRCUITBREAKER:
						return Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.CIRCUITBREAKER;
					case IfcProtectiveDeviceTypeEnum.EARTHLEAKAGECIRCUITBREAKER:
						return Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.EARTHLEAKAGECIRCUITBREAKER;
					case IfcProtectiveDeviceTypeEnum.EARTHINGSWITCH:
						return Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.EARTHINGSWITCH;
					case IfcProtectiveDeviceTypeEnum.FUSEDISCONNECTOR:
						return Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.FUSEDISCONNECTOR;
					case IfcProtectiveDeviceTypeEnum.RESIDUALCURRENTCIRCUITBREAKER:
						return Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.RESIDUALCURRENTCIRCUITBREAKER;
					case IfcProtectiveDeviceTypeEnum.RESIDUALCURRENTSWITCH:
						return Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.RESIDUALCURRENTSWITCH;
					case IfcProtectiveDeviceTypeEnum.VARISTOR:
						return Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.VARISTOR;
					case IfcProtectiveDeviceTypeEnum.ANTI_ARCING_DEVICE:
						//## Handle translation of ANTI_ARCING_DEVICE member from IfcProtectiveDeviceTypeEnum in property PredefinedType
						//TODO: Handle translation of ANTI_ARCING_DEVICE member from IfcProtectiveDeviceTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcProtectiveDeviceTypeEnum.SPARKGAP:
						//## Handle translation of SPARKGAP member from IfcProtectiveDeviceTypeEnum in property PredefinedType
						//TODO: Handle translation of SPARKGAP member from IfcProtectiveDeviceTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcProtectiveDeviceTypeEnum.VOLTAGELIMITER:
						//## Handle translation of VOLTAGELIMITER member from IfcProtectiveDeviceTypeEnum in property PredefinedType
						//TODO: Handle translation of VOLTAGELIMITER member from IfcProtectiveDeviceTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcProtectiveDeviceTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.USERDEFINED;
					case IfcProtectiveDeviceTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.CIRCUITBREAKER:
						PredefinedType = IfcProtectiveDeviceTypeEnum.CIRCUITBREAKER;
						return;
					case Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.EARTHLEAKAGECIRCUITBREAKER:
						PredefinedType = IfcProtectiveDeviceTypeEnum.EARTHLEAKAGECIRCUITBREAKER;
						return;
					case Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.EARTHINGSWITCH:
						PredefinedType = IfcProtectiveDeviceTypeEnum.EARTHINGSWITCH;
						return;
					case Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.FUSEDISCONNECTOR:
						PredefinedType = IfcProtectiveDeviceTypeEnum.FUSEDISCONNECTOR;
						return;
					case Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.RESIDUALCURRENTCIRCUITBREAKER:
						PredefinedType = IfcProtectiveDeviceTypeEnum.RESIDUALCURRENTCIRCUITBREAKER;
						return;
					case Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.RESIDUALCURRENTSWITCH:
						PredefinedType = IfcProtectiveDeviceTypeEnum.RESIDUALCURRENTSWITCH;
						return;
					case Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.VARISTOR:
						PredefinedType = IfcProtectiveDeviceTypeEnum.VARISTOR;
						return;
					case Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.USERDEFINED:
						PredefinedType = IfcProtectiveDeviceTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.NOTDEFINED:
						PredefinedType = IfcProtectiveDeviceTypeEnum.NOTDEFINED;
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