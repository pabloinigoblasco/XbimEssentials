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
namespace Xbim.Ifc4x3.PresentationOrganizationResource
{
	public partial class @IfcLightSourceSpot : IIfcLightSourceSpot
	{

		[CrossSchemaAttribute(typeof(IIfcLightSourceSpot), 10)]
		IIfcDirection IIfcLightSourceSpot.Orientation 
		{ 
			get
			{
				return Orientation;
			} 
			set
			{
				Orientation = value as GeometryResource.IfcDirection;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcLightSourceSpot), 11)]
		Ifc4.MeasureResource.IfcReal? IIfcLightSourceSpot.ConcentrationExponent 
		{ 
			get
			{
				if (!ConcentrationExponent.HasValue) return null;
				return new Ifc4.MeasureResource.IfcReal(ConcentrationExponent.Value);
			} 
			set
			{
				ConcentrationExponent = value.HasValue ? 
					new MeasureResource.IfcReal(value.Value) :  
					 new MeasureResource.IfcReal?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcLightSourceSpot), 12)]
		Ifc4.MeasureResource.IfcPositivePlaneAngleMeasure IIfcLightSourceSpot.SpreadAngle 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositivePlaneAngleMeasure(SpreadAngle);
			} 
			set
			{
				SpreadAngle = new MeasureResource.IfcPositivePlaneAngleMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcLightSourceSpot), 13)]
		Ifc4.MeasureResource.IfcPositivePlaneAngleMeasure IIfcLightSourceSpot.BeamWidthAngle 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositivePlaneAngleMeasure(BeamWidthAngle);
			} 
			set
			{
				BeamWidthAngle = new MeasureResource.IfcPositivePlaneAngleMeasure(value);
				
			}
		}
	//## Custom code
	//##
	}
}