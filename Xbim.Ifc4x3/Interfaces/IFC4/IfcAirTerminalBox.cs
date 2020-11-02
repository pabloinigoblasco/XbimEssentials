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
namespace Xbim.Ifc4x3.HvacDomain
{
	public partial class @IfcAirTerminalBox : IIfcAirTerminalBox
	{

		[CrossSchemaAttribute(typeof(IIfcAirTerminalBox), 9)]
		Ifc4.Interfaces.IfcAirTerminalBoxTypeEnum? IIfcAirTerminalBox.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcAirTerminalBoxTypeEnum.CONSTANTFLOW:
						return Ifc4.Interfaces.IfcAirTerminalBoxTypeEnum.CONSTANTFLOW;
					case IfcAirTerminalBoxTypeEnum.VARIABLEFLOWPRESSUREDEPENDANT:
						return Ifc4.Interfaces.IfcAirTerminalBoxTypeEnum.VARIABLEFLOWPRESSUREDEPENDANT;
					case IfcAirTerminalBoxTypeEnum.VARIABLEFLOWPRESSUREINDEPENDANT:
						return Ifc4.Interfaces.IfcAirTerminalBoxTypeEnum.VARIABLEFLOWPRESSUREINDEPENDANT;
					case IfcAirTerminalBoxTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcAirTerminalBoxTypeEnum.USERDEFINED;
					case IfcAirTerminalBoxTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcAirTerminalBoxTypeEnum.NOTDEFINED;
					case null: 
						return null;
					
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
					case Ifc4.Interfaces.IfcAirTerminalBoxTypeEnum.CONSTANTFLOW:
						PredefinedType = IfcAirTerminalBoxTypeEnum.CONSTANTFLOW;
						return;
					case Ifc4.Interfaces.IfcAirTerminalBoxTypeEnum.VARIABLEFLOWPRESSUREDEPENDANT:
						PredefinedType = IfcAirTerminalBoxTypeEnum.VARIABLEFLOWPRESSUREDEPENDANT;
						return;
					case Ifc4.Interfaces.IfcAirTerminalBoxTypeEnum.VARIABLEFLOWPRESSUREINDEPENDANT:
						PredefinedType = IfcAirTerminalBoxTypeEnum.VARIABLEFLOWPRESSUREINDEPENDANT;
						return;
					case Ifc4.Interfaces.IfcAirTerminalBoxTypeEnum.USERDEFINED:
						PredefinedType = IfcAirTerminalBoxTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcAirTerminalBoxTypeEnum.NOTDEFINED:
						PredefinedType = IfcAirTerminalBoxTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
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