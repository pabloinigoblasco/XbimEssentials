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
	public partial class @IfcElectricFlowStorageDeviceType : IIfcElectricFlowStorageDeviceType
	{

		[CrossSchemaAttribute(typeof(IIfcElectricFlowStorageDeviceType), 10)]
		Ifc4.Interfaces.IfcElectricFlowStorageDeviceTypeEnum IIfcElectricFlowStorageDeviceType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcElectricFlowStorageDeviceTypeEnum.BATTERY:
						return Ifc4.Interfaces.IfcElectricFlowStorageDeviceTypeEnum.BATTERY;
					case IfcElectricFlowStorageDeviceTypeEnum.CAPACITORBANK:
						return Ifc4.Interfaces.IfcElectricFlowStorageDeviceTypeEnum.CAPACITORBANK;
					case IfcElectricFlowStorageDeviceTypeEnum.HARMONICFILTER:
						return Ifc4.Interfaces.IfcElectricFlowStorageDeviceTypeEnum.HARMONICFILTER;
					case IfcElectricFlowStorageDeviceTypeEnum.INDUCTORBANK:
						return Ifc4.Interfaces.IfcElectricFlowStorageDeviceTypeEnum.INDUCTORBANK;
					case IfcElectricFlowStorageDeviceTypeEnum.UPS:
						return Ifc4.Interfaces.IfcElectricFlowStorageDeviceTypeEnum.UPS;
					case IfcElectricFlowStorageDeviceTypeEnum.CAPACITOR:
						//## Handle translation of CAPACITOR member from IfcElectricFlowStorageDeviceTypeEnum in property PredefinedType
						//TODO: Handle translation of CAPACITOR member from IfcElectricFlowStorageDeviceTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcElectricFlowStorageDeviceTypeEnum.COMPENSATOR:
						//## Handle translation of COMPENSATOR member from IfcElectricFlowStorageDeviceTypeEnum in property PredefinedType
						//TODO: Handle translation of COMPENSATOR member from IfcElectricFlowStorageDeviceTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcElectricFlowStorageDeviceTypeEnum.INDUCTOR:
						//## Handle translation of INDUCTOR member from IfcElectricFlowStorageDeviceTypeEnum in property PredefinedType
						//TODO: Handle translation of INDUCTOR member from IfcElectricFlowStorageDeviceTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcElectricFlowStorageDeviceTypeEnum.RECHARGER:
						//## Handle translation of RECHARGER member from IfcElectricFlowStorageDeviceTypeEnum in property PredefinedType
						//TODO: Handle translation of RECHARGER member from IfcElectricFlowStorageDeviceTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcElectricFlowStorageDeviceTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcElectricFlowStorageDeviceTypeEnum.USERDEFINED;
					case IfcElectricFlowStorageDeviceTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcElectricFlowStorageDeviceTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcElectricFlowStorageDeviceTypeEnum.BATTERY:
						PredefinedType = IfcElectricFlowStorageDeviceTypeEnum.BATTERY;
						return;
					case Ifc4.Interfaces.IfcElectricFlowStorageDeviceTypeEnum.CAPACITORBANK:
						PredefinedType = IfcElectricFlowStorageDeviceTypeEnum.CAPACITORBANK;
						return;
					case Ifc4.Interfaces.IfcElectricFlowStorageDeviceTypeEnum.HARMONICFILTER:
						PredefinedType = IfcElectricFlowStorageDeviceTypeEnum.HARMONICFILTER;
						return;
					case Ifc4.Interfaces.IfcElectricFlowStorageDeviceTypeEnum.INDUCTORBANK:
						PredefinedType = IfcElectricFlowStorageDeviceTypeEnum.INDUCTORBANK;
						return;
					case Ifc4.Interfaces.IfcElectricFlowStorageDeviceTypeEnum.UPS:
						PredefinedType = IfcElectricFlowStorageDeviceTypeEnum.UPS;
						return;
					case Ifc4.Interfaces.IfcElectricFlowStorageDeviceTypeEnum.USERDEFINED:
						PredefinedType = IfcElectricFlowStorageDeviceTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcElectricFlowStorageDeviceTypeEnum.NOTDEFINED:
						PredefinedType = IfcElectricFlowStorageDeviceTypeEnum.NOTDEFINED;
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