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
namespace Xbim.Ifc4x3.ProfileResource
{
	public partial class @IfcCenterLineProfileDef : IIfcCenterLineProfileDef
	{

		[CrossSchemaAttribute(typeof(IIfcCenterLineProfileDef), 4)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcCenterLineProfileDef.Thickness 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(Thickness);
			} 
			set
			{
				Thickness = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}
	//## Custom code
	//##
	}
}