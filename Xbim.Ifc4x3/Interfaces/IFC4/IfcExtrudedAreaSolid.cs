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
	public partial class @IfcExtrudedAreaSolid : IIfcExtrudedAreaSolid
	{

		[CrossSchemaAttribute(typeof(IIfcExtrudedAreaSolid), 3)]
		IIfcDirection IIfcExtrudedAreaSolid.ExtrudedDirection 
		{ 
			get
			{
				return ExtrudedDirection;
			} 
			set
			{
				ExtrudedDirection = value as GeometryResource.IfcDirection;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcExtrudedAreaSolid), 4)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcExtrudedAreaSolid.Depth 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(Depth);
			} 
			set
			{
				Depth = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}
	//## Custom code
	//##
	}
}