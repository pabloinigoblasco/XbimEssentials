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
namespace Xbim.Ifc4x3.GeometryResource
{
	public partial class @IfcToroidalSurface : IIfcToroidalSurface
	{

		[CrossSchemaAttribute(typeof(IIfcToroidalSurface), 2)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcToroidalSurface.MajorRadius 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(MajorRadius);
			} 
			set
			{
				MajorRadius = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcToroidalSurface), 3)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcToroidalSurface.MinorRadius 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(MinorRadius);
			} 
			set
			{
				MinorRadius = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}
	//## Custom code
	//##
	}
}