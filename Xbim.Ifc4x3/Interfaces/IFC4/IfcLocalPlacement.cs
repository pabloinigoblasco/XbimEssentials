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
namespace Xbim.Ifc4x3.GeometricConstraintResource
{
	public partial class @IfcLocalPlacement : IIfcLocalPlacement
	{

		[CrossSchemaAttribute(typeof(IIfcLocalPlacement), 1)]
		IIfcObjectPlacement IIfcLocalPlacement.PlacementRelTo 
		{ 
			get
			{
				return PlacementRelTo;
			} 
			set
			{
				PlacementRelTo = value as IfcObjectPlacement;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcLocalPlacement), 2)]
		IIfcAxis2Placement IIfcLocalPlacement.RelativePlacement 
		{ 
			get
			{
				if (RelativePlacement == null) return null;
				var ifcaxis2placement2d = RelativePlacement as GeometryResource.IfcAxis2Placement2D;
				if (ifcaxis2placement2d != null) 
					return ifcaxis2placement2d;
				var ifcaxis2placement3d = RelativePlacement as GeometryResource.IfcAxis2Placement3D;
				if (ifcaxis2placement3d != null) 
					return ifcaxis2placement3d;
				return null;
			} 
			set
			{
				if (value == null)
				{
					RelativePlacement = null;
					return;
				}	
				var ifcaxis2placement2d = value as GeometryResource.IfcAxis2Placement2D;
				if (ifcaxis2placement2d != null) 
				{
					RelativePlacement = ifcaxis2placement2d;
					return;
				}
				var ifcaxis2placement3d = value as GeometryResource.IfcAxis2Placement3D;
				if (ifcaxis2placement3d != null) 
				{
					RelativePlacement = ifcaxis2placement3d;
					return;
				}
				
			}
		}
	//## Custom code
	//##
	}
}