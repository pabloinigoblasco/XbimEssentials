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
	public partial class @IfcSurfaceFeature : IIfcSurfaceFeature
	{

		[CrossSchemaAttribute(typeof(IIfcSurfaceFeature), 9)]
		Ifc4.Interfaces.IfcSurfaceFeatureTypeEnum? IIfcSurfaceFeature.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcSurfaceFeatureTypeEnum.MARK:
						return Ifc4.Interfaces.IfcSurfaceFeatureTypeEnum.MARK;
					case IfcSurfaceFeatureTypeEnum.TAG:
						return Ifc4.Interfaces.IfcSurfaceFeatureTypeEnum.TAG;
					case IfcSurfaceFeatureTypeEnum.TREATMENT:
						return Ifc4.Interfaces.IfcSurfaceFeatureTypeEnum.TREATMENT;
					case IfcSurfaceFeatureTypeEnum.DEFECT:
						//## Handle translation of DEFECT member from IfcSurfaceFeatureTypeEnum in property PredefinedType
						//TODO: Handle translation of DEFECT member from IfcSurfaceFeatureTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcSurfaceFeatureTypeEnum.HATCHMARKING:
						//## Handle translation of HATCHMARKING member from IfcSurfaceFeatureTypeEnum in property PredefinedType
						//TODO: Handle translation of HATCHMARKING member from IfcSurfaceFeatureTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcSurfaceFeatureTypeEnum.LINEMARKING:
						//## Handle translation of LINEMARKING member from IfcSurfaceFeatureTypeEnum in property PredefinedType
						//TODO: Handle translation of LINEMARKING member from IfcSurfaceFeatureTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcSurfaceFeatureTypeEnum.PAVEMENTSURFACEMARKING:
						//## Handle translation of PAVEMENTSURFACEMARKING member from IfcSurfaceFeatureTypeEnum in property PredefinedType
						//TODO: Handle translation of PAVEMENTSURFACEMARKING member from IfcSurfaceFeatureTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcSurfaceFeatureTypeEnum.SYMBOLMARKING:
						//## Handle translation of SYMBOLMARKING member from IfcSurfaceFeatureTypeEnum in property PredefinedType
						//TODO: Handle translation of SYMBOLMARKING member from IfcSurfaceFeatureTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcSurfaceFeatureTypeEnum.NONSKIDSURFACING:
						//## Handle translation of NONSKIDSURFACING member from IfcSurfaceFeatureTypeEnum in property PredefinedType
						//TODO: Handle translation of NONSKIDSURFACING member from IfcSurfaceFeatureTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcSurfaceFeatureTypeEnum.RUMBLESTRIP:
						//## Handle translation of RUMBLESTRIP member from IfcSurfaceFeatureTypeEnum in property PredefinedType
						//TODO: Handle translation of RUMBLESTRIP member from IfcSurfaceFeatureTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcSurfaceFeatureTypeEnum.TRANSVERSERUMBLESTRIP:
						//## Handle translation of TRANSVERSERUMBLESTRIP member from IfcSurfaceFeatureTypeEnum in property PredefinedType
						//TODO: Handle translation of TRANSVERSERUMBLESTRIP member from IfcSurfaceFeatureTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcSurfaceFeatureTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcSurfaceFeatureTypeEnum.USERDEFINED;
					case IfcSurfaceFeatureTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcSurfaceFeatureTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcSurfaceFeatureTypeEnum.MARK:
						PredefinedType = IfcSurfaceFeatureTypeEnum.MARK;
						return;
					case Ifc4.Interfaces.IfcSurfaceFeatureTypeEnum.TAG:
						PredefinedType = IfcSurfaceFeatureTypeEnum.TAG;
						return;
					case Ifc4.Interfaces.IfcSurfaceFeatureTypeEnum.TREATMENT:
						PredefinedType = IfcSurfaceFeatureTypeEnum.TREATMENT;
						return;
					case Ifc4.Interfaces.IfcSurfaceFeatureTypeEnum.USERDEFINED:
						PredefinedType = IfcSurfaceFeatureTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcSurfaceFeatureTypeEnum.NOTDEFINED:
						PredefinedType = IfcSurfaceFeatureTypeEnum.NOTDEFINED;
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