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
	public partial class @IfcPcurve : IIfcPcurve
	{

		[CrossSchemaAttribute(typeof(IIfcPcurve), 1)]
		IIfcSurface IIfcPcurve.BasisSurface 
		{ 
			get
			{
				return BasisSurface;
			} 
			set
			{
				BasisSurface = value as IfcSurface;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcPcurve), 2)]
		IIfcCurve IIfcPcurve.ReferenceCurve 
		{ 
			get
			{
				return ReferenceCurve;
			} 
			set
			{
				ReferenceCurve = value as IfcCurve;
				
			}
		}
	//## Custom code
	//##
	}
}