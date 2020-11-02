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
	public partial class @IfcCompressor : IIfcCompressor
	{

		[CrossSchemaAttribute(typeof(IIfcCompressor), 9)]
		Ifc4.Interfaces.IfcCompressorTypeEnum? IIfcCompressor.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcCompressorTypeEnum.DYNAMIC:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.DYNAMIC;
					case IfcCompressorTypeEnum.RECIPROCATING:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.RECIPROCATING;
					case IfcCompressorTypeEnum.ROTARY:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.ROTARY;
					case IfcCompressorTypeEnum.SCROLL:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.SCROLL;
					case IfcCompressorTypeEnum.TROCHOIDAL:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.TROCHOIDAL;
					case IfcCompressorTypeEnum.SINGLESTAGE:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.SINGLESTAGE;
					case IfcCompressorTypeEnum.BOOSTER:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.BOOSTER;
					case IfcCompressorTypeEnum.OPENTYPE:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.OPENTYPE;
					case IfcCompressorTypeEnum.HERMETIC:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.HERMETIC;
					case IfcCompressorTypeEnum.SEMIHERMETIC:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.SEMIHERMETIC;
					case IfcCompressorTypeEnum.WELDEDSHELLHERMETIC:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.WELDEDSHELLHERMETIC;
					case IfcCompressorTypeEnum.ROLLINGPISTON:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.ROLLINGPISTON;
					case IfcCompressorTypeEnum.ROTARYVANE:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.ROTARYVANE;
					case IfcCompressorTypeEnum.SINGLESCREW:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.SINGLESCREW;
					case IfcCompressorTypeEnum.TWINSCREW:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.TWINSCREW;
					case IfcCompressorTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcCompressorTypeEnum.USERDEFINED;
					case IfcCompressorTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcCompressorTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcCompressorTypeEnum.DYNAMIC:
						PredefinedType = IfcCompressorTypeEnum.DYNAMIC;
						return;
					case Ifc4.Interfaces.IfcCompressorTypeEnum.RECIPROCATING:
						PredefinedType = IfcCompressorTypeEnum.RECIPROCATING;
						return;
					case Ifc4.Interfaces.IfcCompressorTypeEnum.ROTARY:
						PredefinedType = IfcCompressorTypeEnum.ROTARY;
						return;
					case Ifc4.Interfaces.IfcCompressorTypeEnum.SCROLL:
						PredefinedType = IfcCompressorTypeEnum.SCROLL;
						return;
					case Ifc4.Interfaces.IfcCompressorTypeEnum.TROCHOIDAL:
						PredefinedType = IfcCompressorTypeEnum.TROCHOIDAL;
						return;
					case Ifc4.Interfaces.IfcCompressorTypeEnum.SINGLESTAGE:
						PredefinedType = IfcCompressorTypeEnum.SINGLESTAGE;
						return;
					case Ifc4.Interfaces.IfcCompressorTypeEnum.BOOSTER:
						PredefinedType = IfcCompressorTypeEnum.BOOSTER;
						return;
					case Ifc4.Interfaces.IfcCompressorTypeEnum.OPENTYPE:
						PredefinedType = IfcCompressorTypeEnum.OPENTYPE;
						return;
					case Ifc4.Interfaces.IfcCompressorTypeEnum.HERMETIC:
						PredefinedType = IfcCompressorTypeEnum.HERMETIC;
						return;
					case Ifc4.Interfaces.IfcCompressorTypeEnum.SEMIHERMETIC:
						PredefinedType = IfcCompressorTypeEnum.SEMIHERMETIC;
						return;
					case Ifc4.Interfaces.IfcCompressorTypeEnum.WELDEDSHELLHERMETIC:
						PredefinedType = IfcCompressorTypeEnum.WELDEDSHELLHERMETIC;
						return;
					case Ifc4.Interfaces.IfcCompressorTypeEnum.ROLLINGPISTON:
						PredefinedType = IfcCompressorTypeEnum.ROLLINGPISTON;
						return;
					case Ifc4.Interfaces.IfcCompressorTypeEnum.ROTARYVANE:
						PredefinedType = IfcCompressorTypeEnum.ROTARYVANE;
						return;
					case Ifc4.Interfaces.IfcCompressorTypeEnum.SINGLESCREW:
						PredefinedType = IfcCompressorTypeEnum.SINGLESCREW;
						return;
					case Ifc4.Interfaces.IfcCompressorTypeEnum.TWINSCREW:
						PredefinedType = IfcCompressorTypeEnum.TWINSCREW;
						return;
					case Ifc4.Interfaces.IfcCompressorTypeEnum.USERDEFINED:
						PredefinedType = IfcCompressorTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcCompressorTypeEnum.NOTDEFINED:
						PredefinedType = IfcCompressorTypeEnum.NOTDEFINED;
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