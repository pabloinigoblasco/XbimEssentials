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
namespace Xbim.Ifc4x3.ProductExtension
{
	public partial class @IfcRelConnectsElements : IIfcRelConnectsElements
	{

		[CrossSchemaAttribute(typeof(IIfcRelConnectsElements), 5)]
		IIfcConnectionGeometry IIfcRelConnectsElements.ConnectionGeometry 
		{ 
			get
			{
				return ConnectionGeometry;
			} 
			set
			{
				ConnectionGeometry = value as GeometricConstraintResource.IfcConnectionGeometry;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcRelConnectsElements), 6)]
		IIfcElement IIfcRelConnectsElements.RelatingElement 
		{ 
			get
			{
				return RelatingElement;
			} 
			set
			{
				RelatingElement = value as IfcElement;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcRelConnectsElements), 7)]
		IIfcElement IIfcRelConnectsElements.RelatedElement 
		{ 
			get
			{
				return RelatedElement;
			} 
			set
			{
				RelatedElement = value as IfcElement;
				
			}
		}
	//## Custom code
	//##
	}
}