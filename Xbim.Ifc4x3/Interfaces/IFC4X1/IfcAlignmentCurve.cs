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
namespace Xbim.Ifc4x3.GeometricConstraintResource
{
	public partial class @IfcAlignmentCurve : IIfcAlignmentCurve
	{

		[CrossSchemaAttribute(typeof(IIfcAlignmentCurve), 1)]
		IIfcAlignment2DHorizontal IIfcAlignmentCurve.Horizontal 
		{ 
			get
			{
				return Horizontal;
			} 
			set
			{
				Horizontal = value as IfcAlignment2DHorizontal;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcAlignmentCurve), 2)]
		IIfcAlignment2DVertical IIfcAlignmentCurve.Vertical 
		{ 
			get
			{
				return Vertical;
			} 
			set
			{
				Vertical = value as IfcAlignment2DVertical;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcAlignmentCurve), 3)]
		Ifc4.MeasureResource.IfcLabel? IIfcAlignmentCurve.Tag 
		{ 
			get
			{
				if (!Tag.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Tag.Value);
			} 
			set
			{
				Tag = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
	//## Custom code
	//##
	}
}