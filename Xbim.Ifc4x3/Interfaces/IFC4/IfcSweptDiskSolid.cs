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
namespace Xbim.Ifc4x3.GeometricModelResource
{
	public partial class @IfcSweptDiskSolid : IIfcSweptDiskSolid
	{

		[CrossSchemaAttribute(typeof(IIfcSweptDiskSolid), 1)]
		IIfcCurve IIfcSweptDiskSolid.Directrix 
		{ 
			get
			{
				return Directrix;
			} 
			set
			{
				Directrix = value as GeometryResource.IfcCurve;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcSweptDiskSolid), 2)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcSweptDiskSolid.Radius 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(Radius);
			} 
			set
			{
				Radius = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcSweptDiskSolid), 3)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcSweptDiskSolid.InnerRadius 
		{ 
			get
			{
				if (!InnerRadius.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(InnerRadius.Value);
			} 
			set
			{
				InnerRadius = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcSweptDiskSolid), 4)]
		Ifc4.MeasureResource.IfcParameterValue? IIfcSweptDiskSolid.StartParam 
		{ 
			get
			{
				if (!StartParam.HasValue) return null;
				return new Ifc4.MeasureResource.IfcParameterValue(StartParam.Value);
			} 
			set
			{
				StartParam = value.HasValue ? 
					new MeasureResource.IfcParameterValue(value.Value) :  
					 new MeasureResource.IfcParameterValue?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcSweptDiskSolid), 5)]
		Ifc4.MeasureResource.IfcParameterValue? IIfcSweptDiskSolid.EndParam 
		{ 
			get
			{
				if (!EndParam.HasValue) return null;
				return new Ifc4.MeasureResource.IfcParameterValue(EndParam.Value);
			} 
			set
			{
				EndParam = value.HasValue ? 
					new MeasureResource.IfcParameterValue(value.Value) :  
					 new MeasureResource.IfcParameterValue?() ;
				
			}
		}
	//## Custom code
	//##
	}
}