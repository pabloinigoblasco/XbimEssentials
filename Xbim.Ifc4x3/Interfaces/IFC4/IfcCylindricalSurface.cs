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
namespace Xbim.Ifc4x3.GeometryResource
{
	public partial class @IfcCylindricalSurface : IIfcCylindricalSurface
	{

		[CrossSchemaAttribute(typeof(IIfcCylindricalSurface), 2)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcCylindricalSurface.Radius 
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
	//## Custom code
	//##
	}
}