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
namespace Xbim.Ifc4x3.BuildingControlsDomain
{
	public partial class @IfcAlarmType : IIfcAlarmType
	{

		[CrossSchemaAttribute(typeof(IIfcAlarmType), 10)]
		Ifc4.Interfaces.IfcAlarmTypeEnum IIfcAlarmType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcAlarmTypeEnum.BELL:
						return Ifc4.Interfaces.IfcAlarmTypeEnum.BELL;
					case IfcAlarmTypeEnum.BREAKGLASSBUTTON:
						return Ifc4.Interfaces.IfcAlarmTypeEnum.BREAKGLASSBUTTON;
					case IfcAlarmTypeEnum.LIGHT:
						return Ifc4.Interfaces.IfcAlarmTypeEnum.LIGHT;
					case IfcAlarmTypeEnum.MANUALPULLBOX:
						return Ifc4.Interfaces.IfcAlarmTypeEnum.MANUALPULLBOX;
					case IfcAlarmTypeEnum.SIREN:
						return Ifc4.Interfaces.IfcAlarmTypeEnum.SIREN;
					case IfcAlarmTypeEnum.WHISTLE:
						return Ifc4.Interfaces.IfcAlarmTypeEnum.WHISTLE;
					case IfcAlarmTypeEnum.RAILWAYCROCODILE:
						//## Handle translation of RAILWAYCROCODILE member from IfcAlarmTypeEnum in property PredefinedType
						//TODO: Handle translation of RAILWAYCROCODILE member from IfcAlarmTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcAlarmTypeEnum.RAILWAYDETONATOR:
						//## Handle translation of RAILWAYDETONATOR member from IfcAlarmTypeEnum in property PredefinedType
						//TODO: Handle translation of RAILWAYDETONATOR member from IfcAlarmTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcAlarmTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcAlarmTypeEnum.USERDEFINED;
					case IfcAlarmTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcAlarmTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcAlarmTypeEnum.BELL:
						PredefinedType = IfcAlarmTypeEnum.BELL;
						return;
					case Ifc4.Interfaces.IfcAlarmTypeEnum.BREAKGLASSBUTTON:
						PredefinedType = IfcAlarmTypeEnum.BREAKGLASSBUTTON;
						return;
					case Ifc4.Interfaces.IfcAlarmTypeEnum.LIGHT:
						PredefinedType = IfcAlarmTypeEnum.LIGHT;
						return;
					case Ifc4.Interfaces.IfcAlarmTypeEnum.MANUALPULLBOX:
						PredefinedType = IfcAlarmTypeEnum.MANUALPULLBOX;
						return;
					case Ifc4.Interfaces.IfcAlarmTypeEnum.SIREN:
						PredefinedType = IfcAlarmTypeEnum.SIREN;
						return;
					case Ifc4.Interfaces.IfcAlarmTypeEnum.WHISTLE:
						PredefinedType = IfcAlarmTypeEnum.WHISTLE;
						return;
					case Ifc4.Interfaces.IfcAlarmTypeEnum.USERDEFINED:
						PredefinedType = IfcAlarmTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcAlarmTypeEnum.NOTDEFINED:
						PredefinedType = IfcAlarmTypeEnum.NOTDEFINED;
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